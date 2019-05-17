using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoAnonimos
{
    class Punto
    {
        public delegate void DelMenssage();

        public DelMenssage menssage;

        private int x;
        private int y;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return string.Format("X ={0}, Y = {1}", x,y);
        }
    }
}
