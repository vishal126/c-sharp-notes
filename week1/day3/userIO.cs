// Console Class in C#
// Console class is present in the “System” namespace. So, first, we import this System namespace into our program.
//  It also converts the Bytes (from the input stream) into characters using the platform’s default charset.
// using System;
// namespace FirstProgram
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//         }
//     }
// }

// or
// namespace FirstProgram
// {
//     using System;
//     class Program
//     {
//         static void Main(string[] args)
//         {
//         }
//     }
// }


// built-in methods
// namespace System
// {
// public static class Console
// {
// public static int WindowWidth { get; set; }
// public static bool IsOutputRedirected { get; }
// public static bool IsErrorRedirected { get; }
// public static TextReader In { get; }
// public static TextWriter Out { get; }
// public static TextWriter Error { get; }

// public static void Write(decimal value);
// public static void Write(float value);
// public static void Write(double value);
// public static void WriteLine(char value);
// public static void WriteLine(bool value);
// public static void WriteLine(double value);

// public static int Read();
// public static ConsoleKeyInfo ReadKey(bool intercept);
// public static ConsoleKeyInfo ReadKey();
// public static string ReadLine();
// }
// }


// Output in C#:
// In order to print something on the console, we can use the following two methods

// System.Console.WriteLine();
// System.Console.Write();
// System is the namespace, Console is the class within the namespace System, and WriteLine and Write are static methods of the Console class.

// using System;
// namespace FirstProgram
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Prints on ");
//             Console.WriteLine("New line");

//             Console.Write("Prints on ");
//             Console.Write("Same line");
//         }
//     }
// }


// Printing Variables and Literals using WriteLine() and Write() Method in C#
// using System;
// namespace FirstProgram
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Printing Variable
//             int number = 10;
//             Console.WriteLine(number);

//             // Printing Literal
//             Console.WriteLine(50.05);
//         }
//     }
// }


// Combining two strings using the + operator and printing them in C#
// using System;
// namespace FirstProgram
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int number = 55;
//             Console.WriteLine("Hello " + "C#");
//             Console.WriteLine("Number = " + number);
//         }
//     }
// }


// Printing concatenated string using Formatted String in C#
// using System;
// namespace FirstProgram
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int number1 = 15, number2 = 20, sum;
//             sum = number1 + number2;
//             Console.WriteLine("{0} + {1} = {2}", number1, number2, sum);
//         }
//     }
// }


// User Input in C#:
// simplest method to get input from the user is by using the ReadLine() method of the Console class.
// Read() and ReadKey() are also available for getting input from the user.

// using System;
// namespace FirstProgram
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string str;
//             Console.Write("Enter a string - ");
//             str = Console.ReadLine();
//             Console.WriteLine($"You entered {str}");
//         }
//     }
// }


// Difference between ReadLine(), Read() and ReadKey() methods in C#:
// ReadLine(): The ReadLine() method of Console class in C# reads the next line of input from the standard input stream. It returns the same string.
// Read(): The Read() method of Console class in C# reads the next character from the standard input stream. It returns the ASCII value of the character.
// ReadKey(): The ReadKey() method of the Console class in C# obtains the next key pressed by the user. This method is usually used to hold the screen until the user press a key.

// using System;
// namespace FirstProgram
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int userInput;

//             Console.WriteLine("Press any key to continue...");
//             Console.ReadKey();
//             Console.WriteLine();

//             Console.Write("Input using Read() - ");
//             userInput = Console.Read();
//             Console.WriteLine("Ascii Value = {0}", userInput);
//         }
//     }
// }


// Reading Integer and floating Numbers (Numeric Values)
// we will use the same ReadLine() method we used for getting string values. But since the ReadLine() method receives the input as a string, we need to typecast it into an integer or floating-point type as per our requirement
// The simplest approach for converting user input to integer or floating-point type is by using the methods of the Convert class.

// using System;
// namespace FirstProgram
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string userInput;
//             int intVal;
//             double doubleVal;

//             Console.Write("Enter integer value: ");
//             userInput = Console.ReadLine();
//             // Converts to integer type
//             intVal = Convert.ToInt32(userInput);
//             Console.WriteLine("You entered {0}", intVal);

//             Console.Write("Enter double value: ");
//             userInput = Console.ReadLine();
//             // Converts to double type
//             doubleVal = Convert.ToDouble(userInput);
//             Console.WriteLine("You entered {0}", doubleVal);
//         }
//     }
// }

// Note: The ToInt32() and ToDouble() method of the Convert class converts the string input to integer and double type respectively. Similarly, you can convert the input to other types. If you go to the definition of Convert class, then you will find the list of convert methods as shown in the below image.

// namespace System
// {
// public static class Convert
// {
// public static bool ToBoolean (double value);
// public static byte ToByte(sbyte value);
// public static char ToChar(byte value);
// public static decimal ToDecimal (float value);
// public static double ToDouble(string value);
// public static int ToInt32(long value);
// //Many more methdos
// }
// }


// using System;
// namespace FirstProgram
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Enter integer value: ");
//             int intVal = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("You entered {0}", intVal);

//             Console.Write("Enter double value: ");
//             double doubleVal = Convert.ToDouble(Console.ReadLine());
//             Console.WriteLine("You entered {0}", doubleVal);
//         }
//     }
// }

// Hidden Passwords with ReadKey

// If you pass true into the method—Console.ReadKey(true)—it intercepts the user's keystroke without printing it to the screen. This is exactly how command-line interfaces ask you to type a password without showing the characters to anyone standing behind you!
