using System;

namespace Interfaces
{


    class Resta : IOperacion
    {
        private double Answer;

        public void Calcular(double a, double b)
        {
            Answer = a - b;
        }

        public void Mostrar()
        {
            Console.WriteLine("The result of the subtraction {0}", Answer);
        }
    }
}
