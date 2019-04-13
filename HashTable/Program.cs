using System.Collections;
using System;
namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myTable = new Hashtable();

            //Add element
            myTable.Add(1, "Java");
            myTable.Add(2, "JavaScript");
            myTable.Add(3, "C#");

            //Modifity element
            myTable[1] = "PHP";
            myTable[4] = "Vue.js";


            //Show element
            foreach (DictionaryEntry Element in myTable)
            {
                Console.WriteLine("({0},{1})", Element.Key, Element.Value);
            }

            Console.WriteLine("================================");

            Console.WriteLine("The count of element are {0}", myTable.Count);

            Console.WriteLine(myTable[1]);
            Console.WriteLine(myTable[2]);

            //Check one element

            Console.WriteLine("The element existe = {0}",myTable.Contains(1));
                                 
            Console.ReadKey();


        }
    }
}
