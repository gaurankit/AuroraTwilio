using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Models
{
    public class PoolManagerRS
    {
        public List<OrderDetail> OrderDetails { get; set; }
    }

    public class OrderDetail
    {
        public int OrderID { get; set; }
        public int OrderDetailID { get; set; }
        public int HotelPropertyID { get; set; }
        public string HotelSupplierName { get; set; }
        public string HotelPropertyName { get; set; }
        public string HotelPropertyAddress1 { get; set; }
        public string OrdeHotelPropertyAddress2 { get; set; }
        public string HotelPropertyCity { get; set; }
        public string HotelPropertyState { get; set; }
        public string HotelPropertyCountry { get; set; }
        public string HotelPropertyPhone { get; set; }
        public DateTime TravelDateTime { get; set; }
        public string SupplierConfirmationNumber { get; set; }
        public string PassengerFirstName { get; set; }
        public string PassengerLastName { get; set; }
        public string PassengerEmailID { get; set; }
        public int RetryCount { get; set; }
        public int IsHandled { get; set; }
        public DateTime LastAttemptedDateTime { get; set; }
    }
}
