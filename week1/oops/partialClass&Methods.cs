// What is Partial Class in C#?
// Partial Class is the new feature that has been added in C# 2.0 which allows us to define a class on multiple files.
// i.e. we can physically split the content of the class into different files but even physically they are divided but logically it is one single unit only.

// ***** A class in which code can be written in two or more files is known as a partial class. *****
// To make any class partial we need to use the keyword partial.


// Understanding Partial Class in C# with an Example:
// Employee.cs
// using System;
// namespace PartialClassDemo
// {
//     public class Employee
//     {
//         public string FirstName { get; set; }
//         public string LastName { get; set; }
//         public string Gender { get; set; }
//         public double Salary { get; set; }
        
//         public void DisplayFullName()
//         {
//             Console.WriteLine($"Full Name is : {FirstName} {LastName}");
//         }

//         public void DisplayEmployeeDetails()
//         {
//             Console.WriteLine("Employee Details : ");
//             Console.WriteLine($"First Name : {FirstName}");
//             Console.WriteLine($"Last Name : {LastName}");
//             Console.WriteLine($"Gender : {Gender}");
//             Console.WriteLine($"Salary : {Salary}");
//         }
//     }
// }


// // using System;
// namespace PartialClassDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Employee emp = new Employee
//             {
//                 FirstName = "Pranaya",
//                 LastName = "Rout",
//                 Salary = 100000,
//                 Gender = "Male"
//             };
//             emp.DisplayFullName();
//             emp.DisplayEmployeeDetails();
//         }
//     }
// }



// Splitting Above Class Definition into 2 Files using Partial Classes in C#. 
// First, delete the Employee.cs class file from the project. Then we need to add two class files with the name PartialEmployeeOne and PartialEmployeeTwo.
// The PartialEmployeeOne class file going to contain all 4 public auto-implemented properties (FirstName, LastName, Gender, and Salary), and the PartialEmployeeTwo class file going to contain the two public DisplayFullName and DisplayEmployeeDetails methods.

// PartialEmployeeOne.cs
// namespace PartialClassDemo
// {
//     public partial class PartialEmployee
//     {
//         public string FirstName { get; set; }
//         public string LastName { get; set; }
//         public string Gender { get; set; }
//         public double Salary { get; set; }
//     }
// }


// // PartialEmployeeTwo.cs
// // using System;
// namespace PartialClassDemo
// {
//     public partial class PartialEmployee
//     {
//         public void DisplayFullName()
//         {
//             Console.WriteLine($"Full Name is : {FirstName} {LastName}");
//         }

//         public void DisplayEmployeeDetails()
//         {
//             Console.WriteLine("Employee Details : ");
//             Console.WriteLine($"First Name : {FirstName}");
//             Console.WriteLine($"Last Name : {LastName}");
//             Console.WriteLine($"Gender : {Gender}");
//             Console.WriteLine($"Salary : {Salary}");
//         }
//     }
// }


// // Using the Partial Class in C#:
// // using System;
// namespace PartialClassDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             PartialEmployee emp = new PartialEmployee()
//             {
//                 FirstName = "Pranaya",
//                 LastName = "Rout",
//                 Salary = 100000,
//                 Gender = "Male"
//             };
//             emp.DisplayFullName();
//             emp.DisplayEmployeeDetails();
//         }
//     }
// }


// When do we need to use Partial Class in C#?
// 1. When working on large projects, splitting a class over separate files allows multiple programmers to work on it simultaneously.
// 2. When working with automatically generated source code, the code can be added to the class without having to recreate the source file. Visual Studio uses this approach when creating windows form, Web service wrapper code, and so on.


// Rules to follow while working with Partial Classes in C#:
// Rule1: All the parts that contain the class definition must use the partial keyword.
// All the parts must be available at compile time to form the final type, Otherwise, we will get a compilation error stating Missing partial modifier. Another partial declaration of this type exists.
// Rule2: All the parts of the partial class must have the same access modifier
// Rule3: If any of the parts are declared as abstract, then the entire type is considered as abstract or if any of the parts are declared as sealed, then the entire type is considered as sealed or if any of the parts inherit a class, then the entire type inherits that class.
// Rule4: C#.NET does not support multiple class inheritance. That means different parts of the partial class must not specify different base classes.
// Rule5: But it is possible with Partial classes that the different parts of the partial class can specify different base interfaces and the final type should and must implement all the interface methods.


// What are Partial Methods in C#?
// One part of the class contains the signature of the method. An implementation of the Partial Method can be defined in the same part or other parts of the Partial Class.
// If the implementation is not supplied, then the method and all calls to the partial method are removed by the compiler at the time of compilation.



// Rules to Follow while working with Partial Methods in C#:
// Rule1: Partial methods in C# are private by default and we can use any access specifier explicitly, and if we try to use any access specifier explicitly like public, private, protected, etc, then we will get a compiler stating A partial method cannot have access modifiers or the virtual, abstract, override, new, sealed, or extern modifiers.
// Rule2: Partial method declaration and implementation should not be at the same time. Its declaration should be at one place and its implementation must be at a different place either in the same part or in other parts of the partial class.
// Rule3: A partial method return type must be void.
// Rule4: A partial method must and should be declared within a partial class or partial struct.
// Rule5: The signature of the partial method declaration must match the signature of the implementation else we will get a compilation error.