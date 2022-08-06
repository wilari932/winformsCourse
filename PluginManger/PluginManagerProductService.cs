using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;
using Servicios;

namespace PluginManger
{
    public interface IPluginManagerProductService
    {
        IProductService GetInstance();
    }
    public static class PluginManagerProductService
    {
        public static string PluginFolder = "ProductosServicePlugin";

        public static IPluginManagerProductService LoadPlugin()
        {
            var pluginFile = Directory.GetFiles(PluginFolder, "*Plugins.dll").FirstOrDefault();
            if (pluginFile is null)
                return null;
            var context = new AssemblyLoadContext(pluginFile);
       
             using var file = new FileStream(pluginFile, FileMode.Open, FileAccess.Read);
            
            var assembly = context.LoadFromStream(file);
            var types = assembly.GetTypes().ToList();
            var t = types.FirstOrDefault(x => typeof(IPluginManagerProductService).IsAssignableFrom(x));
            if (t == null)
                return null;
           
            IPluginManagerProductService p = Activator.CreateInstance(t) as IPluginManagerProductService;
          return p;

        } 
    }

}
