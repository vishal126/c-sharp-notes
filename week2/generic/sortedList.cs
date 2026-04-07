// What is SortedList<TKey, TValue> in C#?
// The Generic SortedList<TKey, TValue> Collection Class in C# represents a collection of key/value pairs that are sorted by the keys based on the associated IComparer implementation.
// By default, it sorts the key/value pairs in ascending order.
// The generic SortedList collection can be accessible either by using the keys or by using the integral index. 

// The SortedList<TKey, TValue> Collection allows us to store duplicate values, but the keys must be unique and cannot be null.


// How to Create a SortedList<TKey, TValue> collection in C#?
// using System.Collections.Generic;
// SortedList<TKey, TValue> sortedListName = new SortedList<TKey, TValue>();


// How to Add Elements into a Generic SortedList Collection in C#?
// Add(TKey key, TValue value)

// SortedList<int, string> genericSortedList = new SortedList<int, string>();
// genericSortedList.Add(1, “One”);
// genericSortedList.Add(3, “Three”);
// genericSortedList.Add(2, “Two”);


// SortedList<int, string> genericSortedList = new SortedList<int, string>
// {
//         { 1, “One”},
//         { 3, “Three”},
//         { 2, “Two”}
// };



// How to Access a Generic SortedList Collection in C#?
// Using for loop to access Generic SortedList Collection in C#:
// for (int i = 0; i < genericSortedList.Count; i++)
// {
//          Console.WriteLine(“Keys : ” + genericSortedList.Keys[i] + “\tValues : ” + genericSortedList.Values[i]);
// }

// Using Index to Access Generic SortedList Collection in C#:
// Console.WriteLine($”Value of Key 2 is:{ genericSortedList[2]}”);
// string val = (string)genericSortedList[3];
// Console.WriteLine(val);

// Using for-each loop to access Generic SortedList Collection in C#:
// foreach (KeyValuePair<int, string> item in genericSortedList)
// {
//          Console.WriteLine($”Key: { item.Key}, Value: { item.Value}”);
// }


// Example to Understand How to Create a Generic SortedList Collection and Add Elements in C#:
// using System;
// using System.Collections.Generic;
// namespace GenericSortedListDemo
// {
//     class Program
//     {
//         static void Main()
//         {
//             //Creating Generic SortedList Collection
//             SortedList<int, string> genericSortedList = new SortedList<int, string>();

//             //Adding Elements to SortedList Collection using Add Method in Random Order
//             genericSortedList.Add(1, "One");
//             genericSortedList.Add(5, "Five");
//             genericSortedList.Add(4, "Four");
//             genericSortedList.Add(2, "Two");
//             genericSortedList.Add(3, "Three");

//             //You cannot pass null as a key
//             //genericSortedList.Add(null, "Ten"); //Compile-Time Error

//             //Duplicate Key not allowed
//             //System.ArgumentException: 'An entry with the same key already exists.'
//             //genericSortedList.Add(2, "Any Value");

//              // Creating Generic SortedList Collection using Collection Initializer
//              SortedList<int, string> genericSortedList = new SortedList<int, string>
//              {
//                  { 1, "One" },
//                  { 5, "Five" },
//                  { 4, "Four" },
//                  { 2, "Two" },
//                  { 3, "Three" }
//              };

//             //Accessing Generic SortedList Collection using For loop
//             Console.WriteLine("Accessing Generic SortedList using For loop");
//             for (int i = 0; i < genericSortedList.Count; i++)
//             {
//                 Console.WriteLine("Keys : " + genericSortedList.Keys[i] + "\tValues : " + genericSortedList.Values[i]);
//             }

//             //Accessing Generic SortedList Collection using For Each loop
//             Console.WriteLine("\nAccessing SortedList using For Each loop");
//             foreach (KeyValuePair<int, string> item in genericSortedList)
//             {
//                 Console.WriteLine($"Key: { item.Key}, Value: { item.Value}");
//             }

//             //Accessing Generic SortedList Individual Elements using Keys
//             Console.WriteLine("\nAccessing SortedList Individual Elements using Keys");
//             Console.WriteLine($"Key: 1, Value: {genericSortedList[1]}");
//             Console.WriteLine($"Key: 2, Value: {genericSortedList[2]}");
//             Console.WriteLine($"Key: 3, Value: {genericSortedList[3]}");
//         }
//     }
// }


// How to Remove Elements from a Generic SortedList Collection in C#?
// Remove(TKey key)
// RemoveAt(int index)
// Clear()


// using System;
// using System.Collections.Generic;
// namespace GenericSortedListDemo
// {
//     class Program
//     {
//         static void Main()
//         {
//             //Creating a Generic SortedList Collection Object
//             //Here both the keys and values are of string type
//             SortedList<string, string> genericSortedList = new SortedList<string, string>();

//             //Adding Elements to Generic SortedList Collection using Add Method
//             genericSortedList.Add("Ind", "India");
//             genericSortedList.Add("USA", "United State of America");
//             genericSortedList.Add("SA", "South Africa");
//             genericSortedList.Add("PAK", "Pakistan");

//             //Accessing Generic SortedList Collection using For Each loop
//             Console.WriteLine($"SortedList Elements Count={genericSortedList.Count}, Capacity:{genericSortedList.Capacity}"); 
//             foreach (KeyValuePair<string, string> item in genericSortedList)
//             {
//                 Console.WriteLine($"Key: { item.Key}, Value: { item.Value}");
//             }

//             // Remove value having key PAK Using Remove() method
//             genericSortedList.Remove("PAK");
//             Console.WriteLine($"\nSortedList Elements After Remove Method Count={genericSortedList.Count}, Capacity:{genericSortedList.Capacity}");
//             foreach (KeyValuePair<string, string> item in genericSortedList)
//             {
//                 Console.WriteLine($"Key: { item.Key}, Value: { item.Value}");
//             }

//             // Remove element at index 1 Using RemoveAt() method
//             genericSortedList.RemoveAt(1);
//             Console.WriteLine($"\nSortedList Elements After RemoveAT Method Count={genericSortedList.Count}, Capacity:{genericSortedList.Capacity}");
//             foreach (KeyValuePair<string, string> item in genericSortedList)
//             {
//                 Console.WriteLine($"Key: { item.Key}, Value: { item.Value}");
//             }

//             // Remove all key/value pairs Using Clear method
//             genericSortedList.Clear();
//             Console.WriteLine($"After Clear Method Count={genericSortedList.Count}, Capacity:{genericSortedList.Capacity}");
//         }
//     }
// }



// How to check the Availability of key/value Pairs in a Generic SortedList Collection in C#?
// ContainsKey(TKey key)
// ContainsValue(TValue value)

// using System;
// using System.Collections.Generic;
// namespace GenericSortedListDemo
// {
//     class Program
//     {
//         static void Main()
//         {
//             //Creating a Generic SortedList Collection Object
//             //Here both the keys and values are of string type
//             SortedList<string, string> genericSortedList = new SortedList<string, string>
//             {
//                 { "Ind", "India" },
//                 { "USA", "United State of America" },
//                 { "SA", "South Africa" },
//                 { "PAK", "Pakistan" }
//             };

//             //Accessing Generic SortedList Collection using For Each loop
//             Console.WriteLine("Generic SortedList Elements"); 
//             foreach (KeyValuePair<string, string> item in genericSortedList)
//             {
//                 Console.WriteLine($"Key: { item.Key}, Value: { item.Value}");
//             }

//             //Checking the key using the ContainsKey methid
//             Console.WriteLine("\nIs Ind Key Exists : " + genericSortedList.ContainsKey("Ind"));
//             Console.WriteLine("Is NZ Key Exists : " + genericSortedList.ContainsKey("NZ"));
//             //Checking the value using the ContainsValue method
//             Console.WriteLine("\nIs India value Exists : " + genericSortedList.ContainsValue("India"));
//             Console.WriteLine("Is Bangladesh value Exists : " + genericSortedList.ContainsValue("Bangladesh"));
//         }
//     }
// }



// Generic SortedList Collection with Complex Type in C#:
// using System;
// using System.Collections.Generic;
// namespace GenericsDemo
// {
//     class Program
//     {
//         static void Main()
//         {
//             //Here we are creating a sortedlist whose key is int and value is Student
//             SortedList<int, Student> genericSortedList = new SortedList<int, Student>
//             {
//                 { 101, new Student(){ ID = 101, Name ="Anurag", Branch="CSE"} },
//                 { 102, new Student(){ ID = 102, Name ="Mohanty", Branch="CSE"}},
//                 { 103, new Student(){ ID = 103, Name ="Sambit", Branch="ETC"}}
//             };

//             //The following Statement will give you Runtime Exception as the key is already exists
//             //genericSortedList.Add(101, new Student() { ID = 101, Name = "Anurag", Branch = "CSE" });

//             //Accessing Generic SortedList Collection using For Each loop
//             Console.WriteLine("Generic SortedList Elements"); 
//             foreach (KeyValuePair<int, Student> item in genericSortedList)
//             {
//                 Console.WriteLine($"Key: { item.Key}: ID: { item.Value.ID}, Name: { item.Value.Name}, Branch: { item.Value.Branch}");
//             }
//         }
//     }

//     public class Student
//     {
//         public int ID { get; set; }
//         public string Name { get; set; }
//         public string Branch { get; set; }
//     }
// }



// Properties:
// Count
// Comparer
// Capacity
// Keys
// Values

// using System;
// using System.Collections.Generic;
// namespace GenericsDemo
// {
//     class Program
//     {
//         static void Main()
//         {
//             SortedList<string, string> genericSortedList = new SortedList<string, string>
//             {
//                 { "Ind", "India" },
//                 { "USA", "United State of America" },
//                 { "SA", "South Africa" },
//                 { "PAK", "Pakistan" }
//             };

//             Console.WriteLine($"Count Property : {genericSortedList.Count}");
//             Console.WriteLine($"Comparer Property : {genericSortedList.Comparer}");
//             Console.WriteLine($"Capacity Property : {genericSortedList.Capacity}");

//             Console.WriteLine("\nKeys Property");
//             foreach (var item in genericSortedList.Keys)
//             {
//                 Console.WriteLine(item);
//             }

//             Console.WriteLine("\nValues Property");
//             foreach (var item in genericSortedList.Values)
//             {
//                 Console.WriteLine(item);
//             }
//         }
//     }
// }