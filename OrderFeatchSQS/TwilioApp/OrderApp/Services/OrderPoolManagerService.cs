using Amazon.SQS;
using Amazon.SQS.Model;
using AutoMapper.Configuration;
using Newtonsoft.Json;
using OrderApp.Models;
using OrderApp.Repositories;
//using OrderApp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Services
{
    public class OrderPoolManagerService : IOrderPoolManagerService
    {
        //readonly IConfiguration config;
        //private IOrderRepository _orderRepository;

        //public OrderPoolManagerService(IConfiguration configuration, IOrderRepository orderRepository)
        //{
        //    config = configuration;
        //    _orderRepository = orderRepository;
        //}
        public OrderPoolManagerService()
        {
        }

        public async Task<PoolManagerRS> GetOrderDetailsAsync(PoolManagerRQ poolManagerRQ)
        {
            //logger.DoAction($"Call GetOrderDetailsAsync");
            var orderRepository = new OrderRepository(); 
            var getResults = await orderRepository.GetOrderDetailsAsync(poolManagerRQ);
            return getResults;
        }

        public async Task<bool> PushOrderDetailsToQueue(OrderDetail orderDetail)
        {
            try
            {
                OrderDetails orderDetails = new OrderDetails();
                orderDetails.OrderId = orderDetail.OrderID;
                orderDetails.HotelId = string.Empty;
                orderDetails.SupplierName = orderDetail.HotelSupplierName;
                orderDetails.PropertyName = orderDetail.HotelPropertyName;
                orderDetails.PassengerLastName = orderDetail.PassengerLastName;
                orderDetails.PassergerFirstName = orderDetail.PassengerFirstName;
                orderDetails.HotelPhoneNumber = orderDetail.HotelPropertyPhone;
                orderDetails.RetryCount = orderDetail.RetryCount;
                orderDetails.ConfirmationNumber = orderDetail.SupplierConfirmationNumber;
                orderDetails.TravelDate = orderDetail.TravelDateTime;
                orderDetails.LastAttempted = orderDetail.LastAttemptedDateTime;
                orderDetails.IsConfirmed = orderDetail.IsHandled == 0?false:true;

                var sqsConfig = new AmazonSQSConfig
                {
                    ServiceURL = System.Configuration.ConfigurationManager.AppSettings["QueueProviderUrl"]
                };

                var sqsClient = new AmazonSQSClient(sqsConfig);

                SendMessageRequest request = new SendMessageRequest
                {
                    MessageGroupId = System.Configuration.ConfigurationManager.AppSettings["QueueMessageGroupId"],

                    QueueUrl = System.Configuration.ConfigurationManager.AppSettings["QueueServiceUrl"],

                    MessageBody = JsonConvert.SerializeObject(orderDetails, Formatting.Indented)
                };

                var sendMessageResponse = await sqsClient.SendMessageAsync(request);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
