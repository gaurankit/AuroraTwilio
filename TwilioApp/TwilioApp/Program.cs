using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace TwilioApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find your Account Sid and Auth Token at twilio.com/console
            const string accountSid = "AC975209aff8f73551ccf7b2c8b511c649";
            const string authToken = "54c3e6ba8d47587db61a2e4b170c3bac";
            TwilioClient.Init(accountSid, authToken);

            var to = new PhoneNumber("+19523888164");
            var from = new PhoneNumber("+17639511257");
            var call = CallResource.Create(to, from,
                url: new Uri("https://8e87bdb9.ngrok.io/Aurora/GetOrder?orderId=12312"));

            Console.WriteLine(call.Sid);
        }
    }
}
