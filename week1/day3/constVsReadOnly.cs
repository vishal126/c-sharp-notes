// Constant Variables in C#:
// The Constants variables are the immutable values that are known at the time of program compilation and do not change their values for the lifetime of the program.
// The Read-only variables are also immutable values but these values are known at runtime and also do not change their values for the life of the program.

// Constant Variables in C#:
// const float PI = 3.14f;

// If you are not initializing the const variable at the time of its declaration, then you will get a compiler error.
// using System;
// namespace ConstDemo
// {
//     class Program
//     {
//         //we need to assign a value to the const variable
//         //at the time of const variable declaration else it will
//         //give compile time error
//         const float PI = 3.14f; //Constant Variable
//         static void Main(string[] args)
//         {
//             //Const variables are static in nature
//             //so we can access them by using class name 
//             Console.WriteLine(Program.PI);
//             //We can also access them directly within the same class
//             Console.WriteLine(PI);

//             //We can also declare a constant variable within a function
//             const int Number = 10;
//             Console.WriteLine(Number);

//             //Once after declaration we cannot change the value 
//             //of a constant variable. So, the below line gives an error
//             //Number = 20;
//         }
//     }
// }


// Points to Remember while Working with Const Variable
// 1. The keyword const is used to create a “constant” variable. It means it will create a variable whose value is never going to be changed.
// 2. Constants are static by default.
// 3. It is mandatory to initialize a constant variable at the time of its declaration.
// 4. The behavior of a constant variable is the same as the behavior of a static variable i.e. maintains only one copy in the life cycle of the class and initializes immediately once the execution of the class start (object not required)
// 5. The only difference between a static and constant variable is that the static variables can be modified whereas the constant variables in C# can’t be modified once it is declared.

// using System;
// namespace ConstDemo
// {
//     class Program
//     {
//         public const float PI = 3.14f; //Constant Variable
//         int Age = 10; //Non-Static Variable
//         static string Message = "Good Morning"; //Static Variable
//         static void Main(string[] args)
//         {
//         }
//     }
// }



// Read-Only Variables in C#
// these variables can’t be modified like constants but after initialization.
// That means it is not mandatory to initialize a read-only variable at the time of its declaration, they can also be initialized under the constructor.
// That means we can modify the read-only variable value only within a constructor.

// using System;
// namespace TypesOfVariables
// {
//     internal class Program
//     {
//         readonly int x; //Readonly Variable
//         static void Main(string[] args)
//         {
//             Program obj1 = new Program();
//             //Accessing Readonly variable using instance
//             Console.WriteLine($"{obj1.x}");
//         }
//     }
// }


// Read-only Variable Initialization at the time of its Declaration in C#
// using System;
// namespace ReadOnlyDemo
// {
//     class Program
//     {
//         readonly int number = 5;
//         static void Main(string[] args)
//         {
//             Program obj = new Program();
//             Console.WriteLine(obj.number);
//         }
//     }
// }


// Read-only Variable Initialization through Constructor in C#
// using System;
// namespace ReadOnlyDemo
// {
//     class Program
//     {
//         readonly int number = 5;

//         //You can also initialize through constructor
//         public Program()
//         {
//             number = 20;
//         }
        
//         static void Main(string[] args)
//         {
//             Program obj = new Program();
//             Console.WriteLine(obj.number);

//             //You cannot change the value of a readonly variable once it is initialized
//             //The following statement will give us compile time error 
//             //obj.number = 20;
//         }
//     }
// }


// Readonly Variables are created once per Instance:
// using System;
// namespace ReadOnlyDemo
// {
//     class Program
//     {
//         readonly int number;

//         //Initialize Readonly Variable through constructor
//         public Program(int num)
//         {
//             number = num;
//         }
        
//         static void Main(string[] args)
//         {
//             Program obj1 = new Program(100);
//             Console.WriteLine(obj1.number);

//             //You cannot change the value of a readonly variable once it is initialized
//             //The following statement will give us compile time error 
//             //obj1.number = 20;

//             Program obj2 = new Program(200);
//             Console.WriteLine(obj2.number);
//         }
//     }
// }


// Points to Remember while working with Read-Only Variable in C#:
// 1. The read-only variable’s value cannot be modified once after its initialization.
// 2. It is not mandatory or required to initialize the read-only variable at the time of its declaration like a constant. You can initialize the read-only variables under a constructor but the most important point is that once after initialization, you cannot modify the value of the readonly variable outside the constructor.
// 3. The behavior of a read-only variable is similar to the behavior of a non-static variable. That is, it maintains a separate copy for each object.  


// What is the difference between a constant and readonly variable in C#?
// The difference between a constant and readonly variable in C# is that a constant is a fixed value for the whole class whereas readonly is a fixed value specific to an instance of a class and for each instance.

// Const, Readonly, Static and Non-Static Variables Example in C#:
// using System;
// namespace ConstReadOnlyStaticNonStaticDemo
// {
//     internal class Program
//     {
//         const float PI = 3.14f; //Constant Variable
//         static int x = 100; //Static Variable
//         //We are going to initialize variable y and z through constructor
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

//             //Creating two instances
//             Program obj1 = new Program(300, 45);
//             Program obj2 = new Program(400, 55);
//             //Accessing Non-Static and Readonly variables using instance
//             Console.WriteLine($"obj1 y value: {obj1.y} and Readonly z value: {obj1.z}");
//             Console.WriteLine($"obj2 y value: {obj2.y} and Readonly z value: {obj2.z}");
//         }
//     }
// }


