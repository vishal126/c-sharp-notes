// Student.cs file from part 12 with 11 records

// Program.cs
// using System;
// using System.Transactions;

// namespace Demo
// {
//     class Program
//     {
//         public static void Main()
//         {
//             do
//             {
//                 IEnumerable<Student> students = Student.GetAllStudents();
//                 int pageNumber = 0;
//                 if(int.TryParse(Console.ReadLine(), out pageNumber))
//                 {
//                     if(int.TryParse(Console.ReadLine(), out pageNumber))
//                     {
//                         int pageSize = 3;
//                         IEnumerable<Student> result = students.Skip((pageNumber-1)*pageSize).Take(pageSize);

//                         Console.WriteLine();
//                         Console.WriteLine("Displaying Page " + pageNumber);
//                         foreach (Student s in result)
//                         {
//                             Console.WriteLine(s.StudentId + "\t" + s.Name + "\t" + s.TotalMarks);
//                         }
//                         Console.WriteLine();
//                     }
//                     else
//                     {
//                         Console.WriteLine("Page number must be an integer between 1 and 4");
//                     }
//                 }
//                 else
//                 {
//                     Console.WriteLine("Page number must be an integer between 1 and 4");
//                 }
//             } while(1 == 1);
//         }

//     }
// }