using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ICloneable
{
    class Auto : IAutomovil, ICloneable
    {
        private double Cost;
        private double Tax;
        private string Model;

        public Auto(string _Model, double _Cost)
        {
            Cost = _Cost;
            Model = _Model;
        }
        
        public void SetCost(double Cost)
        {
            this.Cost = Cost;
        }
        public void SetTax(double Tax)
        {
            this.Tax= Tax;
        }

        public double GetCost()
        {
            return Cost;
        }

        public double GetTax()
        {
            return Tax;
        }


        public void CalculateTax(double TaxValue)
        {
            Tax = 5000.0 + Cost * TaxValue;
        }

        public void ShowInformation()
        {
            Console.WriteLine("Your car {0}", Model);
            Console.WriteLine("Costo {0} with a tax of {1}", Cost, Tax);
            Console.WriteLine("Total : {0}", Cost + Tax);
            Console.WriteLine("======================================");
        }

        public object Clone()
        {
            Auto AutoTem = new Auto(Model,Cost);
            AutoTem.Tax = Tax;
            return AutoTem;
        }
    }
}
