// Do while loop in C# Language:
// The do-while loop is a post-tested loop or exit-controlled loop i.e. first it will execute the loop body and then it will be going to test the condition.

// using System;
// namespace ControlFlowDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int number = 1;
//             do
//             {
//                 Console.Write($"{number} ");
//                 number++;
//             } while (number <= 5);
//         }
//     }
// }

// Nested Do-While Loop in C# Language:
// using System;
// namespace ControlFlowDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             do
//             {
//                 Console.WriteLine("I am from outer do-while loop");
//                 do
//                 {
//                     Console.WriteLine("I am from inner do-while loop ");
//                 }
//                 while (1 > 10);
//             }
//             while (2 > 10);
//         }
//     }
// }

// Realtime Example of Do-While Loop in C#:
// The do-while loop is mainly used in menu-driven programs where the termination condition depends upon the end-user. That means when the end user wants then the loop is going to terminate. 

using System;
namespace ControlFlowDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            char Choice;
            int MenuOption;
            int Number1, Number2;
            do
            {
                Console.WriteLine("Press 1 for Addition, 2 for Subtraction, 3 for Multiplication, 4 for Division");
                MenuOption = Convert.ToInt32(Console.ReadLine());
                switch (MenuOption)
                {
                    case 1:
                        Console.WriteLine("Enter the value of two numbers");
                        Number1 = Convert.ToInt32(Console.ReadLine());
                        Number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Sum Is {Number1 + Number2}");
                        break;
                    case 2:
                        Console.WriteLine("Enter the value of two numbers");
                        Number1 = Convert.ToInt32(Console.ReadLine());
                        Number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Difference Is {Number1 - Number2}");
                        break;
                    case 3:
                        Console.WriteLine("Enter the value of two numbers");
                        Number1 = Convert.ToInt32(Console.ReadLine());
                        Number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Multiplication Is {Number1 * Number2}");
                        break;
                    case 4:
                        Console.WriteLine("Enter the value of two numbers");
                        Number1 = Convert.ToInt32(Console.ReadLine());
                        Number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Division Is {Number1 / Number2}");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine("Please Enter Y to continue, any keys to terminate");

                Choice = Convert.ToChar(Console.ReadLine());
            }
            while (Char.ToUpper(Choice) == 'Y');
        }
    }
}