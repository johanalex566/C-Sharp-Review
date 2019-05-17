using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos el metodo anonimo para el delegado
            Punto punto = new Punto(5,6);
            punto.menssage += delegate ()
            {
                Console.WriteLine("Estoy desde el metodo anonimo");
            };

            Console.WriteLine(punto.ToString());
            //Invocamos
            punto.menssage();
            
            //adicionamos otro.
            punto.menssage += delegate ()
            {
                Console.WriteLine("Añadimos otro metodo anonimo");
            };
            punto.menssage();
            Console.ReadKey();
        }
    }
}
