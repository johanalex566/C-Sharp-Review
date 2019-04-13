using System;

namespace _IEnumerable
{
    class Auto : IAutomovil
    {
        double Cost;
        double Tax;
        string Model;

        public Auto(string Model, double Cost)
        {
            this.Cost = Cost;
            this.Model = Model;
        }

        public void CalculateTax(double TaxValue)
        {
            Tax = 5000.0 + Cost * TaxValue;
        }

        public void ShowInformation()
        {
            Console.WriteLine("Your car {0}", Model);
            Console.WriteLine("Costo {0} with a tax of {1}", Cost,Tax);
            Console.WriteLine("Total : {0}", Cost+Tax);
            Console.WriteLine("======================================");
        }
    }
}
