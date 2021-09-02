using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        public class Rectangle
        {
            private double x1, y1, x2, y2;

            public Rectangle()
            {

            }

            public double X1
            {
                get
                {
                    return x1;
                }
                set
                {
                    if (value <= 20.0)
                    {
                        x1 = value;
                    }
                    else
                    {
                        Console.WriteLine("Please Enter a Value Less Then 20.0");
                        while (true)
                        {
                            Console.WriteLine("Enter Value again");
                            value = Convert.ToDouble(Console.ReadLine());
                            if(value <= 20.0)
                            {
                                x1 = value;
                                break;
                            }
                        }
                    }
                }
            }
            public double X2
            {
                get
                {
                    return x2;
                }
                set
                {
                    if (value <= 20.0)
                    {
                        x2 = value;
                    }
                    else
                    {
                        Console.WriteLine("Please Enter a Value Less Then 20.0");
                        while (true)
                        {
                            Console.WriteLine("Enter Value again");
                            value = Convert.ToDouble(Console.ReadLine());
                            if (value <= 20.0)
                            {
                                x2 = value;
                                break;
                            }
                        }
                    }

                }
            }
            public double Y1
            {
                get
                {
                    return y1;
                }
                set
                {
                    if (value <= 20.0)
                    {
                        y1 = value;
                    }
                    else
                    {
                        Console.WriteLine("Please Enter a Value Less Then 20.0");
                        while (true)
                        {
                            Console.WriteLine("Enter Value again");
                            value = Convert.ToDouble(Console.ReadLine());
                            if (value <= 20.0)
                            {
                                y1 = value;
                                break;
                            }
                        }
                    }

                }
            }
            public double Y2
            {
                get
                {
                    return y2;
                }
                set
                {
                    if (value <= 20.0)
                    {
                        y2 = value;
                    }
                    else
                    {
                        Console.WriteLine("Please Enter a Value less Then 20.0");
                        while (true)
                        {
                            Console.WriteLine("Enter Value again");
                            value = Convert.ToDouble(Console.ReadLine());
                            if (value <= 20.0)
                            {
                                y2 = value;
                                break;
                            }
                        }
                    }

                }
            }

            double length, width;
            public void Length()
            {
                length = x1 + x2;
                Console.WriteLine("Length is :- " + length);
            }

            public void Width()
            {
                width = y1 + y2;
                Console.WriteLine("Width is :- " + width);
            }

            public void perimeter()
            {
                if (x1 == x2 && x1 == y1 && x1 == y2 && x2 == y1 && x2 == y2 && y1 == y2)
                {
                    double p;
                    p = 4 * x1;
                    Console.WriteLine("================ IT IS A SQUARE =============== ");
                    Console.WriteLine("Perimiter Value Of Square :--  {0}",p);
                }
                else
                {
                    double p;
                    p = x1 + x2 + y1 + y2;
                    Console.WriteLine("================ IT IS A RECTANGLE =============== ");
                    Console.WriteLine("Perimiter Value Of Rectangle :-- {0}",p);
                }

            }

            public void area()
            {
                if (x1 == x2 && x1 == y1 && x1 == y2 && x2 == y1 && x2 == y2 && y1 == y2)
                {
                    double a;
                    a = x1 * x1;
                    Console.WriteLine("================ IT IS A SQUARE =============== ");
                    Console.WriteLine("Area Value Of Square :-- {0}",a);
                }
                else
                {
                    double a;
                    a = (x1 + x2) * (y1 + y2);
                    Console.WriteLine("================ IT IS A RECTANGLE =============== ");
                    Console.WriteLine("Area Value Of Rectangle :-- {0}",a);
                }
            }
        }
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            Console.WriteLine("Enter a Value Of X1 :");
            r.X1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a Value Of y1 :");
            r.Y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a Value Of X2 :");
            r.X2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a Value Of Y2 :");
            r.Y2 = Convert.ToDouble(Console.ReadLine());
            r.perimeter();
            r.area();
            Console.ReadLine();
        }
    }
}
