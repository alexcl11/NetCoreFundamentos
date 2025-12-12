namespace NetCoreFundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnPulsar_Click_1(object sender, EventArgs e)
        {
            //SOLO ESCRIBIMOS AQUI
            this.txtNombre.Location = new Point(10, 3);
            this.txtNombre.Text = "Soy un texto nuevo!!";
            this.txtNombre.Width = 200;
            this.txtNombre.TextAlign = HorizontalAlignment.Right;
            this.txtNombre.BackColor = Color.Green;
        }
    }
}
