using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Amazon.SQS;
using Amazon.SQS.Model;
using Microsoft.Extensions.Configuration;
using OrderPoolManager.Models;
using OrderPoolManager.Repositories;
using OrderPoolManager.Utilities;
using Newtonsoft.Json;

namespace OrderPoolManager.Services
{
    public class OrderPoolManagerService : IOrderPoolManagerService
    {
        readonly LogRunner logger;
        readonly IConfiguration config;
        private IOrderRepository _orderRepository;

        public OrderPoolManagerService(IConfiguration configuration, IOrderRepository orderRepository, LogRunner logRunner)
        {
            config = configuration;
            logger = logRunner;
            _orderRepository = orderRepository;
        }
        public async Task<PoolManagerRS> GetOrderDetailsAsync(PoolManagerRQ poolManagerRQ)
        {
            logger.DoAction($"Call GetOrderDetailsAsync");
            var getResults = await _orderRepository.GetOrderDetailsAsync(poolManagerRQ);
            return getResults;
        }

        public async Task<bool> PushOrderDetailsToQueue(OrderDetail orderDetail)
        {
            try
            {
                var sqsConfig = new AmazonSQSConfig
                {
                    ServiceURL = config.GetValue<string>("QueueProviderUrl")
                };

                var sqsClient = new AmazonSQSClient(sqsConfig);

                SendMessageRequest request = new SendMessageRequest
                {
                    MessageGroupId = config.GetValue<string>("QueueMessageGroupId"),

                    QueueUrl = config.GetValue<string>("QueueServiceUrl"),

                    //MessageBody = JsonConvert.SerializeObject(orderDetail, Formatting.Indented)
                    MessageBody = "Test"
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