namespace Ejemplo3PooCoche
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

            Coche seat = new Coche("Seat", "Leon", "azul", 120, 2010, true);
            Coche volskwagen = new Coche("volskwagen", "Golf", "blanco", 200, 2020, true);


            MessageBox.Show("La marca del coche Seat es: " + seat.getMarca());
            MessageBox.Show("La color del coche Seat es: " + seat.getColor());

        }
    }
}
