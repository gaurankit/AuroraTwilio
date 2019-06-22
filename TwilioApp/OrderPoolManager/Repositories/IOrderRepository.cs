using OrderPoolManager.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderPoolManager.Repositories
{
    public interface IOrderRepository
    {
        Task<PoolManagerRS> GetOrderDetailsAsync(PoolManagerRQ schedulerInput);
    }
}
