// Difference Between Convert.ToString and ToString Method
// Convert.ToString and ToString Method in C#
// Both these methods are used to convert a value to a string. The difference is Convert.ToString() method handles null whereas the ToString() doesn’t handle null in C#.

// In C# if you declare a string variable and if you don’t assign any value to that variable, then by default that variable takes a null value.
// In such a case, if you use the ToString() method then your program will throw the Null Reference Exception. 
// if you use the Convert.ToString() method then your program will not throw an exception.

// using System;
// namespace UnderstandingToStringMethod
// {
//     public class Program
//     {
//         public static void Main()
//         {
//             Customer C1 = null;
//             C1.ToString();
//         }
//     }
//     public class Customer
//     {
//         public string FirstName { get; set; }
//         public string LastName { get; set; }
//     }
// }


// . Let see what happens when we use the Convert.Tostring() method with the above example.
// using System;
// namespace UnderstandingObjectClassMethods
// {
//     public class Program
//     {
//         public static void Main()
//         {
//             Customer C1 = null;
//             Console.WriteLine(Convert.ToString(C1));

//             String Name = null;
//             Console.WriteLine(Convert.ToString(Name));

//             Console.WriteLine("No Error");
//         }
//     }
//     public class Customer
//     {
//         public string FirstName { get; set; }
//         public string LastName { get; set; }
//     }
// }


