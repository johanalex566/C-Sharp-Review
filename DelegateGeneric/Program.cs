using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateGeneric
{
    class Program
    {
        public delegate void mydelegate<T>(T p);
        static void Main(string[] args)
        {
            //Reigistramos y usamos el string
            mydelegate<string> delString = new mydelegate<string>(HandlerString);
            delString("Hello world !!");

            mydelegate<double> delDouble = new mydelegate<double>(HanderDouble);
            delDouble(21.43);
        }
        public static void HandlerString(string menssage)
        {
            Console.WriteLine("Menssage string {0} :", menssage);
        }

        static void HanderDouble(double number)
        {
            Console.WriteLine("Menssage number {0} :", number);
        }
    }
}
