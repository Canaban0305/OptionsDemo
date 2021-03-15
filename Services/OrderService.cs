using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptionsDemo.Services
{
    public class OrderService : IOrderService
    {
        //IOptions<OrderServiceOption> _option;

        // 热更新 -- 范围作用域注册
        //IOptionsSnapshot<OrderServiceOption> _option;

        // 热更新 -- 单例模式注册
        IOptionsMonitor<OrderServiceOption> _option;
        public OrderService(IOptionsMonitor<OrderServiceOption> option)
        {
            this._option = option;

            _option.OnChange(options =>
            {
                Console.WriteLine($"配置发生了变化：{options.MaxCount}");
            });
        }
        public int ShowMaxCount()
        {
            return _option.CurrentValue.MaxCount;
        }
    }
}
