using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03
{
    abstract class Shape
    {
        abstract public double Area { get; }

    }

    class Rectangle : Shape {
        protected double length;
        protected double width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public override double Area
        {
            get
            {
                if(length > 0 && width > 0)
                {
                    return length * width;
                }
                else
                {
                    throw new InvalidOperationException("矩形边长有误");
                }
            }
        }
    }

    class Square : Rectangle
    {
        private double side;
        public Square(double side): base(side, side)
        {
            this.side = side;
        }
        public override double Area
        {
            get
            {
                if (side > 0)
                {
                    return side * side;
                }
                else
                {
                    throw new InvalidOperationException("正方形边长有误");
                }
            }
        }
    }

    class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double Area
        {
            get
            {
                if(a>0 && b>0 && c>0 && a+b>c && a+c>b && b+c>a)
                {
                    double p = (a + b + c) / 2;
                    return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                }
                else
                {
                    throw new InvalidOperationException("三角形边长有误");
                }
            }
        }
    }

    class Factory
    {
        //创建矩形和三角形对象
        public static Shape Manufacture(string shapeName, params double[] sides)
        {
            switch (shapeName)
            {
                case "Rectangle": return new Rectangle(sides[0], sides[1]);
                case "Square": return new Square(sides[0]);
                case "Triangle": return new Triangle(sides[0], sides[1], sides[2]);
                default: throw new NullReferenceException("形状不存在");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] shapes = {"Rectangle","Square","Triangle","Illegal"};
            double[] sides = {1, 2, 3, 4, 5, 1.5, 2.5, 3.5 };
            string _shape;
            double a, b, c;
            double totalArea = 0;
            Shape shape;
            for(int index = 1; index <= 10; index++)
            {
                _shape = shapes[index % 3]; //0矩形、1正方形、2三角形
                a = b = c = sides[index % 8];
                shape = Factory.Manufacture(_shape, a, b, c);
                totalArea += shape.Area;
            }
            Console.WriteLine($"Total Area：{totalArea}");
        }
    }
}
