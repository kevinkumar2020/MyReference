using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    interface Audi
    {
        //Method Declaration
        void Method();
    }

    interface Swift
    {
        //Method Declaration
        void Method();
    }

    class car : Audi, Swift
    {
        //Method definitions
        void Audi.Method()
        {
            Console.WriteLine("Audi Method() called");
        }
        void Swift.Method()
        {
            Console.WriteLine("Swift Method() called");
        }
    }

    class Program
    {
        public static void Main(String[] args)
        {
            Audi a1;
            Swift s1;
            a1 = new car();
            s1 = new car();
            a1.Method();
            s1.Method();
            Console.ReadLine();
        }
    }

}
