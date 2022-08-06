using PluginManger;
using Servicios;
using Servicios.Implementation;

namespace Plugins
{
    public class ProducServicePlugin: IPluginManagerProductService
    {
        public IProductService GetInstance()
            => new NuevoProductService();
    }
}