namespace Notas_alumno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int nota1;
            bool esNumero = int.TryParse(txtNota1.Text, out nota1);

            if (!esNumero)
            {
                MessageBox.Show("Error: La nota 1 debe ser un número válido.");
                return;
            }

            int nota2 = int.Parse(txtNota2.Text);
            int nota3 = int.Parse(txtNota3.Text);

            int resultado = nota1 + nota2 + nota3;
            double notaFinal = resultado / 3;

            MessageBox.Show("La media del alumno es: " + notaFinal);
        }
    }
}
