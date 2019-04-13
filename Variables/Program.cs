using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int? i = null;
            if (i.HasValue)
            {
                Console.WriteLine("not is null");
            }
            else
            {
                Console.WriteLine("Is null");
            }
            //El operador ?? nos permite asignar un valor en caso de que tenga null
            double? number = asignador() ?? 5.55;
            Console.WriteLine(number);


            Console.WriteLine(i);
            Console.ReadKey();
        }
        public static double? asignador()
        {
            return 455;
        }
    }
}
