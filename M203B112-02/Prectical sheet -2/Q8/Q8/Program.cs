using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    class Shape : IDisposable
    {
        public float width, height;

        // Constructor
        public Shape()
        {
            setWidth(width);
            setHeight(height);
        }

        // Dispose 
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void setWidth(float w)
        {
            Console.Write("Enter Width :- ");
            width = float.Parse(Console.ReadLine());
        }
        public void setHeight(float h)
        {
            Console.Write("Enter Height :- ");
            height = float.Parse(Console.ReadLine());
        }

        public virtual void getArea()
        {
            Console.WriteLine("----------- SHAPE AREA ----------");
        }

        // Finalize 
        ~Shape()
        {
            Console.WriteLine("Called Finalized Method.......");
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            Console.WriteLine("Width :- " + width + " And Height :- " + height + " Are Free Resources ......");
            if (!disposed)
            {
                if (disposing)
                {
                    //clean up managed objects
                    Console.WriteLine("\n Width And Height Objects Are Managed .....");
                }
                //clean up unmanaged objects
                Console.WriteLine("\n Width And Height Objects Are UnManaged .....");
                disposed = true;
            }
        }
    }

    // Derived class OverLoading
    class Rectangle : Shape
    {
        // OverRiding
        public override void getArea()
        {
            base.getArea();
            Console.WriteLine("\n Area Of Rectangle :- " + (width * height));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();
            Rect.getArea();
            Console.ReadKey();

        }
    }
}
