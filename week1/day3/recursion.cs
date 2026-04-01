// To understand the recursive function, we need to understand the working flow of the following example.
// using System;
// namespace RecursionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Main Method Started");
//             fun1(4);
//             Console.WriteLine("Main Method Started");
//         }
//         static void fun1(int n)
//         {
//             Console.WriteLine("Fun1 Started");
//             fun2(3);
//             Console.WriteLine("Fun1 Ended");
//         }
//         static void fun2(int n)
//         {
//             Console.WriteLine("Fun2 Started");
//             fun3(2);
//             Console.WriteLine("Fun2 Ended");
//         }

//         static void fun3(int n)
//         {
//             Console.WriteLine("Fun3 Started");
//             fun4(1);
//             Console.WriteLine("Fun3 Ended");
//         }

//         static void fun4(int n)
//         {
//             Console.WriteLine("Fun4 Started");
//             Console.WriteLine("Fun4 Ended");
//         }
//     }
// }


// What does it mean by Recursive Function in C#?
// Function calling itself is called Recursion.
// To solve a problem recursively, two conditions must be satisfied. 
// First, the problem must be written in a Recursive Form so that the function will call itself,
// Second, the problem statement must include a Stopping Condition so that we can stop the function call.


// The most important point that you need to remember is that if a recursive function contains any local variables, a different set of local variables will be created during each call


// syntax
// return_type fun(parameter)
// {
//     if(<base_condition>) // condition to be check before calling the function itself
//     {
//         --------------
//         fun(parameter)  // function calling itself
//         --------------
//     }
// }


// How does Recursion Work in C#?
// using System;
// namespace RecursionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int x = 3;
//             fun1(x);
//         }

//         static void fun1(int n)
//         {
//             if (n > 0)
//             {
//                 Console.Write($"{n} ");
//                 fun1(n - 1);
//             }
//         }
//     }
// }


// How do you trace a recursive function in C#?
// using System;
// namespace RecursionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int x = 3;
//             fun2(x);
//         }

//         static void fun2(int n)
//         {
//             if (n > 0)
//             {
//                 fun2(n - 1);
//                 Console.Write($"{n} ");
//             }
//         }
//     }
// }



// Calculate the Factorial of a Number using Recursion:
// using System;
// namespace RecursionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int x=5;
//             Console.WriteLine($"The factorial of {x} is {factorial(x)}");
//         }

//         static int factorial(int number)
//         {
//             if(number==1)
//             {
//                 return 1;
//             }
//             return number*factorial(number-1);
//         }
//     }
// }


// advantages of Recursion
// 1. Function calling-related information will be maintained by recursion.
// 2. Stack evaluation will take place by using recursion.
// 3. Prefix, postfix, and infix notation will be evaluated by using recursion.

// disadvantages
// 1. It is a very slow process due to stack overlapping.
// 2. The recursive program can create stack overflow.
// 3. The recursive program can create infinite loops.