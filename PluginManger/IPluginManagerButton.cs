using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;

namespace PluginManger
{
    public interface IPluginButton
    {
        public byte Red { get; }
        public byte Green { get; }
        public byte Blue { get; set; }
    }

    public  class  PluginManagerButton
    {

        public  string PluginFolder = "ProductosServicePlugin";

        public  IPluginButton LoadPlugin()
        {
            var pluginFile = Directory.GetFiles(PluginFolder, "*Plugins.dll").FirstOrDefault();
            if (pluginFile is null)
                return null;
            var context = new AssemblyLoadContext(pluginFile);
            var assembly = context.LoadFromAssemblyPath(System.IO.Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), pluginFile)));
            var types = assembly.GetTypes().ToList();
            var t = types.FirstOrDefault(x => typeof(IPluginButton).IsAssignableFrom(x));
            if (t == null)
                return null;
            IPluginButton p = Activator.CreateInstance(t) as IPluginButton;
            return p;

        }
    }
}
