using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwilioVoiceAPI.Models
{
    public class Order
    {
        public string Name { get; set; }
        public DateTime CheckinDate { get; set; }

        public string SupplierName { get; set; }

        public string ConfirmationNumber { get; set; }
    }
}