using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos.Logica
{
    public class Vehiculo
    {
     
        private string marca;
        private string modelo;
        private int año;

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Año { get => año; set => año = value; }


        public virtual String Mostrar()
        {
            return "Marca " + this.marca + "Modelo  " + this.modelo +
                "año " + this.año;
        }
    }
}
