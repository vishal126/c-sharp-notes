using System;

class Program
{
    static unsafe void Main(string[] args)
    {
        int number = 10;
        int* ptr = &number;

        Console.WriteLine($"Value : {number}");
        Console.WriteLine($"Address : {(IntPtr)ptr}");
    }
}