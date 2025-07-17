using System.Drawing.Text;

namespace Edad18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const int MAYOR_DE_EDAD = 18;
        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int edad;

            if (int.TryParse(txtEdad.Text, out edad))
            {
                if (edad >= MAYOR_DE_EDAD)
                {
                    MessageBox.Show($"El usuario : {nombre}, es mayor de edad");
                }
                else
                {
                    //Notación $ en messagebox para incluir valores de variables
                    MessageBox.Show ($"El usuario : {nombre}, es menor de edad");
                }
            }
            else
            {
                MessageBox.Show("Introduce una edad válida");
            }
        }
    }
}
