// Multiple Inheritance in C#
// class1 -----
//             |-----> class3
// class2 -----

// If a class has more than one Immediate Parent class, then we call it Multiple Inheritance


// Even if Multiple Inheritance is not supported through classes in C#, it is still supported through interfaces.

// class --------------
//                     |---> class
// set of interfaces---


// Why Multiple Inheritance Not Supported Through Classes in C#?
// Multiple Inheritance is not Supported through classes because we came across the ambiguity problem(in a class we cannot define two methods with the same name and same parameters i.e. with the same signature.).


// Example to Understand Multiple Inheritance with Interfaces in C#:
// using System;
// namespace MultipleInheritance
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             MultipleInheritanceTest obj = new MultipleInheritanceTest();
//             obj.Test(); 
//         }
//     }

//     public interface Interface1
//     {
//         void Test();
//     }
//     public interface Interface2
//     {
//         void Test();
//     }

//     public class MultipleInheritanceTest : Interface1, Interface2
//     {
//         public void Test()
//         {
//             Console.WriteLine("Test Method is Implemented in Child Class");
//         }
//     }
// }


// How to Implement Each Interfaces Method Separately in C#?
using System;
namespace MultipleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            MultipleInheritanceTest obj = new MultipleInheritanceTest();
            obj.Test();
            //You cannot call the Show method using obj
            //obj.Show();

            //Using Interface Reference call the Show method
            Interface1 i1 = obj;
            i1.Show();

            //Typecase the object to interface type and call the show method
            ((Interface2)obj).Show();
        }
    }

    public interface Interface1
    {
        void Test();
        void Show();
    }
    public interface Interface2
    {
        void Test();
        void Show();
    }

    public class MultipleInheritanceTest : Interface1, Interface2
    {
        //Normal Implementation
        public void Test()
        {
            Console.WriteLine("Test Method is Implemented in Child Class");
        }

        //Explicit Interface Implementation
        void Interface1.Show()
        {
            Console.WriteLine("Interface1 Show Method is Implemented in Child Class");
        }

        //Explicit Interface Implementation
        void Interface2.Show()
        {
            Console.WriteLine("Interface2 Show Method is Implemented in Child Class");
        }
    }
}