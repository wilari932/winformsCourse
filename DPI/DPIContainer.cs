using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using PluginManger;
using Servicios;
using Servicios.Implementation;
using static DPI.ServiceProviderBuilder;

namespace DPI
{
    public static class DPIContainer
    {
        private static IServiceProvider _serviceProvider;
        
        private static IServiceProvider Build() => RegisterService((service) =>
        {
           var p = PluginManagerProductService.LoadPlugin().GetInstance();
            service.TryAddTransient<IProductService>(x=> p );
            service.AddSingleton<PluginManagerButton>(x => new PluginManagerButton());
        });

        public static IServiceProvider GetServiceProvider()
        {
            _serviceProvider ??= Build();
            return _serviceProvider;
        }

    }
}
