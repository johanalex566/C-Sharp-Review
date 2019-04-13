using System;

namespace ClaseGenerica
{
    class Program
    {
        static void Main(string[] args)
        {
            //INT
            claseGen<int> clsGenI = new claseGen<int>(3,4);

            //DOUBLE
            claseGen<double> clsGenD = new claseGen<double>(3.55, 4.34);

            //string
            claseGen<string> clsGenS = new claseGen<string>("hola", "Johan");

            Console.WriteLine(clsGenI);
            //=============================================================================
            Console.WriteLine(clsGenD);
            //=============================================================================
            Console.WriteLine(clsGenS);
            //=============================================================================
            clsGenI.Reset();
            Console.WriteLine(clsGenI);

            clsGenI.FindType();
        }
    }
}
