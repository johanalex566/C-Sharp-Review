using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _action
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Action nos permite crear delegados en el momento, para un maximo de 16 parametros
             * el tipo de retorno debe ser void
             */
            int number = 5;
            string menssage = "Hello World";

            //Usamos action para registrar el handler con el delegado.
            Action<string, int> delAction = new Action<string, int>(RepiteMenssage);

            delAction(menssage, number);

            //Definimos el function, el último parametro es siempre el tipo que retorna.
            Func<int, int, int> func = new Func<int, int, int>(suma);
            Console.WriteLine(func(2,3));
            Console.ReadKey();
        }

        public static void RepiteMenssage(string menssage, int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(menssage);
            }
        }
        public static int suma(int a, int b)
        {
            try
            {
                return a + b;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
