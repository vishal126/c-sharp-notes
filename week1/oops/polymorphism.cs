// What is Polymorphism in C#?
// polymorphism means “many forms” or we can say that the word polymorphism means the ability to take more than one form. That is one thing that can take many forms.
// Polymorphism is a concept by which we can perform a single task in different ways. That is, when a single entity behaves differently in different cases.
// The term polymorphism is an object-oriented programming term that means a function or an operator behaves differently in different scenarios.

// ***** when a function shows different behaviors when we pass different types and numbers of input values, then it is called Polymorphism in C#. *****


// Types of Polymorphism in C#:
// 1. Static Polymorphism / Compile-Time Polymorphism / Early Binding
    // a. Method overloading
    // b. Operator overloadig
    // c. Method Hiding
// 2. Dynamic Polymorphism / Run-Time Polymorphism / Late Binding
    // a. Method overriding



// What is Compile-Time Polymorphism in C#?
// The function call is bounded to the class at the time of compilation; if the function is going to be executed from the same bounded class at run-time, then it is called Compile-Time Polymorphism.
// This happens in the case of Method Overloading because, in this case, each method will have a different signature, and based on the method call, we can easily recognize the method that matches the method signature.

// using System;
// namespace MethodOverloading
// {
//     class Program
//     {
//         public void Add(int a, int b)
//         {
//             Console.WriteLine(a + b);
//         }
//         public void Add(float x, float y)
//         {
//             Console.WriteLine(x + y);
//         }
//         public void Add(string s1, string s2)
//         {
//             Console.WriteLine(s1 + " " + s2);
//         }
//         static void Main(string[] args)
//         {
//             Program obj = new Program();
//             obj.Add(10, 20);
//             obj.Add(10.5f, 20.5f);
//             obj.Add("Pranaya", "Rout");
//         }
//     }
// }



// What is Runtime Polymorphism in C#?
// In dynamic polymorphism, the behavior of a method is decided at runtime.
// The CLR (Common Language Runtime) binds the method call with the method definition/body at runtime and invokes the relevant method during runtime when the method is called.

using System;
namespace PolymorphismDemo
{
    class Class1
    {
        //Virtual Function (Overridable Method)
        public virtual void Show()
        {
            //Parent Class Logic Same for All Child Classes
            Console.WriteLine("Parent Class Show Method");
        }
    }

    class Class2 : Class1
    {
        //Overriding Method
        public override void Show()
        {
            //Child Class Reimplementing the Logic
            Console.WriteLine("Child Class Show Method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class2();
            obj1.Show(); //Resolve at Runtime
        }
    }
}