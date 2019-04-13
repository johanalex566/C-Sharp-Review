using System;
using System.Collections;

namespace Interfaces
{
    class Suma : IOperacion
    {
        private double Answer;
        private ArrayList AnswerList = new ArrayList();

        public void Calcular(double a, double b)
        {
            Answer = a + b;
        }

        public void Mostrar()
        {
            Console.WriteLine("El resultado de la suma es {0}", Answer);
            AnswerList.Add(Answer);
        }

        public void AnswersResult()
        {
            foreach (double R in AnswerList)
            {
                Console.WriteLine("The result is {0}", R);
            }
        }
    }
}
