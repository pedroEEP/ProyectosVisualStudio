namespace EjemploFuncionesString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubcadena_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtOrigen.Text.Substring(0, 5);
        }

        private void btnMayuscula_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtOrigen.Text.ToUpper();
        }

        private void btnMinuscula_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtOrigen.Text.ToLower();
        }
    }
}
