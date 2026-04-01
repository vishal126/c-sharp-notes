// What are Jump Statements in C# Language?
// The Jump Statements in C# are used to transfer control from one point or location or statement to another point or location or statement in the program due to some specified condition while executing the program.
// The Jump Statements in C# Language are used to modify the behavior of conditional (if, else, switch) and iterative (for, while, and do-while) statements.

// C# supports the following jump statements:
// break
// continue
// goto
// return (In the Function section we will discuss the return statement)
// throw (In the Exception Handling section we will discuss the throw statement)


// Break Statement in C# Language:
// By using the break statement, we can terminate either the loop body or the switch body.


// Example to Understand Break Statement in C# Language:
// using System;
// namespace JumpStatementDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             for (int i = 1; i <= 10; i++)
//             {
//                 Console.WriteLine($"I : {i}");
//                 if (i == 5)
//                 {
//                     break;
//                 }
//             }
//             Console.WriteLine("Out of for-loop");
//         }
//     }
// }


// C# Break Statement with Inner Loop:
// The break statement in C# terminates the closest enclosing iteration statement (for, for each, while, or do loop) or switch statement. If we place the break statement inside the nested loop i.e. inside the inner loop, then the break statement will terminate only the innermost loop that contains it.

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
//                     if (inner > 3)
//                     {
//                         break;
//                     }
//                     Console.Write($"  Inner: {inner}");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }

