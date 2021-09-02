using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        class Core_Calculator
        {
            public float num1, num2, num;

            public Core_Calculator()
            {
                Console.WriteLine("\n---------------------- INPUT FROM SIMPLE CALCULATOR ----------------------");

                Console.Write("\n Enter Value 1 :- ");
                num1 = float.Parse(Console.ReadLine());

                Console.Write("\n Enter Value 2 :- ");
                num2 = float.Parse(Console.ReadLine());

                Console.Write("\n Enter Value Which You Want To Square :- ");
                num = float.Parse(Console.ReadLine());

                Console.WriteLine("\n----------------------  SIMPLE CALCULATOR ----------------------");
                Square(num);
                Add(num1, num2);
                Multiply(num1, num2);
                Subtract(num1, num2);
                Division(num1, num2);
            }

            public void Square(float num)
            {
                Console.WriteLine("\n Square Of :- " + (num * num));
            }  
            public void Add(float num1, float num2)
            {
                Console.WriteLine("\n Addition Of :- " + (num1 + num2));
            }

            // Multiply 
            public void Multiply(float num1, float num2)
            {
                Console.WriteLine("\n Multiplication Of :- " + (num1 * num2));
            }
            // Subtracts   
            public void Subtract(float num1, float num2)
            {
                if (num1 > num2)
                {
                    Console.WriteLine("\n Subtraction Of :- " + (num1 - num2));
                }
                else
                {
                    Console.WriteLine("\n Subtraction Of :- " + (num2 - num1));
                }
            }
            //performing Division   
            public void Division(float num1, float num2)
            {
                Console.WriteLine("\n Division Of :- " + (num1 / num2));
            }
        }

        class Scientific_Calculator : Core_Calculator
        {
            public Scientific_Calculator()
            {
                Console.WriteLine("\n---------------------- INPUT FROM SCIENTIFIC CALCULATOR ----------------------");

                float num1;

                Console.Write("\n Enter Value Which You Want To Scintific Calculator :- ");
                num1 = float.Parse(Console.ReadLine());

                Console.WriteLine("\n---------------------- SCIENTIFIC CALCULATOR ----------------------");
                div1x();
                factorial();
                log();
                Log10();
                Exp();
                Sin();
                Cos();
                Tan();
                Round();
                Floor();
                Truncate();
                Ceil();
                Asin();
                Acos();
                Atan();
                Sinh();
                Cosh();
                Tanh();
                Pi();
            }

            public void div1x()
            {
                Console.WriteLine("\n 1 Div x Is :- {0}",(1 / num1));
            }

            public void factorial()
            {
                long fact = 1;
                for (int i = 1; i <= num1; i++)
                {
                    fact = fact * i;
                }
                Console.WriteLine("\n Factorial Is :- {0}",fact);
            }

            public void log()
            {
                double l;
                l = Math.Log(Convert.ToDouble(num1));
                Console.WriteLine("\n Log Is :- {0}", l);
            }

            public void Log10()
            {
                double l;
                l = Math.Log10(Convert.ToDouble(num1));
                Console.WriteLine("\n Log10 Is :- {0}", l);
            }

            public void Exp()
            {
                double l;
                l = Math.Exp(Convert.ToDouble(num1));
                Console.WriteLine("\n Exponent Is :- {0}" , l);
            }

            public void Sin()
            {
                double l;
                l = Math.Sin(Convert.ToDouble(num1));
                Console.WriteLine("\n Sin Is :- {0}", l);
            }

            public void Cos()
            {
                double l;
                l = Math.Cos(Convert.ToDouble(num1));
                Console.WriteLine("\n Cos Is :- {0}", l);
            }

            public void Tan()
            {
                double l;
                l = Math.Tan(Convert.ToDouble(num1));
                Console.WriteLine("\n Tan Is :- {0}", l);
            }

            public void Round()
            {
                double l;
                l = Math.Round(Convert.ToDouble(num1));
                Console.WriteLine("\n Round Is :- {0}",l);
            }

            public void Floor()
            {
                double l;
                l = Math.Floor(Convert.ToDouble(num1));
                Console.WriteLine("\n Floor Is :- {0}", l);
            }

            public void Truncate()
            {
                double l;
                l = Math.Truncate(Convert.ToDouble(num1));
                Console.WriteLine("\n Truncate Is :- {0}", l);
            }

            public void Ceil()
            {
                double l;
                l = Math.Ceiling(Convert.ToDouble(num1));
                Console.WriteLine("\n Ceil Is :- {0}", l);
            }

            public void Asin()
            {
                double l;
                l = Math.Asin(Convert.ToDouble(num1));
                Console.WriteLine("\n Asin Is :- " + l);
            }

            public void Sinh()
            {
                double l;
                l = Math.Sinh(Convert.ToDouble(num1));
                Console.WriteLine("\n Sinh Is :- " + l);
            }

            public void Cosh()
            {
                double l;
                l = Math.Cosh(Convert.ToDouble(num1));
                Console.WriteLine("\n Cosh Is :- " + l);
            }

            public void Tanh()
            {
                double l;
                l = Math.Tanh(Convert.ToDouble(num1));
                Console.WriteLine("\n Tanh Is :- {0}", l);
            }

            public void Acos()
            {
                double l;
                l = Math.Acos(Convert.ToDouble(num1));
                Console.WriteLine("\n Acos Is :- {0}", l);
            }

            public void Atan()
            {
                double l;
                l = Math.Atan(Convert.ToDouble(num1));
                Console.WriteLine("\n Atan Is :- {0}", l);
            }

            public void Pi()
            {
                Console.WriteLine("\n PI Is :- {0}", 3.14);
            }
        }

        static void Main(string[] args)
        {
            Scientific_Calculator Sci_Cal = new Scientific_Calculator();
            Console.ReadLine();
        }
    }
}
