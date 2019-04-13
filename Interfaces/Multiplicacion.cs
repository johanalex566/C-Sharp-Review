using System;

namespace Interfaces
{
    class Multiplicacion : IOperacion
    {


        private double Answer;

        public void Calcular(double a, double b)
        {
            Answer = a * b;
        }

        public void Mostrar()
        {
            Console.WriteLine("The result of the multiply {0}", Answer);
        }
    }
}
