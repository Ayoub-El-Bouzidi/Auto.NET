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
    static String x = "Hello, World!";
    static ref String GetX() => ref x;

    static void Main(string[] args)
    {
        ref string message = ref GetX();
        message = "Hello, C# World!";
        Console.WriteLine(message);
    }
}