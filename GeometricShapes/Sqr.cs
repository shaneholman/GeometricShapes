using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Sqr
    {
        public int Side1 { get; set; } = 0;
        public int Perimeter()
        {

        return 4 * Side1; }

        public int Area()
        {
            return Side1 * Side1;
        }
        public Sqr(int side1)
        {
            Side1 = side1;
        }

    }
}
