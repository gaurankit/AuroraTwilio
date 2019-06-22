using OrderApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Services
{
    public interface IOrderPoolManagerService
    {
        Task<PoolManagerRS> GetOrderDetailsAsync(PoolManagerRQ schedulerInput);

        Task<bool> PushOrderDetailsToQueue(OrderDetail orderDetail);
    }
}