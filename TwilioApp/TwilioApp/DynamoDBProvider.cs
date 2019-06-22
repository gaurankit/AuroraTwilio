using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilioApp
{
    public class DynamoDBProvider
    {
        AmazonDynamoDBClient client = null;
        string tableName = "Aurora";
        public DynamoDBProvider()
        {
            AmazonDynamoDBConfig clientConfig = new AmazonDynamoDBConfig();
            // This client will access the US East 1 region.
            clientConfig.RegionEndpoint = RegionEndpoint.USEast2;
            client = new AmazonDynamoDBClient(clientConfig);
        }

        public void InsertOrder(OrderDetails order)
        {
            try
            {
                var putItemRS = client.PutItem(new PutItemRequest() { TableName = tableName, Item = order.ToAttributes() });
            }
            catch(Exception ex)
            {
                //TODO: log exception
            }
        }
    }
}
