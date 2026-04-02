// Method Overloading
// Method Overloading means it is an approach to defining multiple methods under the class with a single name.
// the parameters of all those methods should be different (different in terms of number, type, and order of the parameters).

// we can create a method in the Derived/Child class with the same name as the method name defined in the Base/Parent class in C#.

// using System;
// namespace MethodOverloading
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Program obj = new Program();
//             obj.Method(); //Invoke the 1st Method
//             obj.Method(10); //Invoke the 2nd Method
//             obj.Method("Hello"); //Invoke the 3rd Method
//             obj.Method(10, "Hello"); //Invoke the 4th Method
//             obj.Method("Hello", 10); //Invoke the 5th Method
//         }

//         public void Method()
//         {
//             Console.WriteLine("1st Method");
//         }
//         public void Method(int i)
//         {
//             Console.WriteLine("2nd Method");
//         }
//         public void Method(string s)
//         {
//             Console.WriteLine("3rd Method");
//         }
//         public void Method(int i, string s)
//         {
//             Console.WriteLine("4th Method");
//         }
//         public void Method(string s, int i)
//         {
//             Console.WriteLine("5th Method");
//         }    
//     }
// }


// Why Return Type is not considered as part of Method Overloading in C#?
//  I have two methods with the same name but one method’s return type is void, and the other method’s return type is a string.
// As soon as we create the second method, the compiler itself gives the compile time error saying Type ‘Program’ already defines a member called ‘Method’ with the same parameter types.
// here we will get the ambiguity problem and see the compiler also giving the same ambiguity error The call is ambiguous between the following methods or properties: ‘Program.Method()’ and ‘Program.Method()’ while invoking the method.


// When should we Overload Methods in C#?
// The concept of Method Overloading falls under the Polymorphisms OOPs principle.
// the advantage of using Method overloading is that if we overload the methods, then the user of our application gets a comfortable feeling

// Can we Overload Methods in the Same Class?
// Yes, it is possible. No Compile Time Error, and No Runtime Error.
// Methods can be overloaded in the same or in super and sub classes because overloaded methods are different methods.
// But we can’t override a method in the same class it leads to Compile Time Error: “Method is Already Defined” because overriding methods are the same methods with a different implementation.


// What is Inheritance-Based Method Overloading in C#?
// A method that is defined in the parent class can also be overloaded under its child class. It is called Inheritance Based Method Overloading.

// using System;
// namespace MethodOverloading
// {
//     class Class1
//     {
//         public void Add(int a, int b)
//         {
//             Console.WriteLine(a + b);
//         }
//         public void Add(float x, float y)
//         {
//             Console.WriteLine(x + y);
//         }
//     }
//     class Class2 : Class1
//     {
//         public void Add(string s1, string s2)
//         {
//             Console.WriteLine(s1 +" "+ s2);
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Class2 obj = new Class2();
//             obj.Add(10, 20);
//             obj.Add(10.5f, 20.7f);
//             obj.Add("Pranaya", "Rout");
//         }
//     }
// }



// Example to Understand Constructor Method Overloading in C#
// using System;
// namespace ConstructorOverloading
// {
//     class ConstructorOverloading
//     {
//         int x, y, z;
//         public ConstructorOverloading(int x)
//         {
//             Console.WriteLine("Constructor1 Called");
//             this.x = 10;
//         }
//         public ConstructorOverloading(int x, int y)
//         {
//             Console.WriteLine("Constructor2 Called");
//             this.x = x;
//             this.y = y;
//         }
//         public ConstructorOverloading(int x, int y, int z)
//         {
//             Console.WriteLine("Constructor3 Called");
//             this.x = x;
//             this.y = y;
//             this.z = z;
//         }
//         public void Display()
//         {
//             Console.WriteLine($"X={x}, Y={y}, Z={z}");
//         }
//     }
//     class Test
//     {
//         static void Main(string[] args)
//         {
//             ConstructorOverloading obj1 = new ConstructorOverloading(10);
//             obj1.Display();
//             ConstructorOverloading obj2 = new ConstructorOverloading(10, 20);
//             obj2.Display();
//             ConstructorOverloading obj3 = new ConstructorOverloading(10, 20, 30);
//             obj3.Display();
//         }
//     }
// }


// Method Overloading Realtime Example
// logging system

// using System;
// namespace MethodOverloading
// {
//     public class Logger
//     {
//         public static void Log(string ClassName, string MethodName, string Message)
//         {
//             Console.WriteLine($"DateTime: {DateTime.Now.ToString()}, ClassName: {ClassName}, MethodName:{MethodName}, Message:{Message}");
//         }
//         public static void Log(string uniqueId, string ClassName, string MethodName, string Message)
//         {
//             Console.WriteLine($"DateTime: {DateTime.Now.ToString()}, UniqueId: {uniqueId}, ClassName: {ClassName}, MethodName:{MethodName}, Message:{Message}");
//         }
//         public static void Log(string Message)
//         {
//             Console.WriteLine($"DateTime: {DateTime.Now.ToString()}, Message: {Message}");
//         }
//         public static void Log(string ClassName, string MethodName, Exception ex)
//         {
//             Console.WriteLine($"DateTime: {DateTime.Now.ToString()}, ClassName: {ClassName}, MethodName:{MethodName}, Exception Message:{ex.Message}, \nException StackTrace: {ex.StackTrace}");
//         }

//         //You create many overloaded versions as per your business requirements
//     }
    
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string ClassName = "Program";
//             string MethodName = "Main";
//             string UniqueId = Guid.NewGuid().ToString();
//             Logger.Log(ClassName, MethodName, "Message 1");
//             Logger.Log(UniqueId, ClassName, MethodName, "Message 2");
//             Logger.Log("Message 3");

//             try
//             {
//                 int Num1 = 10, Num2 = 0;
//                 int result = Num1 / Num2;
//                 Logger.Log(UniqueId, ClassName, MethodName, "Message 4");
//             }
//             catch(Exception ex)
//             {
//                 Logger.Log(ClassName, MethodName, ex);
//             }
//         }
//     }
// }


