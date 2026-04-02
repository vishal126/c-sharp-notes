// What is an Interface in C#?
// The Interface in C# is a Fully Unimplemented Class used for declaring a set of operations/methods of an object.
// we can define an interface as a pure abstract class, which allows us to define only abstract methods.

// . It is used to achieve multiple inheritances, which the class can’t achieve.
// It is used to achieve full abstraction because it cannot have a method body.

// Interfaces allow you to define a common set of functionality that multiple classes can share, promoting code reusability and ensuring a consistent structure for related classes.


// Differences Between Concrete Class, Abstract Class, and Interface in C#:
// Class: Contains only the Non-Abstract Methods (Methods with Method Body).
// Abstract Class: Contains both Non-Abstract Methods (Methods with Method Body) and Abstract Methods (Methods without Method Body).
// Interface: Contain only Abstract Methods (Methods without Method Body).

// Note: Every abstract method of an interface should be implemented by the child class of the interface without fail (Mandatory).

// Generally, a class inherits from another class to consume members of its Parent. On the other hand, if a class inherits from an interface, it is to implement the members of its Parent (Interface), not for consumption.

// Note: A class can inherit from a class and interface(s) at a time.

// How to Define an Interface in C#?
// [<modifiers>] interface <interface name>
// {
     // abstract member declaration here
// }

// interface ITestInterface
// {
//     //Abstract Member Declarations
// }


// How to Define Abstract Methods in an Interface in C#?
// void Add(int num1, int num2);

// While working with Interface, we need to remember some Rules
// Point 1: The default scope for an interface’s members is public, whereas it is private in the case of a class.
// Point 2: By default, every member of an interface is abstract, so we aren’t required to use the abstract modifier on it again.
// interface ITestInterface
// {
//     //By default, the following method is public and abstract
//     void Add(int num1, int num2);
// }
// Point 3: We cannot declare fields/variables, constructors, and destructors in an interface in C#.


// What are the Members we can and can’t define in an interface in C#?
// An interface can contain
// 1. Abstract methods
// 2. Properties
// 3. Indexes
// 4. Events

// An interface cannot contain
// 1. Non-abstract functions
// 2. Data fields
// 3. Constructors
// 4. Destructors

// Point 4: An interface can inherit from another interface in C# just like a class inherits from another.
// interface ITestInterface1
// {
//     //By default, the following method is public and abstract void Add(int num1, int num2);
// }
// interface ITestInterface2: ITestInterface1
// {
//     //By default, the following method is public and abstract void Sub(int num1, int num2);
// }

// Now, the Child class that inherits from Interface1 has to implement one method, i.e., Add, and the child class that inherits from Interface2 has to implement two methods, i.e., Add and Sub.

// Point 5: Every member of an interface should be implemented under the child class without fail (mandatory), but while implementing, we aren’t required to use the override modifier.
// interface ITestInterface1
// {
//     void Add(int num1, int num2);
// }
// interface ITestInterface2 : ITestInterface1
// {
//     void Sub(int num1, int num2);
// }

// public class ImplementationClass1 : ITestInterface1
// {
//     //Implement only the Add method
//     public void Add(int num1, int num2)
//     {
//         Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
//     }
// }

// public class ImplementationClass2 : ITestInterface2
// {
//     //Implement Both Add and Sub method
//     public void Add(int num1, int num2)
//     {
//         Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
//     }

//     public void Sub(int num1, int num2)
//     {
//         Console.WriteLine($"Divison of {num1} and {num2} is {num1 - num2}");
//     }
// }


// if we not use the public modifier while implementing the abstract method then it will throw the compilation error.



// Example to Understand Interface in C#:
// using System;
// namespace AbstractClassMethods
// {
//     class Program
//     {
//         static void Main()
//         {
//             ImplementationClass1 obj1 = new ImplementationClass1();
//             //Using obj1 we can only call Add method
//             obj1.Add(10, 20);
//             //We cannot call Sub method
//             //obj1.Sub(100, 20);

//             ImplementationClass2 obj2 = new ImplementationClass2();
//             //Using obj2 we can call both Add and Sub method
//             obj2.Add(10, 20);
//             obj2.Sub(100, 20);
//         }
//     }
    
//     interface ITestInterface1
//     {
//         void Add(int num1, int num2);
//     }
//     interface ITestInterface2 : ITestInterface1
//     {
//         void Sub(int num1, int num2);
//     }

//     public class ImplementationClass1 : ITestInterface1
//     {
//         //Implement only the Add method
//         public void Add(int num1, int num2)
//         {
//             Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
//         }
//     }

//     public class ImplementationClass2 : ITestInterface2
//     {
//         //Implement Both Add and Sub method
//         public void Add(int num1, int num2)
//         {
//             Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
//         }

//         public void Sub(int num1, int num2)
//         {
//             Console.WriteLine($"Divison of {num1} and {num2} is {num1 - num2}");
//         }
//     }
// }


// Point 6: We cannot create an instance of an interface, but we can create a reference of an interface. The interface reference is going to hold the child class instance. We can only invoke the methods declared in the interface using the interface reference.
// using System;
// namespace AbstractClassMethods
// {
//     class Program
//     {
//         static void Main()
//         {
//             //Creating Reference of an Interface point to the 
//             //child class instance
//             ITestInterface1 obj = new ImplementationClass();

//             //Add method signature declared in ITestInterface1, so we can
//             //Invoke the Add method
//             obj.Add(10, 20);

//             //Sub method signature is not declared in ITestInterface1, 
//             //so, we cannot Invoke the Sub method
//             //obj.Sub(100, 20);
//         }
//     }
    
//     interface ITestInterface1
//     {
//         void Add(int num1, int num2);
//     }
    
//     public class ImplementationClass : ITestInterface1
//     {
//         //Interface Method Implementation
//         public void Add(int num1, int num2)
//         {
//             Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
//         }

//         //This method purely belongs to ImplementationClass
//         public void Sub(int num1, int num2)
//         {
//             Console.WriteLine($"Divison of {num1} and {num2} is {num1 - num2}");
//         }
//     }
// }


// Explicit Interface Implementation in C#
// When each interface method is implemented separately under the child class by providing the method name and the interface name, it is called Explicit Interface Implementation.
// But in this case, while calling the method, we should compulsorily use the interface reference created using the object of a class or typecast the object to the appropriate interface type.

// Explicit Interface Implementation Example in C#

// using System;
// namespace AbstractClassMethods
// {
//     class Program
//     {
//         static void Main()
//         {
//             ImplementationClass obj1 = new ImplementationClass();
//             //Using obj1 we can call the Add method directly because
//             //It is implemented using public access specifier
//             obj1.Add(10, 20);

//             //We need to typecast obj1 to ITestInterface1 to call the Sub
//             //method because Sub method is implemented using Interface name
//             ((ITestInterface1)obj1).Sub(100, 20);

//             //We can call the method directly using the interface reference
//             //Typecasting is not required in this case
//             ITestInterface1 obj2 = new ImplementationClass();
//             obj2.Add(200, 50);
//             obj2.Sub(200, 50);
//         }
//     }
    
//     interface ITestInterface1
//     {
//         void Add(int num1, int num2);
//         void Sub(int num1, int num2);
//     }
    
//     public class ImplementationClass : ITestInterface1
//     {
//         //Interface Method Implementation
//         public void Add(int num1, int num2)
//         {
//             Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
//         }

//         //This method purely belongs to ImplementationClass
//         void ITestInterface1.Sub(int num1, int num2)
//         {
//             Console.WriteLine($"Sub of {num1} and {num2} is {num1 - num2}");
//         }
//     }
// }


// When to use Interface in C#?
// Defining a Common Contract
// Implementing Multiple Inheritance
// Enforcing a Specific Structure
// Implementing Polymorphism
// Testing and Mocking
// Collaboration in Teams
// Code Reusability
// Dependency Injection


// What is the Difference Between Interface and Abstract Class in C#?
// The interface is a fully un-implemented class used for declaring a set of methods of an object. The abstract class is a partially implemented class.
// The interface allows us to develop multiple inheritances. So, we must start object design with interface whereas abstract class does not support multiple inheritances so it always comes next to interface in the object creation process.


// What are the Advantages of using Interface in C#?
// It is used to achieve loose coupling.
// It is used to achieve total abstraction.
// To achieve multiple inheritance and abstraction.