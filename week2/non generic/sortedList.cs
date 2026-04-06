// What is SortedList in C#?
// The Non-Generic SortedList Collection Class in C# represents a collection of key/value pairs that are sorted by the keys and are accessible by key and by index. By default, it sorts the key/value pairs in ascending order. 


// Properties
// The Non-Generic SortedList Class in C# implements the IEnumerable, ICollection, IDictionary, and ICloneable interfaces.
// We can access the element by its key or by its index in SortedList.
// The Non-Generic SortedList object internally maintains two arrays to store the elements of the list, i.e, one array for the keys and another array for the associated values. Here, the key cannot be null, but the value can be null. And one more, it does not allow duplicate keys.
// The capacity of the Non-Generic SortedList object is the number of key/value pairs it holds.
// In the Non-Generic SortedList object in C#, we can store values of the same type and of the different types as it operates on the object data type.
// In the same SortedList, it is not possible to store keys of different data types. If you try then the compiler will throw an exception.


// Methods, Properties, and Constructor of Non-Generic SortedList Collection Class in C#:
// public class SortedList: ICollection, IEnumerable, IDictionary, ICloneable
// {
//     public SortedList();
//     public SortedList (IComparer comparer);
//     public SortedList(IDictionary d);
//     public SortedList(int initialCapacity);
//     public SortedList (IComparer comparer, int capacity);
//     public SortedList(IDictionary d, IComparer comparer);

//     public virtual object this[object key]
//     public virtual ICollection Keys { get; }
//     public virtual bool IsSynchronized { get; }
//     public virtual bool IsReadOnly { get; }
//     public virtual bool IsFixedSize { get; }
//     public virtual int Count { get; )
//     public virtual int Capacity { get; set; }
//     public virtual object SyncRoot { get; }
//     public virtual ICollection Values { get; }

//     public static SortedList Synchronized(SortedList list);
//     public virtual void Add(object key, object value);
//     public virtual void Clear();
//     public virtual object Clone();
//     public virtual bool Contains(object key);
//     public virtual bool ContainsKey(object key);
//     public virtual bool ContainsValue(object value);
//     public virtual void CopyTo(Array array, int arrayIndex);
//     public virtual object GetByIndex(int index);
//     public virtual IDictionaryEnumerator GetEnumerator();
//     public virtual object GetKey(int index);
//     public virtual IList GetKeyList();
//     public virtual IList GetValueList();
//     public virtual int IndexOfKey(object key);
//     public virtual int IndexOfValue(object value);
//     public virtual void Remove(object key);
//     public virtual void RemoveAt(int index);
//     public virtual void SetByIndex(int index, object value);
//     public virtual void TrimToSize();
// }


// How to Create a SortedList Collection in C#?
// SortedList(): It initializes a new instance of the System.Collections.SortedList class that is empty, has the default initial capacity and is sorted according to the IComparable interface implemented by each key added to the System.Collections.SortedList object.
// SortedList(IComparer comparer): It initializes a new instance of the System.Collections.SortedList class that is empty, has the default initial capacity and is sorted according to the specified IComparer interface.
// SortedList(IDictionary d): IT initializes a new instance of the System.Collections.SortedList class contains elements copied from the specified dictionary, has the same initial capacity as the number of elements copied, and is sorted according to the System.IComparable interface implemented by each key.
// SortedList(int initialCapacity): It initializes a new instance of the System.Collections.SortedList class that is empty, has the specified initial capacity, and is sorted according to the System.IComparable interface implemented by each key added to the System.Collections.SortedList object.
// SortedList(IComparer comparer, int capacity): It initializes a new instance of the System.Collections.SortedList class that is empty, has the specified initial capacity, and is sorted according to the specified System.Collections.IComparer interface. 
// SortedList(IDictionary d, IComparer comparer): It initializes a new instance of the System.Collections.SortedList class contains elements copied from the specified dictionary, has the same initial capacity as the number of elements copied, and is sorted according to the specified System.Collections.IComparer interface.

// Let’s see how to create a SortedList using the SortedList constructor in C#:
// using System.Collections;
// SortedList sortedList = new SortedList();


// How to Add Elements into a SortedList in C#?
// Add(object key, object value)

// How to Access a SortedList Collection in C#?
// Using Keys to Access SortedList Elements in C#:
// we need to pass the key as a parameter to find the respective value. The syntax is given below.
// Console.WriteLine($”Key: 1, Value: {sortedList[1]}”);
// Console.WriteLine($”Key: 2, Value: {sortedList[2]}”);
// Console.WriteLine($”Key: 3, Value: {sortedList[3]}”);

// Using Index to Access SortedList Elements in C#:
// Console.WriteLine($”Key: 1, Index: 0, Value: {sortedList.GetByIndex(0)}”);
// Console.WriteLine($”Key: 2, Index: 1, Value: {sortedList.GetByIndex(1)}”);
// Console.WriteLine($”Key: 3, Index: 2, Value: {sortedList.GetByIndex(2)}”);

// Using for loop to Access SortedList Elements in C#:
// for (int x = 0; x < sortedList.Count; x++)
// {
//         Console.WriteLine($”Key: {sortedList.GetKey(x)}, Value: {sortedList.GetByIndex(x)}”);
// }

// Using foreach loop to access SortedList Elements in C#:
// foreach (DictionaryEntry item in sortedList)
// {
//       Console.WriteLine($”Key: {item.Key}, Value: {item.Value}”);
// }


// Example to Understand How to Create a SortedList and Add Elements and Access Elements in C#:
// using System;
// using System.Collections;
// namespace NonGenericCollections
// {
//     public class SortedListDemo
//     {
//         public static void Main(string[] args)
//         {
//             //Creating sortedList Collection
//             SortedList sortedList = new SortedList();

//             //Adding Elements to SortedList using Add Method
//             //Key type going to be same
//             sortedList.Add(1, "One");
//             sortedList.Add(5, "Five");
//             sortedList.Add(4, "Four");
//             sortedList.Add(2, "Two");
//             sortedList.Add(3, "Three");

//             //Duplicate Key not allowed
//             //System.ArgumentException: 'Item has already been added. Key in dictionary: '4'  Key being added: '4''
//             //sortedList.Add(4, "Four");

//             //Null value is allwed
//             //sortedList.Add(6, null);

//             //Duplicate Value is allowed
//             //sortedList.Add(7, "Five");

//             //In this case string key is not valid, throw Exception
//             //sortedList.Add("Ten", "Ten");

//             //Accessing SortedList using For loop
//             Console.WriteLine("Accessing SortedList using For loop");
//             for (int x = 0; x < sortedList.Count; x++)
//             {
//                 Console.WriteLine($"Key: {sortedList.GetKey(x)}, Value: {sortedList.GetByIndex(x)}");
//             }

//             Console.WriteLine("\nAccessing SortedList using For Each loop");
//             //Accessing SortedList using For Each loop
//             foreach (DictionaryEntry item in sortedList)
//             {
//                 Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
//             }

//             Console.WriteLine("\nAccessing SortedList using Keys");
//             Console.WriteLine($"Key: 1, Value: {sortedList[1]}");
//             Console.WriteLine($"Key: 2, Value: {sortedList[2]}");
//             Console.WriteLine($"Key: 3, Value: {sortedList[3]}");

//             Console.WriteLine("\nAccessing SortedList using Index");
//             Console.WriteLine($"Key: 1, Index: 0, Value: {sortedList.GetByIndex(0)}");
//             Console.WriteLine($"Key: 2, Index: 1, Value: {sortedList.GetByIndex(1)}");
//             Console.WriteLine($"Key: 3, Index: 2, Value: {sortedList.GetByIndex(2)}");
//         }
//     }
// }


// Adding Elements to SortedList using Collection Initializer in C#:
// using System;
// using System.Collections;
// namespace NonGenericCollections
// {
//     public class SortedListDemo
//     {
//         public static void Main(string[] args)
//         {
//             //Creating sortedList using Object Initializer
//             SortedList sortedList = new SortedList
//             {
//                 { "Ind", "India" },
//                 { "USA", "United State of America" },
//                 { "SA", "South Africa" },
//                 { "PAK", "Pakistan" }
//             };

//             Console.WriteLine("SortedList Elements");
//             foreach (DictionaryEntry item in sortedList)
//             {
//                 Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
//             }
//         }
//     }
// }


// How to Remove Elements from a SortedList Collection in C#?
// 1. Remove(object key)
// 2. RemoveAt(int index)
// 3. Clear()


// using System;
// using System.Collections;
// namespace NonGenericCollections
// {
//     public class SortedListDemo
//     {
//         public static void Main(string[] args)
//         {
//             //Creating sortedList object
//             SortedList sortedList = new SortedList();

//             //Adding Elements to SortedList using Add
//             sortedList.Add("Ind", "India");
//             sortedList.Add("USA", "United State of America");
//             sortedList.Add("SA", "South Africa");
//             sortedList.Add("PAK", "Pakistan");

//             Console.WriteLine("SortedList Elements");
//             foreach (DictionaryEntry item in sortedList)
//             {
//                 Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
//             }

//             // Remove value having key PAK Using Remove() method
//             sortedList.Remove("PAK");

//             // After Remove() method
//             Console.WriteLine("\nSortedList Elements After Remove Method");
//             foreach (DictionaryEntry item in sortedList)
//             {
//                 Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
//             }

//             // Remove element at index 1 Using RemoveAt() method
//             sortedList.RemoveAt(1);
//             Console.WriteLine("\nSortedList Elements After RemoveAT Method");
//             foreach (DictionaryEntry item in sortedList)
//             {
//                 Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
//             }

//             // Remove all key/value pairs Using Clear method
//             sortedList.Clear();
//             Console.WriteLine($"After Clear Method Total Key-Value Pair Present is : {sortedList.Count} ");
//         }
//     }
// }


// How to check the availability of key/value pairs in a SortedList in C#?
// 1. Contains(object key)
// 2. ContainsKey(object key)
// 3. ContainsValue(object value)

// using System;
// using System.Collections;
// namespace NonGenericCollections
// {
//     public class SortedListDemo
//     {
//         public static void Main(string[] args)
//         {
//             //Creating sortedList using Object Initializer
//             SortedList sortedList = new SortedList
//             {
//                 { "Ind", "India" },
//                 { "USA", "United State of America" },
//                 { "SA", "South Africa" },
//                 { "PAK", "Pakistan" }
//             };

//             //Checking the key using the Contains methid
//             Console.WriteLine("Is Ind Key Exists : " + sortedList.Contains("Ind"));
//             Console.WriteLine("Is NZ Key Exists : " + sortedList.Contains("NZ"));

//             //Checking the key using the ContainsKey methid
//             Console.WriteLine("Is Ind Key Exists : " + sortedList.ContainsKey("Ind"));
//             Console.WriteLine("Is NZ Key Exists : " + sortedList.ContainsKey("NZ"));

//             //Checking the value using the ContainsValue method
//             Console.WriteLine("Is India value Exists : " + sortedList.ContainsValue("India"));
//             Console.WriteLine("Is Bangladesh value Exists : " + sortedList.ContainsValue("Bangladesh"));
//         }
//     }
// }


// How to Clone the Non-Generic SortedList in C#?
// Clone()


// What is the use of the CopyTo method of the Non-Generic SortedList Collection Class in C#?
// CopyTo(Array array, int arrayIndex)

// To copy only the keys in the SortedList, use SortedList.Keys.CopyTo.
// To copy only the values in the SortedList, use SortedList.Values.CopyTo.


// using System;
// using System.Collections;

// namespace NonGenericCollections
// {
//     public class SortedListDemo
//     {
//         public static void Main(string[] args)
//         {
//             //Creating sortedList using Object Initializer
//             SortedList sortedList = new SortedList
//             {
//                 { "Ind", "India" },
//                 { "USA", "United State of America" },
//                 { "SA", "South Africa" },
//                 { "PAK", "Pakistan" }
//             };

//             Console.WriteLine("Sorted List Elements:");
//             foreach (DictionaryEntry item in sortedList)
//             {
//                 Console.WriteLine($"Key: {item.Key} : Value: {item.Value}");
//             }

//             DictionaryEntry[] myTargetArray = new DictionaryEntry[5];
//             sortedList.CopyTo(myTargetArray, 1);
//             Console.WriteLine("\nCopyTo Method to Copy Keys and values:");
//             for (int i = 0; i < myTargetArray.Length; i++)
//             {
//                 Console.WriteLine($"{myTargetArray[i].Key} : {myTargetArray[i].Value}");
//             }

//             Object[] myObjArrayKey = new Object[5];
//             Object[] myObjArrayValue = new Object[5];

//             Console.WriteLine("\nCopyTo Method to Copy Keys:");
//             sortedList.Keys.CopyTo(myObjArrayKey, 0);
//             foreach (var key in myObjArrayKey)
//             {
//                 Console.WriteLine($"{key} ");
//             }

//             Console.WriteLine("\nCopyTo Method to Copy Values:");
//             sortedList.Values.CopyTo(myObjArrayValue, 1);
//             foreach (var key in myObjArrayValue)
//             {
//                 Console.WriteLine($"{key} ");
//             }
//         }
//     }
// }



// Non-Generic SortedList Collection Class Properties in C#
// Keys: Gets the keys in a System.Collections.SortedList object. It returns a System.Collections.ICollection object containing the keys in the System.Collections.SortedList object.
// IsSynchronized: Gets a value indicating whether access to a SortedList object is synchronized (thread-safe). It returns true if access to the SortedList object is synchronized (thread-safe); otherwise, false. The default is false.
// IsReadOnly: Gets a value indicating whether the SortedList object is read-only. It returns true if the System.Collections.SortedList object is read-only; otherwise, false. The default is false.
// IsFixedSize: It returns true if the SortedList object has a fixed size; otherwise, false. The default is false.
// Count: It returns the number of elements contained in the System.Collections.SortedList object.
// Capacity: It returns the number of elements that the System.Collections.SortedList object can contain.
// SyncRoot: It returns an object that can be used to synchronize access to the System.Collections.SortedList object.
// Values: Gets the values in a SortedList object. It returns a System.Collections.ICollection object containing the values in the System.Collections.SortedList object.


