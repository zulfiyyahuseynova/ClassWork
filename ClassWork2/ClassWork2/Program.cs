using System;
using ClassWork2.Models;
using ClassWork2.Interfaces;

namespace ClassWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(4, "asdf", true, 123, 60, 60, 40, "dizel", 20, 40);
            Console.WriteLine("Dolmasina qalan benzin: "+car.RemainOilAmount());
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Sureti: "+car.AverageSpeed());
            Console.WriteLine("-----------------------------");
            car.ShowInfo();
            Console.WriteLine("-----------------------------");

            Bicycle bicycle = new Bicycle("asdf", 123, 12, 30);
            Console.WriteLine("Sureti: "+bicycle.AverageSpeed());
            Console.WriteLine("-----------------------------");
            bicycle.ShowInfo();
            Console.WriteLine("-----------------------------");

            Plane plane = new Plane(100, 50, 200, 70, "asdf", 123, 2, 200);
            Console.WriteLine("Dolmasina qalan benzin: " + plane.RemainOilAmount());
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Sureti: " + plane.AverageSpeed());
            Console.WriteLine("-----------------------------");
            plane.ShowInfo();
            Console.WriteLine("-----------------------------");
        }
    }
}
