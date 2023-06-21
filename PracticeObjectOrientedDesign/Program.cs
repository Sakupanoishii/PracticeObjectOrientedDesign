using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectOrientedDesign
{
    enum ShapeType
    {
        Circle,
        Square
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(4);
            Square square = new Square(4);
            Traiangle traiangle = new Traiangle(5,6);
            double circleArea = circle.CalculateArea();
            double squareArea = square.CalculateArea();
            double traiangleArea = traiangle.CalculateArea();

            Console.WriteLine("円の面積: " + circleArea);
            Console.WriteLine("正方形の面積: " + squareArea);
            Console.WriteLine("三角形の面積: " + traiangleArea);

        }
    }
}
