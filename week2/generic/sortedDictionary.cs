// What is SortedDictionary<TKey, TValue> Collection Class in C#?
// The SortedDictionary<TKey, TValue> is a Generic Collection class in C# which is used to store the key/value pairs in the sorted form and the sorting is done based on the key.


// How to Create a SortedDictionary<TKey, TValue> collection in C#?
// using System.Collections.Generic;
// SortedDictionary<TKey, TValue> sortedDictionaryName = new SortedDictionary<TKey, TValue>();


// How to Add Elements into a Generic SortedDictionary Collection in C#?
// Add(TKey key, TValue value);

// SortedDictionary<int, string> genericSortedDictionary = new SortedDictionary<int, string>();
// genericSortedDictionary.Add(1, “One”);
// genericSortedDictionary.Add(3, “Three”);
// genericSortedDictionary.Add(2, “Two”);

// The following statement will give us a compile-time error as we pass the key as null.
// genericSortedDictionary.Add(null, “Four”);

// The following statement will throw a Runtime Exception as we pass the key as 2 which already exists in the collection.
// genericSortedDictionary.Add(2, “AnyValue”);


// SortedDictionary<int, string> genericSortedDictionary = new SortedDictionary<int, string>
// {
//         { 1, “One”},
//         { 3, “Three”},
//         { 2, “Two”}
// };


// How to Access a Generic SortedDictionary<TKey, TValue> Collection in C#?
// Using For-Each loop to access Generic SortedDictionary Collection in C#:
// foreach (KeyValuePair<int, string> item in genericSortedDictionary)
// {
//          Console.WriteLine($”Key: { item.Key}, Value: { item.Value}”);
// }

// Using For Loop to access Generic SortedDictionary Collection in C#:
// for (int i = 0; i < genericSortedDictionary.Count; i++)
// {
//          KeyValuePair<int, string> element = genericSortedDictionary.ElementAt(i);
//          Console.WriteLine($”Key: { element.Key}, Value: { element.Value}”);
// }

// Using Index to Access Individual SortedDictionary Collection Elements in C#:
// Console.WriteLine($”Key: 1, Value: {genericSortedDictionary[1]}”);
// Console.WriteLine($”Key: 2, Value: {genericSortedDictionary[2]}”);
// Console.WriteLine($”Key: 3, Value: {genericSortedDictionary[5]}”);


// Example to Understand How to Create a Generic SortedDictionary Collection and Add Elements in C#:
// using System;
// using System.Collections.Generic;
// using System.Linq;
// namespace GenericSortedDictionaryCollection
// {
//     public class Program
//     {
//         public static void Main()
//         {
//             //Creating Generic SortedDictionary Collection with key as integer and value as string
//             SortedDictionary<int, string> genericSortedDictionary = new SortedDictionary<int, string>();

//             //Adding Elements to SortedDictionary Collection using Add Method in Random Order
//             genericSortedDictionary.Add(1, "One");
//             genericSortedDictionary.Add(3, "Three");
//             genericSortedDictionary.Add(2, "Two");
//             genericSortedDictionary.Add(5, "Five");
//             genericSortedDictionary.Add(4, "Four");

//             //Duplicate Key not allowed, Runtime Exception
//             //System.ArgumentException: 'An entry with the same key already exists.'
//             //genericSortedDictionary.Add(2, "Any Value");

//             //Key Cannot be null: Compile Time Error
//             //genericSortedDictionary.Add(null, "Any Value");

//             //Accessing Generic SortedDictionary Collection using For Each loop
//             Console.WriteLine("Accessing SortedDictionary Collection using For Each loop");
//             foreach (var item in genericSortedDictionary)
//             {
//                 Console.WriteLine($"Key: { item.Key}, Value: { item.Value}");
//             }

//             //Accessing Generic SortedDictionary Collection using For loop
//             Console.WriteLine("\nAccessing SortedDictionary Collection using For loop");
//             for (int i = 0; i < genericSortedDictionary.Count; i++)
//             {
//                 KeyValuePair<int, string> element = genericSortedDictionary.ElementAt(i);
//                 Console.WriteLine($"Key: { element.Key}, Value: { element.Value}");
//             }
            
//             //Accessing SortedDictionary Collection Individual Elements using Key as Indexer
//             Console.WriteLine("\nAccessing SortedList Individual Elements using Key as Indexer");
//             Console.WriteLine($"Key: 1, Value: {genericSortedDictionary[1]}");
//             Console.WriteLine($"Key: 2, Value: {genericSortedDictionary[2]}");
//             Console.WriteLine($"Key: 5, Value: {genericSortedDictionary[5]}");
//         }
//     }
// }


// How to Remove Elements from a Generic SortedDictionary Collection in C#?
// Remove(TKey key)
// Clear()


// How to check the Availability of key/value Pairs in a Generic SortedDictionary Collection in C#?
// ContainsKey(TKey key)
// ContainsValue(TValue value)


// How to Assign Values to a SortedDictionary<TKey, TValue> with Indexer in C#?
// genericSortedDictionary[key] = value;


// Using Enumerator to Iterates through SortedDictionary<TKey, TValue> Collection in C#:
// Syntax: public System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator GetEnumerator();

// using System;
// using System.Collections;
// using System.Collections.Generic;
// namespace GenericSortedDictionaryCollection
// {
//     public class Program
//     {
//         public static void Main()
//         {
//             SortedDictionary<string, string> genericSortedDictionary = new SortedDictionary<string, string>
//             {
//                 { "Ind", "India" },
//                 { "USA", "United State of America" },
//                 { "UK", "United Kingdom" }
//             };

//             // To get an IDictionaryEnumerator for the SortedDictionary
//             IDictionaryEnumerator myEnumerator = genericSortedDictionary.GetEnumerator();

//             // If MoveNext passes the end of the collection, the enumerator is positioned
//             // after the last element in the collection and MoveNext returns false.
//             while (myEnumerator.MoveNext())
//             {
//                 Console.WriteLine($"Key: {myEnumerator.Key} and Value: {myEnumerator.Value}");
//             }
//         }
//     }
// }


// Generic SortedDictionary<TKey, TValue> Collection with Complex Type in C#:
// using System;
// using System.Collections.Generic;
// namespace GenericSortedDictionaryDemo
// {
//     class Program
//     {
//         static void Main()
//         {
//             //Here we are creating a genericSortedDictionary whose key is int and value is Student
//             SortedDictionary<int, Student> genericSortedDictionary = new SortedDictionary<int, Student>
//             {
//                 { 101, new Student(){ ID = 101, Name ="Anurag", Branch="CSE"} },
//                 { 104, new Student(){ ID = 104, Name ="Pranaya", Branch="ETC"}},
//                 { 103, new Student(){ ID = 103, Name ="Sambit", Branch="ETC"}},
//                 { 102, new Student(){ ID = 102, Name ="Mohanty", Branch="CSE"}}
//             };

//             //The following Statement will give you Runtime Exception as the key is already exists
//             //System.ArgumentException: 'An entry with the same key already exists.'
//             //genericSortedDictionary.Add(101, new Student() { ID = 101, Name = "Anurag", Branch = "CSE" });

//             //Accessing Generic SortedDictionary Collection using For Each loop
//             Console.WriteLine("Generic SortedDictionary Collection Elements");
//             foreach (KeyValuePair<int, Student> item in genericSortedDictionary)
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


// What is the use of the TryGetValue() method of SortedDictionary Class in C#?

// using System;
// using System.Collections.Generic;
// namespace GenericSortedDictionaryCollection
// {
//     class Program
//     {
//         static void Main()
//         {
//             //Here we are creating a genericSortedDictionary whose key is int and value is Student
//             SortedDictionary<int, Student> genericSortedDictionary = new SortedDictionary<int, Student>
//             {
//                 { 101, new Student(){ ID = 101, Name ="Anurag", Branch="CSE"} },
//                 { 104, new Student(){ ID = 104, Name ="Pranaya", Branch="ETC"}},
//                 { 103, new Student(){ ID = 103, Name ="Sambit", Branch="ETC"}},
//                 { 102, new Student(){ ID = 102, Name ="Mohanty", Branch="CSE"}}
//             };

//             //Accessing Generic genericSortedDictionary Collection using For Each loop
//             Console.WriteLine("Generic genericSortedDictionary Elements");
//             foreach (KeyValuePair<int, Student> item in genericSortedDictionary)
//             {
//                 Console.WriteLine($"Key: { item.Key}: ID: { item.Value.ID}, Name: { item.Value.Name}, Branch: { item.Value.Branch}");
//             }

//             Student? std102;
//             if (genericSortedDictionary.TryGetValue(102, out std102))
//             {
//                 Console.WriteLine("\nStudent with Key = 102 is found in the SortedDictionary");
//                 Console.WriteLine($"ID: {std102.ID}, Name: {std102.Name}, Branch: {std102.Branch}");
//             }
//             else
//             {
//                 Console.WriteLine("\nStudent with Key = 102 is not found in the SortedDictionary");
//             }

//             Student? std115;
//             if (genericSortedDictionary.TryGetValue(105, out std115))
//             {
//                 Console.WriteLine("\nStudent with Key = 102 is found in the SortedDictionary");
//                 Console.WriteLine($"ID: {std115.ID}, Name: {std115.Name}, Branch: {std115.Branch}");
//             }
//             else
//             {
//                 Console.WriteLine("\nStudent with Key = 105 is not found in the SortedDictionary");
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


// How to Get all the Keys and Values of a SortedDictionary in C#?
// using System;
// using System.Collections.Generic;
// namespace GenericSortedDictionaryCollection
// {
//     class Program
//     {
//         static void Main()
//         {
//             //Here we are creating a genericSortedDictionary whose key is int and value is Student
//             SortedDictionary<int, Student> genericSortedDictionary = new SortedDictionary<int, Student>
//             {
//                 { 101, new Student(){ ID = 101, Name ="Anurag", Branch="CSE"} },
//                 { 104, new Student(){ ID = 104, Name ="Pranaya", Branch="ETC"}},
//                 { 103, new Student(){ ID = 103, Name ="Sambit", Branch="ETC"}},
//                 { 102, new Student(){ ID = 102, Name ="Mohanty", Branch="CSE"}}
//             };

//             Console.WriteLine("All Keys in Student SortedDictionary");
//             foreach (int key in genericSortedDictionary.Keys)
//             {
//                 Console.WriteLine(key + " ");
//             }

//             // Once you get the keys, then get the values using the keys
//             Console.WriteLine("\nAll Keys and values in Student SortedDictionary");
//             foreach (int key in genericSortedDictionary.Keys)
//             {
//                 var student = genericSortedDictionary[key];
//                 Console.WriteLine($"Key: {key}, Values = ID: {student.ID}, Name: {student.Name}, Branch: {student.Branch}");
//             }

//             //To get all the values in the dictionary use Values property
//             Console.WriteLine("\nAll Student objects in Student SortedDictionary");
//             foreach (Student student in genericSortedDictionary.Values)
//             {
//                 Console.WriteLine($"Values = ID: {student.ID}, Name: {student.Name}, Branch: {student.Branch}");
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