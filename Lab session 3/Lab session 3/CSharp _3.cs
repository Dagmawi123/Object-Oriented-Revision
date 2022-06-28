using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_session_3
{
    abstract class Shape
    {
        public abstract double calculateArea();
        public abstract double calculatePerimeter();
    }
    class circle : Shape
    {
        private double radius;
        public readonly double pi = 3.1415;
        public double radius1
        {
            get { return radius; }

            set => radius = value;
        }

        public override double calculateArea()
        {
            return pi * radius * radius;
        }

        public override double calculatePerimeter()
        {
            return 2 * pi * radius;
        }
    }
    class Square : Shape
    {
        private int l;
        private int w;
        //circle s = new circle { radius1 = 20 };
        public int length
        {
            set { l = value; }
            get { return l ; }
        }
        public int width {
            get { return w; }
            set => w = value; }
        public override double calculateArea()
        {
            return length * width;
        }

        public override double calculatePerimeter()
        {
            return 2 * (length + width);

        } }
        class CSharp__3
        {
            static void Main(String []args) {
                 circle c = new circle();
                c.radius1 = 5;
                Console.WriteLine("Area equals to "+c.calculateArea());
                Console.WriteLine("Perimeter of this circle is "+c.calculatePerimeter());
                 Square s = new Square();
                  s.length = 15;
                s.width = 2;
                    Console.WriteLine("Area equals to " + s.calculateArea());
                        Console.WriteLine("Perimeter of this square is  " + s.calculatePerimeter());
            }
        }
    }

