using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseGenerica
{
    class claseGen<T>
    {
        private T x;
        private T y;

        public claseGen(T x, T y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return string.Format("X ={0}, Y={1}", x, y);
        }
        public void Reset()
        {
            x = default(T);
            y = default(T);
        }

        public void FindType()
        {
            var type = typeof(T);
            if (type == typeof(int))
                Console.WriteLine("Working with int");
            else
                Console.WriteLine("Working with other type");

        }
    }
}
