using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
    class Calculator
    {
        public int number = 0;

        public Calculator() { } //no-argument constructor

        public Calculator(int n) //parameterized constructor
        {
            number = n;
        }

        public static Calculator operator + (Calculator cal1,Calculator cal2)
        {
            Calculator cal3 = new Calculator(0);
            cal3.number = cal1.number + cal2.number;
            return cal3;
        }

        public void display()
        {
            Console.WriteLine("Total Sum Is : {0}",number);
        }
    }
    class calAnswer
    {
        static void Main(string[] args)
        {
            Calculator num1 = new Calculator(20);
            Calculator num2 = new Calculator(30);
            Calculator num3 = new Calculator();
            num3 = num1 + num2;
            num3.display();
            Console.ReadLine();
        }
    }
}
