using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos.Logica
{
    public class Automovil : Vehiculo
    {
        private string matricula;
        private int cantidadPuerta;
        private String tipoCombustible;

        public int CantidadPuerta { get => cantidadPuerta; set => cantidadPuerta = value; }
        public string TipoCombustible { get => tipoCombustible; set => tipoCombustible = value; }
        public string Matricula { get => matricula; set => matricula = value; }

        public override string Mostrar()
        {
            return base.Mostrar() + " Cantidad Puerta: "+ this.cantidadPuerta +
                
                "Tipo Combustibnle "+ this.tipoCombustible;
        }



    }
}
