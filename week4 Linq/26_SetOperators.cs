// Set Operators
// Distinct
// Union
// Intersect
// Except

// Distinct operators returns distinct elements from a given collection.

// Example 1: Return distinct country names.
// In this example the default comparer i being used and the comparison is case-sensitive, so in the output we see country USA 2 times.
// string[] countries = { "USA", "usa", "INDIA", "UK", "UK" };
// var result = countries.Distinct();

// foreach (var v in result)
// {
//     Console.WriteLine(v);
// }

// OUTPUT: USA usa INDIA UK


// Example 2: For the comparison to be case-insensitive,
// use the other overloaded version of Distinct() method to which we can pass a class that implements IEqualityComparer as an argument.
// In this case we see country USA only once in the output.
// string[] countries = { "USA", "usa", "INDIA", "UK", "UK" };
// var result = countries.Distinct(StringComparer.OrdinalIgnoreCase);
// foreach (var v in result)
// {
//     Console.WriteLine(v);
// }

// OUTPUT: USA INDIA UK


// When comparing elements, Distinct() works in a slightly different manner with complex types like Employee, Customer etc.
// Example 3: Notice that in the output we don't get unique employees.
// This is because, the default comparer is being used which will just check for object references being equal
// and not the individual property values.

// List<Employee> list = new List<Employee>()
// {
//     new Employee { ID = 101, Name = "Mike"},
//     new Employee { ID = 101, Name = "Mike"},
//     new Employee { ID = 102, Name = "Mary"}
// };
// var result = list.Distinct();
// foreach (var v in result)
// {
//     Console.WriteLine(v.ID + "\t" + v.Name);
// }

// OUTPUT:
// 101     Mike
// 101     Mike
// 102     Mary

// To solve the problem in Example 3, there are 3 ways
// 1. Use the other overloaded version of Distinct() method to which we can pass a custom class that implements IEqualityComparer
// 2. Override Equals() and GetHashCode() methods in Employee class
// 3. Project the properties into a new anonymous type, which overrides Equals() and GetHashCode() methods

// Example 4: Using the overloaded version of Distinct() method to which we can pass
// a custom class that implements IEqualityComparer

// Step 1: Create a custom class that implements IEqualityComparer<T>
// and implement Equals() and GetHashCode() methods
// public class EmployeeComparer: IEqualityComparer<Employee>
// {
//     public bool Equals(Employee x, Employee y)
//     {
//         return x.ID == y.ID && x.Name == y.Name;
//     }
//     public int GetHashCode (Employee obj)
//     {
//         return obj.ID.GetHashCode() ^ obj.Name.GetHashCode();
//     }
// }

// Step 2: Pass an instance of EmployeeComparer as an argument to Distinct() method
// var result = list.Distinct(new EmployeeComparer());

// Example 5: Override Equals() and GetHashCode() methods in Employee class
// public class Employee
// {
//     public int ID { get; set; }
//     public string Name { get; set; }
//     public override bool Equals(object obj)
//     {
//         return this.ID == ((Employee) obj).ID && this.Name == ((Employee)obj).Name;
//     }
//     public override int GetHashCode()
//     {
//         return this. ID.GetHashCode() ^ this.Name.GetHashCode();
//     }
// }

// Example 6: Project the properties into a new anonymous type, which overrides Equals() and  GetHashCode() methods.
// var result = list.Select(x => new { x.ID, x.Name }).Distinct();

using System;

namespace Demo
{
   public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        // ex.5
        // public override bool Equals(object obj)
        // {
        //     return this.ID == ((Employee) obj).ID && this.Name == ((Employee)obj).Name;
        // }
        // public override int GetHashCode()
        // {
        //     return this. ID.GetHashCode() ^ this.Name.GetHashCode();
        // }
    }

    public class EmployeeComparer: IEqualityComparer<Employee>
    {
        public bool Equals(Employee x, Employee y)
        {
            return x.ID == y.ID && x.Name == y.Name;
        }
        public int GetHashCode (Employee obj)
        {
            return obj.ID.GetHashCode() ^ obj.Name.GetHashCode();
        }
    }

    class Program
    {
        public static void Main()
        {
            // ex.1,2
            // string[] countries = { "USA", "usa", "INDIA", "UK", "UK"};

            // // var result = countries.Distinct();

            // var result = countries.Distinct(StringComparer.OrdinalIgnoreCase);

            // foreach (var v in result)
            // {
            //     Console.WriteLine(v);
            // }

            // complex types (ex.3)
            List<Employee> list = new List<Employee>()
            {
                new Employee { ID = 101, Name = "Mike"},
                new Employee { ID = 101, Name = "Mike"},
                new Employee { ID = 102, Name = "Mary"}
            };

            // var result = list.Distinct();

            // ex.4 Distinct() overloaded version
            // var result = list.Distinct(new EmployeeComparer());

            // ex.5
            // var result = list.Distinct();

            // ex.6
            var result = list.Select(x => new { x.ID, x.Name }).Distinct();

            foreach (var v in result)
            {
                Console.WriteLine(v.ID + "\t" + v.Name);
            }
        }
    }
}