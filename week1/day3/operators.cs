// What are Operators in C#?
// Operators in C# are symbols that are used to perform operations on operands.
// eg. 2+3 = 5 ( 2 & 3 are operands and + & = is the operator)


// Types of Operators in C#:
// 1. Arithmetic Operators
// 2. Relational Operators
// 3. Logical Operators
// 4. Bitwise Operators
// 5. Assignment Operators
// 6. Unary Operators or
// 7. Ternary Operator or Conditional Operator

// the Operators can also be categorized based on the Number of Operands
// Unary Operator: The Operator that requires one operand (variable or value) to perform the operation is called Unary Operator.
// Binary Operator: Then Operator that requires two operands (variables or values) to perform the operation is called Binary Operator.
// Ternary Operator: The Operator that requires three operands (variables or values) to perform the operation is called Ternary Operator. The Ternary Operator is also called Conditional Operator.

                                    // Operator                         Type
                                    // +, -, *, /, %                    Arithmetic Operators
                                    // <, <=, >, >=, ==, !=             Relational Operators
// Binary Operators                 // &&, ||, !                        Logical Operators
                                    // &, |, <<, >>, ~, ^               Bitwise Operators
                                    // =, +=,-=, *=, /=, %=             Assignment Operators

// Unary operator                   // ==, --                           Unary Operators

// Ternary operator                 // ?:                               Ternary Operator or Conditional operator


// Arithmetic Operators in C#
// Addition Operator (+):
// The + operator adds two operands.
// int a=10;
// int b=5;
// int c = a+b; //15, Here, it will add the a and b operand values i.e. 10 + 5

// Subtraction Operator (-):
// The – operator subtracts two operands.
// int a=10;
// int b=5;
// int c = a-b; //5, Here, it will subtract b from a i.e. 10 – 5


// Multiplication Operator (*):
// Division Operator (/):
// Modulus Operator (%):

// Example to Understand Arithmetic Operators in C#:
// using System;
// namespace OperatorsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int Result;
//             int Num1 = 20, Num2 = 10;

//             // Addition Operation
//             Result = (Num1 + Num2);
//             Console.WriteLine($"Addition Operator: {Result}" );

//             // Subtraction Operation
//             Result = (Num1 - Num2);
//             Console.WriteLine($"Subtraction Operator: {Result}");

//             // Multiplication Operation
//             Result = (Num1 * Num2);
//             Console.WriteLine($"Multiplication Operator: {Result}");

//             // Division Operation
//             Result = (Num1 / Num2);
//             Console.WriteLine($"Division Operator: {Result}");

//             // Modulo Operation
//             Result = (Num1 % Num2);
//             Console.WriteLine($"Modulo Operator: {Result}");
//         }
//     }
// }


// Assignment Operators in C#:
// The Assignment Operators in C# are used to assign a value to a variable.
// The most important point that you need to keep in mind is that the value on the right-hand side must be of the same data type as the variable on the left-hand side else you will get a compile-time error.

// Simple Assignment (=):
// Add Assignment (+=):
// Subtract Assignment (-=):
// Multiply Assignment (*=):
// Division Assignment (/=):
// Modulus Assignment (%=):


// Example to Understand Assignment Operators in C#:
// using System;
// namespace OperatorsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Initialize variable x using Simple Assignment Operator "="
//             int x = 15;

//             x += 10;  //It means x = x + 10 i.e. 15 + 10 = 25
//             Console.WriteLine($"Add Assignment Operator: {x}");

//             // initialize variable x again
//             x = 20;
//             x -= 5;  //It means x = x - 5 i.e. 20 - 5 = 15
//             Console.WriteLine($"Subtract Assignment Operator: {x}");

//             // initialize variable x again
//             x = 15;
//             x *= 5; //It means x = x * 5  i.e. 15 * 5 = 75
//             Console.WriteLine($"Multiply Assignment Operator: {x}");

//             // initialize variable x again
//             x = 25;
//             x /= 5; //It means x = x / 5 i.e. 25 / 5 = 5
//             Console.WriteLine($"Division Assignment Operator: {x}");

//             // initialize variable x again
//             x = 25;
//             x %= 5; //It means x = x % 5 i.e. 25 % 5 = 0
//             Console.WriteLine($"Modulo Assignment Operator: {x}");
//         }
//     }
// }



// Relational Operators in C#:
// The Relational Operators in C# are also known as Comparison Operators. It determines the relationship between two operands and returns the Boolean results.

// Equal to (==):
// Not Equal to (!=):
// Less than (<):
// Less than or equal to (<=):
// Greater than (>):
// Greater than or Equal to (>=):

// Example to Understand Relational Operators in C#:
// using System;
// namespace OperatorsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             bool Result;
//             int Num1 = 5, Num2 = 10;

//             // Equal to Operator
//             Result = (Num1 == Num2);
//             Console.WriteLine("Equal (=) to Operator: " + Result);

//             // Greater than Operator
//             Result = (Num1 > Num2);
//             Console.WriteLine("Greater (<) than Operator: " + Result);

//             // Less than Operator
//             Result = (Num1 < Num2);
//             Console.WriteLine("Less than (>) Operator: " + Result);

//             // Greater than Equal to Operator
//             Result = (Num1 >= Num2);
//             Console.WriteLine("Greater than or Equal to (>=) Operator: " + Result);

//             // Less than Equal to Operator
//             Result = (Num1 <= Num2);
//             Console.WriteLine("Lesser than or Equal to (<=) Operator: " + Result);

//             // Not Equal To Operator
//             Result = (Num1 != Num2);
//             Console.WriteLine("Not Equal to (!=) Operator: " + Result);
//         }
//     }
// }


// Logical Operators in C#:
// The Logical Operators are mainly used in conditional statements and loops for evaluating a condition.

// Logical OR (||):
// This operator is used to return true if either of the Boolean expressions is true.

// Logical AND (&&):
// This operator is used to return true if all the Boolean Expressions are true.

// Logical NOT (!):
// This operator is used to return true if the condition in the expression is not satisfied.

// using System;
// namespace OperatorsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             bool x = true, y = false, z;

//             //Logical AND operator
//             z = x && y;
//             Console.WriteLine("Logical AND Operator (&&) : " + z);

//             //Logical OR operator
//             z = x || y;
//             Console.WriteLine("Logical OR Operator (||) : " + z);

//             //Logical NOT operator
//             z = !x;
//             Console.WriteLine("Logical NOT Operator (!) : " + z);
//         }
//     }
// }


// Bitwise Operators in C#:
// The Bitwise Operators in C# perform bit-by-bit processing.
// They can be used with any of the integer (short, int, long, ushort, uint, ulong, byte) types.

// Bitwise OR (|)
// This operator performs the bitwise OR operation on the corresponding bits of the two operands involved in the operation. If either of the bits is 1, it gives 1. If not, it gives 0.

// For example,
// int a=12, b=25;
// int result = a|b; //29
// How?
// 12 Binary Number: 00001100
// 25 Binary Number: 00011001
// Bitwise OR operation between 12 and 25:
// 00001100
// 00011001
// ========
// 00011101 (it is 29 in decimal)
// Note: If the operands are of type bool, the bitwise OR operation is equivalent to the logical OR operation between them.

// Bitwise AND (&):
// This operator performs the bitwise AND operation on the corresponding bits of two operands involved in the operation. If both of the bits are 1, it gives 1. If either of the bits is not 1, it gives 0.

// For example,
// int a=12, b=25;
// int result = a&b; //8
// How?
// 12 Binary Number: 00001100
// 25 Binary Number: 00011001
// Bitwise AND operation between 12 and 25:
// 00001100
// 00011001
// ========
// 00001000 (it is 8 in decimal)
// Note: If the operands are of type bool, the bitwise AND operation is equivalent to the logical AND operation between them.

// Bitwise XOR (^):
// This operator performs a bitwise XOR operation on the corresponding bits of two operands. If the corresponding bits are different, it gives 1. If the corresponding bits are the same, it gives 0.

// For example,
// int a=12, b=25;
// int result = a^b; //21
// How?
// 12 Binary Number: 00001100
// 25 Binary Number: 00011001
// Bitwise AND operation between 12 and 25:
// 00001100
// 00011001
// ========
// 00010101 (it is 21 in decimal)


// using System;
// namespace OperatorsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int a = 12, b = 25, Result;

//             // Bitwise AND Operator
//             Result = a & b;
//             Console.WriteLine($"Bitwise AND: {Result}");

//             // Bitwise OR Operator
//             Result = a | b;
//             Console.WriteLine($"Bitwise OR: {Result}");

//             // Bitwise XOR Operator
//             Result = a ^ b;
//             Console.WriteLine($"Bitwise XOR: {Result}");
//         }
//     }
// }


// eg for boolean data type and bitwise operator
// using System;
// namespace OperatorsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             bool a = true, b = false, Result;

//             // Bitwise AND Operator
//             Result = a & b;
//             Console.WriteLine($"Bitwise AND: {Result}");

//             // Bitwise OR Operator
//             Result = a | b;
//             Console.WriteLine($"Bitwise OR: {Result}");

//             // Bitwise XOR Operator
//             Result = a ^ b;
//             Console.WriteLine($"Bitwise XOR: {Result}");
//         }
//     }
// }



// Unary Operators in C#:
// The Unary Operators in C# need only one operand. They are used to increment or decrement a value.
// There are two types:
// 1. Increment operators (++): Example: (++x, x++)
// 2. Decrement operators (–): Example: (–x, x–)

// Increment Operator (++) in C# Language:
// The Increment Operator (++) is a unary operator. It operates on a single operand only. Again, it is classified into two types:

// a. Post-Increment Operator
// b. Pre-Increment Operator

// Post Increment Operators:
// The Post Increment Operators are the operators that are used as a suffix to its variable. It is placed after the variable.
// eg. x++,  a++ etc.

// Pre-Increment Operators:
// The Pre-Increment Operators are the operators which are used as a prefix to its variable. It is placed before the variable.
// eg. ++x,++a etc.


// Decrement Operators in C# Language:
// The Decrement Operator (–) is a unary operator. It takes one value at a time.
// It is again classified into two types.
// a. Post Decrement Operator
// b. Pre-Decrement Operator


// using System;
// namespace OperatorsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Post-Increment
//             int x = 10;
//             // Result1 is assigned 10 only,
//             // x is not updated yet
//             int Result1 = x++;
//             //x becomes 11 now
//             Console.WriteLine("x is {0} and Result1 is {1}", x, Result1);

//             // Pre-Increment 
//             int y = 10;
//             int Result2 = ++y;
//             //y and Result2 have same values = 11
//             Console.WriteLine("y is {0} and Result2 is {1}", y, Result2);
//         }
//     }
// }

// Five Steps to Understand How the Unary Operators Works in C#?
// pre-increment & pre-decrement
// substitution
// evaluation
// assignment
// post-increment & post-decrement

// using System;
// namespace OperatorsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int x = 10, y = 20, z;
//             z = x++ * --y;
//             Console.WriteLine($"x={x}, y={y}, z={z}");
//         }
//     }
// }


// Ternary Operator in C#:
// The Ternary Operator in C# is also known as the Conditional Operator (?:). It is actually the shorthand of the if-else statement.
// It is called ternary because it has three operands or arguments. The first argument is a comparison argument, the second is the result of a true comparison, and the third is the result of a false comparison
// Syntax: Condition? first_expression : second_expression;

// using System;
// namespace OperatorsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int a = 20, b = 10, res;
//             res = ((a > b) ?a : b);
//             Console.WriteLine("Result = " + res);
//         }
//     }
// }



// Operator Precedence and String Coercion
// int result = 10 + 5 * 2; 
// Console.WriteLine("The result is: " + 10 + 5);

// Line 1: Junior developers read left-to-right and guess 30. Seniors know multiplication has higher precedence than addition, so it evaluates as 10 + (5 * 2), resulting in 20.\
// Line 2: Junior developers guess "The result is: 15". Seniors know that the moment C# sees a string on the left side of a +, it turns the + into a concatenation operator. It converts the 10 to a string, then the 5 to a string. The output is a highly embarrassing The result is: 105. (To fix this, you must use parentheses: "The result is: " + (10 + 5)).