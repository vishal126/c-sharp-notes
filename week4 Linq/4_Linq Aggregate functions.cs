// LINQ Aggregate Functions
// Linq std query operators also called as LINQ extension methods can be broadly classified into the following categories.
// Aggregate Operators
// Grouping operators
// Restriction operators
// Projection operators
// Set operators
// Partitioning operators
// Conversion operators
// Generation operators
// Query operators
// Join operators
// Custom sequence operators
// Quantifiers operators
// Miscellaneous operators


// In this file:
// Min, Max, Count, Sum, Average


using System;
using System.Linq;

namespace Demo
{
    class Program
    {
        int[] Numbers = {1,2,3,4,5,6,7,8};

        // get all numbers min
        int result = Numbers.Min();

        // get even number min
        int result = Number.Where(n => n%2 == 0).Min();

        // get all numbers max
        int result = Numbers.Max();

        // get even number max
        int result = Number.Where(n => n%2 == 0).Max();

        // get all numbers sum
        int result = Numbers.Sum();

        // get even number sum
        int result = Number.Where(n => n%2 == 0).Sum();

        // get all numbers count
        int result = Numbers.Count();

        // get even number count
        int result = Number.Where(n => n%2 == 0).Count();

        // get all numbers average
        int result = Numbers.Average();

        // get even number min
        int result = Number.Where(n => n%2 == 0).Average();

        // eg2
        string[] countries = {"India", "USA","Uk"};

        // int minCount = countries.Min(x=>x.Length); -> 2
        // int maxCount = countries.Max(x=>x.Length); -> 5
    }
}