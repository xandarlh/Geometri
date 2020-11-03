using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriArv3
{
    public class Trapezoid : Quadrangle
    {
        private double b;
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        private double c;
        public double C
        {
            get { return c; }
            set { c = value; }
        }
        private double d;
        public double D
        {
            get { return d; }
            set { d = value; }
        }
        private double s;
        public double S
        {
            get { return s; }
            set { s = value; }
        }
        private double h;
        public double H
        {
            get { return h; }
            set { h = value; }
        }
        public Trapezoid(double a, double b, double c, double d) : base(a)
        {
            this.B = b;
            this.C = c;
            this.D = d;
        }
        public double CalcS()
        {
            return S = (A + B - C + D) / 2;
        }
        public double CalcH()
        {
            double S = CalcS();
            return (A - C) / 2 * Math.Sqrt(S * (S - A + C) * (S - B) * (S - D));
        }
        public override double Area()
        {
            return 0.5 * (A + C) * CalcH();
        }
        public override double Circumference()
        {
            return A + B + C + D;
        }
    }
}
