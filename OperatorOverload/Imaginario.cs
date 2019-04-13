using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Imaginario
    {
        private double entero;
        private double imaginario;

        public Imaginario(double entero, double imaginario)
        {
            this.entero = entero;
            this.imaginario = imaginario;
        }

        public void setEntero(int entero)
        {
            this.entero = entero;
        }
        public void setImaginario(int imaginario)
        {
            this.imaginario = imaginario;
        }

        public double getEntero()
        {
            return entero;
        }

        public double getImagionario()
        {
            return imaginario;
        }

        public override string ToString()
        {
            if (imaginario < 0)
                return string.Format("{0} {1}1", entero, imaginario);
            else
                return string.Format("{0}+{1}1", entero, imaginario);
        }

        //Overloar operator binario
        public static Imaginario operator +(Imaginario i1, Imaginario i2)
        {
            double re = 0;
            double ri = 0;

            re = i1.entero + i2.entero;
            ri = i1.imaginario + i2.imaginario;

            Imaginario temp = new Imaginario(re, ri);
            return temp;
        }
    }
}
