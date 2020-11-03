using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriArv3
{
    public class Rightangled_Triangle : Triangle
    {
        public Rightangled_Triangle(double a, double b, double c) : base(a, b, c)
        {
            
        }

        public override double Area()
        {
            return 0.5 * A * B;
        }

        public override double Circumference()
        {
            return A + B + C;
        }
    }
}
