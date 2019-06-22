using System;
using Amazon.SQS;
using Amazon.SQS.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace TestSuit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var sqsConfig = new AmazonSQSConfig();
            sqsConfig.ServiceURL = "https://sqs.us-east-2.amazonaws.com";
            var sqsClient = new AmazonSQSClient(sqsConfig);

            SendMessageRequest request = new SendMessageRequest();
            request.MessageGroupId = "1";
            request.QueueUrl = "https://sqs.us-east-2.amazonaws.com/694055993363/Aurora.fifo";

            OrderDetails order = new OrderDetails() { OrderId = 454478, ConfirmationNumber = "45478457", PassengerLastName = "Alex", PassergerFirstName = "Doe", HotelPhoneNumber = "+16514289168", SupplierName = "Expedia" };
            request.MessageBody = JsonConvert.SerializeObject(order);
            var sendMessageResponse = sqsClient.SendMessage(request);

             order = new OrderDetails() { OrderId = 784457, ConfirmationNumber = "12545478", PassengerLastName = "Bob", PassergerFirstName = "Doe", HotelPhoneNumber = "+19523888164", SupplierName = "Expedia" };
            request.MessageBody = JsonConvert.SerializeObject(order);
            sendMessageResponse = sqsClient.SendMessage(request);

             order = new OrderDetails() { OrderId = 665457, ConfirmationNumber = "54895544", PassengerLastName = "Mike", PassergerFirstName = "Doe", HotelPhoneNumber = "+19523888164", SupplierName = "Expedia" };
            request.MessageBody = JsonConvert.SerializeObject(order);
            sendMessageResponse = sqsClient.SendMessage(request);
        }


    }

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
