using OrderPoolManager.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderPoolManager.Services
{
    interface IOrderPoolManagerService
    {
        Task<PoolManagerRS> GetOrderDetailsAsync(PoolManagerRQ schedulerInput);
    }
}
