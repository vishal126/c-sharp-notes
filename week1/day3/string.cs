// What is a String?
// The string is an object of the String class that represents a sequence of characters.
// We can perform many operations on strings such as concatenation, comparison, getting substring, search, trim, replacement, etc.
// strings are immutable

// What are the Differences between "String"(Capital) vs "string"(small) in C#?
// string str1 = "";
// String str2 = "";

// The small string is actually an alias of String (Capital string).

// as per the naming convention when you are creating a variable use the small string (i.e. string) and whenever you want to invoke methods on the string then use the capital string (i.e. String), as shown below:
// string str2 = String.Concat(" ");


// Strings are Immutable in C#:
// C# strings are immutable means C# strings cannot be changed.

// Please have a look at the below image. When the first statement is executed, it will create one object and assign the value DotNet. But when the second statement is executed, it will not override the first object, it lets the first object be there for garbage collection and creates a fresh object, and assign the value Tutorials.
// string str = "Dotnet";
// str = "Tutorials";


// Example to Proves C# strings are Immutable:
// using System;
// using System.Diagnostics;

// namespace StringDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string str = "";
//             Console.WriteLine("Loop Started");
//             var stopwatch = new Stopwatch();

//             stopwatch.Start();
//             for (int i = 0; i < 30000000; i++)
//             {
//                  str = Guid.NewGuid().ToString();
//             }
//             stopwatch.Stop();

//             Console.WriteLine("Loop Ended");
//             Console.WriteLine("Loop Exceution Time in MS :" + stopwatch.ElapsedMilliseconds);
//         }
//     }
// }


// Example using Integer in C#:
// using System;
// using System.Diagnostics;

// namespace StringDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int ctr =0;
//             Console.WriteLine("Loop Started");
//             var stopwatch = new Stopwatch();

//             stopwatch.Start();
//             for (int i = 0; i < 30000000; i++)
//             {
//                 ctr = ctr + 1;
//             }
//             stopwatch.Stop();

//             Console.WriteLine("Loop Ended");
//             Console.WriteLine("Loop Exceution Time in MS :" + stopwatch.ElapsedMilliseconds);
//         }
//     }
// }


// Example: String with Same value in C#
// using System;
// using System.Diagnostics;

// namespace StringDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string str = "";
//             Console.WriteLine("Loop Started");
//             var stopwatch = new Stopwatch();

//             stopwatch.Start();
//             for (int i = 0; i < 30000000; i++)
//             {
//                 str ="DotNet Tutorials";
//             }
//             stopwatch.Stop();

//             Console.WriteLine("Loop Ended");
//             Console.WriteLine("Loop Exceution Time in MS :" + stopwatch.ElapsedMilliseconds);
//         }
//     }
// }


// String Intern in C#:
// The String Intern in C# is a process that uses the same memory location if the value is the same.
// when the loop executes for the first time, it will create a fresh object and assign the value “DotNet Tutorials” to it. When the loop executes 2nd time, before creating a fresh object, it will check whether this “DotNet Tutorials” value is already there in the memory, if yes then it simply uses that memory location else it will create a new memory location. This is nothing but C# string interning.


// StringBuilder for Concatenation in C#:
// The C# string immutability behavior can be very very dangerous when it comes to string concatenation.
// using System;
// using System.Diagnostics;

// namespace StringDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string str = "";
//             Console.WriteLine("Loop Started");
//             var stopwatch = new Stopwatch();

//             stopwatch.Start();
//             for (int i = 0; i < 30000; i++)
//             {
//                 str ="DotNet Tutorials" + str;
//             }
//             stopwatch.Stop();

//             Console.WriteLine("Loop Ended");
//             Console.WriteLine("Loop Exceution Time in MS :" + stopwatch.ElapsedMilliseconds);
//         }
//     }
// }

// The loop executes the first time, it will create a new memory location and store the value “DotNet Tutorials”. For the second time, it creates another fresh memory location (fresh object) and stores the value “DotNet Tutorials DotNet Tutorials” and the first memory location will be going for garbage collection. And the same process will continue
// In order to solve the above String Concatenation Problem in C#, the .NET Framework provides the StringBuilder class.

// using System;
// using System.Diagnostics;
// using System.Text;

// namespace StringDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             StringBuilder stringBuilder = new StringBuilder();
//             Console.WriteLine("Loop Started");
//             var stopwatch = new Stopwatch();

//             stopwatch.Start();
//             for (int i = 0; i < 30000; i++)
//             {
//                 stringBuilder.Append("DotNet Tutorials");
//             }
//             stopwatch.Stop();

//             Console.WriteLine("Loop Ended");
//             Console.WriteLine("Loop Exceution Time in MS :" + stopwatch.ElapsedMilliseconds);
//         }
//     }
// }

// every time the for loop runs it will not create fresh objects rather than it will use the same memory location i.e. the same old object which drastically improves the application performance


// Why do they make C# String Immutable?
// They made Strings Immutable for Thread Safety.
// Think of one situation where you have many threads and all the threads want to manipulate the same string object.

// In case you are new to thread safety, I strongly recommended you read the following article, where we discussed Thread and Thread Safety in detail.
// https://dotnettutorials.net/lesson/multithreading-in-csharp/

