// What are Extension Methods in C#?
// It allows us to add new methods into a class without editing the source code of the class
// i.e. if a class consists of a set of members in it and in the future if you want to add new methods into the class, you can add those methods without making any changes to the source code of the class.

// Note: Sometimes inheritance is not possible. That means if the class is declared using the sealed modifier, then we cannot create a derived class from the sealed. But we can extend the functionality of sealed class using the Extension Method.

// Example to Understand Extension Methods in C#:
// using System;
// namespace ExtensionMethods
// {
//     public class OldClass
//     {
//         public int x = 100;
//         public void Test1()
//         {
//             Console.WriteLine("Method one: " + this.x);
//         }
//         public void Test2()
//         {
//             Console.WriteLine("Method two: " + this.x);
//         }
//     }
// }

// // Now our requirement is to add three new methods to the class OldClass. but we don't have access to the code or not have a permission to edit it.
// // using System;
// namespace ExtensionMethods
// {
//     public static class NewClass
//     {
//         public static void Test3(this OldClass O)
//         {
//             Console.WriteLine("Method Three");
//         }
//         public static void Test4(this OldClass O, int x)
//         {
//             Console.WriteLine("Method Four: " + x);
//         }
//         public static void Test5(this OldClass O)
//         {
//             Console.WriteLine("Method Five:" + O.x);
//         }
//     }
// }

// // using System;
// namespace ExtensionMethods
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             OldClass obj = new OldClass();
//             obj.Test1();
//             obj.Test2();
//             //Calling Extension Methods
//             obj.Test3();
//             obj.Test4(10);
//             obj.Test5();
//         }
//     }
// }



// Points to remember:
// 1. Extension methods must be defined only under the static class. If you check our NewClass, then you will see that the NewClass is a static class.
// 2. Static Class in C# contains only Static Members. As an extension method is defined under a static class, it means the extension method should be created as a static method whereas once the method is bound with another class, the method changes into non-static.
// 3. The first parameter of an extension method is known as the binding parameter which should be the name of the class to which the method has to be bound and the binding parameter should be prefixed with this.
// 4. An extension method can have only one binding parameter and that should be defined in the first place on the parameter list.
// 5. an extension method can be defined with normal parameters also starting from the second place of the parameter list.


// Extension Method Real-Time Example in C#:
// As we know string is a built-in class provided by .NET Framework. That means the source code of this class is not available to us and hence we can change the source code of the string class. Also, the string is a sealed class in C# and hence we cannot create a derived class from the string class.
// Now our requirement is to add a method to the String class i.e. GetWordCount() and that method will return the number of words present in a string and we should call this method.

// StringExtension.cs
// using System.Linq;
// namespace ExtensionMethods
// {
//     public static class StringExtension
//     {
//         public static int GetWordCount(this string inputstring)
//         {
//             if (!string.IsNullOrEmpty(inputstring))
//             {
//                 //Split the string by a space
//                 string[] strArray = inputstring.Split(' ');
//                 return strArray.Count();
//             }
//             else
//             {
//                 return 0;
//             }
//         }
//     }
// }


// // using System;
// namespace ExtensionMethods
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string myWord = "Welcome to Dotnet Tutorials Extension Methods Article";
//             int wordCount = myWord.GetWordCount();
//             Console.WriteLine("string : " + myWord);
//             Console.WriteLine("Count : " + wordCount);
//         }
//     }
// }


// LINQ uses Extension Methods Effectively:
// using System;
// using System.Collections.Generic;
// using System.Linq;
// namespace SealedDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             List<int> intList = new List<int>()
//             {
//                 10, 20, 30, 40, 50
//             };

//             //If you go to the definition of Where method, then you will see that
//             //it is implemented as an extension method
//             var List1 = intList.Where(x => x > 20).ToList();
//         }
//     }
// }