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
        int[] numbers = { 1, 2, 3, 4, 5 };
        ref int numRef = ref numbers[2];
        numRef *= 10; // Modify the third element
        Console.WriteLine(numRef);
        Console.WriteLine(numbers[2]);
    }
}