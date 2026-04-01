// Class and Objects from Programming Language Point of View.
// Class:
// A class is simply a user-defined data type that represents both state and behavior.
// The state represents the properties and behavior is the action that objects can perform.
// A class is the blueprint/template that describes the details of an object.
// A class is a blueprint from which the individual objects are created.


// Objects:
// It is an instance of a class.
// To access the class members, we need to use the dot (.) operator.
// The dot operator links the name of an object with the name of a member of a class.


// How can we create a Class and Object in C#?
// class definition
// public class Calculator
// {
//     public int CalculateSum(int no1, int no2)
//     {
//         return no1 + no2;
//     }
// }

// so a class name consists of access specifier, class keyword, class_name & the class body.
// in above code CalculateSum is the is a **method**.

// In order to use the class template we need to create a instance/object.
// Calculator calObject = new Calculator();
// calObject.CalculateSum(10, 20);

// using System;
// namespace ClassObjectsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Creating object
//             Calculator calObject = new Calculator();

//             //Accessing Calculator class member using Calculator class object
//             int result = calObject.CalculateSum(10, 20);

//             Console.WriteLine(result);
//         }
//     }

//     //Defining class or blueprint or template
//     public class Calculator
//     {
//         public int CalculateSum(int no1, int no2)
//         {
//             return no1 + no2;
//         }
//     }
// }


// Types of Classes in C#:
// 1. Abstract Class
// 2. Concrete class
// 3. Sealed Class
// 4. Partial Class
// 5. Static Class