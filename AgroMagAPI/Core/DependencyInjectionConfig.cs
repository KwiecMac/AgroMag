using Microsoft.AspNetCore.Connections;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgroMagAPI.Core
{
    public class DependencyInjectionConfig
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            //services.AddScoped<IConnectionFactory, ConnectionFactory>()
            //    .AddScoped<IXXX_1, XXX_1>()
            //    .AddScoped<IXXX_2, XXX_2>()
            //    .AddScoped<IXXX_3, XXX_3>()
            //    .AddScoped<IXXX_4, XXX_4>()
            //    .AddScoped<IXXX_5, XXX_5>()
        }
    }
}
