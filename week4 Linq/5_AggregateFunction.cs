// eg.
using System;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main()
        {
            string[] countries = {"india", "us","uk","canada","australia"};

            string result = countries.Aggregate((a, b)=>a+", "+b);
            
            Console.WriteLine(result);

            int[] nums = {2,3,4,5};

            int prod = nums.Aggregate((a,b)=>a*b);

            Console.WriteLine(prod);

            int prodSeed = nums.Aggregate(10, (a,b)=>a*b);

            Console.WriteLine(prodSeed);
        }
    }
}