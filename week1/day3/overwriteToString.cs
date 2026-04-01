// Understanding the Object Class in C#:
// The Object class is the Superclass of all dot net types.
// That means, all the types in .NET Framework are inherited directly or indirectly from the Object class.
// Because of this inheritance, every type in .NET inherits the ToString() method from the Object class.
// If you go to the definition of Object class, then you will see that the ToString() method is defined as a Virtual Method which allows this method to be overridden in the child classes.

// Note: Every type in .NET is implicitly inherited from the Object class and hence all the public and protected members of the object class (excluding private members) are inherited into the child class and by using the child class object we can access all the public and protected members of the object class in C#.
// For example, int is a primitive type and string a reference type and both of these two types are inherited from the Object class, and hence using the variable of int and string type, we can access all the public and protected members of the object class.

// In other words, we can say that each and every class type (Reference Types) or struct type (Value Types) are directly or indirectly implicitly inherited from the Object class in C#.

// For example, all variables of type int or float have the ToString method, which enables them to return their contents as a string.

// using System;
// namespace UnderstandingObjectClassMethods
// {
//     public class Program
//     {
//         public static void Main()
//         {
//             int Number = 100;
//             Console.WriteLine(Number.ToString());
//         }
//     }
// }


// When you create a custom class or struct in C#, then you can override the ToString method in order to provide information about your type to the client
// using System;

// namespace UnderstandingObjectClassMethods
// {
//     public class Program
//     {
//         public static void Main()
//         {
//             Employee emp = new Employee();
//             emp.FirstName = "Pranaya";
//             emp.LastName = "Rout";
//             Console.WriteLine(emp.ToString());
//         }
//     }

//     public class Employee
//     {
//         public string FirstName;
//         public string LastName;
//     }
// }


// Our requirement is when we call the ToString() method it should display the First Name and Last Name of the Employee object. To achieve this we need to override the ToString() Virtual method which is provided by the Object class in C#.

// Overriding the ToString() Method in C#:
using System;
namespace UnderstandingObjectClassMethods
{
    public class Program
    {
        public static void Main()
        {
            Employee emp = new Employee();
            emp.FirstName = "Pranaya";
            emp.LastName = "Rout";
            Console.WriteLine(emp.ToString());
        }
    }

    public class Employee
    {
        public string FirstName;
        public string LastName;
        //Overriding the Virtual ToString method of Object class
        //Overriding the Virtual method using override modifier
        public override string ToString()
        {
            return FirstName + ", " + LastName;
        }
    }
}