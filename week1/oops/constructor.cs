// What is a Constructor in C#?
// It is a special method present inside a class responsible for initializing the variables of that class.
// The name of the constructor method is exactly the same name as the class in which it was present.
// The constructor method does not return any value.


// every class requires a constructor, why?
// if a class has no constructors then we're unable to create a instance of that class.

// class Test
// {
//     int i;
// }

// Test obj = new Test();

// the code has no constructor but this is a valid code.
// The reason is that it is the responsibility of a programmer to define a constructor under his class and if he/she fails to do, on behalf of the programmer an implicit constructor gets defined in that class by the compiler.

// before compilation
// class Test
// {
//     int i;
// }

// after compilation
// class Test
// {
//     int i;
//     public Test {
//         internal int = 0;
//     }
// }


// Points to Remember while working with Constructors
// Implicitly Defined Constructors are parameter less and these constructors are also known as Default Constructors.
// Implicitly Defined Constructors are public
// We can also define a constructor under the class and if we define it, we can call it an Explicit Constructor and an Explicit Constructor can be parameter less and parameterized also.


// Example to Understand Implicitly Constructor
// using System;
// namespace ConstructorDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Test obj = new Test();
//             Console.WriteLine($"i = {obj.i}");
//             Console.WriteLine($"b = {obj.b}");

//             //value null will be printed, so here we checking the null
//             if (obj.s == null)
//             {
//                 Console.WriteLine("s = null");
//             }
//         }
//     }
//     class Test
//     {
//         public int i;
//         public bool b;
//         public string s;
//     }
// }


// How to Define the Constructor Explicitly in C#?
// [<modifiers>] <class name> ([<Parameter List>])
// {
//      // statements
// }

// Whenever we are creating an instance, there will be a call to the class constructor

// using System;
// namespace ConstructorDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             ExplicitConstructor obj = new ExplicitConstructor();
//         }
//     }
//     class ExplicitConstructor
//     {
//         public ExplicitConstructor()
//         {
//             Console.WriteLine("Explicit Constructor is Called!");
//         }
//     }
// }



// The Constructors are responsible for two things. One is the object initialization and the other one is memory allocation.
// The role of the new keyword is to create the object and the role of the constructor is to initialize the variables.

// What does a Constructor have in C#?
// It can have all five accessibility modifiers i.e. public, private, protected, etc.
// The constructor can be parameterless or parameterized.
// It can have a throws clause which means we can throw an exception from the constructor.
// The constructor can have logic, as part of logic it can have all C#.NET legal statements except return statements with value.
// We can place a return; in the constructor.