using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TwilioVoiceAPI.Models;

namespace TwilioVoiceAPI.Providers
{
    
    public class DynamoDBProvider
    {
        //AmazonDynamoDBClient client = null;
        string tableName = "Aurora";
        public DynamoDBProvider()
        {
            //AmazonDynamoDBConfig clientConfig = new AmazonDynamoDBConfig();
            //// This client will access the US East 1 region.
            //clientConfig.RegionEndpoint = RegionEndpoint.USEast2;
            //client = new AmazonDynamoDBClient(clientConfig);
        }

        public OrderDetails GetOrderById(string orderId)
        {
            AmazonDynamoDBConfig clientConfig = new AmazonDynamoDBConfig();
            // This client will access the US East 1 region.
            clientConfig.RegionEndpoint = RegionEndpoint.USEast2;
            AmazonDynamoDBClient client = new AmazonDynamoDBClient(clientConfig);
            try
            {
                var request = new GetItemRequest
                {
                    TableName = tableName,
                    Key = new Dictionary<string, AttributeValue>()
                {
                    {
                        "OrderId", new AttributeValue { N = orderId  }
                    }
                },
                    ConsistentRead = true
                };

                var getItemRs = client.GetItem(request);

                var orderDetails = OrderDetails.ToModel(getItemRs.Item);
                return orderDetails;
            }
            catch(Exception ex)
            {
                //TOD: log exception.
            }
            return null;
        }

        public void UpdateOrderDetails(OrderDetails orderDetails)
        {
            try
            {
                AmazonDynamoDBConfig clientConfig = new AmazonDynamoDBConfig();
                // This client will access the US East 1 region.
                clientConfig.RegionEndpoint = RegionEndpoint.USEast2;
                AmazonDynamoDBClient client = new AmazonDynamoDBClient(clientConfig);
                var updateRq = new UpdateItemRequest
                {
                    Key = new Dictionary<string, AttributeValue>()
                {
                    { "OrderId", new AttributeValue { N = orderDetails.OrderId.ToString() } }
                },
                    ExpressionAttributeNames = new Dictionary<string, string>()
                {
                    {"#R","RetryCount"},
                    {"#LA","LastAttempted"},
                    {"#IC","IsConfirmed"}
                },
                    ExpressionAttributeValues = new Dictionary<string, AttributeValue>()
                {
                    {":R",new AttributeValue { N = orderDetails.RetryCount.ToString() }},
                    {":LA",new AttributeValue { S = DateTime.Now.ToString() }},
                    {":IC",new AttributeValue { S = orderDetails.IsConfirmed.ToString() }},
                },

                    UpdateExpression = "SET #R = :R, #LA = :LA, #IC = :IC",

                    TableName = tableName,
                    ReturnValues = "ALL_NEW" // Give me all attributes of the updated item.
                };
                var updateItemRS = client.UpdateItem(updateRq);
            }
            catch(Exception ex)
            {
                //TODO: log exception
            }
        }
    }
}