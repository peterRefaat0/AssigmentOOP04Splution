using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOOP04
{
    interface IShape
    {
        double Area { get; }
        void DisplayShapeInfo();
    }

    interface ICircle : IShape
    {
    }

    interface IRectangle : IShape
    {
    }

    class Circle : ICircle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area => Math.PI * radius * radius;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle with radius {radius} and area {Area}");
        }
    }

    class Rectangle : IRectangle
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Area => width * height;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle with width {width} and height {height} and area {Area}");
        }
    }



}
