﻿using OrderApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Repositories
{
    public interface IOrderRepository
    {
        Task<PoolManagerRS> GetOrderDetailsAsync(PoolManagerRQ schedulerInput);
    }
}
