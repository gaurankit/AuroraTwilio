using Amazon.DynamoDBv2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwilioVoiceAPI.Models
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

        public Dictionary<string, AttributeValue> ToAttributes()
        {
            return new Dictionary<string, AttributeValue>()
            {
                {
                    "OrderId", new AttributeValue() { N = this.OrderId.ToString() }
                },
                {
                    "HotelId", new AttributeValue() { S = string.IsNullOrWhiteSpace(this.HotelId) ? "-" : this.HotelId  }
                },
                {
                    "SupplierName", new AttributeValue() { S = string.IsNullOrWhiteSpace(this.SupplierName) ? "-" : this.SupplierName  }
                },
                {
                    "PropertyName", new AttributeValue() { S = string.IsNullOrWhiteSpace(this.PropertyName) ? "-" : this.PropertyName  }
                },
                {
                    "PassergerFirstName", new AttributeValue() { S = string.IsNullOrWhiteSpace(this.PassergerFirstName) ? "-" : this.PassergerFirstName  }
                },
                {
                    "PassengerLastName", new AttributeValue() { S = string.IsNullOrWhiteSpace(this.PassengerLastName) ? "-" : this.PassengerLastName  }
                },
                {
                    "HotelPhoneNumber", new AttributeValue() { S = string.IsNullOrWhiteSpace(this.HotelPhoneNumber) ? "-" : this.HotelPhoneNumber  }
                },
                {
                    "RetryCount", new AttributeValue() { N = this.RetryCount.ToString() }
                },
                {
                    "ConfirmationNumber", new AttributeValue() { S = string.IsNullOrWhiteSpace(this.ConfirmationNumber) ? "-" : this.ConfirmationNumber  }
                },
                {
                    "TravelDate", new AttributeValue() { S = this.TravelDate.ToString() }
                },
                {
                    "LastAttempted", new AttributeValue() { S = this.LastAttempted.ToString() }
                },
                {
                    "IsConfirmed", new AttributeValue() { S = this.IsConfirmed.ToString() }
                },
            };
        }

        public static OrderDetails ToModel(Dictionary<string, AttributeValue> attributes)
        {
            return new OrderDetails()
            {
                OrderId = attributes.ContainsKey("OrderId") ? int.Parse(attributes["OrderId"].N) : 0,
                HotelId = attributes.ContainsKey("HotelId") ? attributes["HotelId"].S : null,
                SupplierName = attributes.ContainsKey("SupplierName") ? attributes["SupplierName"].S : null,
                PropertyName = attributes.ContainsKey("PropertyName") ? attributes["PropertyName"].S : null,
                PassergerFirstName = attributes.ContainsKey("PassergerFirstName") ? attributes["PassergerFirstName"].S : null,
                PassengerLastName = attributes.ContainsKey("PassengerLastName") ? attributes["PassengerLastName"].S : null,
                HotelPhoneNumber = attributes.ContainsKey("HotelPhoneNumber") ? attributes["HotelPhoneNumber"].S : null,
                RetryCount = attributes.ContainsKey("RetryCount") ? int.Parse(attributes["RetryCount"].N) : 0,
                ConfirmationNumber = attributes.ContainsKey("ConfirmationNumber") ? attributes["ConfirmationNumber"].S : null,
                TravelDate = attributes.ContainsKey("TravelDate") ? DateTime.Parse(attributes["TravelDate"].S) : DateTime.MinValue,
                LastAttempted = attributes.ContainsKey("LastAttempted") ? DateTime.Parse(attributes["LastAttempted"].S) : DateTime.MinValue,
                IsConfirmed = attributes.ContainsKey("IsConfirmed") ? bool.Parse(attributes["IsConfirmed"].S) : false,
            };
        }
    }
}