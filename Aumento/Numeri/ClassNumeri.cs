using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeri
{
    public class ClassNumeri
    {
        public static double IncrementoNumPari(double a)
        {
            if (a % 2 == 0)
                a = a * 10 / 100;
            return a;

        }
    }
}
