using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OrderPoolManager.Models;

namespace OrderPoolManager.Services
{
    public class OrderPoolManagerService : IOrderPoolManagerService
    {
        public Task<PoolManagerRS> GetOrderDetailsAsync(PoolManagerRQ schedulerInput)
        {
            throw new NotImplementedException();
        }
    }
}
