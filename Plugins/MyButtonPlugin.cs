using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginManger;

namespace Plugins
{
    public class MyButtonPlugin:IPluginButton
    {
        public byte Red { get; } = 110;
        public byte Green { get; } = 120;
        public byte Blue { get; set; } = 183;
    }
}
