using OrderApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace OrderApp.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public OrderRepository()
        {
            
        }

        public async Task<PoolManagerRS> GetOrderDetailsAsync(PoolManagerRQ schedulerInput)
        {
            var poolManagerRS = new PoolManagerRS();

            var ds = new DataSet();
            using (var con = new SqlConnection(GetConnectionString()))
            {
                var From = schedulerInput.FromDate;
                var To = schedulerInput.ToDate;

                con.Open();
                using (var command = new SqlCommand("spGetOrderDetailsByDateTime", con))
                {
                    var param = command.CreateParameter();

                    command.Parameters.Add(new SqlParameter("@From", schedulerInput.FromDate));
                    command.Parameters.Add(new SqlParameter("@To", schedulerInput.ToDate));
                    command.CommandType = CommandType.StoredProcedure;

                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(ds);
                    }
                }
            }
            poolManagerRS = ParseResult(ds);

            return poolManagerRS;
        }

        private PoolManagerRS ParseResult(DataSet dataSet)
        {
            var poolManagerRS = new PoolManagerRS();
            poolManagerRS.OrderDetails = new List<OrderDetail>();

            if (dataSet == null)
                throw new ArgumentNullException("dataSet");

            if (dataSet.Tables == null || dataSet.Tables.Count == 0)
                throw new ArgumentException("The dataset has no tables to read", "dataSet");

            var table = dataSet.Tables[0];
            if (table.Rows != null && table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    OrderDetail orderDetail = new OrderDetail();
                    orderDetail.OrderID = Convert.ToInt32(row["OrderID"]);
                    orderDetail.OrderDetailID = Convert.ToInt32(row["OrderDetailID"]);
                    orderDetail.RetryCount = Convert.ToInt32(row["RetryCount"]);
                    orderDetail.IsHandled = Convert.ToInt32(row["IsHandled"]);
                    orderDetail.LastAttemptedDateTime = Convert.ToDateTime(row["LastAttemptedDateime"]);
                    orderDetail.TravelDateTime = Convert.ToDateTime(row["TravelDateTime"]);
                    orderDetail.HotelPropertyID = Convert.ToInt32(row["HotelPropertyID"]);
                    orderDetail.HotelSupplierName = Convert.ToString(row["HotelSupplierName"]);
                    orderDetail.HotelPropertyName = Convert.ToString(row["HotelPropertyName"]);
                    orderDetail.HotelPropertyAddress1 = Convert.ToString(row["HotelPropertyAddress1"]);
                    orderDetail.HotelPropertyAddress1 = Convert.ToString(row["HotelPropertyAddress1"]);
                    orderDetail.HotelPropertyCity = Convert.ToString(row["HotelPropertyCity"]);
                    orderDetail.HotelPropertyState = Convert.ToString(row["HotelPropertyState"]);
                    orderDetail.HotelPropertyCountry = Convert.ToString(row["HotelPropertyCountry"]);
                    orderDetail.HotelPropertyPhone = Convert.ToString(row["HotelPropertyPhone"]);
                    orderDetail.SupplierConfirmationNumber = Convert.ToString(row["SupplierConfirmationNumber"]);
                    orderDetail.PassengerFirstName = Convert.ToString(row["PassengerFirstName"]);
                    orderDetail.PassengerLastName = Convert.ToString(row["PassengerLastName"]);
                    orderDetail.PassengerEmailID = Convert.ToString(row["PassengerEmailID"]);
                    poolManagerRS.OrderDetails .Add(orderDetail);
                }
            }
            return poolManagerRS;
        }

        protected string GetConnectionString()
        {
            var connectionInfo = ConfigurationManager.ConnectionStrings["OrderDB"];

            if (connectionInfo == null || string.IsNullOrWhiteSpace(connectionInfo.ConnectionString))
                throw new ConfigurationErrorsException("OrderDB connection string is missing in the host config file.");

            return connectionInfo.ConnectionString;
        }
    }
}