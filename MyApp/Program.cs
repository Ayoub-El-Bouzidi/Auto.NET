using System;
using MyApp;
namespace MyApp
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Car: {Brand} {Model}");
            }
        }

    }

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car { Brand = "Toyota", Model = "Corolla" };
        car1.PrintInfo();

        Car car2 = car1; // Reference to the same object
        car2.Model = "Camry"; // Modifying the model of car2 will also affect car1
        Console.WriteLine("\nAfter modifying car2:");
        car1.PrintInfo();
        car2.PrintInfo();

        // Make car1 null
        car1 = null;
        Console.WriteLine("\nAfter setting car1 to null:");
        car2.PrintInfo();
        // make car2 null
        car2 = null;
        Console.WriteLine("\nAfter setting car2 to null:");
    }
}