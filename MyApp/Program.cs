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
        String a , b;
        Split("Ayoub EL Bouzidi", out a, out b);
        Console.WriteLine(a);
        Console.WriteLine(b);
        void Split(String name, out String firstName, out String lastName)
        {
            int i = name.LastIndexOf(' ');
            firstName = name.Substring(0, i);
            lastName = name.Substring(i + 1);
        }
    }
}