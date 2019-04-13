using System.Collections;
using System;
using System.Collections.Generic;

namespace _Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> Q = new Queue<string>(); //FIFO

            //Add
            Q.Enqueue("Manzana");
            Q.Enqueue("Fresa");
            Q.Enqueue("Pera");

            foreach (var frutas in Q)
                Console.WriteLine("-->{0}", frutas);

            Console.WriteLine("---------------");

            for (int i = 0; i < Q.Count; i++)
            {
                Console.WriteLine("Dequee removie {0}", Q.Dequeue());
            }
            foreach (var item in Q)
            {
                //remove
                Console.WriteLine("Dequee removie {0}", Q.Dequeue());

            }



            Console.WriteLine("---------------");

            //Read element
            Console.WriteLine("Peek {0}", Q.Peek());


            Console.WriteLine("---------------");

            Console.ReadKey();

        }
    }
}
