// What is a Queue and How Does the Queue Collection Work in C#?
// works in the FIFO(First-In-First-Out) principle.
// When we add an item to the queue, then it is called enqueuing an item. Similarly, when we remove an item from the queue then it is called dequeuing an item.


// Characteristics:
// The Enqueue method adds an element to the end of the Queue.
// The Dequeue method removes the oldest element from the start of the Queue.
// The Peek method returns the oldest element that is at the start of the Queue but does not remove it from the Queue.
// The capacity of a Queue is the number of elements the queue can hold. As we add elements to a queue, the capacity of the queue is automatically increased.
// The Non-Generic Queue Collection allows both null and duplicate values.


// Methods, Properties, and Constructor of Non-Generic Queue Collection Class in C#:
// namespace System.Collections
// {
//     public class Queue: ICollection, IEnumerable, ICloneable
//     {
//         public Queue();
//         public Queue(ICollection col);
//         public Queue(int capacity);
//         public Queue(int capacity, float growFactor);

//         public virtual int Count { get; }
//         public virtual bool IsSynchronized { get; }
//         public virtual object SyncRoot { get; }

//         public static Queue Synchronized(Queue queue);
//         public virtual void Clear();
//         public virtual object Clone();
//         public virtual bool Contains(object obj);
//         public virtual void CopyTo(Array array, int index);
//         public virtual object Dequeue();
//         public virtual void Enqueue(object obj);
//         public virtual IEnumerator GetEnumerator();
//         public virtual object Peek();
//         public virtual object[] ToArray();
//         public virtual void TrimToSize();
//     }
// }


// How to create a Queue in C#?
// 1. Queue(): It is used to initialize a new instance of the Queue class that is empty and has the default initial capacity, and uses the default growth factor.
// 2. Queue(ICollection col): It is used to initialize a new instance of the Queue class that contains elements copied from the specified collection and has the same initial capacity as the number of elements copied and uses the default growth factor.
// 3. Queue(int capacity): It is used to initialize a new instance of the Queue class that is empty, has the specified initial capacity, and uses the default growth factor.
// 4. Queue(int capacity, float growFactor): It is used to initialize a new instance of the Queue class that is empty, has the specified initial capacity, and uses the specified growth factor.
// growFactor specifies the factor by which the capacity of the Queue is expanded.


// Let’s see how to create a queue using the Queue() constructor in C#:
// Step1: using System.Collections;
// Step2: Queue queue = new Queue();


// How to Add Elements into a Queue in C#?
// Enqueue(object obj): This method is used to add an object to the end of the Queue.
// The value can be null.


// Example to Understand How to Create a Queue and Add Elements in C#:
// using System;
// using System.Collections;

// namespace QueueCollectionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Creating a queue collection
//             Queue queue = new Queue();

//             //Adding item to the queue using the Enqueue method
//             queue.Enqueue(101);
//             queue.Enqueue("Hello");
//             queue.Enqueue(3.14f);
//             queue.Enqueue(true);
//             queue.Enqueue(67.8);
//             queue.Enqueue('A');

//             //Printing the queue items using foreach loop
//             foreach (var item in queue)
//             {
//                 Console.WriteLine(item);
//             }
//         }
//     }
// }


// How to Remove Elements from the Queue Collection in C#?
// Dequeue(): This method is used to remove and return the object at the beginning of the Queue. It returns the object that is removed from the beginning of the Queue.
// Clear(): This method is used to remove all objects from the queue.

// using System;
// using System.Collections;

// namespace QueueCollectionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Creating a queue collection
//             Queue queue = new Queue();

//             //Adding item to the queue using the Enqueue method
//             queue.Enqueue(101);
//             queue.Enqueue("Hello");
//             queue.Enqueue(3.14f);
//             queue.Enqueue(true);
//             queue.Enqueue(67.8);
//             queue.Enqueue('A');

//             //Printing the queue items using foreach loop
//             Console.WriteLine($"All Queue Elements: Count {queue.Count}");
//             foreach (var item in queue)
//             {
//                 Console.Write($"{item} ");
//             }

//             //Removing and Returning an item from the queue using the Dequeue method
//             Console.WriteLine($"\n\nDeleted Element: {queue.Dequeue()}");

//             //Printing item after removing the first added item
//             Console.WriteLine($"\nAll Queue Elements After Deletion: Count {queue.Count}");
//             foreach (var item in queue)
//             {
//                 Console.Write($"{item} ");
//             }

//             //Printing Items After Clearing the Queue
//             queue.Clear();
//             Console.WriteLine($"\n\nQueue Elements After Clear Operation: Count {queue.Count}");
//             foreach (var item in queue)
//             {
//                 Console.Write($"{item} ");
//             }
//         }
//     }
// }



// How to get the First Element of the Queue Collection in C#?
// Dequeue()
// Peek()

// using System;
// using System.Collections;

// namespace QueueCollectionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Creating a Queue collection
//             Queue queue = new Queue();

//             //Adding item to the queue using the Enqueue method
//             queue.Enqueue(101);
//             queue.Enqueue("Hello");
//             queue.Enqueue(3.14f);
//             queue.Enqueue(true);
//             queue.Enqueue(67.8);
//             queue.Enqueue('A');

//             Console.WriteLine($"Total Elements present in Queue : {queue.Count}");

//             // Fetch First Element of Queue Using Dequeue method
//             Console.WriteLine($"First Element of Queue is {queue.Dequeue()}");
//             Console.WriteLine($"Total Elements present in Queue : {queue.Count}");

//             // Fetch the topmost element from Queue Using Peek method
//             Console.WriteLine($"First Element of Queue is {queue.Peek()}");
//             Console.WriteLine($"Total Elements present in Queue : {queue.Count}");
//         }
//     }
// }


// How to Check Whether an Element Exists or not in the Queue Collection in C#?
// Contains(object obj)


// using System;
// using System.Collections;

// namespace QueueCollectionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Creating a Queue collection
//             Queue queue = new Queue();

//             //Adding item to the queue using the Enqueue method
//             queue.Enqueue(101);
//             queue.Enqueue("Hello");
//             queue.Enqueue(3.14f);
//             queue.Enqueue(true);
//             queue.Enqueue(67.8);
//             queue.Enqueue('A');

//             Console.WriteLine("All Elements of Queue");
//             foreach (var item in queue)
//             {
//                 Console.Write($"{item} ");
//             }

//             Console.WriteLine("\nChecking if the element Hello is present in the queue or not");
//             // Checking if the element Hello is present in the Stack or not

//             if (queue.Contains("Hello"))
//             {
//                 Console.WriteLine("Element Hello is found");
//             }
//             else
//             {
//                 Console.WriteLine("Element Hello is not found");
//             }

//             if (queue.Contains("World"))
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



// How to Clone the Non-Generic Queue Collection in C#?
// Clone()


// How to copy a queue to an existing array in C#?
// CopyTo(Array array, int index)


// Properties of Queue Class in C#
// Count: It gets the number of elements contained in the Queue.
// IsSynchronized: It gets a value indicating whether access to the Queue is synchronized (thread-safe). It returns true if access to the queue is synchronized (thread-safe); otherwise, false. The default is false.
// SyncRoot: It gets an object that can be used to synchronize access to the Queue. It returns an object that can be used to synchronize access to the queue.