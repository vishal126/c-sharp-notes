// What is a Variable in C# Language?
// A name that is given for any computer memory location is called a variable.
//  or
// variable points to a memory location

// Rules for variable declaration in C#:
// 1. A variable name must begin with a letter or underscore.
// 2. Variables in C# are case sensitive
// 3. They can be constructed with digits and letters.
// 4. No special symbols are allowed other than underscores.
// 5. sum, Height, _value, and abc123, etc. are some examples of the variable name


// How to declare a variable in C#?
// Syntax: data_type variable_name;
// Example: int age;

// How to initialize a Variable in C#?
// Syntax: data_type variable_name = value;
// Example: int age = 20;


// Types of Variables in a Class in C#:
// 1. Non-Static/Instance Variable
// 2. Static Variable
// 3. Constant Variable
// 4. Readonly Variable


// Static and Non-Static Variables in C#
// if we declare a variable inside a static block, then also that variable is a static variable
// using System;
// namespace TypesOfVariables
// {
//     internal class Program
//     {
//         static int x; //Static Variable
//         int y; //Non-Static or Instance Variable
//         static void Main(string[] args)
//         {
//             int z; //Static Variable
//         }
//     }
// }

// Now, let us try to print the value of x and y inside the Main method. Let us initialize the x value to 100 and the y value to 200. Here, you can print the value of x directly inside the Main method. But you cannot print the value of y directly inside the Main method.
// using System;
// namespace TypesOfVariables
// {
//     internal class Program
//     {
//         static int x = 100; //Static Variable
//         int y = 200; //Non-Static or Instance Variable
//         static void Main(string[] args)
//         {
//             Console.WriteLine($"x value: {x}");
//             // Console.WriteLine($"x value: {y}"); // gives error
//         }
//     }
// }

// This is because the memory for the variable y is going to be created only when we create an instance of the class Program and for each instance
// But x does not require an instance of the class. The reason is a static variable is initialized immediately once the execution of the class starts.

// In the below example, we are creating an instance of the Program class, and using that instance we are accessing the y variable. But we are accessing directly the x variable.
// using System;
// namespace TypesOfVariables
// {
//     internal class Program
//     {
//         static int x = 100; //Static Variable
//         int y = 200; //Non-Static or Instance Variable
//         static void Main(string[] args)
//         {
//             Console.WriteLine($"x value: {x}");
//             Program obj = new Program();
//             Console.WriteLine($"y value: {obj.y}");
//         }
//     }
// }


// When Static and Non-Static Variables are Initialized in C#?
// Static variables of a class are initialized immediately once the execution of the class starts,
// whereas non-static variables or instance variables are initialized only after creating the class instance as well as each and every time the instance of the class is created.

// The point we start the execution of a class to the point we end the execution of a class is called a *Life Cycle* of a class.
// In the life cycle of a class, static variables are initialized once and only one time whereas non-static or instance variables are initialized 0 times if no instance is created and n times if n instances are created.

// using System;
// namespace TypesOfVariables
// {
//     internal class Program
//     {
//         static int x = 100; //Static Variable
//         int y = 200; //Non-Static or Instance Variable
//         static void Main(string[] args)
//         {
//             Console.WriteLine($"x value: {x}");
//             Program obj1 = new Program();
//             Program obj2 = new Program();
//             Console.WriteLine($"obj1 y value: {obj1.y}");
//             Console.WriteLine($"obj2 y value: {obj2.y}");
//         }
//     }
// }

// When we are creating an instance of a class, the constructor call is there and hence we can also initialize the instance variables or non-static variables through the class constructor
// using System;
// namespace TypesOfVariables
// {
//     internal class Program
//     {
//         static int x = 100; //Static Variable
//         int y = 200; //Non-Static or Instance Variable

//         //Class Constructor
//         public Program(int a)
//         {
//             y = a;
//         }

//         static void Main(string[] args)
//         {
//             Console.WriteLine($"x value: {x}");
//             Program obj1 = new Program(300);
//             Program obj2 = new Program(400);
//             Console.WriteLine($"obj1 y value: {obj1.y}");
//             Console.WriteLine($"obj2 y value: {obj2.y}");
//         }
//     }
// }

//  can we initialize the static variable through the constructor? The answer is YES. We can initialize the static variable through the constructor. But each time we initialize, the static variable value will override with the new value.
// using System;
// namespace TypesOfVariables
// {
//     internal class Program
//     {
//         static int x = 100; //Static Variable
//         int y = 200; //Non-Static or Instance Variable

//         //Class Constructor
//         public Program(int a)
//         {
//             y = a; //Initializing non-static variable
//             x = a; //Initializing static variable
//         }

//         static void Main(string[] args)
//         {
//             Console.WriteLine($"x value: {x}"); //x = 100

//             Program obj1 = new Program(300);
//             Console.WriteLine($"obj1 y value: {obj1.y}");
//             Console.WriteLine($"x value: {x}"); //x = 300

//             Program obj2 = new Program(400); 
//             Console.WriteLine($"obj2 y value: {obj2.y}");
//             Console.WriteLine($"x value: {x}"); //x = 400
//         }
//     }
// }


// Constant Variables in C#:
// if we declare a variable by using the const keyword, then it is a constant variable and the value of the constant variable can’t be modified once after its declaration.
// it is mandatory to initialize the constant variable at the time of its declaration only.
// eg. const float PI = 3.14f;

// The behavior of a constant variable is similar to the behavior of static variables i.e. initialized once and only one time in the life cycle of the class and does not require an instance of a class either for initialization or execution
// using System;
// namespace TypesOfVariables
// {
//     internal class Program
//     {
//         const float PI = 3.14f; //Constant Variable
//         static int x = 100; //Static Variable
//         //We are going to initialize variable y through constructor
//         int y; //Non-Static or Instance Variable

//         //Constructor
//         public Program(int a)
//         {
//             //Initializing non-static variable
//             y = a; 
//         }

//         static void Main(string[] args)
//         {
//             //Accessing the static variable without instance
//             Console.WriteLine($"x value: {x}");
//             //Accessing the constant variable without instance
//             Console.WriteLine($"PI value: {PI}");

//             Program obj1 = new Program(300);
//             Program obj2 = new Program(400);
//             //Accessing Non-Static variable using instance
//             Console.WriteLine($"obj1 y value: {obj1.y}");
//             Console.WriteLine($"obj2 y value: {obj2.y}");
//         }
//     }
// }



// Read-Only Variables in C#
// When we declare a variable by using the readonly keyword, then it is known as a read-only variable and these variables can’t be modified like constants but after initialization.
// it is not mandatory to initialize a read-only variable at the time of its declaration, they can also be initialized under the constructor.
// That means we can modify the read-only variable value only within a constructor.

// In the below example, we are initializing the readonly variable through the class constructor. Now, the constructor takes two parameters. The first parameter will initialize the non-static variable and the second parameter will initialize the readonly variable. So, while creating the instance, we need to pass two integer values to the constructor function.
// using System;
// namespace TypesOfVariables
// {
//     internal class Program
//     {
//         const float PI = 3.14f; //Constant Variable
//         static int x = 100; //Static Variable
//         //We are going to initialize variable y through constructor
//         int y; //Non-Static or Instance Variable
//         readonly int z; //Readonly Variable

//         //Constructor
//         public Program(int a, int b)
//         {
//             //Initializing non-static variable
//             y = a;
//             //Initializing Readonly variable
//             z = b;
//         }

//         static void Main(string[] args)
//         {
//             //Accessing the static variable without instance
//             Console.WriteLine($"x value: {x}");
//             //Accessing the constant variable without instance
//             Console.WriteLine($"PI value: {PI}");

//             Program obj1 = new Program(300, 45);
//             Program obj2 = new Program(400, 55);
//             //Accessing Non-Static variable using instance
//             Console.WriteLine($"obj1 y value: {obj1.y} and Readonly z value: {obj1.z}");
//             Console.WriteLine($"obj2 y value: {obj2.y} and Readonly z value: {obj2.z}");
//         }
//     }
// }


// Difference Between Non-Static and Readonly in C#:
// The only difference between a non-static and readonly variable is that after initialization, you can modify the non-static variable value but you cannot modify the readonly variable value.
// using System;
// namespace TypesOfVariables
// {
//     internal class Program
//     {
//         const float PI = 3.14f; //Constant Variable
//         static int x = 100; //Static Variable
//         //We are going to initialize variable y through constructor
//         int y; //Non-Static or Instance Variable
//         readonly int z; //Readonly Variable

//         //Constructor
//         public Program(int a, int b)
//         {
//             //Initializing non-static variable
//             y = a;
//             //Initializing Readonly variable
//             z = b;
//         }

//         static void Main(string[] args)
//         {
//             //Accessing the static variable without instance
//             Console.WriteLine($"x value: {x}");
//             //Accessing the constant variable without instance
//             Console.WriteLine($"PI value: {PI}");

//             Program obj1 = new Program(300, 45);
//             //Accessing Non-Static variable using instance
//             Console.WriteLine($"obj1 y value: {obj1.y} and Readonly z value: {obj1.z}");

//             obj1.y = 500; //Modifying Non-Static Variable
//             obj1.z = 400; //Trying to Modify Readonly Variable, Getting Error
//         }
//     }
// }



// Local Variables in C#:
// The Local Variables in C# are declared inside the method of a class. The scope of the local variable is limited to the method, which means you cannot access it from outside the method. The initialization of the local variable is mandatory.
// 1. Scope of the Local Variables: Within the block in which it is declared.
// 2. The lifetime of the Local Variable: Until the control leaves the block in which it is declared.

// using System;
// namespace TypesOfVariables
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//         }

//         public void NonStaticBlock()
//         {
//             //By Default, every local variable is going to be non-static
//             //The Scope is limited to this method only
//             int x = 100;
//         }

//         public static void StaticBlock()
//         {
//             //By Default, every local variable is going to be static
//             //The Scope is limited to this method only
//             int y = 100;
//         }
//     }
// }




// Advance:
// Where do they live?
// Local Variables: Live on the Stack. They are incredibly fast to access, but the moment the method finishes executing, the memory is instantly destroyed.
// Instance (Non-Static) Variables: Live on the Heap. Every time you type the new keyword (e.g., Program obj = new Program();), the CLR carves out a brand new block of Heap memory for that specific object's variables.
// Static Variables: Live in a special, highly protected area of the Heap called the High-Frequency Heap. They are created the moment the application starts and never die until the application completely shuts down.


// Memory Leaks and Assembly Traps
// The Static Memory Leak
// Because static variables live forever, they are the number one cause of memory leaks in C#.
// The Trap: If you create a static List<string> LoggedInUsers and keep adding to it every time someone visits your website, that list will grow infinitely in the RAM. The Garbage Collector is strictly forbidden from cleaning up static variables. Eventually, your server will run out of memory and crash.

// The const Compilation Trap (DLL Hell Part 2)
// The article states that const cannot be changed after declaration, but the hidden danger is when that value is baked into your code
// The Trap: const is evaluated at Compile Time. If you have a const double TaxRate = 0.05; in a Math.dll file, and another application uses it, the compiler literally hardcodes 0.05 into the other application's execution code. If the government changes the tax rate to 0.07, updating the Math.dll is not enough! You have to fully recompile every single application that ever referenced it.
// The Senior Fix: Enterprise developers almost never use public const. They use public static readonly. Because readonly is evaluated at Runtime, you only have to update the .dll, and all other applications will instantly pick up the new value the next time they run!

// The "Definite Assignment" Rule for Local Variables
// The article notes that instance and static variables get default values (like 0 for int).
// The Trap: C# does not give default values to Local Variables (variables inside a method).
// If you write:
// static void Main()
// {
//     int myNumber;
//     Console.WriteLine(myNumber); // FATAL COMPILER ERROR!
// }