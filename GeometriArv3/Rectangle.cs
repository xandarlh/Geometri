using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriArv3
{
    public class Rectangle : Quadrangle
    {
        private double b;
        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public Rectangle(double a, double b) : base(a)
        {
            this.B = b;
        }
        public override double Area()
        {
            return A * B;
        }

        public override double Circumference()
        {
            return A + A + B + B;
        }
    }
}
