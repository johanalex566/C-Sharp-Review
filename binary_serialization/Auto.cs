using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_serialization
{
    [Serializable]
    class Auto
    {
        private double costo;
        private string modelo;

        public Auto(double costo, string modelo)
        {
            this.modelo = modelo;
            this.costo = costo;
        }

        public void showInformatio()
        {
            Console.WriteLine("Tu automovil {0}",modelo);
            Console.WriteLine("Costo {0}",costo);
            Console.WriteLine("------------------------");
        }
    }
}
