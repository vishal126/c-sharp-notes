// What are Abstract Methods in C#?
// abstract methods are methods declared within an abstract class or an interface that do not have a method body or implementation in the declaring class or interface.
// Instead, the responsibility for implementing the method is delegated to any concrete (non-abstract) class that derives from the abstract class or implements the interface.

// A method without the body is known as the Abstract Method.

// The following method is a non-abstract method as this method contains a body.
// public void Add(int num1, int num2)
// {
// }

// But without writing the method body, if we end the method with a semicolon as follows, it is called an Abstract Method.
// public void Add(int num1, int num2)

// if you want to make any method an abstract method, then you should explicitly use the abstract modifier as follows. And once you use the abstract modifier, automatically, the method will be called an abstract method.
// public abstract void Add(int num1, int num2);



// What are Abstract Classes in C#?
// In C#, an abstract class is a class that serves as a blueprint for other classes.
// Abstract classes cannot be instantiated directly, but they can be used as base classes for other classes that derive from them.
// Abstract classes are declared using the abstract keyword.
// They often define a common set of characteristics or behaviors that should be shared among multiple derived classes.

// A class under which we define abstract methods is known as an abstract class.

// public abstract class Calculator
// {
//         public abstract void Add(int num1, int num2);
// }


// What is the use of the Abstract Method in C#?
// If a method is declared abstract under any class, then the child class of that abstract class is responsible for implementing the abstract method without fail.
// In inheritance, we see that the Parent class provides some properties to the Child class for consumption.
// Here also, the inheritance comes into the picture, but the point you need to remember is that the Parent class is abstract, and he will not provide any properties to the Child class for consumption.
// Rather, it imposes some restrictions on the Child classes. And children or Child classes have to be followed or fulfill those restrictions.

// Note: Every abstract method declared within an abstract class must and should be implemented by the Child classes without fail; otherwise, we will get a compile-time error.


// Is Abstract Class Containing Only Abstract Methods in C#?
// It can also contain non-abstract methods. 
// if a class is abstract, it contains both abstract and non-abstract methods in C#.


// Who will Provide the Implementation of Abstract Methods in C#?


// Note: Abstract methods are commonly used within abstract classes.
// An abstract class cannot be instantiated; it serves as a blueprint for other classes.
// Abstract methods within an abstract class define a contract that any derived (sub) class must implement.
// An abstract class is declared using the abstract keyword.


// Can we create an instance of an abstract class in C#?
// No. We cannot create an instance of an abstract class.


// Example to Understand Abstract Class and Abstract Methods in C#:

// Currently, the abstract class does not have any static members. If there are any static members, you can call them directly using the class name.
// But, for calling non-static members, we need an instance. Then who can consume the below members? The answer is child class.

// public abstract class AbsParent
// {
//     public void Add(int x, int y)
//     {
//         Console.WriteLine($"Addition of {x} and {y} is : {x + y}");
//     }
//     public void Sub(int x, int y)
//     {
//         Console.WriteLine($"Subtraction of {x} and {y} is : {x - y}");
//     }
//     public abstract void Mul(int x, int y);
//     public abstract void Div(int x, int y);
// }



// Why Abstract Class Cannot Be Instantiated in C#?
// Its abstract methods cannot be executed because it is not a fully implemented class.
// If the compiler allows us to create the object for an abstract class, we can invoke the abstract method using that object, which CLR cannot execute at runtime.
// Hence, to restrict calling abstract methods, the compiler does not allow us to instantiate an abstract class.


// using System;
// namespace AbstractClassesAndMethods
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             AbsChild absChild = new AbsChild();
//             absChild.Add(10, 5);
//             absChild.Sub(10, 5);
//             absChild.Mul(10, 5);
//             absChild.Div(10, 2);
//         }
//     }
   
//     public abstract class AbsParent
//     {
//         public void Add(int x, int y)
//         {
//             Console.WriteLine($"Addition of {x} and {y} is : {x + y}");
//         }
//         public void Sub(int x, int y)
//         {
//             Console.WriteLine($"Subtraction of {x} and {y} is : {x - y}");
//         }
//         public abstract void Mul(int x, int y);
//         public abstract void Div(int x, int y);
//     }

//     public class AbsChild : AbsParent
//     {
//         public override void Mul(int x, int y)
//         {
//             Console.WriteLine($"Multiplication of {x} and {y} is : {x * y}");
//         }
//         public override void Div(int x, int y)
//         {
//             Console.WriteLine($"Division of {x} and {y} is : {x / y}");
//         }
//     }
// }



// Can we Create a Reference for the Abstract Class in C#?
// Yes, we can create a reference for the abstract class in C#. But we cannot create an instance of an abstract class in C#.

// static void Main(string[] args)
// {
//     //Creating Child class instance
//     Abschild abschild = new AbsChild();
//     //Creating abstract class reference pointing to child class object
//     AbsParent absParent = absChild;
//     //Accessing methods using reference
//     absParent.Add(10, 5);
//     absParent. Sub(10, 5);
//     absParent.Mul(10, 5);
//     absParent.Div(10, 2);
// }

// Overridden methods are not pure child-class methods.
// If a method is overridden in the child class, it has taken permission from the parent class.
// the parent is completely aware of that method.
// the parent class references can also call the child class overridden members but cannot call the pure child class members.

// using System;
// namespace AbstractClassesAndMethods
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Creating Child class instance
//             AbsChild absChild = new AbsChild();

//             //Creating abstract class reference pointing to child class object
//             AbsParent absParent = absChild;

//             //Accessing methods using reference
//             absParent.Add(10, 5);
//             absParent.Sub(10, 5);
//             absParent.Mul(10, 5);
//             absParent.Div(10, 2);

//             //You cannot call the Mod method using Parent reference as it is a pure child class method
//             //absParent.Mod(100, 35);
//         }
//     }
   
//     public abstract class AbsParent
//     {
//         public void Add(int x, int y)
//         {
//             Console.WriteLine($"Addition of {x} and {y} is : {x + y}");
//         }
//         public void Sub(int x, int y)
//         {
//             Console.WriteLine($"Subtraction of {x} and {y} is : {x - y}");
//         }
//         public abstract void Mul(int x, int y);
//         public abstract void Div(int x, int y);
//     }

//     public class AbsChild : AbsParent
//     {
//         public override void Mul(int x, int y)
//         {
//             Console.WriteLine($"Multiplication of {x} and {y} is : {x * y}");
//         }
//         public override void Div(int x, int y)
//         {
//             Console.WriteLine($"Division of {x} and {y} is : {x / y}");
//         }
//         public void Mod(int x, int y)
//         {
//             Console.WriteLine($"Modulos of {x} and {y} is : {x % y}");
//         }
//     }
// }



// When to use Abstract classes and Methods in C#?
// Define a Common Base
// Enforce a Contract
// Provide Default Implementations
// Implement Polymorphism
// Create Frameworks and Libraries
// Extend Functionality
// Ensure Code Consistency
// Enable Code Reusability
// Support Extension Points
// Implement Template Method Pattern


// the concept of abstract methods is nearly similar to the concept of method overriding. In method overriding, if the parent class contains any methods declared as virtual then those methods can be re-implemented under the child class by using the override modifier, and re-implementing or overriding the method is optional.
// the case of abstract, if at all a parent class contains any abstract methods, then those methods must be implemented in the child class using the same override modifier and it is mandatory.


// Real-Time Example to Understand Abstract Classes and Methods in C#:
// We are going to develop an application for calculating the Area of Rectangle, Circle, Triangle, and Cone. So, for our application, the followings are going to be our entities.
// Entities: Rectangle, Circle, Triangle, Cone

// Next, what do we need to do once we identify the Entities for our application? Next, we need to identify the attributes of each and every entity as follows.
// Rectangle: Height and Width
// Circle: Radius and PI
// Triangle: Width (also called Base) and Height
// Cone: Radius, Height, and PI

// Next, we need to identify the common attributes
// Height, Width, Radius, and PI

// using System;
// namespace AbstractClassesAndMethods
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Rectangle rectangle = new Rectangle(10, 20);
//             Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}");

//             Triangle triangle = new Triangle(15, 25);
//             Console.WriteLine($"Area of Triangle: {triangle.GetArea()}");

//             Circle circle = new Circle(12);
//             Console.WriteLine($"Area of Circle: {circle.GetArea()}");

//             Cone cone = new Cone(5, 15);
//             Console.WriteLine($"Area of Cone: {rectangle.GetArea()}");
//         }
//     }
   
//     public abstract class Shape
//     {
//         public double Height;
//         public double Width;
//         public double Radius;
//         public  const float PI = 3.14f;
//         public abstract double GetArea();
//     }

//     public class Rectangle : Shape
//     {
//         public Rectangle(double Height, double Width)
//         {
//            this.Height = Height;
//             this.Width = Width;
//         }

//         public override double GetArea()
//         {
//             return Width * Height;
//         }
//     }
//     public class Circle : Shape
//     {
//         public Circle(double Radius)
//         {
//             this.Radius = Radius;
//         }

//         public override double GetArea()
//         {
//             return PI * Radius * Radius;
//         }
//     }
//     public class Triangle : Shape
//     {
//         public Triangle(double Height, double Width)
//         {
//             this.Height = Height;
//             this.Width = Width;
//         }

//         public override double GetArea()
//         {
//             return (Width * Height)/ 2;
//         }
//     }
//     public class Cone : Shape
//     {
//         public Cone(double Radius, double Height)
//         {
//             this.Radius = Radius;
//             this.Height = Height;
//         }

//         public override double GetArea()
//         {
//             return PI * Radius * (Radius + Math.Sqrt(Height * Height + Radius * Radius));
//         }
//     }
// }