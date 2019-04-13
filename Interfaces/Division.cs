using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Division : IOperacion
    {
        private double Answer;
        public void Calcular(double a, double b)
        {
            Answer = a / b;
        }

        public void Mostrar()
        {
            Console.WriteLine("The result of the division {0} is : ",Answer);
        }
    }
}
