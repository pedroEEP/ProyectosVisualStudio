using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPOO
{
    internal class Coche
    {
        //Atributos
        private string marca;
        private string modelo;
        private string color;
        private bool encendido;
        
        
        //Constructor
        public Coche(string ma, string mo,string co,bool en)
        {
            marca = ma;
            modelo = mo;
            color = co; 
            encendido = en;

        }
        
        //Métodos set y get 
        public void setMarca(string ma) {marca = ma;}
        public string getMarca() {return marca;}
        public void setModelo(string mo) {modelo = mo;}
        public string getModelo() {return modelo;}
        public void setColor(string co) {color = co;}
        public string getColor() {return color;}
        public void setEncendido(bool en) {encendido = en;} 
        public bool getEncendido() {return encendido;}

    }
}
