// Partitioning operators
// Take, Skip, TakeWhile, SkipWhile

// Take method returns a specific number of elements from the start of the collection.
// The number of items to return is specified using the count parameter this method expects.

// using System;
// using System.Collections.Generic;
// using System.Linq;
// namespace Demo
// {
//     class Program
//     {
//         static void Main()
//         {
//             string[] countries = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy"};

//             IEnumerables<string> result = countries.Take(3);
            
//             // IEnumerables<string> result = (from country in countries
//             //                               select country).Take(3);

//             foreach (string str in result)
//             {
//                 Console.WriteLine(str);
//             }
//         }
//     }
// }

// Skip method skips a specified number of elements in a collection and then returns the remaining elements.
// The number of items to skip is specified using the count parameter this method expects.


// using System;
// using System.Collections.Generic;
// using System.Linq;
// namespace Demo
// {
//     class Program
//     {
//         static void Main()
//         {
//             string[] countries = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy"};

//             IEnumerables<string> result = countries.Skip(3);
            
//             // IEnumerables<string> result = (from country in countries
//             //                               select country).Skip(3);

//             foreach (string str in result)
//             {
//                 Console.WriteLine(str);
//             }
//         }
//     }
// }


// TakeWhile method returns elements from a collection as long as the given condition specified by the predicate is true.
// SkipWhile method skip elements from a collection as long as the given condition specified by the predicate is true & returns items where condition fails.

// using System;
// using System.Collections.Generic;
// using System.Linq;
// namespace Demo
// {
//     class Program
//     {
//         static void Main()
//         {
//             string[] countries = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy"};

//             IEnumerables<string> result = countries.TakeWhile(s => s.Length > 2);

//             IEnumerables<string> resultSkip = countries.SkipWhile(s => s.Length > 2);
            
//            IEnumerables<string> result = (from country in countries
//                                          select country).TakeWhile(s => s.Length > 2);

//             foreach (string str in result)
//             {
//                 Console.WriteLine(str);
//             }
//         }
//     }
// }