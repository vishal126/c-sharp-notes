// Introduction to Collections:
// Collections are groups of records that can be treated as one logical unit.
// eg. country collection that can have a country code and country name, product collection

// General Categories of Collections:
// Index based
    // Array
    // List
// Key value pair
    // Hashtable
    // Sorted List
// Prioritized collection: The Prioritized Collections help you to access the elements in a particular sequence.
    // stack
    // queue
// specialized collection
    // string collections
    // hybrid dictionaries



// What is a Collection in C#?
// The Collections in C# are a set of predefined classes that are present in the System.Collections namespace that provides greater capabilities and functionalities than the traditional arrays.
// The collections in C# are reusable, more powerful, and more efficient and most importantly they have been designed and tested to ensure quality and performance.
// A Collection in C# is a dynamic array. That means the collections in C# have the capability of storing multiple values but with the following features.
// 1. Size can be increased dynamically.
// 2. We can insert an element into the middle of a collection.
// 3. It also provides the facility to remove or delete elements from the middle of a collection.


// Types of Collections in C#
// System.Collections classes
// System.Collections.Generic classes
// System.Collections.Concurrent classes


// Non-Generic Collections Classes in C#:
// Defined under the System.Collections namespace.
// The Non-Generic collection classes in C# operate on objects, and hence can handle any type of data, but not in a safe-type manner.

// The System.Collections namespace contains the following classes:
// 1. ArrayList: It Implements the System.Collections.IList interface using an array whose size is dynamically increased as required.
// 2. Stack: It represents a simple last-in-first-out (LIFO) non-generic collection of objects.
// 3. Queue: It represents a first-in, first-out collection of objects.
// 4. Hashtable: It represents a collection of key/value pairs that are organized based on the hash code of the key.
// 5. SortedList:  It represents a collection of key/value pairs that are sorted by the keys and are accessible by key and by index.

// Generic Collections Classes in C#:
// Defined under the System.Collection.Generic namespace.
// It provides a generic implementation of standard data structures like linked lists, stacks, queues, and dictionaries.
// These collection classes are type-safe because they are generic means only those items that are type-compatible with the type of the collection can be stored in a generic collection, it eliminates accidental type mismatches.

// The System.Collections.Generic namespace has the following classes:
// 1. List<T>: It represents a strongly typed list of objects that can be accessed by index. Provides methods to search, sort, and manipulate lists.
// 2. Stack<T>: It represents a variable size last-in-first-out (LIFO) collection of instances of the same specified type.
// 3. Queue<T>: It represents a first-in, first-out collection of objects.
// 4. HashSet<T>: It represents a set of values. It removes duplicate elements from the collection.
// 5. Dictionary<TKey, TValue>: It represents a collection of keys and values.
// 6. SortedList<TKey, TValue>: It represents a collection of key/value pairs that are sorted by key based on the associated System.Collections.Generic.IComparer implementation.
// 7. SortedSet<T>: It represents a collection of objects that are maintained in sorted order.
// 8. SortedDictionary<TKey, TValue>: It represents a collection of key/value pairs that are sorted on the key.
// 9. LinkedList<T>: It represents a doubly linked list.


// Concurrent Collection Classes in C#:
// It provides various threads-safe collection classes.
// when multiple threads are accessing the collection simultaneously.
// The System.Collections.Concurrent namespace provides classes for thread-safe operations.
// Now multiple threads will not create problems for accessing the collection items.

// The System.Collections.Concurrent namespace has the following classes:
// BlockingCollection<T>: It provides blocking and bounding capabilities for thread-safe collections that implement System.Collections.Concurrent.IProducerConsumerCollection.
// ConcurrentBag<T>: It represents a thread-safe, unordered collection of objects.
// ConcurrentStack<T>: It represents a thread-safe last-in-first-out (LIFO) collection.
// ConcurrentQueue<T>: It represents a thread-safe first-in-first-out (FIFO) collection.
// ConcurrentDictionary<TKey, TValue>: It represents a thread-safe collection of key/value pairs that can be accessed by multiple threads concurrently.