using OrderPoolManager.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderPoolManager.Repositories
{
    interface IOrderRepository
    {
        Task<PoolManagerRS> GetOrderDetails(PoolManagerRQ schedulerInput);
    }
}
