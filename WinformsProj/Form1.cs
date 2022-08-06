namespace WinformsProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.button1.Click += Mensage1;
            this.button1.Click += Mensage2;

            var triangulo = new Triangulo();
            triangulo.Size = new Size(100, 100);
            triangulo.Click += (sender, args) =>
            {
                MessageBox.Show($"esto es un triangulo");
            };
            this.Controls.Add(triangulo);
        }


        private void Mensage1(object sender, EventArgs e)
        {
            MessageBox.Show($"Mensage 1  texto del boton: {((Button)sender).Text}");
        }
        private void Mensage2(object sender, EventArgs e)
        {
            MessageBox.Show($"Mensage 2  texto del boton: {((Button)sender).Text}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Click -= Mensage1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button1.Click -= Mensage2;
        }
    }
}