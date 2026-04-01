// Call by Value and Call by Reference

// Call By Value in C#
// In .NET Framework, by default, all the objects are called by value, not called by reference.
// using System;
// namespace FunctionsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int a = 15;
//             int b = a;
//             b = 30;
//             Console.WriteLine(a);
//         }
//     }
// }


// using System;
// namespace FunctionsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int a = 15;
//             UpdateValue(a);
//             Console.WriteLine(a);
//         }

//         private static void UpdateValue(int b)
//         {
//             b = 30;
//         }
//     }
// }



// Call by Value with Reference Types in C#
// class is a reference data type.
// public class Employee  
// {  
//     public int EmployeeID;  
//     public string Name;  
// }


// Now, please observe the following code. Here, we create an instance of the Employee class, i.e., Emp1, and set its two data members. Next, we assign it (Emp1 instance) to another instance of the Employee class, i.e., Emp2, and change the Name property, and then we print EmployeeID and Name on the Console to check what is printed:
// using System;
// namespace FunctionsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Employee Emp1 = new Employee();
//             Emp1.EmployeeID = 1001;
//             Emp1.Name = "James";

//             Employee Emp2 = Emp1;
//             Emp1.Name = "Smith";
//             Console.WriteLine($"Emp1 Name = {Emp1.Name}");
//             Console.WriteLine($"Emp2 Name = {Emp2.Name}");
//         }
//     }

//     public class Employee
//     {
//         public int EmployeeID;
//         public string Name;
//     }
// }

// When we create an Instance of the Employee class, an object is created inside the heap memory, and memory is allocated to it. We are storing the reference of that memory location in the Emp1 reference variable, mostly in stack memory.

// using System;
// namespace FunctionsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Employee Emp1 = new Employee();
//             Emp1.EmployeeID = 1001;
//             Emp1.Name = "James";

//             UpdateName(Emp1);
//             Console.WriteLine($"Emp1 Name = {Emp1.Name}");
//         }

//         public static void UpdateName(Employee Emp2)
//         {
//             Emp2.Name = "Smith";
//             Console.WriteLine($"Emp2 Name = {Emp2.Name}");
//         }
//     }

//     public class Employee
//     {
//         public int EmployeeID;
//         public string Name;
//     }
// }


// What would happen if we set the Emp2 to null inside the UpdateName method as follows?
// using System;
// namespace FunctionsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Employee Emp1 = new Employee();
//             Emp1.EmployeeID = 1001;
//             Emp1.Name = "James";

//             UpdateName(Emp1);
//             Console.WriteLine($"Emp1 Name = {Emp1.Name}");
//         }

//         public static void UpdateName(Employee Emp2)
//         {
//             Emp2 = null;
//         }
//     }

//     public class Employee
//     {
//         public int EmployeeID;
//         public string Name;
//     }
// }

// Now, if you think that you will get a Null Reference Exception in the Main method in the WriteLine statement where you print the Name, then you are wrong. If you think that it will output James, then you are right, and you have understood that by default, reference is passed by value in C#, not by reference.



// Call By Reference in C#
// We need to prefix the parameter with the ref keyword for the call by reference.

// Call by Reference with Value Types
// using System;
// namespace FunctionsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int a = 15;
//             UpdateValue(ref a);
//             Console.WriteLine(a);
//         }

//         static void UpdateValue(ref int b)
//         {
//             b = 30;
//         }
//     }
// }


// Call by Reference with Reference Types in C#
// using System;
// namespace FunctionsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Employee Emp1 = new Employee();
//             Emp1.EmployeeID = 1001;
//             Emp1.Name = "James";

//             UpdateName(ref Emp1);
//             Console.WriteLine($"Emp1 Name = {Emp1.Name}");
//         }

//         public static void UpdateName(ref Employee Emp2)
//         {
//             Emp2 = null;
//         }
//     }
//     public class Employee
//     {
//         public int EmployeeID;
//         public string Name;
//     }
// }


// out and in
// The out Keyword (The Guaranteed Return)
// out passes a variable by reference, but it comes with a strict compiler guarantee: The method MUST assign a value to that variable before the method finishes. * You use out when you want a method to return multiple pieces of data at once.

// The in Keyword (The Read-Only Reference)
// Sometimes you have a massive struct (like a highly complex 3D math matrix that takes up a lot of memory). If you pass it by value, the computer has to pause and make a heavy copy of it, slowing down your app.
// If you pass it using in, C# passes it by reference (which is blazing fast), but makes it Read-Only. The method is allowed to look at the data, but the compiler will throw a fatal error if the method tries to change it. It perfectly balances speed with safety!