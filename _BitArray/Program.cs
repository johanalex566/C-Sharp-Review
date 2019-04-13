using System;
using System.Collections;


namespace _BitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray _BitArray = new BitArray(new byte[] { 1, 2, 4, 8, 16 });

            Console.WriteLine(_BitArray.Count);
            ShowArray(_BitArray, "Array1");

            //Clone the BitArray
            BitArray _BitArray2 = (BitArray)_BitArray.Clone();

            //Invert the Array
            _BitArray2.Not();
            ShowArray(_BitArray2,"ArrayConvert");
                                 
            Console.ReadKey();

        }

        public static void ShowArray(BitArray _BitArray, string TypeArray)
        {
            int Cont = 0;
            Console.WriteLine(TypeArray);

            foreach (bool b in _BitArray)
            {
                Cont++;
                if (b)
                    Console.Write("1");
                else
                    Console.Write("0");
                if (Cont % 8 == 0)
                    Console.Write(",");

            }
            Console.WriteLine();
        }
    }
}
