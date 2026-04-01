// User-Defined Functions in C#
// four types of user-defined functions:
// 1. Functions with No Argument and No Return Type.
// 2. Functions with Argument and No Return Type.
// 3. Functions with No Argument and with Return Type.
// 4. Functions with Argument and with Return Type

// No Arguments Passed and No Return Value Function in C#:
// When a function has no arguments, it does not receive any data from the calling function. Similarly, when it does not return a value, the calling function does not receive any data from the called function

// Example to Understand No Arguments Passed and No Return Value Function in C# Language:
// using System;
// namespace FunctionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Sum();
//         }
//         static void Sum()
//         {
//             int x = 10;
//             int y = 20;
//             int sum = x + y;
//             Console.WriteLine($"Sum of {x} and {y} is {sum}");
//         }
//     }
// }


// No Arguments Passed but Return a Value Function in C#:
// When a function has no arguments, it receives no data from the calling function but returns a value.

// Example:
// using System;
// namespace FunctionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int Result=Sum();
//             Console.WriteLine($"Sum is {Result}");
//         }
//         static int Sum()
//         {
//             int x = 10;
//             int y = 20;
//             int sum = x + y;
//             return sum;
//         }
//     }
// }



// Argument Passed but no Return Value Function in C# Language:
// When a function has arguments, it receives data from the calling function but does not return any value.

// Example:
// using System;
// namespace FunctionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int x = 10, y = 20;
//             Sum(x, y);
//         }
//         static void Sum(int x, int y)
//         {
//             int sum = x + y;
//             Console.WriteLine($"Sum is {sum}");
//         }
//     }
// }


// Argument Passed and Return Value Function in C# Language:
// A self-contained and independent function should behave like a “black box” that receives an input and outputs a value. Such functions will have two-way data communication.

// using System;
// namespace FunctionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int x = 10, y = 20;
//             int Result = Sum(x, y);
//             Console.WriteLine($"Sum is {Result}");
//         }
//         static int Sum(int x, int y)
//         {
//             int sum = x + y;
//             return sum;
//         }
//     }
// }



// What is Function Overloading in C#? (Polymorphism)
// In C#, we can write more than one function with the same name, but with a different argument or parameter list, and when we do so, it is called function overloading.

// static void main()
// {
//     int a=10, b=2,c;
// }

// static int add(int x, int y)
// {
//     return x+y;
// }

// static int add(int x, int y, int z)
// {
//     return  x+y+z;
// }

// static void main()
// {
//     int a=10, b=2, c, d;
//     c = add(a, b);
//     d = AddingNewEventArgs(a, b, c);
// }

// So when we call “add(a, b)” it will be calling add(int x, int y), and when we call ‘add(a, b, c)’ it will be “add(int x, int y, int z)”. The C# compiler can differentiate between these two functions, and this is the concept of function overloading in C#.

// using System;
// namespace FunctionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int a = 10, b = 2, c, d;
//             c = add(a, b);
//             Console.WriteLine($"Sum of {a} and {b} is {c}");
//             d = add(a, b, c);
//             Console.WriteLine($"Sum of {a} and {b} and {c} is {d}");
//         }
//         static int add(int x, int y)
//         {
//             return x + y;
//         }
//         static int add(int x, int y, int z)
//         {
//             return x + y + z;
//         }
//     }
// }


// Advantages of Function Overloading in C#
// we don't need to think of new names every time.

// Let us declare one more add function, which returns the sum of two float numbers.
// static float add(float x, float y){
//         return x + y;
// }

// if we call the add by passing the float values then it will call the above version.


// How Can Be the Parameters List Different?
// Either the data type of the parameter or the number of parameters
// eg
// int add(int, int)
// float add(float, float)
// int add(int, int, int)
// float add(int, int) -> this is invalid as the int, int parameter is exists in the 1st function as well.


// using System;
// namespace FunctionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int a = 10, b = 2, c, d;
//             c = add(a, b);
//             Console.WriteLine($"Sum of {a} and {b} is {c}");
//             d = add(a, b, c);
//             Console.WriteLine($"Sum of {a} and {b} and {c} is {d}");
//             Console.WriteLine($"Sum of 10.5 and 25.6 is {add(10.5f, 25.6f)}");
//         }
//         static int add(int x, int y)
//         {
//             return x + y;
//         }
//         static int add(int x, int y, int z)
//         {
//             return x + y + z;
//         }
//         static float add(float x, float y)
//         {
//             return x + y;
//         }
//     }
// }