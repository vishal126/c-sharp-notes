// What is a Hashtable in C#?
// The Hashtable in C# is a Non-Generic Collection that stores the element in the form of “Key-Value Pairs”.
// The data in the Hashtable are organized based on the hash code of the key.
// The key in the HashTable is defined by us and more importantly, that key can be of any data type.
// Once we created the Hashtable collection, then we can access the elements by using the keys. The Hashtable class comes under the System.Collections namespace.

// The Hashtable computes a hash code for each key. Then it uses that hash code to look up the elements very quickly which increases the performance of the application.


// Hashtable Characteristics in C#
// 1. The Hashtable Collection Class in C# stores the elements in the form of key-value pairs.
// 2. Hashtable Class belongs to System.Collection namespace i.e. it is a Non-Generic Collection class.
// 3. It implements the IDictionary interface.
// 4. The Keys can be of any data type but they must be unique and not null.
// 5. The Hashtable accepts both null and duplicate values.
// 6. We can access the values by using the associated key.
// 7. The capacity of a Hashtable is the number of elements that a Hashtable can hold.
// 8. A hashtable is a non-generic collection, so we can store elements of the same type as well as of different types.


// How Actually the Hashtable works in C#?
// When we add elements to a hashtable like string, int, or complex types, then it converts the key data which can be a string, integer, numeric, or anything in the world into simple hash integer values so that lookup can be easy.
// Once the conversion is done, then the data will be added to the hashtable collection.

// add the object to hashTable 
// -> convert long key data into simple hash integer values so that lookup can be easy
// keys         Hashes
// anurag       00001
// pranaya      00002
// sambit       00003
// hina         00004
// priyanka     00005
// -> finally adds into the hashtable.


// One more point that you need to remember is that the performance of the hashtable is less as compared to the ArrayList because of this key conversion (converting the key to an integer hashcode).


// Differences between ArrayList and Hashtable in C#:
// Lookup: ArrayList can be only looked up via the index number which is generated internally. Hashtable can be looked up by a custom-defined key.
// Performance: ArrayList is faster than hashtable because of extra tasks performed in hashtables i.e. hashing.
// Scenario: If you want a key lookup use hashtable. If you just want to add and browser through a collection then use ArrayList.



// How to Create a Non-Generic Hashtable Collection in C#?
// public Hashtable(): It is used to initialize a new, empty instance of the Hashtable class using the default initial capacity, load factor, hash code provider, and comparer.

// Now, let’s see how to create a hashtable in C#:
// Step1:
// The Hashtable class belongs to System.Collections namespace. So, first, we need to include the System.Collections namespace in our program with the help of the “using” keyword are as follows.
// using System.Collections;

// Step2:
// Next, we need to create an instance of the Hashtable class using the Hashtable constructor as follows. Here, we are using the 0-argument constructor.
// Hashtable hashtable = new Hashtable();


// How to Add Elements into a Hashtable Collection in C#?
// We need to use Add() method of the Hashtable class.
// Add(object key, object? value): The Add(object key, object? value) method is used to add an element with the specified key and value into the Hashtable.
// The value can be null.

// For Example
// hashtable.Add(“EId”, 1001);
// hashtable.Add(“Name”, “James”);

// Even it is also possible to create a Hashtable using collection-initializer syntax as follows:
// var cities = new Hashtable(){
//         {“UK”, “London, Manchester, Birmingham”},
//         {“USA”, “Chicago, New York, Washington”},
//         {“India”, “Mumbai, Delhi, BBSR”}
// };


// How to access a Non-Generic Hashtable Collection in C#?
// Using Keys to Access Hashtable in C#:
// If the specified key is not present, then the compiler will throw an exception.
// hashtable[“EId”]
// hashtable[“Name”]

// Using ForEach loop to Access Hashtable in C#:
// foreach (object obj in hashtable.Keys)
// {
//        Console.WriteLine(obj + ” : ” + hashtable[obj]);
// }

// The elements in Hashtable are stored as **DictionaryEntry** objects. So, instead of an object, you can also use DictionaryEntry.
// foreach (DictionaryEntry item in hashtable)
// {
//         Console.WriteLine($”Key: {item.Key}, Value: {item.Value}”);
// }


// Example to Understand How to Create a Hashtable and Add Elements in C#:
// using System;
// using System.Collections;
// namespace HasntableExample
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Creating Hashtable collection with default constructor
//             Hashtable hashtable = new Hashtable();

//             //Adding elements to the Hash table using key value pair
//             hashtable.Add("EId", 1001); //Here key is Eid and value is 1001
//             hashtable.Add("Name", "James"); //Here key is Name and value is James
//             hashtable.Add("Salary", 3500); //Here key is Salary and value is 3500
//             hashtable.Add("Location", "Mumbai"); //Here key is Location and value is Mumbai
//             hashtable.Add("EmailID", "a@a.com"); //Here key is EmailID and value is a@a.com

//             //Printing the keys and their values using foreach loop
//             Console.WriteLine("Printing Hashtable using Foreach Loop");
//             foreach (object obj in hashtable.Keys)
//             {
//                 Console.WriteLine(obj + " : " + hashtable[obj]);
//             }
//             //Or
//             //foreach (DictionaryEntry de in hashtable)
//             //{
//             //    Console.WriteLine($"Key: {de.Key}, Value: {de.Value}");
//             //}

//             Console.WriteLine("\nPrinting Hashtable using Keys");
//             //I want to print the Location by using the Location key
//             Console.WriteLine("Location : " + hashtable["Location"]);

//             //I want to print the Email ID by using the EmailID key
//             Console.WriteLine("Emaild ID : " + hashtable["EmailID"]);
//         }
//     }
// }


// Example to Add Elements to a Hashtable using Collection Initializer in C#:
// using System;
// using System.Collections;

// namespace HasntableExample
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Creating a Hashtable using collection-initializer syntax
//             Hashtable citiesHashtable = new Hashtable(){
//                             {"UK", "London, Manchester, Birmingham"}, //Key:UK, Value:London, Manchester, Birmingham
//                             {"USA", "Chicago, New York, Washington"}, //Key:USA, Value:Chicago, New York, Washington
//                             {"India", "Mumbai, New Delhi, Pune"}      //Key:India, Value:Mumbai, New Delhi, Pune
//                         };

//             Console.WriteLine("Creating a Hashtable Using Collection-Initializer");
//             foreach (DictionaryEntry city in citiesHashtable)
//             {
//                 Console.WriteLine($"Key: {city.Key}, Value: {city.Value}");
//             }
//         }
//     }
// }



// How to Check the Availability of a key/value Pair in a Hashtable in C#?
// 1. Contains(object key): The Contains(object key) method of the Hashtable is used to check whether the Hashtable contains a specific key.
// It returns true if the Hashtable contains an element with the specified key; otherwise, false. If the key is null, then it will throw System.ArgumentNullException.
// 2. ContainsKey(object key): The ContainsKey(object key) method of the Hashtable is used to check if a given key is present in the Hashtable or not.
//  the given key is present in the collection then it will return true else it will return false. If the key is null, then it will throw System.ArgumentNullException.
// 3. ContainsValue(object value): The ContainsValue(object value) Method of the Hashtable class is used to check if a value is present in the Hashtable or not.
// If the given value is present in the collection then it will return true else it will return false.

// using System;
// using System.Collections;

// namespace HasntableExample
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Creating Hashtable collection with default constructor
//             Hashtable hashtable = new Hashtable();

//             //Adding elements to the Hash table using key value pair
//             hashtable.Add("EId", 1001); //Here key is Eid and value is 1001
//             hashtable.Add("Name", "James"); //Here key is Name and value is James
//             hashtable.Add("Job", "Developer");
//             hashtable.Add("Salary", 3500);
//             hashtable.Add("Location", "Mumbai");
//             hashtable.Add("Dept", "IT");
//             hashtable.Add("EmailID", "null");

//             //Checking the key using the Contains methid
//             Console.WriteLine("Is EmailID Key Exists : " + hashtable.Contains("EmailID"));
//             Console.WriteLine("Is Department Key Exists : " + hashtable.Contains("Department"));

//             //Checking the key using the ContainsKey methid
//             Console.WriteLine("Is EmailID Key Exists : " + hashtable.ContainsKey("EmailID"));
//             Console.WriteLine("Is Department Key Exists : " + hashtable.ContainsKey("Department"));

//             //Checking the value using the ContainsValue method
//             Console.WriteLine("Is Mumbai value Exists : " + hashtable.ContainsValue("Mumbai"));
//             Console.WriteLine("Is Technology value Exists : " + hashtable.ContainsValue("Technology"));
//         }
//     }
// }



// How to Remove Elements from a Non-Generic Hashtable Collection in C#?
// 1. Remove(object key): This method is used to remove the element with the specified key from the Hashtable.
// It throws the KeyNotfoundException if the specified key is not found in the Hashtable, so check for an existing key using the ContainsKey() method before removing it.

// If you want to remove all the elements from the hashtable
// Clear(): This method is used to remove all elements from the Hashtable

// using System;
// using System.Collections;

// namespace HasntableExample
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Hashtable employee = new Hashtable
//             {
//                 { "EId", 1001 },
//                 { "Name", "James" },
//                 { "Salary", 3500 },
//                 { "Location", "Mumbai" },
//                 { "EmailID", "a@a.com" }
//             };

//             //Count Property returns the number of elements present in the collection
//             Console.WriteLine($"Hashtable Total Elements: {employee.Count}");

//             // Remove EId as this key exists
//             employee.Remove("EId");
//             Console.WriteLine($"After Removing EID Total Elements: {employee.Count}");

//             //Following statement throws run-time exception: KeyNotFoundException
//             //employee.Remove("City"); 

//             //Check key before removing it
//             if (employee.ContainsKey("City"))
//             {
//                 employee.Remove("City");
//             }
//             else
//             {
//                 Console.WriteLine("Hashtable doesnot contain City key");
//             }

//             //Removes all elements
//             employee.Clear();
//             Console.WriteLine($"After Clearing Hashtable Total Elements: {employee.Count}");
//         }
//     }
// }



// How to Assign Values to a Hashtable with Indexer in C#?
// we need to use square brackets after the Hashtable name.
//  must have to specify both key and value while adding the elements.
// Syntax: hashtable[key] = value;

// using System;
// using System.Collections;

// namespace HasntableExample
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Hashtable hashtable = new Hashtable();

//             hashtable[1] = "One";
//             hashtable[5] = "Five";
//             hashtable[30] = "Thirty";

//             foreach (DictionaryEntry de in hashtable)
//             {
//                 Console.WriteLine($"Key: {de.Key}, Value: {de.Value}");
//             }
//         }
//     }
// }



// How to Update a Hashtable in C# using Indexer?
// Hashtable in C# is a non-generic collection class, so it is our responsibility to type-cast values to the appropriate type while retrieving it.
// you can also use the key indexer to update an existing key value in Hashtable.

// using System;
// using System.Collections;

// namespace HasntableExample
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Creating Hashtable collection using collection-initializer syntax
//             Hashtable employee = new Hashtable
//             {
//                 { "EId", 1001 }, 
//                 { "Name", "James" }, 
//                 { "Salary", 3500 },
//                 { "Location", "Mumbai" },
//                 { "EmailID", "a@a.com" }
//             };

//             string EmployeeName = (string)employee["Name"]; //Cast to String
//             int EmployeeSalary = (int)employee["Salary"];   //Cast to Int

//             Console.WriteLine("Before Updating Name and Salary");
//             Console.WriteLine($"Employee Name: {EmployeeName}");
//             Console.WriteLine($"Employee Salary: {EmployeeSalary}");

//             //Updating the Name and Salary
//             employee["Name"] = "Smith"; //Update value of Name key
//             employee["Salary"] = 5000; //Update value of Salary key

//             Console.WriteLine("\nAfter Updating Name and Salary");
//             EmployeeName = (string)employee["Name"]; 
//             EmployeeSalary = (int)employee["Salary"]; 

//             Console.WriteLine($"Employee Name: {EmployeeName}");
//             Console.WriteLine($"Employee Salary: {EmployeeSalary}");
//         }
//     }
// }



// How to Clone a Non-Generic Hashtable Collection in C#?
// Clone(): This method is used to create and return a shallow copy of a Hashtable object.

// using System;
// using System.Collections;

// namespace HasntableExample
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Creating Hashtable collection with default constructor
//             Hashtable hashtable = new Hashtable();

//             //Adding elements to the Hash table using Add method
//             hashtable.Add("EId", 1001); 
//             hashtable.Add("Name", "James"); 
//             hashtable.Add("Job", "Developer");
//             hashtable.Add("Salary", 3500);
//             hashtable.Add("Location", "Mumbai");
//             hashtable.Add("Dept", "IT");
//             hashtable.Add("EmailID", "a@a.com");

//             Console.WriteLine("Hashtable  Elements:");
//             foreach (DictionaryEntry item in hashtable)
//             {
//                 Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
//             }

//             //Creating a clone Hashtable using Clone method
//             Hashtable cloneHashtable = (Hashtable)hashtable.Clone();
//             Console.WriteLine("\nCloned Hashtable Elements:");
//             foreach (DictionaryEntry item in cloneHashtable)
//             {
//                 Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
//             }
//         }
//     }
// }



// How to Copy a Hashtable to an Existing Array in C#?
// CopyTo(Array array, int arrayIndex): The CopyTo method of the Non-Generic Hashtable Collection Class is used to copy hashtable elements to a one-dimensional Array object, starting at the specified index in the array.
// To copy only the keys in the Hashtable, use Hashtable.Keys.CopyTo.
// To copy only the values in the Hashtable, use Hashtable.Values.CopyTo.


// using System;
// using System.Collections;

// namespace HasntableExample
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Creating Hashtable collection with default constructor
//             Hashtable hashtable = new Hashtable();

//             //Adding elements to the Hash table using Add method
//             hashtable.Add("EId", 1001); 
//             hashtable.Add("Name", "James"); 
//             hashtable.Add("Location", "Mumbai");

//             //Printing All Queue Elements using For Each Loop
//             Console.WriteLine("Hashtable Elements:");
//             foreach (DictionaryEntry item in hashtable)
//             {
//                 Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
//             }

//             //Copying the Hashtable to an object array
//             DictionaryEntry[] myArray = new DictionaryEntry[hashtable.Count];
//             hashtable.CopyTo(myArray, 0);
//             Console.WriteLine("\nHashtable Copy Array Elements:");
//             foreach (DictionaryEntry item in myArray)
//             {
//                 Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
//             }

//             Object[] myObjArrayKey = new Object[hashtable.Count];
//             Object[] myObjArrayValue = new Object[hashtable.Count];
//             Console.WriteLine("\nCopyTo Method to Copy Keys:");
//             hashtable.Keys.CopyTo(myObjArrayKey, 0);
//             foreach (var key in myObjArrayKey)
//             {
//                 Console.WriteLine($"{key} ");
//             }

//             Console.WriteLine("\nCopyTo Method to Copy Values:");
//             hashtable.Values.CopyTo(myObjArrayValue, 0);
//             foreach (var key in myObjArrayValue)
//             {
//                 Console.WriteLine($"{key} ");
//             }
//         }
//     }
// }



// Non-Generic Hashtable Collection Class Properties in C#
// 1. IsFixedSize: Gets a value indicating whether the System.Collections.Hashtable has a fixed size. It returns true if the Hashtable object has a fixed size; otherwise, false. The default is false.
// 2. Keys: Gets a System.Collections.ICollection containing the keys in the Hashtable. It returns a System.Collections.ICollection containing the keys in the Hashtable.
// 3. IsSynchronized: Gets a value indicating whether access to the Hashtable is synchronized (thread-safe). It returns true if access to the Hashtable is synchronized (thread-safe); otherwise, false. The default is false.
// 4. IsReadOnly: Gets a value indicating whether the Hashtable is read-only. It returns true if the Hashtable object is read-only; otherwise, false. The default is false.
// 5. Count: Gets the number of key/value pairs contained in the Hashtable. It returns the number of key/value pairs contained in the System.Collections.Hashtable.
// 6. Values: Gets a System.Collections.ICollection containing the values in the Hashtable. It returns a System.Collections.ICollection containing the values in the Hashtable.
// 7. SyncRoot: Gets an object that can be used to synchronize access to the Hashtable. It returns an object that can be used to synchronize access to the Hashtable.
// 8. comparer: Gets or sets the System.Collections.IComparer to use for the Hashtable. It returns the System.Collections.IComparer to use for the Hashtable.
// 9. hcp: Gets or sets the object that can dispense hash codes. It returns the object that can dispense hash codes.
// 10. EqualityComparer: Gets the System.Collections.IEqualityComparer to use for the Hashtable. It returns the System.Collections.IEqualityComparer to use for the Hashtable.
