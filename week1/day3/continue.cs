// Continue Statement in C# Language:
// By using the continue keyword, we can skip the statement execution from the loop body.

// using System;
// namespace JumpStatementDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             for (int i = 1; i <= 5; i++)
//             {
//                 if (i == 3)
//                 {
//                     continue;
//                 }
//                 Console.WriteLine($"I : {i}");
//             }
//         }
//     }
// }


// Using Continue Statement inside the nested loop:
// The continue statement starts a new iteration of the closest enclosing iteration statement (for, for each, while, or do loop)

// using System;
// namespace JumpStatementDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             for (int outer = 1; outer <= 5; outer++)
//             {
//                 Console.WriteLine($"Outer: {outer}");
//                 for (int inner = 1; inner <= 5; inner++)
//                 {
//                     if (inner == 3)
//                     {
//                         continue;
//                     }
//                     Console.Write($"  Inner: {inner}");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }