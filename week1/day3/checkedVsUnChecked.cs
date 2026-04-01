// Checked and Unchecked Keywords
// Why do we need Checked and Unchecked Keywords in C#?
// According to MSDN, The Checked Keyword in C# is used to explicitly enable overflow checking for integral-type arithmetic operations and conversions.
// The Unchecked Keyword in C# is used to suppress overflow-checking for integral-type arithmetic operations and conversions.

// Here, overflow checking means when the value of any integral type exceeds its range, it does not raise any exception, instead it will give us unexpected or garbage results.

// using System;
// namespace CheckedUncheckedDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine(int.MaxValue);
//         }
//     }
// }

// Example Without Checked Keyword in C#:
// using System;
// namespace CheckedUncheckedDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int a = 2147483647;
//             int b= 2147483647;

//             int c = a + b;

//             Console.WriteLine(c);
//         }
//     }
// }


// above code returns -2 as it has overflow issue.

// Example to Understand Checked Keyword in C#
// we use the checked keyword, it should throw runtime exception rather than displaying -2.
// using System;
// namespace CheckedUncheckedDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int a = 2147483647;
//             int b= 2147483647;

//             int c = checked(a + b);

//             Console.WriteLine(c);
//         }
//     }
// }

// above code returns exception rather than -2


// Unchecked keyword in C#:
// The unchecked keyword behaves almost the same way as the default behavior of the compiler.

// using System;
// namespace CheckedUncheckedDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int a = 2147483647;
//             int b= 2147483647;

//             int c = unchecked(a + b);

//             Console.WriteLine(c);
//         }
//     }
// }

// above code returns -2

// the question that should come to your mind is when the default compiler works the same as the unchecked keyword then what is the exact use of it.
// using System;
// namespace CheckedUncheckedDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             const int a = 2147483647;
//             const int b= 2147483647;

//             int c = a + b;

//             Console.WriteLine(c);
//         }
//     }
// }


// As you can see in the above code that we have declared variable a and b as const int. now, when you try to compile the project, you should get the following compile-time error.(error CS0220: The operation overflows at compile time in checked mode)
// If you want to bypass this behavior then you need to use the unchecked keyword in C#.
// using System;
// namespace CheckedUncheckedDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             const int a = 2147483647;
//             const int b= 2147483647;

//             int c = unchecked(a + b);

//             Console.WriteLine(c);
//         }
//     }
// }