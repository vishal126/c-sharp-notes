// What is Stack in C# and how does it work?
// It works on the LIFO (Last in First out) principle.
// When we add an item to a stack collection, then it is called pushing an item. 
// when we remove an item from the stack then it is called popping an item.


// Methods, Properties, and Constructor of Stack Class in C#:
// namespace System.Collections
// {
//     public class Stack : ICollection, IEnumerable, ICloneable
//      { 
//         public Stack();
//         public Stack(ICollection col);
//         public Stack(int initialCapacity);

//         public virtual int Count { get; }
//         public virtual bool IsSynchronized { get; }
//         public virtual object SyncRoot { get; }

//         public static Stack Synchronized(Stack stack);
//         public virtual void Clear();
//         public virtual object Clone();
//         public virtual bool Contains (object obj);
//         public virtual void CopyTo(Array array, int index);
//         public virtual IEnumerator GetEnumerator();
//         public virtual object Peek();
//         public virtual object Pop();
//         public virtual void Push(object obj);
//         public virtual object[] ToArray();
//     }
// }


// How to create a Non-Generic Stack Collection in C#?
// The non-generic collection Stack class in C# has three constructors which we can use to create a stack.
// 1. Stack(): It is used to initialize a new instance of the Stack class that is empty and has the default initial capacity.
// 2. Stack(ICollection col): It is used to initialize a new instance of the non-generic Stack class that contains elements copied from the specified collection and has the same initial capacity as the number of elements copied.
// The parameters col specifies the System.Collections.ICollection to copy elements from.
// 3. Stack(int initialCapacity): It is used to initialize a new instance of the System.Collections.Stack class that is empty and has the specified initial capacity or the default initial capacity, whichever is greater.

// Let’s see how to create a stack using the Stack() constructor:
// Step1: we need to include System.Collections namespace in our program with the help of the “using” keyword as follows:
// using System.Collections;
// Step2: we need to create an instance of the Stack Collection class using the Stack() constructor as follows:
// Stack stack = new Stack();


// How to Add Elements into a Stack Collection in C#?
// We need to use the Push() method of the Stack class.
// Push(object obj): The push() method is used to insert an object on top of the Stack.
// The parameter obj specifies the Object to push onto the Stack. The value can be null.


// Example to Understand How to Create a Stack and Add Elements in C#:
// using System;
// using System.Collections;

// namespace StackCollectionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Creating a stack collection
//              Stack stack = new Stack();

//             //Adding item to the stack using the push method
//             stack.Push(10);
//             stack.Push("Hello");
//             stack.Push(3.14f);
//             stack.Push(true);
//             stack.Push(67.8);
//             stack.Push('A');

//             //Printing the stack items using foreach loop
//             foreach (object item in stack)
//             {
//                 Console.WriteLine(item);
//             }
//         }
//     }
// }


// How to Remove Elements from a Non-Generic Stack Collection in C#?
// In Stack, you are allowed to remove elements from the top of the stack. The Stack class in C# provides two different methods to remove elements.
// They are as follows:
// Pop(): This method is used to remove and return the object at the top of the Stack.
// Clear(): This method is used to remove all objects from the Stack.

// using System;
// using System.Collections;

// namespace StackCollectionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Creating a stack collection
//              Stack stack = new Stack();

//             //Adding item to the stack using the push method
//             stack.Push(10);
//             stack.Push("Hello");
//             stack.Push(3.14f);
//             stack.Push(true);
//             stack.Push(67.8);
//             stack.Push('A');

//             //Printing the stack items using foreach loop
//             Console.WriteLine($"All Stack Elements: Count {stack.Count}");
//             foreach (var item in stack)
//             {
//                 Console.Write($"{item} ");
//             }

//             //Removing and Returning an item from the stack using the pop method
//             Console.WriteLine($"\n\nDeleted Element: {stack.Pop()}");
//             //Printing item after removing the last added item
//             Console.WriteLine($"\nAll Stack Elements After Deletion: Count {stack.Count}");
//             foreach (var item in stack)
//             {
//                 Console.Write($"{item} ");
//             }
//         }
//     }
// }


// How to get the topmost element of a Stack in C#?
// 1. Pop(): This method is used to remove and return the object at the top of the Stack.
// If there is no object (or element) present in the stack and if you are trying to remove an item or object from the stack using the pop() method then it will throw an exception i.e. System.InvalidOperationException
// 2. Peek(): The peek() method is used to return the object from the top of the Stack without removing it.
// If there is no object (or element) present in the stack and if you are trying to return an item (object) from the stack using the peek() method then it will throw an exception i.e. System.InvalidOperationException

// using System;
// using System.Collections;

// namespace StackCollectionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Creating a stack collection
//              Stack stack = new Stack();

//             //Adding item to the stack using the push method
//             stack.Push(10);
//             stack.Push("Hello");
//             stack.Push(3.14f);
//             stack.Push(true);
//             stack.Push(67.8);
//             stack.Push('A');

//             Console.WriteLine($"Total elements present in stack : {stack.Count}");

//             // Fetch the topmost element of stack Using Pop method
//             Console.WriteLine($"Topmost element of stack is {stack.Pop()}");

//             Console.WriteLine($"Total elements present in stack : {stack.Count}");

//             // Fetch the topmost element from Stacj Using Peek method
//             Console.WriteLine($"Topmost element of Stack is {stack.Peek()}");

//             Console.WriteLine($"Total elements present in stack : {stack.Count}");
//         }
//     }
// }


// How to check whether an element exists or not in the stack in C#?
// If you want to check whether an element exists or not in the stack, then you need to use the following Contains() method of the Stack class.
// You can also use this method to search for an element in the given stack.
// Contains(object obj): This method is used to determine whether an element is in the Stack.

// using System;
// using System.Collections;

// namespace StackCollectionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Creating a stack collection
//             Stack stack = new Stack();

//             //Adding item to the stack using the push method
//             stack.Push(10);
//             stack.Push("Hello");
//             stack.Push(3.14f);
//             stack.Push(true);
//             stack.Push(67.8);
//             stack.Push('A');

//             // Checking if the element Hello is present in the Stack or not
//             if (stack.Contains("Hello"))
//             {
//                 Console.WriteLine("Element Hello is found");
//             }
//             else
//             {
//                 Console.WriteLine("Element Hello is not found");
//             }

//             // Checking if the element Hello is present in the Stack or not
//             if (stack.Contains("World"))
//             {
//                 Console.WriteLine("Element World is found");
//             }
//             else
//             {
//                 Console.WriteLine("Element World is not found");
//             }
//         }
//     }
// }

// Note: The Contains(object obj) method of Stack Class takes O(n) time to check if the element exists in the stack.


// How to Clone the Non-Generic Stack Collection in C#?
// Clone(): This method is used to create and return a shallow copy of a stack object.

// using System;
// using System.Collections;

// namespace StackCollectionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Creating a stack collection
//             Stack stack = new Stack();

//             //Adding item to the stack using the push method
//             stack.Push(10);
//             stack.Push("Hello");
//             stack.Push(3.14f);
//             stack.Push(67.8);

//             //Printing All Stack Elements using For Each Loop
//             Console.WriteLine("Stack Elements:");
//             foreach (var item in stack)
//             {
//                 Console.WriteLine(item);
//             }

//             //Creating a clone stack using Clone method
//             Stack cloneStack = (Stack)stack.Clone();
//             Console.WriteLine("\nCloned Stack Elements:");
//             foreach (var item in cloneStack)
//             {
//                 Console.WriteLine(item);
//             }
//         }
//     }
// }


// How to copy a stack to an existing array in C#?
// CopyTo(Array array, int index): This method is used to copy the Stack elements to an existing one-dimensional Array, starting at the specified array index.

// using System;
// using System.Collections;

// namespace StackCollectionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Creating a stack collection
//             Stack stack = new Stack();

//             //Adding item to the stack using the push method
//             stack.Push(10);
//             stack.Push("Hello");
//             stack.Push(3.14f);
//             stack.Push(true);
//             stack.Push(67.8);

//             //Printing All Queue Elements using For Each Loop
//             Console.WriteLine("Stack Elements:");
//             foreach (var item in stack)
//             {
//                 Console.WriteLine(item);
//             }
//             //Copying the queue to an object array
//             object[] stackCopy = new object[5];
//             stack.CopyTo(stackCopy, 0);
//             Console.WriteLine("\nStack Copy Array Elements:");
//             foreach (var item in stackCopy)
//             {
//                 Console.WriteLine(item);
//             }
//         }
//     }
// }


// Properties of Non-Generic Stack Collection Class in C#
// 1. Count: It returns the number of elements contained in the Stack.
// 2. IsSynchronized: Gets a value indicating whether access to the Stack is synchronized (thread-safe). It returns true if access to the Stack is synchronized (thread-safe); otherwise, false. The default is false.
// 3. SyncRoot: Gets an object that can be used to synchronize access to the Stack. It returns an object that can be used to synchronize access to the Stack.


// Characteristics of Non-Generic Stack Collection Class in C#:
// 1. The capacity of a Stack is the number of elements the Stack can hold. As we add elements to a Stack, the capacity of the stack is automatically increased.
// 2. If Count is less than the capacity of the stack, Push is an O(1) operation. If the capacity needs to be increased to accommodate the new element, Push becomes an O(n) operation, where n is Count. Pop is an O(1) operation.
// 3. The Stack Collection in C# allows both null and duplicate values.


