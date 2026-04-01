// Types of Constructors in C#
// There are five types of constructors available in C#, they are as follows
// 1. Default or Parameter Less Constructor
// 2. Parameterized Constructor
// 3. Copy Constructor
// 4. Static Constructor
// 5. Private Constructor


// Default or Parameterless Constructors in C#
// If a constructor method does not take any parameters, then we call that a Default or Parameter Less Constructor.
// These constructors can be defined by a programmer explicitly or else will be defined implicitly provided there is no explicit constructor under the class.

// two types
// 1. System-Defined Default Constructor
// using System;
// namespace ConstructorDemo
// {
//     class Employee
//     {
//         public int Id, Age;
//         public string Address, Name;
//         public bool IsPermanent;
//     }
//     class Test
//     {
//         static void Main(string[] args)
//         {
//             Employee e1 = new Employee();
//             Console.WriteLine("Employee Id is:  " + e1.Id);
//             Console.WriteLine("Employee Name is:  " + e1.Name);
//             Console.WriteLine("Employee Age is:  " + e1.Age);
//             Console.WriteLine("Employee Address is:  " + e1.Address);
//             Console.WriteLine("Is Employee Permanent:  " + e1.IsPermanent);
//         }
//     }
// }

// 2. User-Defined Default Constructor
// using System;
// namespace ConstructorDemo
// {
//     class Employee
//     {
//         public int Id, Age;
//         public string Address, Name;
//         public bool IsPermanent;

//         //User Defined Default Constructor
//         public Employee()
//         {
//             Id = 100;
//             Age = 30;
//             Address = "Bhubaneswar";
//             Name = "Anurag";
//             IsPermanent = true;
//         }

//         public void Display()
//         {
//             Console.WriteLine("Employee Id is:  " + Id);
//             Console.WriteLine("Employee Age is:  " + Age);
//             Console.WriteLine("Employee Address is:  " + Address);
//             Console.WriteLine("Employee Name is:  " + Name);
//             Console.WriteLine("Is Employee Permanent:  " + IsPermanent);
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Employee e1 = new Employee();
//             e1.Display();
//         }
//     }
// }

// The drawback of the above user-defined default constructor is that each and every instance (i.e. object) of the class will be initialized (assigned) with the same set of values.
// That means it is not possible to initialize each instance of the class with different values.
// class Program
// {
//     static void Main(string[] args)
//     {
//         Employee e1 = new Employee();
//         e1.Display();
//         Employee e2 = new Employee();
//         Console.WriteLine();
//         e2.Display();
//     }
// }



// When should we define a parameterized constructor in a class?
// If we want to initialize the object dynamically with the user-given values or if we want to initialize each instance of a class with a different set of values then we need to use the Parameterized Constructor in C#.



// What is Parameterized Constructor in C#?
// If a constructor method is defined with parameters, we call it a Parameterized Constructor.
// public class ParameterizedConstructor
// {
//     //Constructor with Parameter is called Parameterized Constructor
//     public ParameterizedConstructor(int i)
//     {
//          Console.WriteLine($"Parameterized Constructor is called {i}");
//     }
// }

// using System;
// namespace ConstructorDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             ParameterizedConstructor obj1 = new ParameterizedConstructor(10);
//             ParameterizedConstructor obj2 = new ParameterizedConstructor(20);
//         }
//     }

//     public class ParameterizedConstructor
//     {
//         public ParameterizedConstructor(int i)
//         {
//             Console.WriteLine($"Parameterized Constructor is Called : {i}");
//         }
//     }
// }


// When should we use Parameterized Constructor in C#?
// With the help of a Parameterized constructor, we can initialize each instance of the class with a different set of values. That means using parameterized constructor we can store a different set of values in different instances created in the class.
// using System;
// namespace ConstructorDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             ParameterizedConstructor obj1 = new ParameterizedConstructor(10);
//             obj1.Display();
//             ParameterizedConstructor obj2 = new ParameterizedConstructor(20);
//             obj2.Display();
//         }
//     }

//     public class ParameterizedConstructor
//     {
//         int x;
//         public ParameterizedConstructor(int i)
//         {
//             //Initializing the variable
//             x = i;
//             Console.WriteLine($"Parameterized Constructor is Called : {i}");
//         }
//         public void Display()
//         {
//             Console.WriteLine($"Value of X = {x}");
//         }
//     }
// }



// Copy Constructor in C#:
// If we want to create multiple instances with the same values then we need to use the copy constructor.
// In a copy constructor the constructor takes the same class as a parameter to it.
// using System;
// namespace ConstructorDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             CopyConstructor obj1 = new CopyConstructor(10);
//             obj1.Display();
//             CopyConstructor obj2 = new CopyConstructor(obj1);
//             obj2.Display();
//         }
//     }

//     public class CopyConstructor
//     {
//         int x;

//         //Parameterized Constructor
//         public CopyConstructor(int i)
//         {
//             x = i;
//         }

//         //Copy Constructor
//         public CopyConstructor(CopyConstructor obj)
//         {
//             x = obj.x;
//         }

//         public void Display()
//         {
//             Console.WriteLine($"Value of X = {x}");
//         }
//     }
// }

// Constructors can be overloaded in C#.



//  Static Constructor in C#
// In C#, it is also possible to create a constructor as static and when we do so, it is called a Static Constructor.
// . If a constructor is declared explicitly by using the static modifier, then it is called a static constructor.

// In a static constructor, you cannot use any access specifiers like public, private, and protected.
// public class Test
// {
//     static Test()
//     {
        
//     }
// }


// Points to Remember while working with Static Constructors in C#:
// 1. If a class contains any static variables, then only implicit static constructors come into the picture otherwise we must be defined them explicitly.
// 2. Static Constructors are responsible for initializing static variables and these constructors are never called explicitly.
// They are called Implicitly and moreover, these constructors are the first to execute in any class
// using System;
// namespace ConstructorDemo
// {
//     public class StaticConstructor
//     {
//         static StaticConstructor()
//         {
//             Console.WriteLine("Static Constructor Executed!");
//         }
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Main Method Exceution Started...");
//         }
//     }
// }

// 3. Static Constructors cannot be parameterized, so overloading of the static constructors is not possible.



// Points To Remember About Static Constructor in C#:
// 1. There can be only one static constructor in a class.
// 2. It can’t be called explicitly, it is always called implicitly.
// 3. The static constructor should be without any parameters.
// 4. It can only access the static members of the class.
// 5. There should not be any access specifiers in the static constructor definition.
// 6. If a class is static then we cannot create the object for the static class.
// 7. It is called automatically to initialize the static members.
// 8. Static constructor will be invoked only once i.e. at the time of class loading.


// Can we initialize static data fields within a non-static constructor in C#?
// Yes, we can initialize static data members within a non-static constructor.



// What is a Private Constructor in C#?
// The constructor whose accessibility is private is known as a private constructor.
// When a class contains a private constructor then we cannot create an object for the class outside of the class.
// private constructors are used to create an object for the class within the same class.
// private constructors are used in the Remoting concept.


// using System;
// namespace ConstructorDemo
// {
//     class Program
//     {
//         private Program()
//         {
//             Console.WriteLine("This is private constructor");
//         }
//         static void Main(string[] args)
//         {
//             Program p = new Program();
//             Console.WriteLine("Main method");
//         }
//     }
// }


// Points To Remember about C# Private Constructor:
// Using Private Constructor in C# we can implement the singleton design pattern.
// We need to use the private constructor in C# when the class contains only static members.
// Using a private constructor is not possible to create an instance from outside the class.

// singleton pattern
// The Singleton Design Pattern ensures that only one instance of a particular class is going to be created and then provide simple global access to that instance for the entire application.


// How to Implement Singleton Design Pattern in C#?
// 1. You need to declare only a single constructor in your class and that constructor should be private and parameterless. This is required because it is not allowed the class to be instantiated from outside the class. It only instantiates from within the class.
// 2. The class should be declared sealed which will ensure that it cannot be inherited.
// 3. You need to create a private static variable that is going to hold a reference to the single created instance of the class.
// 4. You also need to create a public static property/method which will return the single-created instance of the singleton class. This method or property first checks if an instance of the singleton class is available or not. If the singleton instance is available, then it returns that singleton instance otherwise it will create an instance and then return that instance.


// using System;
// namespace PrivateConstructorDemo
// {
//     public sealed class Singleton
//     {
//         private static int counter = 0;
//         private static Singleton instance = null;
//         private static readonly object Instancelock = new object();
//         public static Singleton GetSingletonInstance()
//         {
//             lock (Instancelock)
//             {
//                 if (instance == null)
//                 {
//                     instance = new Singleton();
//                 }
//                 return instance;
//             }
//         }

//         private Singleton()
//         {
//             counter++;
//             Console.WriteLine($"Singleton Constructor Executed {counter} Time");
//         }
//         public void SomeMethod(string Message)
//         {
//             Console.WriteLine($"Some Method Called : {Message}");
//         }
//     }
// }

// namespace PrivateConstructorDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Singleton fromPlace1 = Singleton.GetSingletonInstance();
//             fromPlace1.SomeMethod("From Place 1");
//             Singleton fromPlace2 = Singleton.GetSingletonInstance();
//             fromPlace2.SomeMethod("From Place 2");
//         }
//     }
// }


