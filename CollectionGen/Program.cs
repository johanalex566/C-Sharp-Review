using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionGen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> values = new List<int>();
            int n =0;
            int r = 0;

            values.Add(5);
            values.Add(6);
            values.Add(7);
            values.Add(8);
            values.Add(9);

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

        }
    }
}
