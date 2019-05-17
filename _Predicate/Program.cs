using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            /*System.Predicate<T> es un delegado generico que representa
             * un metodo que va a definir un criterio y dice si el objeto
             * cumple o no con ese criterio public List<T> FindAll(predicate<t> match)
             * recorre los elementos de la lista y los pasa como parametro al delegado,
             * si este regresa true los pone en la lista de retorno.
             */

            List<int> ListNumeros = new List<int>();
            ListNumeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            //Indicamos el delegado
            Predicate<int> delegado = new Predicate<int>(pares);

            //Invocamos metodo
            List<int> numPares = ListNumeros.FindAll(delegado);

            foreach (var n in numPares)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }

        static bool pares(int n)
        {
            if (n % 2 == 0)
                return true;
            else
                return false;

        }
    }
}
