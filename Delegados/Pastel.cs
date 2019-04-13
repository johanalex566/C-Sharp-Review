using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    class Pastel
    {
        public static void showPastel(string Anuncio)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine("This pastel have menssage of {0}: ", Anuncio);
        }
    }
}
