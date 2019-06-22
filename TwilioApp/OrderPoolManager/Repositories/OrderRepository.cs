using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OrderPoolManager.Models;
using OrderPoolManager.Repositories.DBModels;
using System.Linq;

namespace OrderPoolManager.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderContext _OrderContext;
        public OrderRepository(OrderContext dbContext)
        {
            _OrderContext = dbContext;
        }

        public async Task<PoolManagerRS> GetOrderDetailsAsync(PoolManagerRQ schedulerInput)
        {
            var poolManagerRS = new PoolManagerRS();

            var cmd = EFExtension.LoadStoredProc(_OrderContext, "spGetOrderDetailsByDateTime").WithSqlParam("@From", schedulerInput.FromDate).WithSqlParam("@To", schedulerInput.ToDate);
            await EFExtension.ExecuteStoredProcAsync(cmd, (handler) =>
            {
                poolManagerRS.OrderDetails = handler.ReadToList<OrderDetail>().ToList();
            });

            return poolManagerRS;
        }
    }
}
