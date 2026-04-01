// While Loop in C# Language:
// A while loop is used for executing a statement repeatedly until a given condition returns false.

// using System;
// namespace ControlFlowDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int x = 1;
//             while (x <= 5)
//             {
//                 Console.WriteLine("Value of x:" + x);
//                 x++;
//             }
//         }
//     }
// }


// Example: Print the numbers in the following format up to a given number and that number is entered from the keyboard.
// 2 4 6 8 …………………….. up to that given number

// using System;
// namespace ControlFlowDemo
// {
//     class Program
//     {
//         static void Main()
//         {
//             int i, n;
//             Console.WriteLine("Enter a number: ");
//             n = Convert.ToInt32(Console.ReadLine());
//             i=2;

//             while(i<=n)
//             {
//                 Console.Write($"{i} ");
//                 i+=2;
//             }
//         }
//     }
// }


// What is Pre-Checking Process or Entry-Controlled Loop?
// The pre-checking process means before the evaluation of the statement block, the conditional part will be executed.

// Nested While Loop in C# Programming Language:
// Writing a while loop inside another while loop is called nested while loop.