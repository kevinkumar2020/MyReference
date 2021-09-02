using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    public class Vehicle
    {
        // Virtual method
        public virtual void Drive()
        {
            Console.WriteLine("Performing base class driving tasks");
        }
    }
    // Child class Inherit from base class
    public class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Driving a car");
        }
    }
    // Child class Inherit from base class
    public class Bike : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Driving a bike");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Compile-time type is Vehicle.
            // Runtime type is Vehicle as well.
            Vehicle veh = new Vehicle();
            veh.Drive();
            // Compile-time type is Vehicle.
            // Runtime type is Car.
            Vehicle car = new Car();
            car.Drive();
            // Compile-time type is Vehicle.
            // Runtime type is Bike.
            Vehicle bike = new Bike();
            bike.Drive();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
