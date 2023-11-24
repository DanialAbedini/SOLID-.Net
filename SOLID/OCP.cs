using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public interface IShape
    {
        public abstract double Area();
        public abstract String Name();
    }
    public class OCP
    {
        public class Rectangle : IShape
        {
            int Height;
            int Width;

            public Rectangle(int height, int width)
            {
                Height = height;
                Width = width;
            }

            public virtual double Area()
            {
                return Height * Width;
            }

            public virtual String Name()
            {
                return "Rectangle";
            }
        }

        public class Square : Rectangle
        {
            int Len;

            public Square(int len) : base(len, len)
            {
                Len = len;
            }

            public override double Area()
            {
                return Len * 4;
            }

            public override String Name()
            {
                return "Square";
            }

        }

        public class Circle : IShape
        {
            double Radius;

            public Circle(double radius)
            {
                Radius = radius;
            }

            public double Area()
            {
                return  Math.Pow(Radius, 2) * Math.PI;
            }

            public string Name()
            {
                return "Circle";
            }
        }

        public static class PrinterArea
        {
            public static void Print(IShape shape)
            {
                Console.WriteLine($"Area {shape.Name()}: {shape.Area().ToString("F2")}");
            }
        }
    }
}
