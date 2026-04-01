// What are Access Specifiers in C#?
// Every keyword that we use such as private, public, protected, virtual, sealed, partial, abstract, static, base, etc. is called Modifiers. 
// Access Specifiers are special kinds of modifiers using which we can define the scope of a type and its members.

// Access Specifiers are used to define the scope of the type (Class, Interface, Structs, Delegate, Enum, etc.) as well as the scope of their members (Variables, Properties, Constructors, and Methods).


// Different Types of Access Specifiers in C#:
// 1. Private
// 2. Public
// 3. Protected
// 4. Internal
// 5. Protected Internal
// 6. Private Protected (C# Version 7.2 onwards)


// Access Specifiers or Access Modifiers with the Type Members:
// Access Specifiers or Access Modifiers defined the scope of the type members. That is from where we can access them and from where we cannot access them.
// 1. With the Class
// 2. Derived Class in Same Assembly
// 3. Non-Derived Class in Same Assembly
// 4. Derived Class in Other Assemblies
// 5. Non-Derived Class in Other Assemblies


// Private Access Specifier or Modifier in C# with Examples:
// When we declare a type member (variable, property, method, constructor, etc) as private, then we can access that member with the class only. From outside the class, we cannot access them.

// where we can and can't access private access specifiers
// With the Class: YES
// Derived Class in Same Assembly: NO
// Non-Derived Class in Same Assembly: NO
// Derived Class in Other Assemblies: NO
// Non-Derived Class in Other Assemblies: NO



// Public Access Specifiers or Access Modifiers in C# with Examples:
// When we declare a type member (variable, property, method, constructor, etc) as public, then we can access that member from anywhere. That means there is no restriction for public members. 

// So, the scope of the public member in C#.NET is as follows:

// With the Class: YES
// Derived Class in Same Assembly: YES
// Non-Derived Class in Same Assembly: YES
// Derived Class in Other Assemblies: YES
// Non-Derived Class in Other Assemblies: YES



// Protected Access Specifier or Access Modifier
// Protected Members in C# are available within the containing type as well as to the types that are derived from the containing type.Protected Members in C# are available within the containing type as well as to the types that are derived from the containing type
// That means protected members are available within the parent class (i.e. the containing type) as well as to the child/derived classes (classes derived from the containing type). 

// So, the scope of the protected members in C#.NET is as follows:

// With the Class: YES
// Derived Class in Same Assembly: YES
// Non-Derived Class in Same Assembly: NO
// Derived Class in Other Assemblies: YES
// Non-Derived Class in Other Assemblies: NO



// Internal Access Specifier or Access Modifier
// Whenever a member is declared with Internal Access Specifier in C#, then it is available anywhere within the containing assembly.
// It’s a compile-time error to access an internal member from outside the containing assembly.

// So, the scope of the internal members in C#.NET is as follows:

// With the Class: YES
// Derived Class in Same Assembly: YES
// Non-Derived Class in Same Assembly: YES
// Derived Class in Other Assemblies: NO
// Non-Derived Class in Other Assemblies: NO



// Protected Internal Access Specifier or Access Modifier in C#:
// Protected Internal Members in C# can be accessed anywhere within the same assembly i.e. in which it is declared or from within a derived class from another assembly.

// So, the scope of the protected internal members in C#.NET is as follows:

// With the Class: YES
// Derived Class in Same Assembly: YES
// Non-Derived Class in Same Assembly: YES
// Derived Class in Other Assemblies: YES
// Non-Derived Class in Other Assemblies: NO




// Private Protected Access Specifier or Access Modifier
// The private protected members are accessible within the class and within the derived class of the same assembly but cannot be accessed from another assembly.

// So, the scope of the private protected members in C#.NET is as follows:

// With the Class: YES
// Derived Class in Same Assembly: YES
// Non-Derived Class in Same Assembly: NO
// Derived Class in Other Assemblies: NO
// Non-Derived Class in Other Assemblies: NO



// Access Specifiers with Type in C#:
// We can use all 6 access specifiers with type members in C# but type allows only two access specifiers i.e. Internal and Public.
// It is a compile-time error to use private, protected, protected internal, and private protected access specifiers with types.

// Note: The point that you need to remember is if you want to access the class only within the same assembly, then you need to declare the class as internal and if you want to access the class from the same assembly as well as from other assemblies then you need to declare the class as public.

// Example to Understand Internal and Public Access Specifier in C# with Type:
// class1.cs
// using System;
// namespace AssemblyOne
// {
//     internal class AssemblyOneClass1
//     {
//         public int Id;
//         public void Display1()
//         {
//             Console.WriteLine(Id);
//         }
//     }
//     internal class AssemblyOneClass2 : AssemblyOneClass1
//     {
//         public void Display2()
//         {
//             Console.WriteLine(Id);
//         }
//     }

//     internal class AssemblyOneClass3
//     {
//         public void Dispplay3()
//         {
//             AssemblyOneClass1 obj = new AssemblyOneClass1();
//             Console.WriteLine(obj.Id);
//         }
//     }
// }


// Now, let us try to use the internal class from a different assembly
// Please modify the Program.cs.
//Program.cs
// using AssemblyOne;
// using System;
// namespace AccessSpecifierDemo
// {
//     public class Program
//     {
//         static void Main(string[] args)
//         {
//         }
//     }

//     //You cannot make inheritance relationship because AssemblyOneClass1 is internal
//     //Internal cannot be accessible to outside assembly
//     public class AnotherAssemblyClass1 : AssemblyOneClass1
//     {
//         public void Display4()
//         {
//         }
//     }

//     public class AnotherAssemblyClass2
//     {
//         public void Dispplay3()
//         {
//             //You cannot create an instance because AssemblyOneClass1 is not accessible
//             //to outside assembly
//             AssemblyOneClass1 obj = new AssemblyOneClass1();
//         }
//     }
// }


// Now, modify the class from internal to public in class1.cs class file as shown in the below code. Once we make the class AssemblyOneClass1 public, all the compilation errors are gone.


// What are the default Access Specifiers in C# for a Class and Class Members?
// If we don’t specify an access specifier in C# then for Class, the default access specifier is internal and for class members it is private.