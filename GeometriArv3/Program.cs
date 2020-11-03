using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriArv3
{
    class Program
    {
        static void Main(string[] args)
        {
            //news one of each figure
            Figure square = new Square(3);
            Figure parallelogram = new Parallelogram(3,5,20);
            Figure trapez = new Trapezoid(10,9,8,9);
            Figure triangle = new Rightangled_Triangle(1, 2, 3);
            Figure rectangle = new Rectangle(4, 4.5);
         
            List<Figure> figures = new List<Figure>();

            //Adds all figues to the list "figures"
            figures.Add(square);
            figures.Add(rectangle);
            figures.Add(parallelogram);
            figures.Add(trapez);
            figures.Add(triangle);
            

            //Loops through all items in figures and get the area and circumference of the item.
            foreach (var item in figures)
            {
                //Returns area of the current item
                Console.WriteLine("Area of " + item.GetType().Name + " = " + item.Area());

                //Return circumference of the current item
                Console.WriteLine("Circumference of " + item.GetType().Name + " = " + item.Circumference());
                Console.WriteLine("\n");          
            }

            
            /*
            if (trapez is Trapezoid)
               Console.WriteLine( ((Trapezoid)trapez).GetH() );
           
            Console.WriteLine(trapez.Area());
            */
            
            Console.ReadLine();
        }
    }
}
