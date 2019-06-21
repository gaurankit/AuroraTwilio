using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OrderPoolManager.Models;
using OrderPoolManager.Repositories.DBModels;

namespace OrderPoolManager.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderContext _OrderContext;
        public OrderRepository(OrderContext dbContext)
        {
            _OrderContext = dbContext;
        }

        public Task<PoolManagerRS> GetOrderDetails(PoolManagerRQ schedulerInput)
        {
            throw new NotImplementedException();
        }
    }
}
