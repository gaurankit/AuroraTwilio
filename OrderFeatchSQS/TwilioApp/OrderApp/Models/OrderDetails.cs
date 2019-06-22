using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Models
{
    public class OrderDetails
    {
        public int OrderId { get; set; }
        public string HotelId { get; set; }
        public string SupplierName { get; set; }
        public string PropertyName { get; set; }
        public string PassergerFirstName { get; set; }
        public string PassengerLastName { get; set; }
        public string HotelPhoneNumber { get; set; }
        public int RetryCount { get; set; }
        public string ConfirmationNumber { get; set; }
        public DateTime TravelDate { get; set; }
        public DateTime LastAttempted { get; set; }
        public bool IsConfirmed { get; set; }

    }

}
