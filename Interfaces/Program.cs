using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            double vala = 0.0;
            double valb = 0.0;
            IOperacion Operacion = null;

            Console.WriteLine("1-Sum, 2-Subtraction, 3-Multuply, 4-Division, 5-Exit");
            opc = Convert.ToInt32(Console.ReadLine());

            while (opc != 5)
            {

                Console.WriteLine("Get value A");
                vala = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Get value B");
                valb = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Operacion = new Suma();
                        break;
                    case 2:
                        Operacion = new Resta();
                        break;
                    case 3:
                        Operacion = new Multiplicacion();
                        break;
                    case 4:
                        Operacion = new Division();
                        break;
                    default:
                        break;
                }
                Operacion.Calcular(vala, valb);
                Operacion.Mostrar();

                Console.WriteLine("1-Sum, 2-Subtraction, 3-Multuply, 4-Division, 5-Exit");
                opc = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
