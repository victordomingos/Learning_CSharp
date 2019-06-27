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
            Console.WriteLine("Rectangle()             --> L:{0} W:{1}  Area: {2}", rect1.Length, rect1.Width, rect1.GetArea());
            rect1.Length = 1;
            rect1.Width = 2;
            Console.WriteLine("   rect.Length, .Width  --> L:{0} W:{1}  Area: {2}", rect1.Length, rect1.Width, rect1.GetArea());
                        
            Rectangle rect2 = new Rectangle(5);
            Console.WriteLine("Rectangle(5)            --> L:{0} W:{1}  Area: {2}", rect2.Length, rect2.Width, rect2.GetArea());
                        
            Rectangle rect3 = new Rectangle(6, 7);
            Console.WriteLine("Rectangle(6, 7)         --> L:{0} W:{1}  Area: {2}", rect3.Length, rect3.Width, rect3.GetArea());
            
            Console.WriteLine("");
        }
    }
}
