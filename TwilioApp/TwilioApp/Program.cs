using Amazon.SQS;
using Amazon.SQS.Model;
using Newtonsoft.Json;
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
        public static AmazonSQSClient _queue = null;
        private static DynamoDBProvider _db = new DynamoDBProvider();
        private static string _queueUrl = "https://sqs.us-east-2.amazonaws.com/694055993363/Aurora.fifo";

        static void Main(string[] args)
        {
            ConsoleKeyInfo result;
            Random random = new Random();
            List<string> verifiedNumbers = new List<string>() { "+16514289168", "+19523888164" };

            do
            {
                Console.WriteLine("Fetching order from queue..");
                var sqsConfig = new AmazonSQSConfig();
                sqsConfig.ServiceURL = "https://sqs.us-east-2.amazonaws.com";
                _queue = new AmazonSQSClient(sqsConfig);

                var receiveMessageRequest = new ReceiveMessageRequest();

                receiveMessageRequest.QueueUrl = _queueUrl;
                var receiveMessageResponse = _queue.ReceiveMessage(receiveMessageRequest);
                if (receiveMessageResponse != null && receiveMessageResponse.Messages != null && receiveMessageResponse.Messages.Count > 0)
                {

                    DeleteMessageRequest deleteMessageRequest = new DeleteMessageRequest();
                    var message = receiveMessageResponse.Messages.FirstOrDefault();
                    deleteMessageRequest.QueueUrl = _queueUrl;
                    deleteMessageRequest.ReceiptHandle = message.ReceiptHandle;
                    DeleteMessageResponse response = _queue.DeleteMessage(deleteMessageRequest);

                    var orderDetails = JsonConvert.DeserializeObject<OrderDetails>(message.Body);

                    _db.InsertOrder(orderDetails);

                    // Find your Account Sid and Auth Token at twilio.com/console
                    const string accountSid = "AC975209aff8f73551ccf7b2c8b511c649";
                    const string authToken = "54c3e6ba8d47587db61a2e4b170c3bac";
                    TwilioClient.Init(accountSid, authToken);
                    var hotelPhoneNumber = verifiedNumbers[random.Next(0, 1)];
                    var to = new PhoneNumber(hotelPhoneNumber);
                    var from = new PhoneNumber("+17639511257");
                    var call = CallResource.Create(to, from,
                        url: new Uri("https://fe49ec69.ngrok.io/Aurora/GetOrder?orderId=" + orderDetails.OrderId));


                    Console.WriteLine("Calling - {0}", hotelPhoneNumber);
                }
                else
                {
                    Console.WriteLine("No record found");
                }
                Console.WriteLine("Press 'Y' to fetch next order..");
                result = Console.ReadKey();
            } while (result.KeyChar == 'Y' || result.KeyChar == 'y');
        }
    }
}
