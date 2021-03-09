using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptionsDemo.Services
{
    public class OrderService : IOrderService
    {
        IOptions<OrderServiceOption> _option;
        public OrderService(IOptions<OrderServiceOption> option)
        {
            this._option = option;
        }
        public int ShowMaxCount()
        {
            return _option.Value.MaxCount;
        }
    }
}
