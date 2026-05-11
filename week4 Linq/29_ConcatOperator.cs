// It concatenates two sequences into one sequence.

// Concatenates both the integer sequences (numbers1 & numbers2) into one integer sequence.
// Notice that the duplicate elements ARE NOT REMOVED.

// int[] numbers1 = {1,2,3};
// int[] numbers2 = {1,4,5};

// var result = numbers1.Concat(numbers2);

// foreach (var v in result)
// {
//     Console.WriteLine(v);
// }

// OUTPUT: 1 2 3 1 4 5


// Just like Concat operator, Union operator also combines the 2 integer sequences (numbers1 & numbers2) into one integer sequence.
// It removes the duplicate elements.

// int[] numbers1 = {1,2,3};
// int[] numbers2 = {1,4,5};

// var result = numbers1.Union(numbers2);

// foreach (var v in result)
// {
//     Console.WriteLine(v);
// }

// OUTPUT: 1 2 3 4 5


using System;
using System.Collections;

namespace Demo
{
    class Program
    {
        public static void Main()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 1, 4, 5 };

            // var result = numbers1.Concat(numbers2);
            var result = numbers1.Union(numbers2);

            foreach (var v in result)
            {
                Console.WriteLine(v);
            }
        }
    }
}