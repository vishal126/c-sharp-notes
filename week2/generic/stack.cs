// Stack is a generic LIFO (Last in first out) collection class that is present in System.Collections.Generic namespace.
// The last item to be added (pushed) to the Stack, will be the first item to be removed (popped) from the Stack.

// To insert items to the end of the stacl, use Push() method.
// To remove and return an item that is present at the beginning of the Stack, use Pop() method.
// A foreach loop iterates through the items in the stack, but will not remove them from the stack.
// To check if an item, exists in the stack, use Contains() method.

// What is the difference between Pop() & Peek() methods?
// Pop() method removes and returns the item at the top of the stack, where as Peek() returns the item at the beginning of the stack, without removing it.

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
            Stack<Customer> stackCustomers = new Stack<Customer>();

            // EnStack
            stackCustomers.Push(customer1);
            stackCustomers.Push(customer2);
            stackCustomers.Push(customer3);
            stackCustomers.Push(customer4);
            stackCustomers.Push(customer5);

            // retrive item (pop)
            // Customer c1 = stackCustomers.Pop();
            // Console.WriteLine(c1.ID + " - " + c1.Name);
            // Console.WriteLine("Total items: " + stackCustomers.Count);

            // Customer c2 = stackCustomers.Pop();
            // Console.WriteLine(c2.ID + " - " + c2.Name);
            // Console.WriteLine("Total items: " + stackCustomers.Count);

            // Customer c3 = stackCustomers.Pop();
            // Console.WriteLine(c3.ID + " - " + c3.Name);
            // Console.WriteLine("Total items: " + stackCustomers.Count);

            // Customer c4 = stackCustomers.Pop();
            // Console.WriteLine(c4.ID + " - " + c4.Name);
            // Console.WriteLine("Total items: " + stackCustomers.Count);

            // Customer c5 = stackCustomers.Pop();
            // Console.WriteLine(c5.ID + " - " + c5.Name);
            // Console.WriteLine("Total items: " + stackCustomers.Count);

            // traversing

            // foreach(Customer c in stackCustomers)
            // {
            //     Console.WriteLine(c.ID + " - " + c.Name);
            //     Console.WriteLine("Total items in the Stack = " + stackCustomers.Count);
            // }


            // // Peek() - get beginning items without removing it
            // Customer c = stackCustomers.Peek();
            // Console.WriteLine(c.ID + " - " + c.Name);
            // Console.WriteLine("Total items in the Stack = " + stackCustomers.Count);


            // check for item existance - Contains()
            if(stackCustomers.Contains(customer1))
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