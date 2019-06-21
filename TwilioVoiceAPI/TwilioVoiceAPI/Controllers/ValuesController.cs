using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Twilio.TwiML;
using Twilio.AspNet.Mvc;
using System.Xml.Linq;

namespace TwilioVoiceAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values/GetInitialSay
        [System.Web.Http.HttpPost]
        public string GetInitialSay()
        {
            //var twilioAuthToken = ConfigurationManager.AppSettings["TwilioAuthToken"];
            //var _requestValidationService = new RequestValidationService();
            //if (!_requestValidationService.IsValidRequest(System.Web.HttpContext.Current, twilioAuthToken))
            //{
            //    //return new HttpUnauthorizedResult();
            //}

            //var response = new VoiceResponse();
            //response
            //    .Say("Thanks for contacting our sales department. Our " +
            //         "next available representative will take your call.")
            //    .Hangup();

            //var controller = new TwilioController();


            var doc = new XDocument();
            var response = new XElement("Response");
            //var gather = new XElement("Gather",
            //new XAttribute("action", Url.Action("Input")),
            //new XElement("Say", "Thank you for calling. Please enter your order number followed by the pound key.")
            //);

            var say = new XElement("Say", "Thank you for calling. Please enter your order number followed by the pound key.");

            response.Add(say);
            doc.Add(response);

            //return new ContentResult
            //{
            //    Content = doc.ToString(),
            //    ContentType = "text/xml"
            //};

            return doc.ToString();



            //return controller.TwiML(response);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
