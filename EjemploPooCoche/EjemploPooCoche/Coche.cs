using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPooCoche
{
    internal class Coche
    {
    
        //Atributos
        public string marca;
        public string modelo;
        public string color;
        public int velocidad;
        public int agno;
        public bool encendido;

        //Métodos
        public void Arrancar()
        {
            encendido = true;
        }
        public void Parar()
        {
            encendido = false;
        }

        public int VelocidadActual()
        {
            return velocidad;
        }
    }
}

