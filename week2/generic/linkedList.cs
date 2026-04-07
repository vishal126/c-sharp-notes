// What is LinkedList<T> in C#?
// A LinkedList is a linear data structure used for storing the elements in a non-contiguous manner.
// The elements in a linked list are linked with each other using pointers.
// LinkedList consists of nodes where each node contains a data field and a reference(link) to the next node in the list.

// each node contains two parts.
// 1. data
// 2. address


// Points to Remember while working with Linked List:
// The LinkedList<T> belongs to the System.Collections.Generic namespace and implements ICollection, ICollection<T>, IEnumerable, IEnumerable<T>, ISerializable, and IDeserializationCallback interfaces.
// LinkedList<T> is a general-purpose linked list. It supports enumerators.
// You can remove nodes and reinsert them, either in the same list or in another list, which results in no additional objects allocated on the heap. Insertion and removal are O(1) operations.
// Each node in a LinkedList<T> object is of the type LinkedListNode<T>.
// The LinkedList class does not support chaining, splitting, cycles, or other features that can leave the list in an inconsistent state.
// If the LinkedList is empty, the First and Last properties contain null.
// The LinkedList is doubly linked, therefore, each node points forward to the Next node and backward to the previous node.
// The capacity of a LinkedList is the number of elements the LinkedList can hold.
// In LinkedList, it is allowed to store duplicate elements of the same type.


// How to Create a LinkedList<T> Collection in C#?
// using System.Collections.Generic;
// LinkedList<Type_of_linkedlist> linkedlist_name = new LinkedList<Type_of_linkedlist>();


// How to Add Elements into a Generic LinkedList<T> Collection in C#?
// AddAfter(LinkedListNode<T> node, LinkedListNode<T> newNode)
// AddAfter(LinkedListNode<T> node, T value)
// AddBefore(LinkedListNode<T> node, LinkedListNode<T> newNode)
// AddBefore(LinkedListNode<T> node, T value)
// AddFirst(LinkedListNode<T> node)
// AddFirst(T value)
// AddLast(LinkedListNode<T> node)
// LinkedListNode<T> AddLast(T value)


// How to Access a Generic LinkedList<T> Collection in C#?
// foreach (var item in linkedList)
// {
//        Console.WriteLine(item);
// }


// Example to Understand How to Create a Generic LinkedList<T> Collection and Add Elements in C#:
// using System;
// using System.Collections.Generic;
// namespace GenericLinkedListCollection
// {
//     public class Program
//     {
//         public static void Main()
//         {
//             LinkedList<string> linkedList = new LinkedList<string>();
//             linkedList.AddLast("India");
//             linkedList.AddLast("USA");
//             linkedList.AddLast("Srilanka");
//             linkedList.AddLast("UK");
//             linkedList.AddLast("Japan");

//             Console.WriteLine("LinkedList Elements");
//             foreach (var item in linkedList)
//             {
//                 Console.WriteLine(item);
//             }
//         }
//     }
// }


// How to Remove Elements From LinkedList<T> Collection in C#?
// Remove(LinkedListNode<T> node)
// Remove(T value)
// RemoveFirst()
// RemoveLast()
// Clear()


// How to check the Availability of elements in a Generic LinkedList<T> Collection in C#?
// Contains(T value)


// Advantages of Linked List in C#
// 1. They are dynamic in nature and allocate memory as and when required.
// 2. Insertion and deletion are easy to implement.
// 3. Other data structures such as Stack and Queue can also be implemented easily using Linked List.
// 4. It has faster access time and can be expanded in constant time without memory overhead.
// 5. Since there is no need to define an initial size for a linked list, hence memory utilization is effective.
// 6. Backtracking is possible in doubly-linked lists.
