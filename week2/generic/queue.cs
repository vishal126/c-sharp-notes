// Queue is a generic FIFO (First in first out) collection class that is present in System.Collections.Generic namespace.
// The first item to be added (enqueued) to the queue, will be the first item to be removed (dequeued) from the Queue.

// To add items to the end of the queue, use Enqueue() method.
// To remove an item that is present at the beginning of the queue, use Dequeue() method.
// A foreach loop iterates through the items in the queue, but will not remove them from the queue.
// To check if an item, exists in the queue, use Contains() method.

// What is the difference between Dequeue() & Peek() methods?
// Dequeue() method removes and returns the item at the beginning of the queue, where as Peek() returns the item at the beginning of the queue, without removing it.

using System;
using System.Collections.Generic;

namespace SortComplex
{
    public class SortComplex
    {
        public static void Main()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Gender = "Male"

            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Gender = "Female"
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "John",
                Gender = "Male"
            };

            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "Ken",
                Gender = "Male"
            };
            
            Customer customer5 = new Customer()
            {
                ID = 105,
                Name = "Valarie",
                Gender = "Female"
            };

            // declaring
            Queue<Customer> queueCustomers = new Queue<Customer>();

            // Enqueue
            queueCustomers.Enqueue(customer1);
            queueCustomers.Enqueue(customer2);
            queueCustomers.Enqueue(customer3);
            queueCustomers.Enqueue(customer4);
            queueCustomers.Enqueue(customer5);

            // retrive item (dequeue)
            // Customer c1 = queueCustomers.Dequeue();
            // Console.WriteLine(c1.ID + " - " + c1.Name);
            // Console.WriteLine("Total items: " + queueCustomers.Count);

            // Customer c2 = queueCustomers.Dequeue();
            // Console.WriteLine(c2.ID + " - " + c2.Name);
            // Console.WriteLine("Total items: " + queueCustomers.Count);

            // Customer c3 = queueCustomers.Dequeue();
            // Console.WriteLine(c3.ID + " - " + c3.Name);
            // Console.WriteLine("Total items: " + queueCustomers.Count);

            // Customer c4 = queueCustomers.Dequeue();
            // Console.WriteLine(c4.ID + " - " + c4.Name);
            // Console.WriteLine("Total items: " + queueCustomers.Count);

            // Customer c5 = queueCustomers.Dequeue();
            // Console.WriteLine(c5.ID + " - " + c5.Name);
            // Console.WriteLine("Total items: " + queueCustomers.Count);

            // traversing

            // foreach(Customer c in queueCustomers)
            // {
            //     Console.WriteLine(c.ID + " - " + c.Name);
            //     Console.WriteLine("Total items in the Queue = " + queueCustomers.Count);
            // }


            // // Peek() - get beginning items without removing it
            // Customer c = queueCustomers.Peek();
            // Console.WriteLine(c.ID + " - " + c.Name);
            // Console.WriteLine("Total items in the Queue = " + queueCustomers.Count);


            // check for item existance - Contains()
            if(queueCustomers.Contains(customer1))
            {
                Console.WriteLine("Customer1 exists");
            }
            else
            {
                Console.WriteLine("Customer1 does not exists");
            }
        }


        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
        }
    }
}