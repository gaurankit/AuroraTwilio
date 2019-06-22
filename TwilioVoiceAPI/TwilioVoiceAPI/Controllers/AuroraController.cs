﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio.AspNet.Mvc;
using Twilio.TwiML;
using Twilio.TwiML.Voice;
using TwilioVoiceAPI.Models;
using TwilioVoiceAPI.Providers;

namespace TwilioVoiceAPI.Controllers
{
    public class AuroraController : TwilioController
    {
        private readonly IRequestValidationService _requestValidationService;
        private QuestionAnswerProvider _qProvider = new QuestionAnswerProvider();
        private static Order _order = new Order();
        public AuroraController() : this(new RequestValidationService())
        {
        }

        public AuroraController(IRequestValidationService requestValidationService)
        {
            _requestValidationService = requestValidationService;
        }




        [HttpPost]
        public ActionResult GetOrder(string orderId)
        {
            var twilioAuthToken = ConfigurationManager.AppSettings["TwilioAuthToken"];
            if (!_requestValidationService.IsValidRequest(System.Web.HttpContext.Current, twilioAuthToken))
            {
                return new HttpUnauthorizedResult();
            }


            _order.Name = "Jane Deo";
            _order.SupplierName = "Expedia";
            _order.CheckinDate = new DateTime(2019, 09, 22);
            _order.ConfirmationNumber = orderId;

            var response = new VoiceResponse();
            response
               .Pause(3)
               .Say("Hi, My name is Clic, and I am calling  from CXLoyalty. We have made a booking at your property, for a VIP customer,  and I want to ensure that they have a pleasant check-in experience.")
               .Say(String.Format("Can you confirm if you have a booking, for, Ms. {0} ?", _order.Name))
               .Say("I will hold on, to give you some time, to look up the information.")
               .Pause(3)
               .Say(string.Format("Ready ? So the name of the guest is, {0}.", _order.Name))
               .Say("The check-in date is, " + _order.CheckinDate.ToString("dddd, dd MMMM yyyy"))
               .Say(string.Format("The booking was made via, {0}.", _order.SupplierName))
               .Say(string.Format("And the booking confirmation number, is {0}.", string.Join(" ", orderId.ToCharArray())))
               .Say("I will hold the line, to give you some time to find the information.")
               .Pause(4);

            var gather = new Gather(input: new[] { Gather.InputEnum.Speech }.ToList(), action: new Uri("https://8e87bdb9.ngrok.io/Aurora/GatherConfirmBooking?OrderId=" + orderId + "&Q=1"), method: Twilio.Http.HttpMethod.Get);
            gather.Say("Do you have the booking ?");
            response.Append(gather);
            response.Say("We didn't receive any input. Goodbye!")
                .Hangup();

            return TwiML(response);
        }

        [HttpGet]
        public ActionResult GatherConfirmBooking([Bind(Include = "OrderId,SpeechResult, Q")] UserInput input)
        {
            string parsedInput = ParseInput(input.SpeechResult.ToLower());
            int questionId = int.Parse(input.Q);
            var question = _qProvider.GetQuestionById(questionId);
            var answer = question.Answers.Find(a => string.Equals(a.Body, parsedInput));

            var nextQuestion = _qProvider.GetQuestionById(answer.NextQuestionId);
            string body = nextQuestion.ProcessWithOrder ?
                    string.Format(nextQuestion.Body, _order.Name
                   , _order.CheckinDate.ToString("dddd, dd MMMM yyyy")
                   , _order.SupplierName
                   , string.Join(" ", _order.ConfirmationNumber.ToCharArray())) 
               : nextQuestion.Body;


            var response = new VoiceResponse();
            response.Say(body);
            if(nextQuestion.Answers != null && nextQuestion.Answers.Count > 0)
            {
                var gather = new Gather(input: new[] { Gather.InputEnum.Speech }.ToList(), action: new Uri("https://8e87bdb9.ngrok.io/Aurora/GatherConfirmBooking?OrderId=" + input.OrderId + "&Q=" + nextQuestion.Id), method: Twilio.Http.HttpMethod.Get);
                response.Append(gather);
            }
            //var request = Request.RawUrl;
            //var orderID = answer.OrderId;
            //var speechResult = answer.SpeechResult;
            //var response = new VoiceResponse();
            //response
            //   .Say("Thank you. Would you recommend that I call again later in the day to check if you have received the booking ? Pleases say YES or NO.")
            //    .Hangup();

            return TwiML(response);
        }

        private string ParseInput(string speechResult)
        {
            List<string> possibleYes = new List<string>() { "yes", "yeah", "sure", "found" };
            List<string> possibleNo = new List<string>() { "no", "neah", "not", "nah" };
            if (possibleYes.Exists(y => speechResult.Contains(y))) return "Yes";
            if (possibleNo.Exists(y => speechResult.Contains(y))) return "No";
            return "Repeat";
        }
    }
}
