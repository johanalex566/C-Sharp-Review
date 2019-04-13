using System;
using System.Collections;

namespace _ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Palabras = new ArrayList();
            int n = 0;
            int r = 0;

            //We can add by rank
            // An aaray is passed as a parameter
            Palabras.AddRange(new string[] { "Hola", "Como", "Estsn?" });

            System.Console.WriteLine("Amount of elemet in the arrayList {0}", Palabras.Count);

            for (int i = 0; i < Palabras.Count; i++)
            {
                System.Console.WriteLine("{0}", Palabras[i]);
            }
            Console.WriteLine("----------------");

            //Way of add elemets 
            Palabras.Add("bien y tu");

            foreach(var item in Palabras)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");

            ArrayList values = new ArrayList();

            //values.Add(new int [] {1,2,3,4,5});
            values.Add(1);
            values.Add(2);
            values.Add(3);


            for (int i = 0; i < values.Count; i++)
            {
                r = (int)values[i];
                Console.WriteLine(r);
            }

            Console.WriteLine("===================");

            Console.WriteLine("Verify the existence of an element 5");
            Console.WriteLine(values.Contains(5));

            Console.WriteLine("===================");

            Console.WriteLine("Insert on element in specify position");

            values.Insert(2,55);

            for (int i = 0; i < values.Count; i++)
            {
                r = (int)values[i];
                Console.WriteLine(r);
            }

            Console.WriteLine("===================");

            Console.WriteLine("Remove on element 55");
            values.Remove(55);


            Console.WriteLine("===================");


            Console.WriteLine("Remove in specify position 1");
            values.RemoveAt(0);

            for (int i = 0; i < values.Count; i++)
            {
                r = (int)values[i];
                Console.WriteLine(r);
            }



            Console.ReadKey();
        }
    }
}
