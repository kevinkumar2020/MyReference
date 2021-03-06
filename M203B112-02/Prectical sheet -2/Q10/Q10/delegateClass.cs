using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    class delegateClass
    {
        public delegate void rectDelegate(double height, double width); //declaring delegate

        public void perimeter(double height , double width)
        {
            Console.WriteLine("Primeter Is : {0}", 2 * (height * width));
        }

        public void area(double height,double width)
        {
            Console.WriteLine("Area Is : {0}",(height * width));
        }

        static void Main(string[] args)
        {
            delegateClass dc = new delegateClass();
            rectDelegate  rd = new rectDelegate(dc.perimeter);
            rd += dc.area;
            rd.Invoke(12.5, 6.5);//calling method
            Console.WriteLine();
            rd.Invoke(16.5, 8.5);
            Console.ReadLine();
        }
    }
}
