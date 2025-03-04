namespace EjemploPooCoche
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Coche seat = new Coche();
            //La palabra reservada new nos permite llamar al constructor de la clase Coche
            Coche volskwagen = new Coche();

            seat.marca = "Seat";
            seat.modelo = "Leon";
            seat.color = "azul";
            seat.velocidad = 120;
            seat.agno = 2010;
            seat.encendido = true;

            volskwagen.marca = "volskwagen";
            volskwagen.modelo = "Golf";
            volskwagen.color = "blanco";
            volskwagen.velocidad = 200;
            volskwagen.agno = 2020;
            volskwagen.encendido = true;

            MessageBox.Show("El modelo del coche Seat es: " + seat.modelo);

        }
    }
}
