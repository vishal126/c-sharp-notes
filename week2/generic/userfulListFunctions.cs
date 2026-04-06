// useful methods of list collection class
// TrueForAll()-Returns true or false depending on whether if every element in the list matches the conditions defined by the specified predicate.

// AsReadOnly() - Returns a read-only wrapper for the current collection. Use this method, if you don't want the client code to modify the collection
// i.e add or remove any elements from the collection. The ReadOnlyCollection will not have methods to add or remove items from the collection.
// You can only read items from this collection.

// TrimExcess()-Sets the capacity to the actual number of elements in the List, if that number is less than a threshold value.

// According to MSDN:
// This method can be used to minimize a collection's memory overhead if no new elements will be added to the collection.
// The cost of reallocating and copying a large List<T> can be considerable. So the TrimExcess method does nothing if the list is at more than 90 percent of capacity.
// This avoids incurring a large reallocation cost for a relatively small gain. The current threshold is 90 percent, but this could change in the future.


using System;
using System.Collections.ObjectModel;
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
                Salary = 4000

            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Rob",
                Salary = 5500
            };

            List<Customer> listCustomers = new List<Customer>(100);
            listCustomers.Add(customer1);
            listCustomers.Add(customer3);
            listCustomers.Add(customer2);
            
            // TrueForAll()
            Console.WriteLine("Are all salaries greater than 5000 = " +  listCustomers.TrueForAll(x=>x.Salary>5000));
            Console.WriteLine("Are all salaries greater than 3000 = " +  listCustomers.TrueForAll(x=>x.Salary>3000));

            // AsReadOnly()
            ReadOnlyCollection<Customer> readonlyCustomers = listCustomers.AsReadOnly();
            Console.WriteLine("Total Items = " + readonlyCustomers.Count);
            // readonlyCustomers[0] = customer2; // throws error

        
            // TrimExcess()
            Console.WriteLine("Capacity: " + listCustomers.Capacity);
            listCustomers.TrimExcess();
            Console.WriteLine("Capacity: " + listCustomers.Capacity);
        }

        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
        }
    }
}