using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TwilioVoiceAPI.Models;

namespace TwilioVoiceAPI.Providers
{
    public class QuestionAnswerProvider
    {
        private static List<Question> Questions = new List<Question>()
        {
            new Question()
            {
                Id=1,
                Body="Do you have the booking ?",
                Answers=new List<Answer>()
                {
                   new Answer
                   {
                       Body="Yes",
                       NextQuestionId=2
                   },
                   new Answer
                   {
                       Body="No",
                       NextQuestionId=3
                   },
                   new Answer
                   {
                       Body="Repeat",
                       NextQuestionId=4
                   }
                }
            },
            new Question()
            {
                Id=2,
                Body="That’s great. Thank you, so everything looks great, and we really appreciate your help.",
                Answers=new List<Answer>(),
            },
            new Question()
            {
                Id=3,
                Body="Ok. Would you recommend that I call again later in the day to check if you have received the booking ?",
                Answers=new List<Answer>()
                {
                   new Answer
                   {
                       Body="Yes",
                       NextQuestionId=5
                   },
                   new Answer
                   {
                       Body="No",
                       NextQuestionId=6
                   },
                   new Answer
                   {
                       Body="Repeat",
                       NextQuestionId=3
                   }
                }
            },
            new Question()
            {
                Id=4,
                ProcessWithOrder = true,
                Body="Sure, So the name of the guest is, {0}. The check-in date is,  {1}. The booking was made via, {2}. And the booking confirmation number, is {3}. Do you have the booking ?",
                Answers=new List<Answer>()
                {
                   new Answer
                   {
                       Body="Yes",
                       NextQuestionId=2
                   },
                   new Answer
                   {
                       Body="No",
                       NextQuestionId=3
                   },
                   new Answer
                   {
                       Body="Repeat",
                       NextQuestionId=4
                   }
                }
            },
            new Question()
            {
                Id=5,
                Body="Ok, I will try checking again later. Maybe you would be able to find the booking by then. Thanks again, and you have a great day.",
                Answers=new List<Answer>(),
            },
            new Question()
            {
                Id=6,
                Body="No problem. There might have been some problem in the booking reaching you. I will let the guest know. Thanks again, and you have a great day.",
                Answers=new List<Answer>(),
            },
        };

        public Question GetQuestionById(int questionId)
        {
            return Questions.Find(q => q.Id == questionId);
        }
    }
}