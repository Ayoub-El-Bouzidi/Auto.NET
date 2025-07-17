// See https://aka.ms/new-console-template for more information
using System;

//the stack and the heap
class Program
{
    //the stack and the heap
    //the stack is for value types, the heap is for reference types
    //the stack is faster than the heap
    //the stack is limited in size, the heap is not
    //the stack is used for method calls, the heap is used for objects
    static void Main(string[] args)
    {
        int result = Factorial(5);
        Console.WriteLine($"Factorial of 5 is: {result}");
    }
    static int Factorial(int x)
    {
        if (x == 0) return 1;
        return x * Factorial(x - 1);
    }
}