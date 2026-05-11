// Used to determing whether 2 sequences are equal.
// This method returns true if the sequences are equal otherwise false.

// For 2 sequences to be equal
// 1. Both the sequences sould have same number of elements and
// 2. Same values should be present in the same order in both the sequences

// ex.1 SequenceEqual() returns true
// string[] countries1 = {"USA", "India", "UK"};
// string[] countries2 = {"USA", "India", "UK"};

// var result = countries1.SequenceEqual(countries2);

// Console.WriteLine("Are Equal - " + result);


// ex.2 SequenceEqual() returns false, as the  default comparison is case sensitive
// string[] countries1 = {"USA", "India", "UK"};
// string[] countries2 = {"usa", "india", "uk"};

// var result = countries1.SequenceEqual(countries2);

// Console.WriteLine("Are Equal - " + result);


// ex.3 if we want the comparison to be case insensitive, then use the other overloaded version of SequenceEqual() method to which we can pass an alternate comparer
// string[] countries1 = {"USA", "India", "UK"};
// string[] countries2 = {"USA", "India", "UK"};

// var result = countries1.SequenceEqual(countries2, StringComparer.OrdinalIgnoreCase);

// Console.WriteLine("Are Equal - " + result);


// ex.4 SequenceEqual() returns false. This is because, although both the sequences contain same data, the data is not present in the same order.
// string[] countries1 = {"USA", "India", "UK"};
// string[] countries2 = {"UK", "India", "USA"};

// var result = countries1.SequenceEqual(countries2);

// Console.WriteLine("Are Equal - " + result);


// ex.5 to fix the problem in ex.4,use OrderBy() to sort data in the source sequences.
// string[] countries1 = {"USA", "India", "UK"};
// string[] countries2 = {"UK", "India", "USA"};

// var result = countries1.OrderBy(c => c).SequenceEqual(countries2.OrderBy(c => c));

// Console.WriteLine("Are Equal - " + result);


// ex.6 When comparing complex types, the default comparer will only check if the object references are equal. So, in this case SequenceEqual() returns false.

// Three ways to fix
// 1. Use the other overloaded version of SequenceEqual() method to which we can pass a custom class that implements IEqualityComparer
// 2. Override Equals() and GetHashCode() methods in Employee class
// 3. Project the properties into a new anonymous type, which overrides Equals() and GetHashCode() methods

// List<Employee> list1= new List<Employee>()
// {
//     new Employee { ID = 101, Name = "Mike"},
//     new Employee { ID = 102, Name = "Susy"}
// };

// List<Employee> list2= new List<Employee>()
// {
//     new Employee { ID = 101, Name = "Mike"},
//     new Employee { ID = 102,Name = "Susy"}
// };

// var result = list1.SequenceEqual(list2);

// Console.WriteLine("Are Equal = " + result);

using System;

namespace Demo
{
    class Employee
    {
        public int ID {get; set;}
        public string Name {get; set;}
    }

    class Program
    {
        public static void  Main()
        {
            string[] countries1 = {"USA", "India", "UK"};
            string[] countries2 = {"USA", "India", "UK"};

            var result = countries1.SequenceEqual(countries2);

            Console.WriteLine("Are Equal - " + result);


            string[] countries11 = {"USA", "India", "UK"};
            string[] countries21= {"usa", "india", "uk"};

            var result1 = countries11.SequenceEqual(countries21);

            Console.WriteLine("Are Equal - " + result1);


            string[] countries12 = {"USA", "India", "UK"};
            string[] countries22 = {"USA", "India", "UK"};

            var result2 = countries11.SequenceEqual(countries22, StringComparer.OrdinalIgnoreCase);

            Console.WriteLine("Are Equal - " + result2);

            string[] countries13 = {"USA", "India", "UK"};
            string[] countries23 = {"UK", "India", "USA"};

            var result3 = countries13.SequenceEqual(countries23);

            Console.WriteLine("Are Equal - " + result3);


            string[] countries14 = {"USA", "India", "UK"};
            string[] countries24 = {"UK", "India", "USA"};

            var result4 = countries14.OrderBy(c => c).SequenceEqual(countries24.OrderBy(c => c));

            Console.WriteLine("Are Equal - " + result4);


            List<Employee> list1= new List<Employee>()
            {
                new Employee { ID = 101, Name = "Mike"},
                new Employee { ID = 102, Name = "Susy"}
            };

            List<Employee> list2= new List<Employee>()
            {
                new Employee { ID = 101, Name = "Mike"},
                new Employee { ID = 102, Name = "Susy"}
            };

            var result5 = list1.SequenceEqual(list2);

            Console.WriteLine("Are Equal = " + result5);
        }
    }
}