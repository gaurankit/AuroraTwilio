using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using OrderApp.Models;
using OrderApp.Repositories;
using OrderApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp
{
    public class Program
    {
        //private static string rootPath = System.IO.Path.GetDirectoryName(System.Environment.CommandLine.Split(' ')[0]) + "\\";
        //private static IConfiguration config;
        public static void Main(string[] args)
        {
            try
            {
                if (args.Length != 0)
                {
                    GetAndPushOrderDetailsToQueue(args).Wait();
                }
            }
            catch (Exception ex)
            {
                Environment.ExitCode = 1;
            }
            Environment.ExitCode = 0;
        }

        #region Helper methods
        private static async Task<bool> GetAndPushOrderDetailsToQueue(string[] args)
        {
            bool isSuccess = false;

            var orderPoolManagerService = new OrderPoolManagerService();

            var poolManagerRQ = GetPoolManagerRequest(args);

            var poolManagerRS = await orderPoolManagerService.GetOrderDetailsAsync(poolManagerRQ);

            foreach (OrderDetail orderDetail in poolManagerRS.OrderDetails)
            {
                isSuccess = await orderPoolManagerService.PushOrderDetailsToQueue(orderDetail);
            }

            return isSuccess;
        }

        private static PoolManagerRQ GetPoolManagerRequest(string[] args)
        {
            var poolManagerRQ = new PoolManagerRQ();

            var frequency = args[0];

            var today = DateTime.Today;

            switch (frequency)
            {
                //case "Hourly": 
                //    {
                //        poolManagerRQ.FromDate = today.AddDays(-1);
                //        poolManagerRQ.ToDate = today;
                //        break;
                //    }
                case "Daily":
                default:
                    {
                        //poolManagerRQ.FromDate = today.AddDays(-1);
                        poolManagerRQ.FromDate = today.AddMonths(-6);
                        poolManagerRQ.ToDate = today;
                        break;
                    }
            }

            return poolManagerRQ;
        }
        #endregion
    }
}
