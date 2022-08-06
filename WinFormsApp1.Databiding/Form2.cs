using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using PluginManger;
using Servicios;

namespace WinFormsApp1.Databiding
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var manager = DPI.DPIContainer.GetServiceProvider().GetService<PluginManagerButton>();
           var p = manager.LoadPlugin();
           if (p != null)
           {
               button1.BackColor = Color.FromArgb(p.Red, p.Green, p.Blue);
           }
        }
    }
}
