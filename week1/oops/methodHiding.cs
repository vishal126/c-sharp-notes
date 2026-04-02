// What is Method Hiding in C#?
// Method Hiding/Shadowing is also an approach of re-implementing the parent class methods under the child class exactly with the same signature (same name and same parameters).

// In Method Overriding, the child classes re-implement their parent class methods which are declared as virtual.
// In Method Hiding/Shadowing, the child classes can re-implement any method of its parent class methods even if they are not declared as virtual.

// How to Implement Method Hiding/Shadowing in C#?
// public class Parent
// {
//     public virtual void Show() { }
//     public void Display() { }
// }

// public class Child: Parent
// {
//     // Method hiding using new keyword
//     public new void Show() { }

//     // Method hiding w/o using the new keyword
//     // Getting one warning
//     public void Display() { }
// }



// Example to Understand Method Hiding/Shadowing in C#:
// using System;
// namespace MethodHiding
// {
//     public class Parent
//     {
//         public virtual void Method1()
//         {
//             Console.WriteLine("Parent Class Method1 Method");
//         }
//         public void Method2()
//         {
//             Console.WriteLine("Parent Class Method2 Method");
//         }
//         public virtual void Method3()
//         {
//             Console.WriteLine("Parent Class Method3 Method");
//         }
//         public void Method4()
//         {
//             Console.WriteLine("Parent Class Method4 Method");
//         }
//     }
//     public class Child : Parent
//     {
//         //Overriding Virtual Method
//         //Method Overriding
//         public override void Method1()
//         {
//             Console.WriteLine("Child Class Method1 Method");
//         }

//         //Overriding Non-Virtual Method
//         //Not Possible. Compile Time Error
//         public override void Method2()
//         {
//             Console.WriteLine("Child Class Method2 Method");
//         }
        
//         //Method Hiding/Shadowing Virtual Method
//         public new void Method3()
//         {
//             Console.WriteLine("Child Class Method3 Method");
//         }

//         //Method Hiding/Shadowing Non-Virtual Method
//         public new void Method4()
//         {
//             Console.WriteLine("Child Class Method4 Method");
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Child obj = new Child();
//             obj.Method1();
//             obj.Method2();
//             obj.Method3();
//             obj.Method4();
//         }
//     }
// }




// Why we are using the new keyword in Method Hiding?
// The new keyword explicitly tells us that you are hiding the base class or parent class members inside the child class.
// The new keyword explicitly tells us that you are hiding the base class or parent class members inside the child class. Even if you are not using the new keyword, then also you can re-implement the method under the child, but in that case, you will get a warning from the compiler.
// Here, the compiler gives us one warning that the Child class Display method hides the inherited Parent class Display method. It is saying that if you want to hide the member, then please use the new keyword.
// when we use the new keyword, it is just a piece of information to the compiler that the programmer intentionally defined a method with the same name and same signature as the parent class method.
// when we use the new keyword, it is just a piece of information to the compiler that the programmer intentionally defined a method with the same name and same signature as the parent class method. So, if you removed the new keyword there is no difference in the program execution only you will get a warning. That is the only use of the new keyword in this context.



// How to Invoke the Parent class Methods from the Child Class re-implemented methods?
// 1. Using the Parent Class Instance
// 2. Using the base keyword

// using System;
// namespace MethodHiding
// {
//     public class Parent
//     {
//         public virtual void Show()
//         {
//             Console.WriteLine("Parent Class Show Method");
//         }
//         public void Display()
//         {
//             Console.WriteLine("Parent Class Display Method");
//         }
//     }
//     public class Child : Parent
//     {
//         //Method Overriding
//         public override void Show()
//         {
//             //Using Parent class instance to Invoke the Parent Methods
//             Parent parent = new Parent();
//             parent.Show();

//             //Using base keyword to invoke the Parent method
//             base.Display();
//             Console.WriteLine("Child Class Show Method");
//         }
        
//         //Method Hiding/Shadowing
//         public new void Display()
//         {
//             //Using Parent class instance to Invoke the Parent Methods
//             Parent parent = new Parent();
//             parent.Display();

//             //Using base keyword to invoke the Parent method
//             base.Show();
//             Console.WriteLine("Child Class Display Method");
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Child obj = new Child();
//             obj.Show();
//             obj.Display();
//         }
//     }
// }


// How to Invoke the Parent class Methods from the Child Class re-implemented methods?
// using System;
// namespace MethodHiding
// {
//     public class Parent
//     {
//         public virtual void Show()
//         {
//             Console.WriteLine("Parent Class Show Method");
//         }
//         public void Display()
//         {
//             Console.WriteLine("Parent Class Display Method");
//         }
//     }
//     public class Child : Parent
//     {
//         //Method Overriding
//         public override void Show()
//         {
//             //Using Parent class instance to Invoke the Parent Methods
//             Parent parent = new Parent();
//             parent.Show();

//             //Using base keyword to invoke the Parent method
//             base.Display();
//             Console.WriteLine("Child Class Show Method");
//         }
        
//         //Method Hiding/Shadowing
//         public new void Display()
//         {
//             //Using Parent class instance to Invoke the Parent Methods
//             Parent parent = new Parent();
//             parent.Display();

//             //Using base keyword to invoke the Parent method
//             base.Show();
//             Console.WriteLine("Child Class Display Method");
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Child obj = new Child();
//             obj.Show();
//             obj.Display();
//         }
//     }
// }



// Differences Between Method Overriding and Method Hiding in C#:
// using System;
// namespace MethodHiding
// {
//     public class Parent
//     {
//         public virtual void Show()
//         {
//             Console.WriteLine("Parent Class Show Method");
//         }
//         public void Display()
//         {
//             Console.WriteLine("Parent Class Display Method");
//         }
//     }
//     public class Child : Parent
//     {
//         //Method Overriding
//         public override void Show()
//         {
//             Console.WriteLine("Child Class Show Method");
//         }
        
//         //Method Hiding/Shadowing
//         public new void Display()
//         {
//             Console.WriteLine("Child Class Display Method");
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Parent obj = new Child();
//             obj.Show();
//             obj.Display();
//         }
//     }
// }


// You can see in the above output that the Show method (Overriding Method) is executed from the Child class while the Display method (Hiding Method) is executed from the Parent class. Why?
// The point that you need to remember is that a parent class reference variable even if created by using the child class instance, cannot access any members which are purely defined inside the child class but can call the overriding methods of the child class because overridden members are not considered as pure child class members.
// the members which are re-implemented inside the child class by using the approach of hiding are considered as pure child class members and cannot be accessed by Parent reference variable.