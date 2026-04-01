// What are the Functions of C# Language?
// A function is a group of related instructions that performs a specific task.
// functions allow us to reuse the code without retyping the code.

// Why do we need functions?
// Functions are also called modules or procedures.

// Types of Functions in C#:
// two types of Functions
// 1. Built-in Functions: The function which is already defined in the framework and available to be used by the developer or programmer is called a built-in function
// 2. User-Defined Functions: function defined by the developer or programmer explicitly, then it is called a user-defined function.

// Advantages of Using Standard Library functions:
// 1. these functions are gone through multiple testing phases and are easy to use.
// 2. optimized for performance.
// 3. saves development time.


// Example to understand Built-in C# Functions:
// using System;
// namespace FunctionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int number = 25;
//             double squareRoot = Math.Sqrt(number);
//             Console.WriteLine($"Square Root of {number} is {squareRoot}");
//         }
//     }
// }


// What are the limitations of Pre-Defined Functions in C# Language?
// contains limited tasks only. ( i.e., for what purpose the function is designed for the same purpose it should be used.)



// What are User-Defined Functions in C# Language?
// The User-defined functions in C# are the functions that are created by the programmer so that he/she can use them many times.
// It reduces the complexity of a big program and optimizes the code.

// Advantages of User-Defined Functions in C#:
// code will be easier to understand, maintain and debug.
// write the code once, reuse many times. ( code reusability)
// program size reduced.


// **How to Create a User-Defined Function in C#?
// the function should have a name that is mandatory
// it should have a parameter list (the parameters it is taking) which is optional
// the function should have a return type which is mandatory.
// A function can have an access specifier, which is optional, and a modifier which is also optional

// <Access Specifier> [Modifier] <Return Type> <Function Name> ([Parameter List])
// {
//      //Function body/Method body
// }

// Access Specifier: it defines the accessibility of the method, such as private, protected, public, etc.
// Modifier: It is optional and defines the method’s access type. For example, static, virtual, partial, sealed, etc
// you declare the method with a static modifier, then you can access the method directly without creating an instance.
// If you declare the method with the sealed modifier, then this method is not going to be overridden under a child class.
// if you declare the method with the partial modifier, then you can split the method definition into two parts.

// eg
// public int max(int x, int y) {
//  if(x>y)
//      return x;
//  else
//      return y;
// }



// What is Function Signature in C#?
// A Method Signature is consisting of two things, i.e., the Method Name and the Parameter List.
// The return type is not considered to be a part of the method signature

// eg
// public static int Add(int a, int b)
// {
//     int sum =a+b;
//     return sum;
// }

// here the Add(int a, int b) is the method signature.


// What is Return Statement in C#?
// The return statement terminates the execution of a function immediately and returns the control to the calling function.
// Execution resumes in the calling function at the point immediately following the call.
// A return statement can also return a value to the calling function.

// How to Call a Method in C#?
// When a method is invoked (called), a request is made to perform some action.
// The code we need to invoke a method contains the name of the method to be executed and any data the receiving method requires. The required data for a method is specified in the method’s parameter list.
// When we invoke a method, the control gets transferred to the called method. Then the called method returns the control to the caller method (from where we call the method) in the following three conditions.
// 1. When the return statement is executed.
// 2. When it reaches the method ending closing curly brace.
// 3. When it throws an exception that is not handled in the called method.



// Example to Understand Functions in C# Language:
// normal code inside main
// using System;
// namespace FunctionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int x, y;
//             x = 10;
//             y = 15;
//             int sum = x + y;
//             Console.WriteLine($"Sum is {sum}");
//         }
//     }
// }

// creating function for the above code.
// using System;
// namespace FunctionDemo
// {
//     class Program
//     {
//         static void Main()
//         {
//             int x,y;
//             x=10;
//             y=20;
//             int sum = Add(x, y);

//             Console.WriteLine($"Sum is {sum}");
//         }

//         static int Add(int a, int b)
//         {
//             int sum = a+b;
//             return sum;
//         }
//     }
// }


// Different Parts of a Function in C#:
// using System;
// namespace FunctionDemo
// {
//     class Program
//     {
//         static int Add(int a, int b) // function signature or prototype
//         {                            // function definition or body
//             int sum = a+b;
//             return sum;
//         }
//         static void Main()
//         {
//             int x,y;
//             x=10;
//             y=20;
//             int sum = Add(x, y);    // Function call

//             Console.WriteLine($"Sum is {sum}");
//         }
//     }
// }


// What are the Parameters of a function?
// using System;
// namespace FunctionDemo
// {
//     class Program
//     {
//         static int Add(int a, int b) // here a & b are the formal parameters
//         {
//             int sum = a+b;
//             return sum;
//         }
//         static void Main()
//         {
//             int x,y;
//             x=10;
//             y=20;
//             int sum = Add(x, y);    // here a & b are the actual parameters

//             Console.WriteLine($"Sum is {sum}");
//         }
//     }
// }


// How does it work inside the Main memory?
// When the program starts, i.e., when the main method starts its execution, three variables (x, y, and sum) are declared inside the stack, that is, inside the activation area of the main function.
// then x & y are assigned with values 10 & 15
// then main method calls the Add method.
// now the Add method creates its own activation area inside the stack, and it will have its own variables. (a,b & sum)
// now x=10, y=15 are passed to the add function and copied to the variables a & b.
// then add method adds the 2 numbers and the result is 25 in variable sum.
// the result 25 is returned to the add method.
// the result of add method is store in sum variable of main method & printed.


// The Call Stack and Stack Overflow
// how the "Main memory" creates an activation area for variables. you need to know this is called The Call Stack.
// Think of the Call Stack like a stack of plates at a buffet.
// When your app starts, the OS puts the Main() method plate on the stack.
// If Main() calls CalculateTotal(), a new plate is placed on top of Main().
// The CPU always executes the plate at the very top.
// When CalculateTotal() hits the return statement, its plate is destroyed, its local variables are wiped from RAM, and the CPU goes back to the Main() plate right where it left off.

// The Fatal Trap: What happens if MethodA calls MethodB, and MethodB calls MethodA, creating an infinite loop of method calls?
// The computer keeps stacking plates until it runs out of physical RAM. This causes a catastrophic crash known as a StackOverflowException (yes, this is exactly where the famous website gets its name!).

// class CheckoutSystem
// {
//     // Access Modifier: public (anyone can use it)
//     // Return Type: decimal (returns money)
//     // Parameters: subtotal and taxRate
//     public decimal CalculateFinalPrice(decimal subtotal, decimal taxRate)
//     {
//         if (subtotal <= 0) 
//         {
//             return 0m; // Guard clause! We instantly exit the method.
//         }

//         decimal taxAmount = subtotal * taxRate;
//         decimal finalPrice = subtotal + taxAmount;
        
//         return finalPrice; // Hands the data back to the caller and destroys the local variables
//     }
// }