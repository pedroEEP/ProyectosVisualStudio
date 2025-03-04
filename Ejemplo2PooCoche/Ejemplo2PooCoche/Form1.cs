namespace Ejemplo2PooCoche
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //La palabra reservada new nos permite llamar al constructor de la clase Coche

            Coche seat = new Coche();
            Coche volskwagen = new Coche();

            seat.setMarca("Seat");
            seat.setModelo("Leon");

            volskwagen.setMarca("volskwagen");
            volskwagen.setModelo("Golf");


            MessageBox.Show("La marca del coche Seat es: " + seat.getMarca());

        }
    }
}
