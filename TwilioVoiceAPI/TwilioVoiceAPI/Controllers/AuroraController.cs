using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio.AspNet.Mvc;
using Twilio.TwiML;
using TwilioVoiceAPI.Models;

namespace TwilioVoiceAPI.Controllers
{
    public class AuroraController : TwilioController
    {
        private readonly IRequestValidationService _requestValidationService;

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

            var order = new Order();
            order.

            var response = new VoiceResponse();
            response
                .Say("Thanks for contacting our sales department. Our " +
                     "next available representative will take your call." + orderId)
                .Hangup();

            return TwiML(response);
        }
    }
}
