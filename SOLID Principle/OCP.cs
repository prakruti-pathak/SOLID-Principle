using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle
{
    //Open/Closed Principle (OCP):
    //A class should be open for extension but closed for modification.
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double CalculateArea() => Math.PI * Radius * Radius;
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double CalculateArea() => Width * Height;
    }

    // Area calculator is open for new shapes but does not need modification.
    public class AreaCalculator
    {
        public double TotalArea(List<Shape> shapes)
        {
            double total = 0;
            foreach (var shape in shapes)
            {
                total += shape.CalculateArea();
            }
            return total;
        }
    }

}
