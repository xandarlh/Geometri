using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriArv3
{
    public class Square : Quadrangle
    {
        public Square(double a) : base(a)
        {

        }
        public override double Area()
        {
            return A * A;
        }
        public override double Circumference()
        {
            return A + A + A + A;
        }
    }
}
