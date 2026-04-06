// Problems with Non-Generic Collections in C#
// works with object data type.
// performance overhead (due to boxing and unboxing)

// solution: generic collections
// A Generic Collection is Strongly Type-Safe. Which type of data do you want to store in generic type, this information you have to provide at compile time. It means you can only put one type of data into it. This eliminates type mismatches at runtime. 

// The Generic Collection Classes are implemented under the System.Collections.Generic namespace.
// The classes which are present in this namespace are as follows.
// Stack<T>: It represents a variable size last-in-first-out (LIFO) collection of instances of the same specified type. 
// Queue<T>: It represents a first-in, first-out collection of objects. 
// HashSet<T>: It represents a set of values. It eliminates duplicate elements.
// SortedList<TKey, TValue>: It represents a collection of key/value pairs that are sorted by key based on the associated System.Collections.Generic.IComparer implementation. It automatically adds the elements in ascending order of key by default.
// List<T>: It represents a strongly typed list of objects that can be accessed by index. Provides methods to search, sort, and manipulate lists. It grows automatically as you add elements to it.
// Dictionary<TKey, Tvalue>: It represents a collection of keys and values.
// SortedSet<T>: It represents a collection of objects that are maintained in sorted order.
// SortedDictionary<TKey, TValue>: It represents a collection of key/value pairs that are sorted on the key.
// LinkedList<T>: It represents a doubly linked list.


// Why do we need Generics in C#?
// Generic is a concept that allows us to define classes and methods with placeholders.
// C# Compiler replaces these placeholders with the specified type at compile time. The concept of generics is used to create general-purpose classes and methods.

// using System;
// namespace GenericsDemo
// {
//     public class ClsMain
//     {
//         private static void Main()
//         {
//             //bool IsEqual = ClsCalculator.AreEqual<int>(10, 20);
//             //bool IsEqual = ClsCalculator.AreEqual<string>("ABC", "ABC");
//             bool IsEqual = ClsCalculator.AreEqual<double>(10.5, 20.5);
//             if (IsEqual)
//             {
//                 Console.WriteLine("Both are Equal");
//             }
//             else
//             {
//                 Console.WriteLine("Both are Not Equal");
//             }
//             Console.ReadKey();
//         }
//     }

//     public class ClsCalculator
//     {
//         //public static bool AreEqual(int value1, int value2)
//         //{
//         //    return value1 == value2;
//         //}

//         public static bool AreEqual<T>(T value1, T value2)
//         {
//             return value1.Equals(value2);
//         }
//     }
// }


// What are Generics in C#?
// The Generics allow us to define classes and methods which are decoupled from the data type.
// the Generics allow us to create classes using angular brackets specifying the data type of its members.
// At compilation time, these angular brackets are going to be replaced with some specific data types.

// In C#, the Generics can be applied to the following:
// Interface
// Abstract class
// Class
// Method
// Static method
// Property
// Event
// Delegates

// Advantages of Generics in C#
// It Increases the Reusability of the Code
// Generics are Type-Safe
// Generic Provides Better Performance


// How to use Generics with Class and its Members in C#?
// using System;
// namespace GenericsDemo
// {
//     //MyGenericClass is a Generic Class
//     //Here T specifies the Data Types of the class Members
//     class MyGenericClass<T>
//     {
//         //Generic variable
//         //The data type is generic i.e. T
//         private T GenericMemberVariable;

//         //Generic Constructor
//         //Constructor accepts one parameter of Generic type i.e. T
//         public MyGenericClass(T value)
//         {
//             GenericMemberVariable = value;
//         }

//         //Generic Method
//         //Method accepts one Generic type Parameter i.e. T
//         //Method return type also Generic i.e. T
//         public T GenericMethod(T GenericParameter)
//         {
//             Console.WriteLine($"Parameter type: { typeof(T).ToString()}, Value: {GenericParameter}");
//             Console.WriteLine($"Return type: {typeof(T).ToString()}, Value: {GenericMemberVariable}");
//             return GenericMemberVariable;
//         }

//         //Generic Property
//         //The data type is generic i.e. T
//         public T GenericProperty { get; set; }
//     }
// }

// namespace GenericsDemo
// {
//     class Program
//     {
//         static void Main()
//         {
//             MyGenericClass<int> integerGenericClass = new MyGenericClass<int>(10);
//             int val = integerGenericClass.GenericMethod(200);
//             Console.WriteLine(val);
//         }
//     }
// }



// Generic Constraints in C#
// Constraints in C# are nothing but validations that we can put on the generic type parameter.
// That means constraints are used to restrict the types that can be substituted for type parameters.
// It will give you a compile-time error if you try to substitute a generic type using a type that is not allowed by the specified constraints.


// Why do we need Generic Constraints in C#?
// if you want to restrict a generic class to accept only a particular type of placeholder,  then we need to use the Generic Constraints.
// So, by using Generic Constraints in C#, we can specify what type of placeholder the generic class can accept.
// If we try to instantiate a generic class with the placeholder type, that is not allowed by a constraint, then the compiler will throw a compile-time error.

// Syntax: GenericTypeName<T> where T : contraint1, constraint2

// Types of Generic Constraints in C#:
// 1. where T: struct => The type argument must be non-nullable value types such as primitive data types int, double, char, bool, float, etc. The struct constraint can’t be combined with the unmanaged constraint.
// 2. where T: class => The type argument must be a reference type. This constraint can be applied to any class (non-nullable), interface, delegate, or array type in C#.
// 3. where T: new() => The type argument must be a reference type that has a public parameterless (default) constructor.
// 4. where T: <base class name> => The type of argument must be or derive from the specified base class.
// 5. where T: <interface name> => The type argument must be or implement the specified interface. Also, multiple interface constraints can be specified.
// 6. where T: U => The type argument supplied for must be or derive from the argument supplied for U. In a nullable context, if U is a non-nullable reference type, T must be a non-nullable reference type. If U is a nullable reference type, T may be either nullable or non-nullable.


// where T: class Generic Constraint in C#
// using System;
// namespace GenericsConstraintsDemo
// {
//     public class GenericClass<T> where T : class
//     {
//         public T Message;
//         public void GenericMethod(T Param1, T Param2)
//         {
//             Console.WriteLine($"Message: {Message}");
//             Console.WriteLine($"Param1: {Param1}");
//             Console.WriteLine($"Param2: {Param2}");
//         }
//     }
// }

// GenericClass<string> stringClass = new GenericClass<string>(); // string is reference type
// GenericClass<int> intClass = new GenericClass<int>(); // throws error:  int is not reference type, its value type


// Example to understand where T: class Generic Constraint in C#
// using System;
// namespace GenericsConstraintsDemo
// {
//     public class GenericClass<T> where T : class
//     {
//         public T Message;
//         public void GenericMethod(T Param1, T Param2)
//         {
//             Console.WriteLine("hello");
//             Console.WriteLine($"Message: {Message}");
//             Console.WriteLine($"Param1: {Param1}");
//             Console.WriteLine($"Param2: {Param2}");
//         }
//     }

//     public class Employee
//     {
//         public string Name { get; set; }
//         public string Location { get; set; }
//     }

//     class Program
//     {
//         static void Main()
//         {
//             // Instantiate Generic Class with Constraint
//             GenericClass<string> stringClass = new GenericClass<string>();
//             stringClass.Message = "Welcome to DotNetTutorials";
//             stringClass.GenericMethod("Anurag Mohanty", "Bhubaneswar");

//             GenericClass<Employee> EmployeeClass = new GenericClass<Employee>();
//             Employee emp1 = new Employee() { Name = "Anurag", Location = "Bhubaneswar" };
//             Employee emp2 = new Employee() { Name = "Mohanty", Location = "Cuttack" };
//             Employee emp3 = new Employee() { Name = "Sambit", Location = "Delhi" };
//             EmployeeClass.Message = emp1;
//             EmployeeClass.GenericMethod(emp2, emp3);

//             // The following statement will giveCompile Time Error as int is a value type, not reference type
//             //GenericClass<int> intClass = new GenericClass<int>();  
//         }
//     }
// }



// where T: struct Generic Constraint in C#
// If you want the type argument to accept only the value type then you need to use where T: struct constraints in C#.
// the type argument must be non-nullable value types such as int, double, char, bool, float, etc.
// The struct constraint can’t be combined with the unmanaged constraint

// using System;
// namespace GenericsConstraintsDemo
// {
//     public class GenericClass<T> where T : struct
//     {
//         public T Message;
//         public void GenericMethod(T Param1, T Param2)
//         {
//             Console.WriteLine($"Message: {Message}");
//             Console.WriteLine($"Param1: {Param1}");
//             Console.WriteLine($"Param2: {Param2}");
//         }
//     }
// }

// Let us create an instance of GenericClass by passing value-type arguments as follows.
// GenericClass<int> intClass = new GenericClass<int>();

// The following statement will give you a compile-time error as the string is a reference type, not a value type.
// GenericClass<string> stringClass = new GenericClass<string>();


// Example to understand where T: struct Generics Constraint in C#
// using System;
// namespace GenericsConstraintsDemo
// {
//     public class GenericClass<T> where T : struct
//     {
//         public T Message;
//         public void GenericMethod(T Param1, T Param2)
//         {
//             Console.WriteLine($"Message: {Message}");
//             Console.WriteLine($"Param1: {Param1}");
//             Console.WriteLine($"Param2: {Param2}");
//         }
//     }

//     public class Employee
//     {
//         public string Name { get; set; }
//         public string Location { get; set; }
//     }

//     public class Program
//     {
//         static void Main()
//         {
//             // Instantiate Generic Class with Constraint
//             GenericClass<int> intClass = new GenericClass<int>();
//             intClass.Message = 30;
//             intClass.GenericMethod(10, 20);

//             //Compile Time Error as string is not a value type, it is a reference type
//             //GenericClass<string> stringClass = new GenericClass<string>();

//             //Compile Time Error as Employee is not a value type, it is a reference type
//             //GenericClass<Employee> EmployeeClass = new GenericClass<Employee>();
//         }
//     }
// }


// where T: new() Generic Constraint in C#
// The type argument must be a reference type that has a public parameterless (default) constructor.
// with the help of the new() constraint, we can only specify types which has a parameterless constructor.

// using System;
// namespace GenericsDemo
// {
//     public class GenericClass<T> where T : new()
//     {
//         public T Message;
//         public void GenericMethod(T Param1, T Param2)
//         {
//             Console.WriteLine($"Message: {Message}");
//             Console.WriteLine($"Param1: {Param1}");
//             Console.WriteLine($"Param2: {Param2}");
//         }
//     }
// }

// namespace GenericsDemo
// {
//     public class Employee
//     {
//         public string Name { get; set; }
//         public string Location { get; set; }
//     }
//     public class Customer
//     {
//         public string Name { get; set; }
//         public string Location { get; set; }
//         public Customer(string customerName, string customerLocation)
//         {
//             Name = customerName;
//             Location = customerLocation;
//         }
//     }
// }

// Now, Let us create an instance of GenericClass bypassing Employee type arguments as follows.
// GenericClass<Employee> employee = new GenericClass<Employee>();

// The following statement will give you a compile-time error as the Customer class has a Parameterized constructor or you can say the Customer class does not have a default parameterless constructor.
// GenericClass<Customer> customer = new GenericClass<Customer>();



// Example to understand where T: new() Generic Constraint in C#
// using System;
// namespace GenericsDemo
// {
//     public class GenericClass<T> where T : new()
//     {
//         public T Message;
//         public void GenericMethod(T Param1, T Param2)
//         {
//             Console.WriteLine($"Message: {Message}");
//             Console.WriteLine($"Param1: {Param1}");
//             Console.WriteLine($"Param2: {Param2}");
//         }
//     }

//     public class Employee
//     {
//         public string Name { get; set; }
//         public string Location { get; set; }
//     }

//     public class Customer
//     {
//         public string Name { get; set; }
//         public string Location { get; set; }
//         public Customer(string customerName, string customerLocation)
//         {
//             Name = customerName;
//             Location = customerLocation;
//         }
//     }

//     class Program
//     {
//         static void Main()
//         {
//             //No Error, as Emplyoee class has parameterless constructor
//             GenericClass<Employee> employee = new GenericClass<Employee>();
//             Employee emp1 = new Employee() { Name = "Anurag", Location = "Bhubaneswar" };
//             Employee emp2 = new Employee() { Name = "Mohanty", Location = "Cuttack" };
//             Employee emp3 = new Employee() { Name = "Sambit", Location = "Delhi" };

//             employee.Message = emp1;
//             employee.GenericMethod(emp2, emp3);

//             //CompileTime Error, as Customer class has Parameterized constructor
//             //GenericClass<Customer> customer = new GenericClass<Customer>();
//         }
//     }
// }



// where T: BaseClass Generic Constraint in C#
// the type of argument must be derived from the specified base class. That means in the <base class> constraint, we can only specify types that are inherited from <base class>.

// using System;
// namespace GenericsDemo
// {
//     public class GenericClass<T> where T : BaseEmployee
//     {
//         public T Message;
//         public void GenericMethod(T Param1, T Param2)
//         {
//             Console.WriteLine($"Message: {Message}");
//             Console.WriteLine($"Param1: {Param1}");
//             Console.WriteLine($"Param2: {Param2}");
//         }
//     }
// }
// // where T: BaseEmployee constraint which allows the type which is the derived class, abstract class, and interface of the BaseEmployee type.

// namespace GenericsDemo
// {
//     public class BaseEmployee
//     {
//     }

//     public class Employee : BaseEmployee
//     {
//         public string Name { get; set; }
//     }

//     public class Customer
//     {
//         public string Name { get; set; }
//     }
// }

// It works fine because Employee is derived from the BaseEmployee class.
// GenericClass<Employee> employee = new GenericClass<Employee>();

// The following statement will give you a compile-time error as the Customer class is not derived from the BaseEmployee type.
// GenericClass<Customer> customer = new GenericClass<Customer>();

// Example to understand where T: BaseClass Constraint in C# Generics
// using System;
// namespace GenericsDemo
// {
//     public class GenericClass<T> where T : BaseEmployee
//     {
//         public T Message;
//         public void GenericMethod(T Param1, T Param2)
//         {
//             Console.WriteLine($"Message: {Message}");
//             Console.WriteLine($"Param1: {Param1}");
//             Console.WriteLine($"Param2: {Param2}");
//         }
//     }
//     public class BaseEmployee
//     {
//     }
//     public class Employee : BaseEmployee
//     {
//         public string Name { get; set; }
//     }
//     public class Customer
//     {
//         public string Name { get; set; }
//     }
//     class Program
//     {
//         static void Main()
//         {
//             //No Error, as Emplyoee is a derived class of BaseEmployee class
//             GenericClass<Employee> employee = new GenericClass<Employee>();
//             Employee emp1 = new Employee() { Name = "Anurag" };
//             Employee emp2 = new Employee() { Name = "Mohanty" };
//             Employee emp3 = new Employee() { Name = "Sambit" };

//             employee.Message = emp1;
//             employee.GenericMethod(emp2, emp3);

//             //CompileTime Error, as Customer is not a derived class of BaseEmployee class
//             //GenericClass<Customer> customer = new GenericClass<Customer>(); 
//         }
//     }
// }



// where T: Interface Generic Constraint in C#
// the type argument must be or implement the specified interface. Also, multiple interface constraints can be specified.

// using System;
// namespace GenericsDemo
// {
//     public class GenericClass<T> where T : IEmployee
//     {
//         public T Message;
//         public void GenericMethod(T Param1, T Param2)
//         {
//             Console.WriteLine($"Message: {Message}");
//             Console.WriteLine($"Param1: {Param1}");
//             Console.WriteLine($"Param2: {Param2}");
//         }
//     }
// }

// namespace GenericsDemo
// {
//     public interface IEmployee
//     {
//     }

//     public class Employee : IEmployee
//     {
//         public string Name { get; set; }
//     }

//     public class Customer
//     {
//         public string Name { get; set; }
//     }
// }

// It works fine because the Employee class implements the IEmployee interface.
// GenericClass<Employee> employee = new GenericClass<Employee>();

// The following statement will give you a compile-time error as the Customer class does not implement the IEmployee interface.
// GenericClass<Customer> customer = new GenericClass<Customer>();


// Example to understand where T: Interface Constraint in C# Generics
// using System;
// namespace GenericsDemo
// {
//     public class GenericClass<T> where T : IEmployee
//     {
//         public T Message;
//         public void GenericMethod(T Param1, T Param2)
//         {
//             Console.WriteLine($"Message: {Message}");
//             Console.WriteLine($"Param1: {Param1}");
//             Console.WriteLine($"Param2: {Param2}");
//         }
//     }
//     public interface IEmployee
//     {
//     }

//     public class Employee : IEmployee
//     {
//         public string Name { get; set; }
//     }
//     public class Customer
//     {
//         public string Name { get; set; }
//     }
//     class Program
//     {
//         static void Main()
//         {
//             //No Error, as Emplyoee class Implement the IEmployee Interface
//             GenericClass<Employee> employee = new GenericClass<Employee>();
//             Employee emp1 = new Employee() { Name = "Anurag" };
//             Employee emp2 = new Employee() { Name = "Mohanty" };
//             Employee emp3 = new Employee() { Name = "Sambit" };

//             employee.Message = emp1;
//             employee.GenericMethod(emp2, emp3);

//             //CompileTime Error, as Customer is not Implement the IEmployee Interface
//             //GenericClass<Customer> customer = new GenericClass<Customer>(); 
//         }
//     }
// }



// where T: U Generic Constraint in C#
// the type argument supplied must be or derive from the argument supplied for U.
// In a nullable context, if U is a non-nullable reference type, T must be a non-nullable reference type.
// If U is a nullable reference type, T may be either nullable or non-nullable.
// U can be an interface, abstract class, or simple class. T must inherit or implements the U class.

// using System;
// namespace GenericsDemo
// {
//     public class GenericClass<T, U> where T : U
//     {
//         public T Message;
//         public void GenericMethod(T Param1, U Param2)
//         {
//             Console.WriteLine($"Message: {Message}");
//             Console.WriteLine($"Param1: {Param1}");
//             Console.WriteLine($"Param2: {Param2}");
//         }
//     }
// }

// namespace GenericsDemo
// {
//     public interface IEmployee
//     {
//     }

//     public class Employee : IEmployee
//     {
//         public string Name { get; set; }
//     }

//     public class Customer
//     {
//         public string Name { get; set; }
//     }
// }

// It works fine because the Employee class implements the IEmployee interface.
// GenericClass<Employee, IEmployee> employeeGenericClass = new GenericClass<Employee, IEmployee>();

// The following statement will give you a compile-time error as the Customer class does not implement the IEmployee interface i.e. T does not implement U.
// GenericClass<Customer, IEmployee> customerGenericClass = new GenericClass<Customer, IEmployee>();


// Example to understand where T: U constraint in C# generics
// using System;
// using System.Data;
// namespace GenericsDemo
// {
//     public class GenericClass<T, U> where T : U
//     {
//         public T Message;
//         public void GenericMethod(T Param1, U Param2)
//         {
//             Console.WriteLine($"Message: {Message}");
//             Console.WriteLine($"Param1: {Param}");
//             Console.WriteLine($"Param2: {Param2}");
//         }
//     }
//     public interface IEmployee
//     {
//     }

//     public class Employee : IEmployee
//     {
//         public string Name {get; set;}
//     }

//     public class Customer
//     {
//         public string Name {get; set;}
//     }

//     class Program
//     {
//         static void Main()
//         {
//             // No error, as Employee class Implement the IEmployee interface i.e. T Implements U
//             GenericClass<Employee, IEmployee> employeeGenericClass  = new GenericClass<Employee, IEmployee>();

//             //CompileTime Error, as Customer is not Implement the IEmployee Interface i.e. T does not Implements U
//             // GenericClass<Customer, IEmployee> customerGenericClass = new GenericClass<Customer, IEmployee>();
//         }
//     }
// }



// Multiple Generic Constraints in C#:
// it is also possible to apply multiple constraints on generic classes based on our requirements.

// using System;
// namespace GenericsDemo
// {
//     public class GenericClass<T, X> where T: class where X: struct
//     {
//         public T Message;
//         public void GenericMethod(T Param1, X Param2)
//         {
//             Console.WriteLine($"Message: {Message}");
//             Console.WriteLine($"Param1: {Param1}");
//             Console.WriteLine($"Param2: {Param2}");
//         }
//     }
   
//     class Program
//     {
//         static void Main()
//         {
//             GenericClass<string, int> multipleGenericConstraints = new GenericClass<string, int>();
//             multipleGenericConstraints.Message = "Good Morning";
//             multipleGenericConstraints.GenericMethod("Anurag", 100);
//         }
//     }
// }