// What is Generic SortedSet<T> Collection in C#?
// SortedSet Collection store the elements in sorted order. That means it stores the element in ascending order and also, and it does not store duplicate elements.

// How to create a Generic SortedSet Collection in C#?
// using System.Collections.Generic;
// SortedSet<Type_of_SortedSet> sortedSet = new SortedSet<Type_of_SortedSet>();


// How to Add Elements into a SortedSet Collection in C#?
// Add(T item)

// SortedSet<int> sortedSetNumbers = new SortedSet<int>();
// hashSetCountries.Add(10);
// hashSetCountries.Add(5);
// hashSetCountries.Add(50);

// SortedSet<int> sortedSetNumbers = new SortedSet<int>
// {
//       10,
//       5,
//       50
// };


// How to Access a Generic SortedSet<T> Collection in C#?
// foreach (var item in sortedSetNumbers)
// {
//         Console.WriteLine(item);
// }

// SortedSet<int>.Enumerator em = sortedSetNumbers.GetEnumerator();
// while (em.MoveNext()) {
//       int val = em.Current;
//       Console.WriteLine(val);
// }


// Example to Understand How to Create a SortedSet Object and Add Elements in C#:
// using System;
// using System.Collections.Generic;
// namespace GenericsDemo
// {
//     class Program
//     {
//         static void Main()
//         {
//             //Creating an Instance of SortedSet class to store Integer values
//             SortedSet<int> sortedSetNumbers = new SortedSet<int>();

//             //Adding Elements to SortedSet using Add Method
//             sortedSetNumbers.Add(10);
//             sortedSetNumbers.Add(5);
//             sortedSetNumbers.Add(50);
//             sortedSetNumbers.Add(37);
//             sortedSetNumbers.Add(18);
//             sortedSetNumbers.Add(37);

//             //Accessing the SortedSet Elements using For Each Loop
//             Console.WriteLine("SortedSet Elements");
//             foreach (var item in sortedSetNumbers)
//             {
//                 Console.WriteLine(item);
//             }
//         }
//     }
// }


// How to Remove Elements from a Generic SortedSet<T> Collection in C#?
// Remove(T item)
// RemoveWhere(Predicate<T> match)
// Clear()


// How to Check the Availability of an Element in a SortedSet in C#?
// Contains(T item)


// Set Operations on Generic SortedSet<T> Collection Class in C#
// same as HashSet


// Generic SortedSet Collection with Complex Type in C#:

// we should tell how to sort the elements by implementing the IComparable interface and providing an implementation for the CompareTo method

// using System;
// using System.Collections.Generic;
// namespace GenericsDemo
// {
//     class Program
//     {
//         static void Main()
//         {
//             SortedSet<Student> sortedSetStudents = new SortedSet<Student>()
//             {
//                 new Student(){ ID = 101, Name ="Anurag", Branch="CSE"},
//                 new Student(){ ID = 101, Name ="Any Value", Branch="Any Value"},
//                 new Student(){ ID = 102, Name ="Mohanty", Branch="CSE"},
//                 new Student(){ ID = 103, Name ="Sambit", Branch="ETC"}
//             };
//             Console.WriteLine("SortedSet Students List");
//             foreach (var item in sortedSetStudents)
//             {
//                 Console.WriteLine($"ID: {item.ID}, Name: {item.Name}, Branch: {item.Branch}");
//             }
//         }
//     }

//     public class Student : IComparable<Student>
//     {
//         public int ID { get; set; }
//         public string Name { get; set; }
//         public string Branch { get; set; }

//         public int CompareTo(Student other)
//         {
//             if (this.ID > other.ID)
//             {
//                 return 1;
//             }
//             else if (this.ID < other.ID)
//             {
//                 return -1;
//             }
//             else
//             {
//                 return 0;
//             }
//         }
//     }
// }


// How to copy a list to a SortedSet in C#?
// SortedSet(IEnumerable<T> collection);


// Properties:
// Min
// Max
// Count
// Comparer


