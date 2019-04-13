using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosGenericos
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 3;

            Console.WriteLine("X = {0}, y = {1}", x, y);
            Intercambio<int>(ref x, ref y);
            Console.WriteLine("X = {0}, y = {1}", x, y);
            Console.WriteLine("=======================");
            string m = "Hola";
            string n = "Como estas ?";

            Console.WriteLine("m = {0}, n = {1}", m, n);
            Intercambio<string>(ref m, ref n);
            Console.WriteLine("m = {0}, n = {1}", m, n);


            Console.ReadKey();
        }

        //Metodo que utiliza un tipo generico <T> =simboliza tipo generico puede actuar como int,double,string
        static void Intercambio<T>(ref T a, ref T b)
        {
            T temporal;
            temporal = a;
            a = b;
            b = temporal;
        }
    }
}
