// Write a program to Print inverted pyramid of number pattern.
// output:
// 1 2 3 4 5
// 1 2 3 4
// 1 2 3
// 1 2 
// 1


using System;
namespace problem2
{
    class Problem2
    {
        static void Main()
        {
            int n = 0;
            while(true)
            {
                Console.Write("Enter a positive number: ");
                if(int.TryParse(Console.ReadLine(), out n))
                {
                    if(n<0)
                    {
                        Console.WriteLine("Please enter positive number!");
                    }
                    else if(n==0)
                    {
                        Console.WriteLine("number can't be 0!");
                    }
                    else
                    {
                        // Console.WriteLine($"you entered {n}");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter digits only!");
                }
            }

            for(uint i = 0; i<n; i++)
            {
                for(uint j=(uint)n; j>i; j--)
                {
                    Console.Write($"{j} ");
                }
                Console.Write("\n");
            }
        }
    }
}
