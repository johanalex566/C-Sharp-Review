using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ICallBack
{
    class Program
    {
        static void Main(string[] args)
        {
            Refri MyRefri = new Refri(50, -20);
            Random rnd = new Random();

            //sink1 tiene el codigo que se ejecutara cuando suceda el evento
            RefriSink sink1 = new RefriSink();

            MyRefri.AddSink(sink1);

            //Working refri
            while (MyRefri.getKilos() > 0)
            {
                MyRefri.Working(rnd.Next(1,5));
            }
            Console.ReadKey();
        }
    }
}
