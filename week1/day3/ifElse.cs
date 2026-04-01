// What are Selection or Branching Control Flow Statements in C#?
// It is also called as Decision Making Statements.
// The decision-making statements in C# allow us to make a decision, based upon the result of a condition. If the condition is satisfying, we may need to execute some piece of code and if the condition is failed, we might need to execute some other piece of code.

// Selection statements can be divided into the following categories:
// 1. If-Else Statements
// 2. Switch Statements

// If Statement in C# Language:
// It executes a block of statements (one or more instructions) when the condition in the if block is true and when the condition is false, it will skip the execution of the if block
// using System;
// namespace ControlFlowDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int number;
//             Console.WriteLine("Enter a Number: ");
//             number = Convert.ToInt32(Console.ReadLine());
//             if (number > 10)
//             {
//                 Console.WriteLine($"{number} is greater than 10 ");
//                 Console.WriteLine("End of if block");
//             }
//             Console.WriteLine("End of Main Method");
//         }
//     }
// }


// If Else Statements in C# Language:
// if the condition is true, then the if block statements will be executed, and if the condition is false, then the else block statement will execute.

// using System;
// namespace ControlFlowDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter a Number: ");
//             int number = Convert.ToInt32(Console.ReadLine());
//             if (number % 2 == 0)
//             {
//                 Console.WriteLine($"{number} is an Even Number");
//             }
//             else
//             {
//                 Console.WriteLine($"{number} is an Odd Number");
//             }
//         }
//     }
// }


// Nested If-Else Statements in C# Language:
// When an if-else statement is present inside the body of another if or else then this is called nested if-else.

// What is the Nested If block?
// Nested if block means defining if block inside another if block.
// We can also define the if block inside the else blocks.

// using System;
// namespace ControlFlowDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int a = 15, b = 25, c = 10;
//             int LargestNumber = 0;

//             if (a > b)
//             {
//                 Console.WriteLine($"Outer IF Block");
//                 if (a > c)
//                 {
//                     Console.WriteLine($"Outer IF - Inner IF Block");
//                     LargestNumber = a;
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Outer IF - Inner ELSE Block");
//                     LargestNumber = c;
//                 }
//             }
//             else
//             {
//                 Console.WriteLine($"Outer ELSE Block");
//                 if (b > c)
//                 {
//                     Console.WriteLine($"Outer ELSE - Inner IF Block");
//                     LargestNumber = b;
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Outer ELSE - Inner ELSE Block");
//                     LargestNumber = c;
//                 }
//             }

//             Console.WriteLine($"The Largest Number is: {LargestNumber}");
//         }
//     }
// }



// using System;
// namespace ControlFlowDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int a = 15, b = 25, c = 10;
//             int LargestNumber = 0;

//             Console.WriteLine($"a={a}, b={b}, c={c}");
//             LargestNumber = (a > b) ? ((a > c)?(a):(c)) : ((b > c) ?(b):(c));

//             Console.WriteLine($"The Largest Number is: {LargestNumber}");
//         }
//     }
// }



// Ladder if-else statements in C# Language:
// In Ladder if-else statements one of the statements will be executed depending upon the truth or false of the conditions.
// using System;
// namespace ControlFlowDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int i = 20;
//             if (i == 10)
//             {
//                 Console.WriteLine("i is 10");
//             }
//             else if (i == 15)
//             {
//                 Console.WriteLine("i is 15");
//             }
//             else if (i == 20)
//             {
//                 Console.WriteLine("i is 20");
//             }
//             else
//             {
//                 Console.WriteLine("i is not present");
//             }
//         }
//     }
// }