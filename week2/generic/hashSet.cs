// What is HashSet<T> in C#?
// It is an unordered collection of unique elements.
// It does not allow for the addition of duplicate elements.


// Creating a hash set
// using System.Collections.Generic;
// HashSet<Type_of_hashset> hashSet = new HashSet<Type_of_hashset>();HashSet<Type_of_hashset> hashSet = new HashSet<Type_of_hashset>();


// How to Add Elements into a HashSet Collection in C#?
// Add(T item)

// HashSet<string> hashSetCountries = new HashSet<string>();
// hashSetCountries.Add(“INDIA”);
// hashSetCountries.Add(“USA”);
// hashSetCountries.Add(“UK”);

// Adding Duplicate Elements: Now, if you add duplicate elements into the collection then you will get any compile time error

// HashSet<string> hashSetCountries = new HashSet<string>
// {
//        “INDIA”,
//         “USA”,
//         “UK”
// };


// How to Access a Generic HashSet<T> Collection in C#?
// foreach (var item in hashSetCountries)
// {
//        Console.WriteLine(item);
// }

// Note: You cannot use a for loop to access the elements of a generic HashSet collection and the reason for this is the Generic HashSet collection class does not have any integer indexer.


// Example to Understand How to Create a HashSet and Add Elements in C#:
// using System;
// using System.Collections.Generic;
// namespace GenericHashSetDemo
// {
//     class Program
//     {
//         static void Main()
//         {
//             //Creating HashSet
//             HashSet<string> hashSetCountries = new HashSet<string>();

//             //Adding Elements to HashSet using Add Method
//             hashSetCountries.Add("INDIA");
//             hashSetCountries.Add("USA");
//             hashSetCountries.Add("UK");

//             //Adding Duplicate Elements will not give compile time error
//             //But duplicate elements are simply ignored and will not be added into the collection
//             hashSetCountries.Add("UK");
//             hashSetCountries.Add("INDIA");

//             // or
//             // HashSet<string> hashSetCountries = new HashSet<string>
//             // {
//             //     //Adding Elements to HashSet using Add Method
//             //     "INDIA",
//             //     "USA",
//             //     "UK",
//             //     //Adding Duplicate Elements will not give compile time error
//             //     //But duplicate elements are simply ignored and will not be added into the collection
//             //     "UK",
//             //     "INDIA"
//             // };

//             Console.WriteLine($"Elements Count: {hashSetCountries.Count}");

//             //Accessing HashSet collection using For Each Loop
//             //Here, you can observe UK and INDIA are printed once
//             Console.WriteLine($"Accessing HashSet Elements:");
//             foreach (var item in hashSetCountries)
//             {
//                 Console.WriteLine(item);
//             }
//         }
//     }
// }


// How to Remove Elements from a Generic HashSet<T> Collection in C#?
// Remove(T item)
// RemoveWhere(Predicate<T> match): This method is used to remove all elements that match the conditions defined by the specified predicate from a HashSet collection. It returns the number of elements that were removed from the HashSet collection. Here, the parameter match specifies the Predicate delegate that defines the conditions of the elements to remove.
// Clear()


// using System;
// using System.Collections.Generic;
// namespace GenericHashSetDemo
// {
//     class Program
//     {
//         static void Main()
//         {
//             //Creating HashSet and Adding Elements to HashSet using Collection Initializer 
//             HashSet<string> hashSetCountries = new HashSet<string>()
//             {
//                 "Bangladesh",
//                 "Nepal"
//             };

//             //Adding Elements to HashSet using Add Method
//             hashSetCountries.Add("INDIA");
//             hashSetCountries.Add("USA");
//             hashSetCountries.Add("UK");
            
//             Console.WriteLine($"HashSet Elements Count Before Removing: {hashSetCountries.Count}");
//             foreach (var item in hashSetCountries)
//             {
//                 Console.WriteLine(item);
//             }

//             //Removing element Bangladesh from HashSet Using Remove() method
//             hashSetCountries.Remove("Bangladesh");
//             Console.WriteLine($"\nHashSet Elements Count After Removing Bangladesh: {hashSetCountries.Count}");
//             foreach (var item in hashSetCountries)
//             {
//                 Console.WriteLine(item);
//             }

//             //Remove Element from HashSet Using RemoveWhere() method where element length is > 3
//             int NumberOfElementRemoved = hashSetCountries.RemoveWhere(x => x.Length > 3);
//             Console.WriteLine($"\nHashSet Elements Count After Removeing {NumberOfElementRemoved} Elements : {hashSetCountries.Count}");
//             foreach (var item in hashSetCountries)
//             {
//                 Console.WriteLine(item);
//             }

//             //Remove All Elements Using Clear method
//             hashSetCountries.Clear();
//             Console.WriteLine($"\nHashSet Elements Count After Clear: {hashSetCountries.Count}");
//         }
//     }
// }


// How to Check the Availability of an Element in a HashSet in C#?
// public bool Contains(T item)

// using System;
// using System.Collections.Generic;
// namespace GenericHashSetDemo
// {
//     class Program
//     {
//         static void Main()
//         {
//             //Creating HashSet 
//             HashSet<string> hashSetCountries = new HashSet<string>();
           
//             //Adding Elements to HashSet using Add Method
//             hashSetCountries.Add("INDIA");
//             hashSetCountries.Add("USA");
//             hashSetCountries.Add("UK");

//             //Checking the key using the Contains method
//             Console.WriteLine("Is INDIA Key Exists : " + hashSetCountries.Contains("INDIA"));
//             Console.WriteLine("Is NZ Key Exists : " + hashSetCountries.Contains("NZ"));
//         }
//     }
// }



// Set Operations on Generic HashSet<T> Collection Class in C#
// UnionWith(IEnumerable<T> other)
// IntersectWith(IEnumerable<T> other)
// ExceptWith(IEnumerable<T> other): This method is used to remove all elements in the specified collection from the current HashSet object.
// SymmetricExceptWith(IEnumerable<T> other): This method is used to modify the current HashSet object to contain only elements that are present either in that object or in the specified collection, but not both.


// Generic HashSet Collection with Complex Type in C#:
// using System;
// using System.Collections.Generic;
// namespace GenericHashSetDemo
// {
//     class Program
//     {
//         static void Main()
//         { 
//             HashSet<Student> hashSetStudents = new HashSet<Student>()
//             {
//                 new Student(){ ID = 101, Name ="Anurag", Branch="CSE"},
//                 //Adding Duplicate Element
//                 new Student(){ ID = 101, Name ="Anurag", Branch="CSE"},
//                 new Student(){ ID = 102, Name ="Mohanty", Branch="CSE"},
//                 new Student(){ ID = 103, Name ="Sambit", Branch="ETC"}
//             };

//             Console.WriteLine("HashSet Students List");
//             foreach (var item in hashSetStudents)
//             {
//                 Console.WriteLine($"ID: {item.ID}, Name: {item.Name}, Branch: {item.Branch}");
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

// We have already discussed that the Generic HashSet<T> Collection Class in C# will not allow duplicates into the collection. But if you observe our output, still we are having duplicate records.
// To overcome this drawback, we need to implement the IEquatable interface, override Equals, and GetHashCode methods as shown below.
// Here, we want to check the duplicate elements based on the ID property and hence we are using the ID property inside the Equals and GetHashCode methods.

// What is IEquatable<T> Interface?
// This Interface provides one method called Equals and this method is used for determining the equality of instances.


// using System;
// using System.Collections.Generic;
// namespace GenericHashSetDemo
// {
//     class Program
//     {
//         static void Main()
//         {
//             HashSet<Student> hashSetStudents = new HashSet<Student>()
//             {
//                 new Student(){ ID = 101, Name ="Anurag", Branch="CSE"},

//                 //Adding Duplicate Element
//                 new Student(){ ID = 101, Name ="Anurag", Branch="CSE"},
//                 new Student(){ ID = 102, Name ="Mohanty", Branch="CSE"},
//                 new Student(){ ID = 103, Name ="Sambit", Branch="ETC"}
//             };

//             Console.WriteLine("HashSet Students List");
//             foreach (var item in hashSetStudents)
//             {
//                 Console.WriteLine($"ID: {item.ID}, Name: {item.Name}, Branch: {item.Branch}");
//             }
//         }
//     }

//     public class Student : IEquatable<Student>
//     {
//         public int ID { get; set; }
//         public string Name { get; set; }
//         public string Branch { get; set; }

//         public bool Equals(Student other)
//         {
//             return this.ID.Equals(other.ID);
//         }
//         public override int GetHashCode()
//         {
//             return this.ID.GetHashCode();
//         }
//     }
// }



// Note: While the average time complexity for accessing an element in an array is O(n), where n represents the number of elements in the array, the complexity is just O(1) for accessing a particular element in a HashSet. This makes HashSet a good choice for fast searches and for performing set operations. You can use a list if you would like to store a collection of items in a certain order, and maybe include duplicates as well.



// Getting an Enumerator that Iterates through HashSet<T> Collection in C#:
// The HashSet<T>.GetEnumerator Method is used to get an enumerator that iterates through a HashSet object. It returns a HashSet<T>.Enumerator object for the HashSet<T> object.

// using System;
// using System.Collections.Generic;
// namespace GenericsDemo
// {
//     class Program
//     {
//         static void Main()
//         {
//             //Creating HashSet 
//             HashSet<string> hashSetCountries1 = new HashSet<string>();

//             //Adding Elements to HashSet using Add Method
//             hashSetCountries1.Add("IND");
//             hashSetCountries1.Add("USA");
//             hashSetCountries1.Add("UK");
//             hashSetCountries1.Add("NZ");
//             hashSetCountries1.Add("BAN");

//             HashSet<string>.Enumerator em = hashSetCountries1.GetEnumerator();
//             while (em.MoveNext())
//             {
//                 string val = em.Current;
//                 Console.WriteLine(val);
//             }
//         }
//     }
// }



