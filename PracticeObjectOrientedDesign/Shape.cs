using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectOrientedDesign
{
    class Circle 
    {
        double Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    class Square
    {
        double SideLength;
        public Square(double sideLength)
        {
            SideLength = sideLength;
        }

        public double CalculateArea()
        {
            return SideLength * SideLength;
        }
    }
    class Traiangle
    {
        double Bottom;
        double Height;
        public Traiangle(double bottom, double height)
        {
            Bottom = bottom;
            Height = height;
        }

        public double CalculateArea()
        {
            return Bottom * Height / 2;
        }
    }
    class Shape
    {
        public ShapeType Type { get; set; }
        public double Radius { get; set; }
        public double SideLength { get; set; }
        // ... 他の共通のプロパティやメソッド ...

        public double CalculateArea()
        {
            double area = 0;

            if (Type == ShapeType.Circle)
            {
                area = Math.PI * Radius * Radius;
            }
            else if (Type == ShapeType.Square)
            {
                area = SideLength * SideLength;
            }
            return area;
        }
    }
}
