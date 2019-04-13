using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Supports cloning, which creates a new instance of a class with the same value as an existing instance.
 The ICloneable interface enables you to provide a customized implementation that creates a copy of an existing object. 
     
     */

namespace _ICloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto CarMarch = new Auto("March", 17000);

            //We think that do have clone
            //but only is other variable referenced the same instance

            Auto CarKia = CarMarch;

            CarMarch.CalculateTax(0.10);
            CarKia.CalculateTax(0.10);

            CarMarch.ShowInformation();
            CarKia.ShowInformation();

            Console.WriteLine("=====================================");

            CarMarch.SetCost(60000);

            CarMarch.ShowInformation();
            CarKia.ShowInformation();


            Console.WriteLine("=====================================");

            //Now we doing clone
            Auto CarSpark = (Auto)CarMarch.Clone();

            CarMarch.CalculateTax(0.10);
            CarSpark.CalculateTax(0.10);

            CarMarch.SetCost(25000);

            //Show information
            CarMarch.ShowInformation();
            CarSpark.ShowInformation();

            Console.ReadKey();
        }
    }
}
