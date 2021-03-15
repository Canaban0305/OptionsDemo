using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptionsDemo.Services
{
    public static class OrderServiceExtensions
    {
        public static IServiceCollection AddOrderService(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<OrderServiceOption>(configuration);

            // 动态配置
            services.PostConfigure<OrderServiceOption>(options =>
            {
                options.MaxCount += 100;
            });

            services.AddSingleton<IOrderService, OrderService>();
            return services;
        }
    }
}
