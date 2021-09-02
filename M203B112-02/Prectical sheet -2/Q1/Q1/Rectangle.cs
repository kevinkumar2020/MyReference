using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    interface rectInterface
    {
        void perimeter();
        void area();
    }
    class Rectangle : rectInterface
    {
        private double length,width,ans;

        public Rectangle()
        {
            length = 1.0;
            width = 1.0;
        }

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value >= 0.0 && value <= 20.0)
                {
                    length = value;
                }
                else
                {
                    Console.WriteLine("Please Set Value Between (0.0 to 20.0)..!");
                }
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
                if  (value >= 0.0 && value <= 20.0) {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Please Set Value Between (0.0 to 20.0)..!");
                }
                
            }
        }

        void rectInterface.perimeter()
        {
            ans = 2 * (length + width);
            Console.WriteLine("Rectangle Perimeter Is : " + ans);
        }
        void rectInterface.area()
        {
            ans = length * width;
            Console.WriteLine("Rectangle Area Is : " + ans);
        }
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            rectInterface ri1 = new Rectangle();
            Console.WriteLine("Enter Length Value : ");
            r1.Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width Value : ");
            r1.Width = Convert.ToDouble(Console.ReadLine());
            ri1.perimeter();
            ri1.area();
            Console.ReadLine();
        }
    }
}
