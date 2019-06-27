// Rectangle area - a simple exercise on C# classes

using System;

namespace _02_exercise_classes
{

    class Rectangle
    {
        // data members
        private double length;
        private double width;


        // Constructors
        public Rectangle()
        {
            length = 0;
            width = 0;
        }


        public Rectangle(double l)
        {
            length = l;
            width = l;
        }

        
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        // Public properties with getters and setters
        public double Length
        {
            get
            {
                return length;
            }

            set
            {
                if (value > 0.0)
                    length = value;
            }
        }


        public double Width
        {
            get
            {
                return width;
            }

            set
            {
                if (value > 0.0)
                    width = value;
            }
        }


        public double GetArea()
        {
            return width * length;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            Rectangle rect1 = new Rectangle();
            Console.WriteLine("\nRectangle()            --> L:" + rect1.Length + " W:" + rect1.Width);
            Console.WriteLine("   Area: " + rect1.GetArea());
            rect1.Length = 1;
            rect1.Width = 2;
            Console.WriteLine("  rect.Length, .Width  --> L:" + rect1.Length + " W:" + rect1.Width);
            Console.WriteLine("   Area: " + rect1.GetArea());


            Rectangle rect2 = new Rectangle(5);
            Console.WriteLine("\nRectangle(5)           --> L:" + rect2.Length + " W:" + rect2.Width);
            Console.WriteLine("   Area: " + rect2.GetArea());


            Rectangle rect3 = new Rectangle(6, 7);
            Console.WriteLine("\nRectangle(6, 7)        --> L:" + rect3.Length + " W:" + rect3.Width);
            Console.WriteLine("   Area: " + rect3.GetArea());

            Console.WriteLine("");
        }
    }
}
