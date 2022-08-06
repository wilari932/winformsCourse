using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace DPI
{
    public static class ServiceProviderBuilder
    {
        private static IServiceCollection InitServiceProvider()
        {
            try
            {
                var services = new ServiceCollection();
                return services;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static IServiceProvider RegisterService(Action<IServiceCollection> action)
        {
            var services = InitServiceProvider();
            action?.Invoke(services);
            return services.BuildServiceProvider();
        }
    }
}
