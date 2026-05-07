// Conversion operators
// ToList
// ToArray
// ToDictionary
// ToLookup
// Cast
// OfType
// AsEnumerable
// AsQueryable

// ToList operator extracts all of the items from the source sequence and returns a new List<T>.
// This operator causes the query to be executed immediately.
// This operator does not use deferred execution.

// int[] numbers = {1,2,3,4,5};
// List<int> result = numbers.ToList();
// foreach (int i in result)
// {
//     Console.WriteLine(i);
// }

// ToArray operator extracts all of the items from the source sequence and returns a new Array.
// This operator causes the query to be executed immediately.
// This operator does not use deferred execution.

// eg. convert List<sring> to string array and the items should be sorted in ascending order.
// List<string> countries = new List<string> {"US", "India", "UK", "Australia", "Canada"};

// string[] result = (from country in countries
//                     orderby country ascending
//                     select country).ToArray();

// foreach (string str in result)
// {
//     Console.WriteLine(str);
// }


// ToDictionary operator extracts all of the items from the source sequence and returns a new Dictionary.
// This operator causes the query to be executed immediately.
// This operator does not use deferred execution.

// ex.1 convert a List<Student> to a dictionary. StudentID should be the key and Name should be the value.
// In this eg. we are using the overloaded version of ToDictionary() that takes 2 parameters.
// a) keySelector - A fn to extract a key from each element.
// b) elementSelector - A fn to produce a result element from each element in the sequence.

// List<Student> listStudennts = new List<Student>
// {
//     new Student { StudentID = 101, Name = "Tom", TotalMarks = 800 },
//     new Student { StudentID = 102, Name = "Mary", TotalMarks = 900 },
//     new Student { StudentID = 103, Name = "Pam", TotalMarks = 800 }
// };

// Dictionary<int, string> result = listStudennts.ToDictionary(x => x.StudentID, x => x.Name);

// foreach(KeyValuePair<int, string> kvp in result)
// {
//     Console.WriteLine(kvp.Key + " " + kvp.Value);
// }

// ex.2 for the above listStudennts the key should StudentID but the value should be Student object.
// we use overloaded version of ToDictionary()
// Dictionary<int, Student> result = listStudents.ToDictionary(x=>x.StudentID);

// Note: keys in the dictionary must be unique. if 2 identical keys are created by the keySelector function, the error will be thrown at runtime.


// ToLookup creates a Lookup. just like a dictionary, a lookup is a collection of key/value pairs.
// A dictionary cannot contain keys with identical values, where as a Lookup can.

// ex. create a lookup in which Employees are grouped by JobTitle
// var employeeByJobTitle = listEmployees.ToLookup(x=>x.JobTitle);

// Console.WriteLine("Employees grouped by JobTitle");

// foreach (var kvp in employeeByJobTitle)
// {
//     Console.WriteLine(kvp.key);
//     foreach (var item in employeeByJobTitle[kvp.key])
//     {
//         Console.WriteLine("\t" + item.Name + "\t" + item.JobTitle + "\t" + item.City);
//     }
// }

// using System;

// namespace Demp
// {
//     public class Student
//     {
//         public int StudentID { get; set; }
//         public string Name { get; set; }
//         public int TotalMarks { get; set; }
//     }

//     public class Employee
//     {
//         public int JobTitle { get; set; }
//         public string Name { get; set; }
//         public int City { get; set; }
//     }

//     class Program
//     {
//         public static void Main()
//         {
            // ToList
            // int[] numbers = {1,2,3,4,5};
            // List<int> result = numbers.ToList();
            // foreach (int i in result)
            // {
            //     Console.WriteLine(i);
            // }

            // ToArray
            // List<string> countries = new List<string> {"US", "India", "UK", "Australia", "Canada"};

            // string[] result = (from country in countries
            //                     orderby country ascending
            //                     select country).ToArray();

            // foreach (string str in result)
            // {
            //     Console.WriteLine(str);
            // }

            // ToDictionary ex1
            // List<Student> listStudents = new List<Student>
            // {
            //     new Student { StudentID = 101, Name = "Tom", TotalMarks = 800 },
            //     new Student { StudentID = 102, Name = "Mary", TotalMarks = 900 },
            //     new Student { StudentID = 103, Name = "Pam", TotalMarks = 800 }
            // };

            // Dictionary<int, string> result = listStudents.ToDictionary(x => x.StudentID, x => x.Name);

            // foreach(KeyValuePair<int, string> kvp in result)
            // {
            //     Console.WriteLine(kvp.Key + " " + kvp.Value);
            // }

            // ex2
            // Dictionary<int, Student> result = listStudents.ToDictionary(x=>x.StudentID);
            // Dictionary<int, Student> result = listStudents.ToDictionary(x=>x.StudentID, x=>x);

            // foreach(KeyValuePair<int, Student> kvp in result)
            // {
            //     Console.WriteLine(kvp.Key + " " + kvp.Value.Name);
            // } 


            // ToLookup
//             var employeeByJobTitle = listEmployees.ToLookup(x=>x.JobTitle);

//             Console.WriteLine("Employees grouped by JobTitle");

//             foreach (var kvp in employeeByJobTitle)
//             {
//                 Console.WriteLine(kvp.key);
//                 foreach (var item in employeeByJobTitle[kvp.key])
//                 {
//                     Console.WriteLine("\t" + item.Name + "\t" + item.JobTitle + "\t" + item.City);
//                 }
//             }
//         }
//     }
// }