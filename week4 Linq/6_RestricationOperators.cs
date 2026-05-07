// The WHERE std query operator belong to Restriction Operators category.
// Just like SQL, the WHERE std query operator in LINQ is used to filter rows.
// The filter expression is specified using a predicate.

// 2 overloaded versions in Enumerable class
// public static IEnumerable<TSource> Where <TSource>(
//     this IEnumerable<TSource> source, Func<TSource, bool> predicate);

// public static IEnumerable<Tsource> Where<TSource>(
//     this IEnumerable<TSource> source, Func<TSource, int, bool> predicate);

// what is predicate?
// it is a fn to test each element for a condition.

// Note: Where query operator is optional.


// using System;
// using System.Linq;

// namespace Demo
// {
//     class Program
//     {
//         static void Main()
//         {
//             List<int> numbers = new List<int> {1,2,3,4,5,6,7,8};
//             IEnumerable<int> evenNumbers = numbers.Where(x => x%2 == 0);

//             foreach (int i in evenNumbers)
//             {
//                 Console.WriteLine(i);
//             }
//         }
//     }
// }

// Where method expects a parameter predicate and its type is Func<int, bool>
// but if we see definition of this function then it excepts 2 parameters "this IEnumerable<TSource> source, Func<TSource, Func<TSource, bool> predicate" or "this IEnumerable<TSource> source, Func<TSource, Func<TSource, int, bool> predicate"
// we need to pass only one parameter to Where function which is predicate because this method is a extension method and we call it like numebrs.Where(x=>x%2==0) so it maps the numbers as first parameter.

// The "Func" is a delegate (fn pointer) so the second argument can be a lambda expression (or predicate name in which lambda expression is stored) or function name which returns bool.

// The type of "Func" is <int, bool> (Func<in T, out TResult>)
// if a lambda expression is not evaluated to true/false then we will get a compilation error (x=>x+2 not evaluate to bool)

// passing predicate name
// using System;
// using System.Linq;

// namespace Demo
// {
//     class Program
//     {
//         static void Main()
//         {
//             List<int> numbers = new List<int> {1,2,3,4,5,6,7,8};
            
//             Func<int, bool> predicate = x => x%2 == 0;
//             IEnumerable<int> evenNumbers = numbers.Where(predicate);

//             foreach (int i in evenNumbers)
//             {
//                 Console.WriteLine(i);
//             }
//         }
//     }
// }


// passing a separate function
// using System;
// using System.Linq;

// namespace Demo
// {
//     class Program
//     {
//         static void Main()
//         {
//             List<int> numbers = new List<int> {1,2,3,4,5,6,7,8};
//             IEnumerable<int> evenNumbers = numbers.Where(num => IsEven(num));

//             foreach (int i in evenNumbers)
//             {
//                 Console.WriteLine(i);
//             }
//         }

//         private static bool IsEven(int number)
//         {
//             return number%2 == 0;
//         }
//     }
// }


// writing LINQ query that looks like t-sql
// using System;
// using System.Linq;

// namespace Demo
// {
//     class Program
//     {
//         static void Main()
//         {
//             List<int> numbers = new List<int> {1,2,3,4,5,6,7,8};
//             IEnumerable<int> evenNumbers = from num in numbers
//                                             where num%2==0
//                                             select num;

//             foreach (int i in evenNumbers)
//             {
//                 Console.WriteLine(i);
//             }
//         }
//     }
// }


// overloaded version of Where
// public static IEnumerable<Tsource> Where<TSource>(
//     this IEnumerable<TSource> source, Func<TSource, int, bool> predicate);

// the middle int is for the index position of the element.

// using System;
// using System.Linq;

// namespace Demo
// {
//     class Program
//     {
//         static void Main()
//         {
//             List<int> numbers = new List<int> {1,2,3,4,5,6,7,8};

//             // var res = numbers.Select((num, index)=>new {Number = num, Index = index})
//             var res = numbers.Select((num, index)=>new {Number = num, Index = index}).Where(x => x.Number % 2 == 0).Select(x => x.Index);

//             foreach (var item in res)
//             {
//                 // Console.WriteLine(item.Number + " - " + item.Index);
//                 Console.WriteLine(item);
//             }
//         }
//     }
// }


// for reteriving and filtering using db
// EmployeeDBContext context = new EmployeeDBContext();
// IEnumerable<Department> depts = context.Departments.Where(x => x.Name == "IT" || x.Name == "HR");

// for(Department dept in depts)
// {
//      Console.WriteLine("Department - " + dept.Name);
//      IEnumerable<Employee> employees = dept.Employees.Where(x => x.gender == "Male");
//      
//      foreach(Employee emp in employees)
//      {
//          Console.WriteLine("\tEmployee Name = " + emp.FirstName + " " + emp.LastName);
//      }
//      Console.WriteLine();
// }