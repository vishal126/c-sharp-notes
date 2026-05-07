// Student.cs
// from part 7

// Program.cs
// using System;
// using System.Collections.Generic;
// using System.Linq;
// namespace Demo
// {
//     class Program
//     {
//         static void Main()
//         {
//             IEnumerable<List<string>> result = Student.GetAllStudetns().Select(x => x.Subjects);
//             foreach (List<string> stringList in result)
//             {
//                 foreach (string str in stringList)
//                 {
//                     Console.WriteLine(str);
//                 }
//             }

//             IEnumerable<string> result = Student.GetAllStudetns().SelectMany(x => x.Subjects);
//             foreach (string str in result)
//             {
//                 Console.WriteLine(str);
//             }
//         }
//     }
// }

// using select we need  to use 2 nested loops
// using selectMany we only needs to loop one time as it flattens queries that return lists of lists into a sigle list.