using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Imaginario im1 = new Imaginario(1,2);
            Imaginario im2 = new Imaginario(3,4);
            Imaginario imr;

            //
            imr = im1 = im2;

            Console.WriteLine("{0} + {1} = {2} ",im1,im2,imr);

            Console.ReadKey();
        }
    }
}
