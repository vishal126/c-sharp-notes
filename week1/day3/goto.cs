// Goto Statement in C#
// The Goto Statement in C# is used to transfer the control to the labeled statement in the program
// The label is a valid identifier and placed just before the statement from where the control is transferred.
// That means the goto Statement provides an unconditional jump from the goto to a labeled statement in the same function.

// using System;
// namespace JumpStatementDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("1st Statement: ");

//             goto label1;   //goto label label1:

//             Console.WriteLine("2nd Statement: ");

//         label1:    //label:
//             Console.WriteLine("3rd Statement: ");

//             Console.WriteLine("End of Main Method Statement: ");
//         }
//     }
// }

// It is also possible in C# that we can have multiple labels. When a label match is found, it will execute the statements as well as the other label statements which are appeared after this match label statements.
// using System;
// namespace JumpStatementDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("1st Statement: ");

//             goto label2;   //goto label label2:

//             Console.WriteLine("2nd Statement: ");

//         label1:    //label:
//             Console.WriteLine("3rd Statement: ");

//         label2:    //label:
//             Console.WriteLine("4th Statement: ");

//         label3:    //label:
//             Console.WriteLine("5th Statement: ");

//             Console.WriteLine("End of Main Method Statement: ");
//         }
//     }
// }


// Using goto statement inside a Loop in C#:
// The label statement must exist in the scope of the goto statement
// More than one goto statement can transfer control to the same label.
// This statement can be used to get out from a loop or an inner nested loop to an outer loop

// using System;
// namespace JumpStatementDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             for (int i = 1; i <= 10; i++)
//             {
//                 if (i == 5)
//                 {
//                     goto Exitlabel;
//                 }
//                 Console.WriteLine(i);
//             }
//             Console.WriteLine("Next statement placed after loop");

//             Exitlabel: //goto label
//                 Console.WriteLine("Labeled statement");
//         }
//     }
// }


// Using goto in Switch Statement
// Unlike the break statement, it does not transfer the program control to the next statement which is placed immediately after the loop or switch instead it will transfer the control to the statement written after the matched label.
// You can also use the goto statement to transfer the control to a specific switch-case label or the default label in a switch statement

// using System;
// namespace JumpStatementDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int number = 20;
//             switch (number)
//             {

//                 case 5:
//                     Console.WriteLine("case 5");
//                     break;
//                 case 10:
//                     Console.WriteLine("case 10");
//                     break;
//                 case 20:
//                     Console.WriteLine("case 20");
//                     // goto statement transfer
//                     // the control to case 5
//                     goto case 5;

//                 default:
//                     Console.WriteLine("No match found");
//                     break;
//             }
//         }
//     }
// }


// Can we print numbers from 1 to 10 without using the loop in C#?
// using System;
// namespace ControlFlowDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int count = 1;
//         label_Loop:
//             Console.WriteLine(count);
//             count++;
//             if (count <= 10)
//             {
//                 goto label_Loop;
//             }
//         }
//     }
// }