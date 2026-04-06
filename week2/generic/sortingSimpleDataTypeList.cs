using System;
using System.Reflection.Metadata;

namespace Sort
{
    public class Sort
    {
        public static void Main()
        {
            List<int> numbers = new List<int>() {1,8,7,5,2,3,4,9,6};

            Console.WriteLine("Numbers before sorting");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // SORT IN ASCENDING ORDER
            numbers.Sort();
            Console.WriteLine("Numbers after sorting");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // sort in descending order
            numbers.Reverse();
            Console.WriteLine("Numbers after reverse");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            
            // sorting a list of strings
            List<string> alphas  = new  List<string>() {"B", "F","D", "E", "A", "C"};
            foreach (string alpha in alphas)
            {
                Console.WriteLine(alpha);
            }

            // Sort()
            alphas.Sort();

            Console.WriteLine("alphas after sorting");
            foreach (string alpha in alphas)
            {
                Console.WriteLine(alpha);
            }   

            // descending
            alphas.Reverse();
            Console.WriteLine("alphas after reverse");
            foreach (string alpha in alphas)
            {
                Console.WriteLine(alpha);
            }


            // we cannot sort complex datatypes (objects, structs) using Sort()
            // if we try to do then we will get a runtime invald operation exception - Failed to compare 2 elements in the array.
            // This is because .net runtime does not know, how to sort complex types. we have to tell the way we want data to be sorted in the list by implementing IComparable interface.

            // This sort functionality is working for simple data types like int, string, char etc, because these types have implemented IComparable interface already. 

            // for complex types sorting visit the sortingComplexDataTypeList.cs
        }
    }
}