// What are Static and Non-Static Members in C#?
// The members (Variables, Constructors, and Methods) which are created by using the static modifier are called static members rest of all are called non-static members.

// Understanding Static and Non-Static Variables in C#
// Whenever we declare a variable by using the static modifier or when we declare a variable inside of any static block then those variables are considered static variables whereas the rest of the others are considered non-static variables.

// public class Program
// {
//     int x = 10 //Non-Static Variable
//     static int y = 20 //Static Variable
//     public static void Main() //Static Block
//     {
//     int a = 10 //By Default Static
//     }
//     void SomeMethod() //Non Static Block
//     {
//     int b = 10 //By Default Non-Static
//     }
// }


// Example to Understand Static and Non-Static Variables in C#
// u


// What is the Scope of Static and Non-Static Variables in C#?
// The Non-Static variables are created when the object is created and are destroyed when the object is destroyed
// The object is destroyed when its reference variable is destroyed or initialized with null.
// So, we can say that the scope of the object is the scope of its referenced variables

// the Static Variable scope is the Application Scope
// the application start and class execution starts, static variables are created and they will be there as long as your application is running.
// Once the application stops, then static variables are going to be deleted. So, the scope is application scope.


// Static and Non-Static Methods in C#
// When we create a method by using the static modifier then it is called the static method and the rest of the methods are non-static methods
// You cannot consume the non-static members directly within a static method. If you want to consume any non-static members with a static method then you need to create an object and then through the object, you can access the non-static members


// Rules to follow while working with Static and Non-Static Members in c#:
// Non-Static to Static: Non-Static Members can be consumed only by using the object of that class inside a static block.
// Static to Static: Static Members can be consumed directly (within the same class) or by using the class name (from outside the class) inside another static block.
// Static to Non-Static: Static Members can be consumed directly or by using the class name inside a Non-Static block.
// Non-Static to Non-Static: Non-Static Members can be consumed directly or by using the “this” keyword inside another non-static block.

// using System;
// namespace StaticNonStaticDemo
// {
//     class Example
//     {
//         int x = 100;
//         static int y = 200;
//         static void Add()
//         {
//             //This is a static block
//             //we can access non static members X with the help of Example object
//             //We can access the static member directly or through class name
//             Example obj = new Example();
//             //Console.WriteLine(obj.x + Example.y);
//             Console.WriteLine("Sum of 100 and 200 is :" + (obj.x + y));
//             Console.WriteLine("Sum of 100 and 200 is :" + (obj.x + Example.y));
//         }

//         void Mul()
//         {
//             //This is a Non-Static method
//             //we can access static members directly or through class name
//             //we can access the non-static members directly or through this keyword
//             Console.WriteLine("Multiplication of 100 and 200 is :" + (this.x * Example.y));
//             Console.WriteLine("Multiplication of 100 and 200 is :" + (x * y));
//         }
//         static void Main(string[] args)
//         {
//             // Main method is a static method
//             // ADD() method is a static method
//             // Statid to Static 
//             // we can call the add method directly or through class name
//             Example.Add(); //Calling Add Method using Class Name
//             Add(); //Calling Add Method Directly

//             // Mul() method is a Non-Static method
//             // We can call the non-static method using object only from a static method
//             // Static to Non-Static
//             Example obj = new Example();
//             obj.Mul(); //Calling Mul Method using Instance
//             Console.ReadLine();
//         }
//     }
// }


// Understanding Static and Non-Static Constructors in C#:
// If we create the constructor explicitly by the static modifier, then we call it a static constructor and the rest of the others are non-static constructors.
// The most important point that you need to remember is the static constructor is the first block of code that gets executed under a class. No matter how many numbers of objects you created for the class the static constructor is executed only once.
//  a non-static constructor gets executed only when we created the object of the class and that is too for each and every object of the class.
// It is not possible to create a static constructor with parameters. This is because the static constructor is the first block of code that is going to execute under a class. And this static constructor is called implicitly, even if parameterized there is no chance of sending the parameter values.

// using System;
// namespace StaticNonStaticDemo
// {
//     class Example
//     {
//         //Static Constructor
//         //Executed only once
//         //First block of code to be executed inside a class
//         //Before Main Method body start executing, this constructor will execute
//         static Example()
//         {
//             Console.WriteLine("Static Constructor is Called");
//         }

//         //Non-Static Constructor
//         //Executed once per object
//         //When we create an instance, this constructor will execute
//         public Example()
//         {
//             Console.WriteLine("Non-Static Constructor is Called");
//         }

//         //Program Execution will start from the Main method
//         //But before executing the Main method body, it will
//         //execute the static constructor
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Main Method Execution Start");
//             Example obj1 = new Example();
//             Example obj2 = new Example();
//             Console.WriteLine("Main Method Execution End");
//             Console.ReadLine();
//         }
//     }
// }


// Static Class in C#:
// The class which is created by using the static modifier is called a static class in C#.
// A static class can contain only static members. It is not possible to create an instance of a static class. This is because it contains only static members. And we know we can access the static members of a class by using the class name

// namespace StaticNonStaticDemo
// {
//     public static class TemperatureConverter
//     {
//         public static double CelsiusToFahrenheit(string temperatureCelsius)
//         {
//             // Convert argument to double for calculations.
//             double celsius = Double.Parse(temperatureCelsius);

//             // Convert Celsius to Fahrenheit.
//             double fahrenheit = (celsius * 9 / 5) + 32;

//             return fahrenheit;
//         }

//         public static double FahrenheitToCelsius(string temperatureFahrenheit)
//         {
//             // Convert argument to double for calculations.
//             double fahrenheit = Double.Parse(temperatureFahrenheit);

//             // Convert Fahrenheit to Celsius.
//             double celsius = (fahrenheit - 32) * 5 / 9;

//             return celsius;
//         }
//     }
//     class TestTemperatureConverter
//     {
//         static void Main()
//         {
//             Console.WriteLine("Please select the convertor direction");
//             Console.WriteLine("1. From Celsius to Fahrenheit.");
//             Console.WriteLine("2. From Fahrenheit to Celsius.");
//             Console.Write(":");

//             string selection = Console.ReadLine();
//             double F, C = 0;

//             switch (selection)
//             {
//                 case "1":
//                     Console.Write("Please enter the Celsius temperature: ");
//                     F = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
//                     Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
//                     break;

//                 case "2":
//                     Console.Write("Please enter the Fahrenheit temperature: ");
//                     C = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
//                     Console.WriteLine("Temperature in Celsius: {0:F2}", C);
//                     break;

//                 default:
//                     Console.WriteLine("Please select a convertor.");
//                     break;
//             }

//             // Keep the console window open in debug mode.
//             Console.WriteLine("Press any key to exit.");
//         }
//     }
// }