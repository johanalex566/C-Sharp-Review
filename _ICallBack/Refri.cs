using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ICallBack
{
    class Refri
    {
        //Aqui guardamos los sinks con los que se comunica el refri
        private ArrayList ListSinks = new ArrayList();

        private int KilosAlimento = 0;
        private int Grados = 0;

        public Refri(int KilosAlimento, int Grados)
        {
            this.KilosAlimento = KilosAlimento;
            this.Grados = Grados;
        }

        //Con este metodo adicionamos un sink
        public void AddSink(IEventRefri objSink)
        {
            if (objSink != null)
            {
                ListSinks.Add(objSink);
            }
        }

        public void DeleteSink(IEventRefri objSink)
        {
            if (ListSinks.Contains(objSink))
            {
                ListSinks.Remove(objSink);
            }
        }

        public int getKilos()
        {
            return KilosAlimento;
        }

        public int getGrados()
        {
            return Grados;
        }


        public void Working(int Consumo)
        {
            KilosAlimento -= Consumo;
            Grados += 1;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0}, Kilos, {1} Grados",KilosAlimento,Grados);

            //Verificamos condicion para invocar Handlers
            if (KilosAlimento < 10)
            {
                //Invocamos a los handlers de cada sinks
                foreach (IEventRefri Handler in ListSinks)
                {
                    Handler.EReservasBajas(KilosAlimento);
                }
            }
        }

    }
}
