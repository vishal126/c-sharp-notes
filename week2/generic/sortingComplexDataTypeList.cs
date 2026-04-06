// to sort a list of complex types without using linq, the complex type has to implement IComparable interface and provide implementation for CompareTo() method.
// CompareTo() method returns an integer, and the meaning of the  return value is below.
// RETURN VALUE is
// Greater than zero - the current instance is greater than the object being compare with.
// Less than zero - the current instance is less than the object being compared with.
// is zero - the current instance is equal to the object  being compared with.

// public class Customer : IComparable<Customer>
// {
//     public int ID { get; set; }
//     public string Name { get; set; }
//     public int Salary { get; set; }

//     public int CompareTo(Customer obj)
//     {
//         // if(this.Salary>obj.Salary)
//         //     return 1;
//         // else if(this.Salary<obj.Salary)
//         //     return -1;
//         // else
//         //     return 0;

//         // alternatively we can also invoke CompareTo() method.
//         return this.Salary.CompareTo(obj.Salary);
//     }
// }


// using System;
// namespace SortComplex
// {
//     public class SortComplex
//     {
//         public static void Main()
//         {
//             Customer customer1 = new Customer()
//             {
//                 ID = 101,
//                 Name = "Mark",
//                 Salary = 4000

//             };

//             Customer customer2 = new Customer()
//             {
//                 ID = 102,
//                 Name = "Pam",
//                 Salary = 7000
//             };

//             Customer customer3 = new Customer()
//             {
//                 ID = 103,
//                 Name = "Rob",
//                 Salary = 5500
//             };

//             List<Customer> listCustomers = new List<Customer>();
//             listCustomers.Add(customer1);
//             listCustomers.Add(customer2);
//             listCustomers.Add(customer3);

//             // Console.WriteLine("Before sorting: ");
//             // foreach(Customer c in listCustomers)
//             // {
//             //     Console.WriteLine(c.Salary); 
//             // }

//             // sorting
//             // listCustomers.Sort();

//             // Console.WriteLine("after sorting: ");
//             // foreach(Customer c in listCustomers)
//             // {
//             //     Console.WriteLine(c.Salary); 
//             // }


//             // // desccending  order
//             // listCustomers.Reverse();

//             // Console.WriteLine("After reverse: ");
//             // foreach(Customer c in listCustomers)
//             // {
//             //     Console.WriteLine(c.Salary); 
//             // }


//             // sorting according to name
//             Console.WriteLine("Before sorting: ");
//             foreach(Customer c in listCustomers)
//             {
//                 Console.WriteLine(c.Name); 
//             }

//             // sorting
//             listCustomers.Reverse();

//             Console.WriteLine("after sorting: ");
//             foreach(Customer c in listCustomers)
//             {
//                 Console.WriteLine(c.Name); 
//             }
//         }

//     }

//     public class Customer : IComparable<Customer>
//     {
//         public int ID { get; set; }
//         public string Name { get; set; }
//         public int Salary { get; set; }

//         public int CompareTo(Customer other)
//         {
//             // if(this.Salary > other.Salary)
//             //     return 1;
//             // else if(this.Salary < other.Salary)
//             //     return -1;
//             // else
//             //     return  0;

//             // we can use the  int IComparable function

//             // return this.Salary.CompareTo(other.Salary);

//             //sorting by name
//             return this.Name.CompareTo(other.Name);
//         }
//     }
// }


// If you prefer not to use the sort functionality provided by the class, then we can provide our own, by implementing IComparer Interface.
// for eg. if i want the customers to sorted by name instead of salary.

// step 1: implement IComparer interface

// public class SortByName : IComparer<Customer>
// {
//     public int Compare(Customer x, Customer y)
//     {
//         return x.Name.CompareTo(y.Name);
//     }
// }

// step 2: pass an instance of the class that implements IComparer interface, as an argument to the Sort() method.
// SortByName sortByName = new SortByName();
// listCustomers.sort(sortByName);


// using System;
// namespace SortComplex
// {
//     public class SortComplex
//     {
//         public static void Main()
//         {
//             Customer customer1 = new Customer()
//             {
//                 ID = 101,
//                 Name = "Mark",
//                 Salary = 4000

//             };

//             Customer customer2 = new Customer()
//             {
//                 ID = 102,
//                 Name = "Pam",
//                 Salary = 7000
//             };

//             Customer customer3 = new Customer()
//             {
//                 ID = 103,
//                 Name = "Rob",
//                 Salary = 5500
//             };

//             List<Customer> listCustomers = new List<Customer>();
//             listCustomers.Add(customer1);
//             listCustomers.Add(customer2);
//             listCustomers.Add(customer3);

//             SortByName sortByName = new SortByName();
//             listCustomers.Sort(sortByName);

//             Console.WriteLine("sorting by name: ");
//             foreach(Customer c in listCustomers)
//             {
//                 Console.WriteLine(c.Name ); 
//             }
//         }

//     }

//     public class SortByName : IComparer<Customer>
//     {
//         public int Compare(Customer x, Customer y)
//         {
//             return x.Name.CompareTo(y.Name);
//         }
//     }

//     public class Customer : IComparable<Customer>
//     {
//         public int ID { get; set; }
//         public string Name { get; set; }
//         public int Salary { get; set; }

//         public int CompareTo(Customer other)
//         {
//             // if(this.Salary > other.Salary)
//             //     return 1;
//             // else if(this.Salary < other.Salary)
//             //     return -1;
//             // else
//             //     return  0;

//             // we can use the  int IComparable function

//             return this.Salary.CompareTo(other.Salary);
//         }
//     }
// }



// using Comparison delegate with List<T>
// one of the overloads of the Sort() method in List class expects Comparison delefate to be passed as an argument.
// public void Sort(Comparison<T> comparison);

// Approach 1:
// step 1: create a function whose signature matches the  signature of System.Comparison delegate. This is the method where we need to write the logic to compare 2 customer objects.
// step 2: create an instance of System.Comparison delegate, and then pass the name of the function created in step1 as an argument.
// so, at this point "Comparison" delegate is pointing to our function that contains the logic to compare 2 customer objects.
// step 3: pass the delegate instance as an argument, to Sort() function.
// listCustomers.Sort(customerComparer);

// what is an delegate?
// it is an function pointer.
// signature of function match with the signature of the delegate to which it is pointing to that's why it is called type safe  function pointer.


// using System;
// namespace SortComplex
// {
//     public class SortComplex
//     {
//         public static void Main()
//         {
//             Customer customer1 = new Customer()
//             {
//                 ID = 101,
//                 Name = "Mark",
//                 Salary = 4000

//             };

//             Customer customer2 = new Customer()
//             {
//                 ID = 102,
//                 Name = "Pam",
//                 Salary = 7000
//             };

//             Customer customer3 = new Customer()
//             {
//                 ID = 103,
//                 Name = "Rob",
//                 Salary = 5500
//             };

//             List<Customer> listCustomers = new List<Customer>();
//             listCustomers.Add(customer1);
//             listCustomers.Add(customer3);
//             listCustomers.Add(customer2);

//             Comparison<Customer> customerComparer = new Comparison<Customer>(CompareCustomer);
            
//             Console.WriteLine("before sorting: ");
//             foreach(Customer c in listCustomers)
//             {
//                 Console.WriteLine(c.ID);
//             }

//             listCustomers.Sort(customerComparer);

//             Console.WriteLine("after sorting: ");
//             foreach(Customer c in listCustomers)
//             {
//                 Console.WriteLine(c.ID);
//             }
//         }

//         private static int CompareCustomer (Customer x, Customer y)
//         {
//             return x.ID.CompareTo(y.ID);
//         }

//     }

//     public class Customer : IComparable<Customer>
//     {
//         public int ID { get; set; }
//         public string Name { get; set; }
//         public int Salary { get; set; }
//     }
// }


// Approach 2:
// we dont need to follow all the steps of approach 1


using System;
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

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer3);
            listCustomers.Add(customer2);
            
            Console.WriteLine("before sorting: ");
            foreach(Customer c in listCustomers)
            {
                Console.WriteLine(c.ID);
            }

            // listCustomers.Sort(delegate(Customer c1, Customer c2) { return c1.ID.CompareTo(c2.ID); });
            //using lambda expression
            listCustomers.Sort((x,y)=> x.ID.CompareTo(y.ID));

            Console.WriteLine("after sorting: ");
            foreach(Customer c in listCustomers)
            {
                Console.WriteLine(c.ID);
            }


            // Sorting Collection of Complex Types using LINQ in C#:
            listCustomers = listCustomers.OrderBy(x => x.Name).ToList();
            Console.WriteLine("\nEmployees After Sorting using Linq");
            foreach(Customer c in listCustomers)
            {
                Console.WriteLine(c.ID);
            }
        }

    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}