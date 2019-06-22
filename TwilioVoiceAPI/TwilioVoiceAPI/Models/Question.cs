using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwilioVoiceAPI.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Body { get; set; }

        public List<Answer> Answers { get; set; }
        public bool ProcessWithOrder { get; set; }
    }
}