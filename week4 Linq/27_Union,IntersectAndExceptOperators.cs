// Union combines two collections into one collection while removing the duplicate elements.

// ex.1 numbers1 & numbers2 collections are combined into a single collection. Notice that, the duplicate elements are removed.
// int[] numbers1 = {1,2,3,4,5};
// int[] numbers2 = {1,2,3,4,5};

// var result = numbers1.Union(numbers2);

// foreach (var v in result)
// {
//     Console.WriteLine(v);
// }

// OUTPUT: 1 2 3 4 5 6 7 8


// When comparing elements, just like Distinct() method, Union(), Intersect() and Except() methods work in a slightly different manner with complex types like Employee, Customer etc.

// Ex.2 notice that in the op the duplicate employee objects are not removed.
// This is because, the default comparer is being used which will just check for object references being equal and not the individual property values.

// List<Employee> list1 = new List<Employee>()
// { 
//     new Employee { ID = 101, Name = "Mike"}, 
//     new Employee {ID = 102, Name = "Susy"},
//     new Employee { ID = 103, Name = "Mary"}
// };
// List<Employee> list2 = new List<Employee>()
// {
//     new Employee { ID = 101, Name = "Mike"},
//     new Employee { ID = 104, Name = "John"}
// };

// var result = list1.Union(list2);

// foreach (var v in result)
// {
//     Console.WriteLine(v. ID + "\t" + v.Name);
// }

// OUTPUT:
// 101     Mike
// 102     Susy
// 103     Mary
// 101     Mike
// 104     John

// To solve this there are 3 methods which are discussed in 26_SetOperators.cs
// one of the way to solve that is
// var result = list1.Select(x => new { x.ID, x.Name })
//                           .Union(list2.Select(x => new { x.ID, x.Name }));


// Intersect() returns the common elements between the 2 collections
// Example 4: Return common elements in numbers1 and numbers2 collections.
// int[] numbers1 = {1, 2, 3, 4, 5};
// int[] numbers2 = {1, 3, 6, 7, 8};

// var result = numbers1.Intersect(numbers2);

// foreach (var v in result)
// {
//     Console.WriteLine(v);
// }

// Except() returns the elements that are present in the first collection but not in the second collection.
// var result = numbers1.Except(numbers2);

using System;

namespace Demo
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    
    class Program
    {
        public static void Main()
        {
            // ex.1
            // int[] numbers1 = {1,2,3,4,5};
            // int[] numbers2 = {1,2,3,4,5};

            // var result = numbers1.Union(numbers2);

            // foreach (var v in result)
            // {
            //     Console.WriteLine(v);
            // }

            // ex.2
            List<Employee> list1 = new List<Employee>()
            { 
                new Employee { ID = 101, Name = "Mike"}, 
                new Employee {ID = 102, Name = "Susy"},
                new Employee { ID = 103, Name = "Mary"}
            };
            List<Employee> list2 = new List<Employee>()
            {
                new Employee { ID = 101, Name = "Mike"},
                new Employee { ID = 104, Name = "John"}
            };
            
            // var result = list1.Union(list2);
            
            // foreach (var v in result)
            // {
            //     Console.WriteLine(v. ID + "\t" + v.Name);
            // }

            // one of the way to solve that is
            // var result = list1.Select(x => new { x.ID, x.Name })
            //                   .Union(list2.Select(x => new { x.ID, x.Name }));

            // foreach (var v in result)
            // {
            //     Console.WriteLine(v. ID + "\t" + v.Name);
            // }

            // ex.4
            int[] numbers1 = {1, 2, 3, 4, 5};
            int[] numbers2 = {1, 3, 6, 7, 8};

            // var result = numbers1.Intersect(numbers2);

            // foreach (var v in result)
            // {
            //     Console.WriteLine(v);
            // }

            // ex.5
            // var result = numbers1.Except(numbers2);
            // foreach (var v in result)
            // {
            //     Console.WriteLine(v);
            // }
        }
    }
}