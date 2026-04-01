// Switch Statements in C# Language:
// The switch is a keyword in the C# language, and by using this switch keyword we can create selection statements with multiple blocks. And the Multiple blocks can be constructed by using the case keyword.
// Switch case statements in C# are a substitute for long if else statements that compare a variable or expression to several values.


// Syntax of Switch Statements in C# Language:
// switch(variable)
// {
//      case 1:
            // code
//      break;
//      case n:
            // code
//      break;
//      default:
            // code
//      break;
// }


// In C#, duplicate case values are not allowed
// The default block in the switch statement is optional
// We need to use the break statement inside the switch block to terminate the switch statement execution
// Nesting of switch statements is allowed, which means you can have switch statements inside another switch

// using System;
// namespace ControlFlowDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int x = 2;
//             switch (x)
//             {
//                 case 1:
//                     Console.WriteLine("Choice is 1");
//                     break;
//                 case 2:
//                     Console.WriteLine("Choice is 2");
//                     break;
//                 case 3:
//                     Console.WriteLine("Choice is 3");
//                     break;
//                 default:
//                     Console.WriteLine("Choice other than 1, 2 and 3");
//                     break;
//             }
//         }
//     }
// }


// If we are not inserting the break statement, then we will get a compilation error.
// you can combine multiple case blocks with a single break statement if and only if the previous case statement does not have any code block
// using System;
// namespace ControlFlowDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string str = "C#";
//             switch (str)
//             {
//                 case "C#":      
//                 case "Java":
//                 case "C":
//                     Console.WriteLine("It’s a Programming Langauge");
//                     break;

//                 case "MSSQL":
//                 case "MySQL":
//                 case "Oracle":
//                     Console.WriteLine("It’s a Database");
//                     break;

//                 case "MVC":
//                 case "WEB API":
//                     Console.WriteLine("It’s a Framework");
//                     break;

//                 default:
//                     Console.WriteLine("Invalid Input");
//                     break;
//             }
//         }
//     }
// }


// Although the switch statement makes the code look cleaner than the if…else if statement, the switch is restricted to work with limited data types. The switch statement in C# only works with:
// Primitive data types: bool, char, and integral type
// Enumerated Types (Enum)
// String Class
// Nullable types of the above data types



// The Jump Table
// If you have an if-else if ladder with 50 conditions, and the correct answer is at the very bottom, the CPU must evaluate the first 49 conditions one by one before it finally finds the truth. This is O(N) linear time.

// When the C# compiler sees a large switch statement (especially with numbers or strings), it doesn't evaluate them one by one. Instead, it builds a Jump Table (or Hash Dictionary) in memory. When the code runs, it calculates the exact memory address of the correct case and jumps there instantly, skipping all the other cases. This executes in O(1) constant time.

// Switch Expressions (C# 8+)
// The traditional switch statement shown in the article is bulky. It requires typing case and break over and over, and it mutates variables outside of its scope.

// Modern C# introduced Switch Expressions, which allow you to return a value directly using a clean, lambda-like syntax (=>). This is how professionals write switches today.

// The Old Way (Statement):
// string status;
// int statusCode = 404;

// switch (statusCode)
// {
//     case 200:
//         status = "OK";
//         break;
//     case 404:
//         status = "Not Found";
//         break;
//     default:
//         status = "Unknown";
//         break;
// }

// The Modern Way (Expression):
// int statusCode = 404;

// // The switch goes AFTER the variable, and returns the result directly!
// string status = statusCode switch
// {
//     200 => "OK",
//     404 => "Not Found",
//     _ => "Unknown" // The underscore (_) replaces the 'default' keyword
// };