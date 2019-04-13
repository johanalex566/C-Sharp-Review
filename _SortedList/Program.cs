using System;
using System.Collections;
namespace _SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList list = new SortedList();

            list.Add(321,"Holanda");
            list.Add(434,"volvo");
            list.Add(565,"Nissan");
            list.Add(235,"Fiat");

            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine("{0}, {1}", item.Key, item.Value);
            }
            Console.ReadKey();
        }
    }
}
