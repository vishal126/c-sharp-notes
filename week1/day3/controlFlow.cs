// The Control Flow Statements in C# are the statements that Alter the Flow of Program Execution and provide better control to the programmer on the flow of execution.

// Example to Understand Control Flow Statements in C#:
// normal flow
// using System;
// namespace ControlFlowDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Executing Statment1");
//             Console.WriteLine("Executing Statment2");
//             Console.WriteLine("Executing Statment3");
//             Console.WriteLine("Executing Statment4");
//             Console.WriteLine("Executing Statment5");
//         }
//     }
// }

// control flow
// using System;
// namespace ControlFlowDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             if(10 > 5)
//             {
//                 Console.WriteLine("Executing Statment1");
//                 Console.WriteLine("Executing Statment2");
//             }
//             else
//             {
//                 Console.WriteLine("Executing Statment3");
//                 Console.WriteLine("Executing Statment4");
//             }
            
//             Console.WriteLine("Executing Statment5");
//         }
//     }
// }


// looping control flow
// using System;
// namespace ControlFlowDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             for (int i = 0; i < 5; i++)
//             {
//                 Console.WriteLine("Welcome to C#.NET");
//             }
            
//             Console.WriteLine("Some Other Statement");
//         }
//     }
// }


// goto control statement.
// using System;
// namespace ControlFlowDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Executing Statment1");
//             goto statement4;   //goto label someLabel:
//             Console.WriteLine("Executing Statment2");
//             Console.WriteLine("Executing Statment3");

//             statement4:    //label:
//             Console.WriteLine("Executing Statment4");
//             Console.WriteLine("Executing Statment5");
//         }
//     }
// }


// Types of Control Flow Statements in C#:
// three categories:
// Selection Statements or Branching Statements: (Examples: if-else, switch case, nested if-else, if-else ladder)
// Iteration Statements or Looping Statements: (Examples: while loop, do-while loop, for-loop, and foreach loop)
// Jumping Statements: (Examples: break, continue, return, goto)

                        // control flow statements
// selection statement          iteration statements            jump statements
// if else                      for                             break
// switch                       while                           continue
//                              do-while                        return
//                              for-each                        goto


// Control Flow statements dictate which lines of code the computer executes and which lines it skips.
// Under the hood, your CPU has a special register called the Instruction Pointer (IP). It holds the memory address of the very next line of code to execute.
// Normally, the IP just increments by 1 (moving to the next line). But when C# compiles an if statement or a for loop, it inserts Branching Instructions into the machine code. It tells the CPU: "Evaluate this boolean. If it is false, change the Instruction Pointer to jump 50 bytes down the memory stack, skipping this block of code entirely."