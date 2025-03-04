using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2PooCoche
{
    internal class Coche
    {
        //Atributos
        private string marca;
        private string modelo;
        private string color;
        private int velocidad;
        private int agno;
        private bool encendido;

        //Métodos get y set
        public void setMarca(string m)
        {
            marca = m;
        }

        public string getMarca()
        {
            return marca;
        }
        public void setModelo(string mo)
        {
            modelo = mo;
        }
        public string getModelo()
        {
            return modelo;
        }
        public void setColor(string c)
        {
            color = c;
        }
        public string getColor()
        {
            return color;
        }
        public void setVelocidad(int v)
        {
            velocidad = v;
        }
        public int getVelocidad()
        {
            return velocidad;
        }
        public void setAgno(int a)
        {
            agno = a;
        }
        public int getAgno()
        {
            return agno;
        }
        public void setEncendido(bool e)
        {
            encendido = e;
        }
        public bool getEncendido()
        {
            return encendido;
        }

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




