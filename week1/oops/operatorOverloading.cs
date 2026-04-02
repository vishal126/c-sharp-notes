// What is Operator Overloading in C#?
// it is possible to make operators work with user-defined data types like classes.
// C# has the ability to provide the operators with a special meaning for a data type, this ability is known as operator overloading
// For example, we can overload the + operator in a class like String so that we can concatenate two strings by just using +.

// Using operator overloading in C# we can specify more than one meaning for an operator in one scope. The purpose of operator overloading is to provide a special meaning of an operator for a user-defined data type.

// syntax:
// public static return_type operator op (Type T)
// {
//     // statements
// }
// where Type must be a class or struct.

// here,
// The return type is the return type of the function.
// the operator is a keyword.
// Op is the symbol of the operator that we want to overload. Like: +, <, -, ++, etc.
// The type must be a class or struct. It can also have more parameters.
// It should be a static function.


// Operator Overloading in C#
// We have operators for performing addition (+), multiplication (*), subtraction (-), increment and decrement operator (++, –), and so on.
// That means to perform various kinds of things there are operators available in C#. And these operators are meant for some specific data types.

// Operators               Description
// +, -, !, ~, ++, --      unary operators take one operand and can be overloaded.
// +, -, *, /, %           Binary operators take two operands and can be overloaded.
// ==, !=, =               Comparison operators can be overloaded.
// &&, ||                  Conditional logical operators cannot be overloaded directly
// +=, -=, *=, /=, %=, =   Assignment operators cannot be overloaded.



// The above image shows some built-in operators and these operators are operating on built-in data types or primitive data types available in C#. Like additions can be performed on integer, float, and so on.
// If we are defining our own data type like if we are writing a class Matrix.
// class Matrix
// {
//     ...
// }

// Then can we use the + operator for adding two matrices and store the result in another object of type matrix (C = A + B)? So, can we overload + operator for the matrix class? Yes, + operator can be overloaded for the matrix class.


// Examples to Understand Operator Overloading in C#
// Let us take an example of a complex number to understand Operator Overloading in C#.
// In mathematics, we have a complex number that is written in the form of a + ib as shown in the below image.
// a + ib ( a = real, ib = imaginary)
// What is imaginary? Here, i is the square root of -1.
// The square root of minus one is undefined.
// So, we call it imaginary (i). Anything multiplied by an imaginary number becomes an imaginary number.

// 3+7i <--- c1
// 5+2i <--- c2
// -----
// 8+9i <--- c3 = c1+c2



// Example to add two Complex Numbers in C# using Operator Overloading:
// using System;
// namespace OperatorOverloadingDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Complex c1 = new Complex(3, 7);
//             c1.Display();
//             Complex c2 = new Complex(5, 2);
//             c2.Display();
//             Complex c3 = c1 + c2;
//             c3.Display();
//         }
//     }

//     public class Complex
//     {
//         private int real;
//         private int img;
//         public Complex(int r = 0, int i = 0)
//         {
//             real = r;
//             img = i;
//         }
//         public static Complex operator +(Complex c1, Complex c2)
//         {
//             Complex temp = new Complex();
//             temp.real = c1.real + c2.real;
//             temp.img = c1.img + c2.img;
//             return temp;
//         }
//         public void Display()
//         {
//             Console.WriteLine($"{real} + i{img}");
//         }
//     };
// }