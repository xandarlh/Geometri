using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriArv3
{
    public class Parallelogram : Quadrangle
    {
        private double b;
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        private double sin1;
        public double Sin1
        {
            get { return sin1; }
            set { sin1 = value; }
        }
        public Parallelogram(double a, double b, double sin1) : base(a)
        {
            this.Sin1 = sin1;
            this.B = b;
        }
        public double CalcAngle()
        {
            return Math.PI * Sin1 / 180; 
        }
        public override double Area()
        {
            double angle = CalcAngle();
            return this.A * this.B * Math.Sin(angle);
        }
        public override double Circumference()
        {
            return A + A + B + B;
        }
    }
}
