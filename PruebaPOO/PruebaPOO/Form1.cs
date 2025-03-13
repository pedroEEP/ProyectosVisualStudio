namespace PruebaPOO
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
        }


        private void btnDatos_Click(object sender, EventArgs e)
        {
            string ma=txtMarca.Text;
            string mo=txtModelo.Text;
            string co=txtColor.Text;

            Coche coche=new Coche(ma, mo, co,false);
            MessageBox.Show("Datos del coche: " + "\n" +
                "Marca: " + coche.getMarca() + "\n" +
                "Modelo: " + coche.getModelo() + "\n" +
                "Color: " + coche.getColor());
        }
    }
}
