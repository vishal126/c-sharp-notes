// What is ArrayList in C#?
// The ArrayList in C# is a non-generic collection class that works like an array but provides the facilities such as dynamic resizing, adding, and deleting elements from the middle of a collection.
// The ArrayList in C# can be used to add unknown data i.e. when we don’t know the types of data and size of the data, then we can use ArrayList. 

// Properties:
// 1. The Elements can be added and removed from the Array List collection at any point in time.
// 2. The ArrayList is not guaranteed to be sorted.
// 3. The capacity of an ArrayList is the number of elements the ArrayList can hold.
// 4. Elements in this collection can be accessed using an integer index. Indexes in this collection are zero-based.
// 5. It allows duplicate elements.


// How to Create an ArrayList in C#?
// The ArrayList in C# provides the following three constructors which we can use to create an instance of the ArrayList class.
// 1. ArrayList(): The method is used to initialize a new instance of the ArrayList class that is empty and has the default initial capacity.
// 2. ArrayList(ICollection c): The method is used to initialize a new instance of the ArrayList class that contains elements copied from the specified collection and that have the same initial capacity as the number of elements copied.
// 3. ArrayList(int capacity): The method is used to initialize a new instance of the ArrayList class that is empty and has the specified initial capacity. The parameter capacity specifies the number of elements that the new list can initially store.

// syntax: ArrayList arrayList = new ArrayList();
// or
// var arrayList = new ArrayList();


// How to Add Elements into ArrayList in C#?
// The ArrayList non-generic class provides the Add() method which we can use to add elements to the array list or even we can use the object initializer syntax to add elements in an ArrayList.
// The most important point is that we can add multiple different types of elements in an ArrayList even though it is also possible to add duplicate elements.

// using System;
// using System.Collections;
// namespace Csharp8Features
// {
//     public class ArrayListDemo
//     {
//         public static void Main()
//         {
//             //Adding elements to ArrayList using Add() method
//             ArrayList arrayList1 = new ArrayList();
//             arrayList1.Add(101); //Adding Integer Value
//             arrayList1.Add("James"); //Adding String Value
//             arrayList1.Add("James"); //Adding Duplicate Value
//             arrayList1.Add(" "); //Adding Empty
//             arrayList1.Add(true); //Adding Boolean
//             arrayList1.Add(4.5); //Adding double
//             arrayList1.Add(null); //Adding null

//             foreach (var item in arrayList1)
//             {
//                 Console.WriteLine(item);
//             }

//             //Adding Elements to ArrayList using object initializer syntax
//             var arrayList2 = new ArrayList()
//             {
//                 102, "Smith", "Smith", true, 15.6
//             };

//             foreach (var item in arrayList2)
//             {
//                 Console.WriteLine(item);
//             }
//         }
//     }
// }


// How to Access an ArrayList in C#?
// we can access the elements of that collection by using the integer indexes.
// While adding the elements into ArrayList, it will automatically cast the elements into object types and then store them in the collection.
// So, while accessing the elements an explicit casting to the appropriate types is required, or else you can use the var variable.

// using System;
// using System.Collections;
// namespace Csharp8Features
// {
//     public class ArrayListDemo
//     {
//         public static void Main()
//         {
//             //Adding elements to ArrayList using Add() method
//             ArrayList arrayList1 = new ArrayList();
//             arrayList1.Add(101); //Adding Integer Value
//             arrayList1.Add("James"); //Adding String Value
//             arrayList1.Add(true); //Adding Boolean
//             arrayList1.Add(4.5); //Adding double

//             //Accessing individual elements from ArrayList using Indexer
//             int firstElement = (int)arrayList1[0]; //returns 101
//             string secondElement = (string)arrayList1[1]; //returns "James"
//             //int secondElement = (int) arrayList1[1]; //Error: cannot cover string to int
//             Console.WriteLine($"First Element: {firstElement}, Second Element: {secondElement}");

//             //Using var keyword without explicit casting
//             var firsItem = arrayList1[0]; //returns 101
//             var secondItem = arrayList1[1]; //returns "James"
//             //var fifthElement = arrayList1[5]; //Error: Index out of range
//             Console.WriteLine($"First Item: {firsItem}, Second Item: {secondItem}");

//             //update elements
//             arrayList1[0] = "Smith";
//             arrayList1[1] = 1010;
//             //arrayList1[5] = 500; //Error: Index out of range

//             foreach (var item in arrayList1)
//             {
//                 Console.Write($"{item} ");
//             }
//         }
//     }
// } 


// How to Iterate an ArrayList in C#?
// ArrayList non-generic collection class implements the ICollection interface.
// ICollection interface supports iteration of the collection types. So, we can either use the foreach loop and for loop to iterate a collection of type ArrayList.
// The Count property of ArrayList returns the total number of elements present in an ArrayList.

// using System;
// using System.Collections;
// namespace Csharp8Features
// {
//     public class ArrayListDemo
//     {
//         public static void Main()
//         {
//             //Adding elements to ArrayList using Add() method
//             ArrayList arrayList1 = new ArrayList();
//             arrayList1.Add(101); //Adding Integer Value
//             arrayList1.Add("James"); //Adding String Value
//             arrayList1.Add(true); //Adding Boolean
//             arrayList1.Add(4.5); //Adding double

//             //Iterating through foreach loop
//             Console.WriteLine("Using ForEach Loop");
//             foreach (var item in arrayList1)
//             {
//                 Console.Write($"{item} ");
//             }

//             //Iterating through for loop
//             Console.WriteLine("\n\nUsing For Loop");
//             for (int i = 0; i < arrayList1.Count; i++)
//             {
//                 Console.Write($"{arrayList1[i]} ");
//             }
//         }
//     }
// }



// How to Insert an Element into a Specified Position in an ArrayList Collection in C#?
// The Add method will add the element at the end of the collection.
// if you want to add the element at a specified position, then you need to use the Insert() method of the ArrayList class which will insert an element into the collection at the specified index position.
// syntax: void Insert(int index, object value);

// using System;
// using System.Collections;
// namespace Csharp8Features
// {
//     public class ArrayListDemo
//     {
//         public static void Main()
//         {
//             ArrayList arrayList = new ArrayList()
//             {
//                     101,
//                     "James",
//                     true,
//                     10.20
//             };
            
//             //Insert "First Element" at First Position i.e. Index 0
//             arrayList.Insert(0, "First Element");

//             //Insert "Third Element" at Third Position i.e. Index 2
//             arrayList.Insert(2, "Third Element");
//             // arrayList.Insert(10, "last Element"); // throws error index out of bound.
//             //Iterating through foreach loop
//             foreach (var item in arrayList)
//             {
//                 Console.WriteLine($"{item}");
//             }
//         }
//     }
// }


// we have a collection and we want to insert that collection into another collection of Array List, then we can use the InsertRange() method.
// The InsertRange() method Inserts the elements of a collection into the ArrayList at the specified index.
// syntax: void InsertRange(int index, ICollection c)
// the parameter index specifies at which location the new elements should be inserted and the parameter c specifies the Collection whose elements should be inserted into the ArrayList.
// The collection itself cannot be null, but it can contain elements that are null.

// using System;
// using System.Collections;
// namespace Csharp8Features
// {
//     public class ArrayListDemo
//     {
//         public static void Main()
//         {
//             ArrayList arrayList1 = new ArrayList()
//             {
//                     "India",
//                     "USA",
//                     "UK",
//                     "Nepal"
//             };
//             Console.WriteLine("Array List Elements");
//             foreach (var item in arrayList1)
//             {
//                 Console.Write($"{item} ");
//             }

//             ArrayList arrayList2 = new ArrayList()
//             {
//                     "Srilanka",
//                     "Japan",
//                     "Britem"
//             };
//             arrayList1.InsertRange(2, arrayList2);
            
//             Console.WriteLine("\n\nArray List Elements After InsertRange");
//             foreach (var item in arrayList1)
//             {
//                 Console.Write($"{item} ");
//             }
//         }
//     }
// }



// How to Remove Elements from ArrayList in C#?
// We can use Remove(), RemoveAt(), or RemoveRange() methods of the ArrayList class in C#.
// 1. Remove(object? obj): This method is used to remove the first occurrence of a specific object from the System.Collections.ArrayList.
// The parameter obj specifies the Object to remove from the ArrayList. The value can be null.
// 2. RemoveAt(int index): This method is used to remove the element at the specified index of the ArrayList.
// 3. RemoveRange(int index, int count): This method is used to remove a range of elements from the ArrayList.

// using System;
// using System.Collections;
// namespace Csharp8Features
// {
//     public class ArrayListDemo
//     {
//         public static void Main()
//         {
//             ArrayList arrayList = new ArrayList()
//             {
//                     "India",
//                     "USA",
//                     "UK",
//                     "Nepal",
//                     "HongKong",
//                     "Srilanka",
//                     "Japan",
//                     "Britem",
//                     "HongKong",
//             };

//             Console.WriteLine("Array List Elements");
//             foreach (var item in arrayList)
//             {
//                 Console.Write($"{item} ");
//             }

//             arrayList.Remove("HongKong"); //Removes first occurance of null
//             Console.WriteLine("\n\nArray List Elements After Removing First Occurances of HongKong");
//             foreach (var item in arrayList)
//             {
//                 Console.Write($"{item} ");
//             }

//             arrayList.RemoveAt(3); //Removes element at index postion 3, it is 0 based index
//             Console.WriteLine("\n\nArray List1 Elements After Removing Element from Index 3");
//             foreach (var item in arrayList)
//             {
//                 Console.Write($"{item} ");
//             }

//             arrayList.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)
//             Console.WriteLine("\n\nArray List Elements After Removing First Two Elements");
//             foreach (var item in arrayList)
//             {
//                 Console.Write($"{item} ");
//             }
//         }
//     }
// }


// How to Remove all the elements from the ArrayList in C#?
// We can use the Clear() method of the ArrayList class but this method doesn’t reduce the capacity of the ArrayList.

// using System;
// using System.Collections;
// namespace Csharp8Features
// {
//     public class ArrayListDemo
//     {
//         public static void Main()
//         {
//             ArrayList arrayList = new ArrayList()
//             {
//                     "India",
//                     "USA",
//                     "UK",
//                     "Denmark",
//                     "Nepal",
//             };

//             int totalItems = arrayList.Count;
//             Console.WriteLine(string.Format($"Total Items: {totalItems}, Capacity: {arrayList.Capacity}"));
//             //Remove all items from the Array list             
//             arrayList.Clear();

//             totalItems = arrayList.Count;
//             Console.WriteLine(string.Format($"Total Items After Clear(): {totalItems}, Capacity: {arrayList.Capacity}"));
//         }
//     }
// }


// How do we Check whether an Element exists in ArrayList or not in C#?
// In order to check whether an element exists or not in ArrayList, we need to use the Contains() method of the ArrayList non-generic collection class in C#.
// It returns true if exists otherwise returns false.
// syntax: bool Contains(object item)

// using System;
// using System.Collections;
// namespace Csharp8Features
// {
//     public class ArrayListDemo
//     {
//         public static void Main()
//         {
//             ArrayList arrayList = new ArrayList()
//             {
//                     "India",
//                     "UK",
//                     "Nepal",
//                     101
//             };

//             Console.WriteLine("Array List Elements");
//             foreach (var item in arrayList)
//             {
//                 Console.Write($"{item} ");
//             }

//             Console.WriteLine($"\n\nIs ArrayList Contains India: {arrayList.Contains("India")}"); // true
//             Console.WriteLine($"Is ArrayList Contains USA: {arrayList.Contains("USA")}"); // false
//             Console.WriteLine($"Is ArrayList Contains 101: {arrayList.Contains(101)}"); // true
//             Console.WriteLine($"Is ArrayList Contains 10.5: {arrayList.Contains(10.5)}"); // false
//         }
//     }
// }


// Note: It is not recommended to use the non-generic collection class ArrayList in C# due to performance issues i.e. boxing and unboxing as it is operating on the object data type.
// So, instead of using ArrayList, it is recommended to use the generic collection List<object> to store heterogeneous objects. To store data of the same data type, use Generic List<T>.

// How to Clone the Non-Generic ArrayList Collection in C#?
// If you want to clone the Non-Generic ArrayList collection in C#, then you need to use the following Clone() method provided by the ArrayList Collection Class.
// Clone(): This method is used to create and return a shallow copy of the ArrayList.

// using System;
// using System.Collections;
// namespace Csharp8Features
// {
//     public class ArrayListDemo
//     {
//         public static void Main()
//         {
//             ArrayList arrayList = new ArrayList()
//             {
//                     "India",
//                     "USA",
//                     "UK",
//                     "Denmark",
//                     "HongKong",
//             };

//             Console.WriteLine("Array List Elements:");
//             foreach (var item in arrayList)
//             {
//                 Console.WriteLine($"{item} ");
//             }

//             //Creating a clone of the arrayList using Clone method
//             ArrayList cloneArrayList = (ArrayList)arrayList.Clone();
//             Console.WriteLine("\nCloned ArrayList Elements:");
//             foreach (var item in cloneArrayList)
//             {
//                 Console.WriteLine($"{item} ");
//             }
//         }
//     }
// }


// How to copy an ArrayList to an existing array in C#?
// 1. CopyTo(Array array): This method is used to copy the entire ArrayList to a compatible one-dimensional Array, starting at the beginning of the target array.
// If the parameter array is null, then it will throw ArgumentNullException.
// 2. CopyTo(Array array, int arrayIndex): This method is used to copy the entire ArrayList to a compatible one-dimensional Array, starting at the specified index of the target array.
// The arrayIndex parameter specifies the zero-based index in the array at which copying begins.
// If the parameter arrayIndex is less than zero, then it will throw ArgumentOutOfRangeException.
// 3. CopyTo(int index, Array array, int arrayIndex, int count): This method is used to copy a range of elements from the System.Collections.ArrayList, starting at the specified index of the target array.
// The count parameter specifies the number of elements to copy.

// using System;
// using System.Collections;
// namespace Csharp8Features
// {
//     public class ArrayListDemo
//     {
//         public static void Main()
//         {
//             ArrayList arrayList = new ArrayList()
//             {
//                     "India",
//                     "USA",
//                     "UK",
//                     "Denmark",
//                     "HongKong",
//             };

//             Console.WriteLine("Array List Elements:");
//             foreach (var item in arrayList)
//             {
//                 Console.WriteLine($"{item} ");
//             }

//             //Copying the arrayList to an object array
//             object[] arrayListCopy = new object[arrayList.Count];
//             arrayList.CopyTo(arrayListCopy);
//             Console.WriteLine("\nArrayList Copy Array Elements:");
//             foreach (var item in arrayListCopy)
//             {
//                 Console.WriteLine(item);
//             }
//         }
//     }
// }


// How to Sort the Elements of an ArrayList Collection in C#?
// 1. Sort(): This method is used to sort the elements in the entire System.Collections.ArrayList.
// 2. Sort(IComparer? comparer): This method is used to sort the elements in the entire ArrayList using the specified comparer.
// 3. Sort(int index, int count, IComparer? comparer): This method is used to sort the elements in a range of elements in ArrayList using the specified comparer.

// These methods use the QuickSort algorithm to perform sorting on the ArrayList and the elements are arranged in ascending order.

using System;
using System.Collections;
namespace Csharp8Features
{
    public class ArrayListDemo
    {
        public static void Main()
        {
            ArrayList arrayList = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Denmark",
                    "Nepal",
                    "HongKong",
                    "Austrailla",
                    "Srilanka",
                    "Japan",
                    "Britem",
                    "Brazil",
            };

            Console.WriteLine("Array List Elements Before Sorting");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }

            // Sorting the elements of  ArrayList Using sort() method
            arrayList.Sort();
            Console.WriteLine("\n\nArray List Elements After Sorting");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
        }
    }
}