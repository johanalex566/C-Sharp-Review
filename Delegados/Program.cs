using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    class Program
    {
        public delegate void myDelegate(string mensg);

        static void Main(string[] args)
        {
            //Creamos un objeto de delegado y lo referenciamos a un metodo.
            myDelegate delegado = new myDelegate(Radio.methodRadio);

            delegado("Hi world");

            //Cambiamos la referencia apuntado a otro metodo
            delegado = new myDelegate(Pastel.showPastel);

            delegado("Feliz cumpleaños");

            Console.ReadKey();


        }
    }
}
