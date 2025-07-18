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
        int x = 8;
        Foo(ref x);
        Console.WriteLine($"Value of x after Foo: {x}");

        static void Foo(ref int p)
        {
            p = p + 1;
            Console.WriteLine($"Value of p inside Foo: {p}");
        }
    }
}