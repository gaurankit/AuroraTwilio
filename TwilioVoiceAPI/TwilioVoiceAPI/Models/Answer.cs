using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwilioVoiceAPI.Models
{
    public class Answer
    {
        //public string OrderId { get; set; }
        //public string SpeechResult { get; set; }

        public string Body { get; set; }

        public int NextQuestionId { get; set; }
    }
}