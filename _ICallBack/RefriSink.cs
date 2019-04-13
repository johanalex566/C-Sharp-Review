using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ICallBack
{
    class RefriSink : IEventRefri
    {
        //Clase sink donde van los handlers definos en la intefaz

        public void EReservasBajas(int pKilos)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-->Reservas bajas de alimento");
            Console.WriteLine("--> Quedan {0} Kilos", pKilos);
        }
    }
}
