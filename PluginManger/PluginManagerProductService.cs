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
            var context = new AssemblyLoadContext(pluginFile);
            var assembly = context.LoadFromAssemblyPath(System.IO.Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(),pluginFile)));
            var types = assembly.GetTypes().ToList();
            var t = types.FirstOrDefault(x => typeof(IPluginManagerProductService).IsAssignableFrom(x));
            //.FirstOrDefault();
                //.Select((p) => new AssemblyLoadContext(p).LoadFromAssemblyPath(System.IO.Path.GetFullPath(p))).Select(c =>
                //    c.GetTypes().FirstOrDefault(x => x.IsAssignableFrom(typeof(IPluginManagerProductService))))
                //.FirstOrDefault();



            IPluginManagerProductService p = Activator.CreateInstance(t) as IPluginManagerProductService;
          return p;

        } 
    }

}
