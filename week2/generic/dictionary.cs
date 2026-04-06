// A dictionary is a collection of (key, value) pairs.
// Dictionary class is present in System.Collections.Generic namespace.
// When creating a dictionary, we need to specify the type for key and value.
// Dictionary provides fast lookups for values using keys.
// Keys in the dictionary must be unique.

// Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();

// Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 5000};
// Customer customer2 = new Customer() { ID = 102, Name = "Mark", Salary = 5000};
// Customer customer3 = new Customer() { ID = 104, Name = "Mark", Salary = 5000};

// dictionaryCustomers.Add(customer1.ID, customer1);
// dictionaryCustomers.Add(customer2.ID, customer2);
// dictionaryCustomers.Add(customer3.ID, customer3);

// Customer customer101 = dictionaryCustomers[101];
// Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer101.ID, customer101.Name, customer101.Salary);

// foreach (KeyValuePair<int, Customer> customerKeyValuePair in dictionaryCustomers)
// {
//     Console.WriteLine("Key" + customerKeyValuePair.Key);
//     Customer cust = customerKeyValuePair.Value;
//     Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
// }



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
                Salary = 5000

            };

            Customer customer2 = new Customer()
            {
                ID = 110,
                Name = "Pam",
                Salary = 6500
            };

            Customer customer3 = new Customer()
            {
                ID = 119,
                Name = "John",
                Salary = 3500
            };

            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();

            dictionaryCustomers.Add(customer1.ID, customer1);
            dictionaryCustomers.Add(customer2.ID, customer2);
            dictionaryCustomers.Add(customer3.ID, customer3);
            // dictionaryCustomers.Add(customer3.ID, customer3); // throws runtime exception for duplicate key

            // // check first for the existance of key then insert record
            // if(!dictionaryCustomers.ContainsKey(customer1.ID))
            // {
            //     dictionaryCustomers.Add(customer1.ID, customer1);
            // }

            // // retriving the customer data
            // Customer customer119 = dictionaryCustomers[119];
            // Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer119.ID, customer119.Name, customer119.Salary);

            // what if the key not exists and we are trying to retrieve that
            // Customer nonCustomer = dictionaryCustomers[135]; // throws the runtime exception

            // // check for existance first then try to retrieve
            // if(dictionaryCustomers.ContainsKey(135))
            // {
            //     Customer nonCustomer = dictionaryCustomers[135];
            // }

            // // iterating over dictionary
            // foreach (KeyValuePair<int, Customer> customerKeyValuePair in dictionaryCustomers)
            // {
            //     Console.WriteLine("ID = {0}", customerKeyValuePair.Key);
            //     Customer cust = customerKeyValuePair.Value;
            //     Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //     Console.WriteLine("-----------------------------------------------------------------------");
            // }


            // foreach (var customerKeyValuePair in dictionaryCustomers)
            // {
            //     Console.WriteLine("ID = {0}", customerKeyValuePair.Key);
            //     Customer cust = customerKeyValuePair.Value;
            //     Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //     Console.WriteLine("-----------------------------------------------------------------------");
            // }

            // // iterating through keys only
            // foreach (int key in dictionaryCustomers.Keys)
            // {
            //     Console.WriteLine(key);
            // }

            // // iterating through values only
            // foreach (Customer cust in dictionaryCustomers.Values)
            // {
            //     Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //     Console.WriteLine("-----------------------------------------------------------------------");
            // }


            // // TryGetValue()
            // // if we are not sure that the dictionary contains the key or not and try to avoid runtime exception then we will use this method.
            // Customer cust;
            // if(dictionaryCustomers.TryGetValue(/*111*/101, out cust))
            // {
            //     Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            // }
            // else
            // {
            //     Console.WriteLine("The key is not found");
            // }

            // // Count()
            // Console.WriteLine("Total items = {0}", dictionaryCustomers.Count);
            // // or
            // Console.WriteLine("Total items = {0}", dictionaryCustomers.Count()); // This is a LINQ extension method

            // // count of emp whose salary is greater than 4000
            // Console.WriteLine("Total items = {0}", dictionaryCustomers.Count(kvp => kvp.Value.Salary > 4000));


            // // Remove()
            // dictionaryCustomers.Remove(110);
            // Console.WriteLine("Total items = {0}", dictionaryCustomers.Count);

            
            // // Clear()
            // removes all items from the  dictionary
            // dictionaryCustomers.Clear();
            // Console.WriteLine("Total items = {0}", dictionaryCustomers.Count);


            // // Using LINQ extension methods with Dictionary
            // Console.WriteLine("Total items = {0}", dictionaryCustomers.Count()); // This is a LINQ extension method


            // // Different ways to convert an array into a dictionary
            // Customer[] customers = new Customer[3];
            // customers[0] = customer1;
            // customers[1] = customer2;
            // customers[2] = customer3;

            // Dictionary<int, Customer> dict = customers.ToDictionary(cust=>cust.ID, cust=>cust);

            // foreach (KeyValuePair<int, Customer> customerKeyValuePair in dict)
            // {
            //     Console.WriteLine("ID = {0}", customerKeyValuePair.Key);
            //     Customer cust = customerKeyValuePair.Value;
            //     Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //     Console.WriteLine("-----------------------------------------------------------------------");
            // }


            // // list to dictionary
            // List<Customer> lCustomers = new List<Customer>();
            // lCustomers.Add(customer1);
            // lCustomers.Add(customer2);
            // lCustomers.Add(customer3 );

            // Dictionary<int, Customer> lDict = customers.ToDictionary(cust=>cust.ID, cust=>cust);

            // foreach (KeyValuePair<int, Customer> customerKeyValuePair in lDict)
            // {
            //     Console.WriteLine("ID = {0}", customerKeyValuePair.Key);
            //     Customer cust = customerKeyValuePair.Value;
            //     Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //     Console.WriteLine("-----------------------------------------------------------------------");
            // }
        }


        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
        }
    }
}