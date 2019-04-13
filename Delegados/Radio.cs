using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    class Radio
    {
         public static void methodRadio(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("We have in the class radio");
            Console.WriteLine("this is on message {0}: ", message);
        }
    }
}
