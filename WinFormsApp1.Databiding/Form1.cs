using Microsoft.Extensions.DependencyInjection;
using Servicios;

namespace WinFormsApp1.Databiding
{
    public partial class Form1 : Form
    {
        public ViewModel ViewModel { get; set; } = new ViewModel();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            label1.DataBindings.Add(new Binding(nameof(label1.Text), ViewModel,
                nameof(ViewModel.UserText), false, DataSourceUpdateMode.OnPropertyChanged));

            label1.DataBindings.Add(new Binding(nameof(label1.BackColor), ViewModel,
                nameof(ViewModel.LabelColor), false, DataSourceUpdateMode.OnPropertyChanged));

            textBox1.DataBindings.Add(new Binding(nameof(textBox1.Text), ViewModel,
                nameof(ViewModel.UserText), false, DataSourceUpdateMode.OnPropertyChanged));
            button1.Click += ViewModel.OnPost;
            var service =  DPI.DPIContainer.GetServiceProvider().GetService<IProductService>();

          service.GetProducs().ToList().ForEach((c) =>
          {
              flowLayoutPanel1.Controls.Add(new Label
              {
                  Size = new Size(100,100),
                  Text = c.Nombre

              });
          });
          new Form2().ShowDialog();
         
        }

      
    }
}