// List is one of the generic collection classes present in System.Collections.Generic namespace
// A list class can be used to create a collection of any type.
// eg. list of integers, strings & complex types.

// The object stored in list can be accessed by index.
// list can  grow in size automatically.
// This class also provides methods to search, sort & manipulate lists.

using System;
namespace List
{
    class List
    {
        public static void Main()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000,
                Type = "RetailCustomer"
                
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000,
                Type = "RetailCustomer"
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Rob",
                Salary = 5500,
                Type = "RetailCustomer"
            };

            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "John",
                Salary = 6500,
                Type = "CorporateCustomer"
            };

            Customer customer5 = new Customer()
            {
                ID = 105,
                Name = "Sam",
                Salary = 3500,
                Type = "CorporateCustomer"
            };

            //  creating a customer array
            // Customer[] customers = new Customer[2];
            // customers[0] = customer1;
            // customers[1] = customer2;
            // customers[2] = customer3;
            // the above code will be throwing exception at run time as arrays doesn't grow in size.

            // creating list
            // syntax: List<T> name = new List<T>();
            List<Customer> customers = new List<Customer>(2);
            // adding items to list
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            // retrieve item from List
            // Customer c = customers[0];

            // printing customer details
            // Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            

            // Iterating
            // foreach loop
            // foreach(Customer cust in customers)
            // {
            //     Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            // }

            //for loop
            // for(int i=0; i<customers.Count; i++)
            // {
            //     c = customers[i];
            //     Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            // }

            // generic list are strongly typed
            // customers.Add(101); // throws compile time error
            
            // we can add the derived class item to list
            // SavingsCustomer sc = new SavingsCustomer();

            // customers.Add(sc);


            // inserting at specific position
            // customers.Insert(0, customer3); 

            // foreach(Customer cust in customers)
            // {
            //     Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            // }


            // finding index of object(IndexOf: returns the first occurance)
            // Console.WriteLine(customers.IndexOf(customer3));

            // finding from specific index (2nd argument)
            // Console.WriteLine(customers.IndexOf(customer3, 1));

            // no.of items to look (3rd argument)
            // Console.WriteLine(customers.IndexOf(customer3, 1, 2));
            // Console.WriteLine(customers.IndexOf(customer3, 1, 3));
            // Console.WriteLine(customers.IndexOf(customer3, 1, 5)); // throws exception OutOfRange


            // Contains() function - checks if an item exists in the list. This method returns true if the items exists, else false.
            // if(customers.Contains(customer3))
            // {
            //     Console.WriteLine("Customer 3 exists");
            // }
            // else
            // {
            //     Console.WriteLine("Customer3 does not exists");
            // }
             
            // Exists() function - checks if an item exists in the list based on a condition. This method returns true if the items exists, else false
            // if(customers.Exists(cust => cust.Name.StartsWith("P")))
            // {
            //     Console.WriteLine("starts with p");
            // }
            // else
            // {
            //     Console.WriteLine("not starts with p");
            // }
            
            // Find() function - Searches for an element that matched the condition defined by the secified lambda expression and returns the first matching item from the list
            // Customer findCustomer =  customers.Find(cust => cust.Salary > 5000);
            // Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", findCustomer.ID, findCustomer.Name, findCustomer.Salary);

            // FindLast() function - Searches for an element that matches the conditions defined by the specified lambda expression and returns the Last matching item from the list.
            // Customer findLastCustomer =  customers.FindLast(cust => cust.Salary > 5000);
            // Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", findLastCustomer.ID, findLastCustomer.Name, findLastCustomer.Salary);

            // FindAll() function - Returns all the items from the list that matches the condition specified by the lambda expression.
            // List<Customer> findAllCustomers =  customers.FindAll(cust => cust.Salary > 5000);
            // foreach(Customer cust in findAllCustomers)
            // {
            //     Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);   
            // }

            // FindIndex() function -  returns the index of the first item, that  matches the  condition specified by the lambda expression. There are s2 other overloads of this method which allows us to specify the range of elements to search, with in the list.
            // int index = customers.FindIndex(cust => cust.Salary > 5000);
            // Console.WriteLine("Index = "+index);

            // index = customers.FindIndex(2,  cust => cust.Salary > 5000);
            // Console.WriteLine("Index = "+index);
            
            // FindLastIndex() function - returns the index of the last item, that  matches the  condition specified by the lambda expression. There are2 other overloads of this method which allows us to specify the range of elements to search, with in the list.
            // int lastIndex = customers.FindLastIndex(cust => cust.Salary > 5000);
            // Console.WriteLine("Last Index = " + index);

            // Convert an array to a List - use ToList() method
            // Customer[] custArr = new Customer[3];
            // custArr[0] = customer1;
            // custArr[1] = customer2;
            // custArr[2] = customer3;

            // List<Customer> listCust = custArr.ToList();

            // foreach(Customer cust in listCust)
            // {
            //     Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);   
            // }
 
            // Convert a list to an array - ToArray()
            // Customer[] custArr =  customers.ToArray();

            // Convert a list to a dictionary - ToDictionary()
            // Dictionary<int, Customer> dict = customers.ToDictionary(x => x.ID);
            // foreach(KeyValuePair<int, Customer> kvp in dict)
            // {
            //     Console.WriteLine("Key= " + kvp.Key);
            // }



            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            List<Customer> listCorporateCustomers = new List<Customer>();
            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);

            // working with generic list class& ranges
            // AddRange() - Add() method allows us to add one item at a time to the end of the list, where as AddRange() allows us to add another list of items, to the end of the list.
            // listCustomers.AddRange(listCorporateCustomers);

            // foreach(Customer cust in listCustomers)
            // {
            //     Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            // }

            // GetRange() - using an item index, we can retrieve only one item at a time from the list, if we want to get a list of items from the list, then use GetRange() function.
            // This function expects 2 parameters,.e the start index in the list and the number of elements to return.
            // List<Customer> getRangeCust = listCustomers.GetRange(3, 2);

            // foreach(Customer cust in getRangeCust)
            // {
            //     Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", cust.ID, cust.Name, cust.Salary,cust.Type);
            // }

            // InsertRange() - Insert() method allows us to insert a single item into the list at a specified index, where as InsertRange() allow use, to insert another list of items to out list at the specified index.
            // listCustomers.InsertRange(0, listCorporateCustomers);

            // foreach(Customer cust in listCustomers)
            // {
            //     Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", cust.ID, cust.Name, cust.Salary,cust.Type);
            // }

            // RemoveRange() - Remove() function removes only the first matching item from the list. RemoveAt() function, removes the item at the specified index in the list.
            // RemoveAll() function removes all the items that matches the specified condition.
            // RemoveRange() method removes a range of elements from the list. This function excepts 2 parameters, i.e start index in the list and the number of elements to remove.
            // If you want to remove all the elements from the list without specifying any condition, then use Clear() function.
            // listCustomers.Remove(customer1);
            // listCustomers.RemoveAt(4);
            // listCustomers.RemoveAll(cust => cust.Type == "CorporateCustomer");

            // listCustomers.RemoveRange(3, 2);
            // foreach(Customer cust in listCustomers)
            // {
            //     Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", cust.ID, cust.Name, cust.Salary,cust.Type);
            // }

        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set;}
    }

    public class SavingsCustomer : Customer
    {
        
    }
}