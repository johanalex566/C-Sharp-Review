using _IEnumerable;
using System;


namespace IEnumerable
{
    class Program
    {
        //public interface IEnumerable
        //{
        //    IEnumerable GetEnumerable();
        //}


        static void Main(string[] args)
        {
            AutoStore Store = new AutoStore();

            //Get indexer
            Auto myCar = Store[0];
            myCar.ShowInformation();

            //Set indexer
            Auto mytwoCar =new Auto("Vocho",20000);
            Store[1] = mytwoCar;

            //Recorremos cada uno de los elementos de la 
            //estructura que expone.

            foreach (Auto auto in Store)
            {
                auto.CalculateTax(0.05);
                auto.ShowInformation();
            }
            Console.ReadKey();
        }
    }
}
