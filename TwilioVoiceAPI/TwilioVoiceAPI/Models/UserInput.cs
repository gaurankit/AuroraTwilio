using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwilioVoiceAPI.Models
{
    public class UserInput
    {
        public string OrderId { get; set; }
        public string SpeechResult { get; set; }
        public string Q { get; set; }
    }
}