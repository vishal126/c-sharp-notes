// Ordering operators
// OrderBy
// OrderByDescending
// ThenBy
// ThenByDescending
// Reverse

// OrderBy, OrderByDescending, ThenBy, and ThenByDescending can be used to sort data.

// Reverse method simply reverses the items in a given collection.


// Student.cs
// using System.Collections.Generic;
// namespace Demo
// {
//     public class Student
//     {
//         public int StudentID { get; set; }
//         public string Name { get; set; }
//         public int TotalMarks { get; set; }
//         public static List<Student> GetAllStudents()
//         {
//             List<Student> listStudents = new List<Student>
//             {
//                 new Student
//                 {
//                     StudentID= 101,
//                     Name = "Tom",
//                     TotalMarks = 800
//                 },
//                 new Student
//                 {
//                     StudentID= 102,
//                     Name = "Mary",
//                     TotalMarks = 900
//                 },
//                 new Student
//                 {
//                     StudentID= 103,
//                     Name = "Valarie",
//                     TotalMarks = 800
//                 },
//                 new Student
//                 {
//                     StudentID= 104,
//                     Name = "John",
//                     TotalMarks = 800
//                 },
//                 new Student
//                 {
//                     StudentID= 105,
//                     Name = "John",
//                     TotalMarks = 800
//                 }
//             };

//             return listStudents;
//         }
//     }
// }


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
//             Console.WriteLine("Studnet names before sorting");
            
//             List<Student> students = Student.GetAllStudents();
//             foreach (Student s in students)
//             {
//                 Console.WriteLine(s.Name);
//             }

//             Console.WriteLine();

//             Console.WriteLine("Studnet names after sorting");

//             IOrderedEnumerable<Student> result = Student.GetAllStudents().OrderBy(s => s.Name);

            // IOrderedEnumerable<Student> result = from student in Student.GetAllStudents()
            //                                      orderby student.Name
            //                                      select student;
            
            // foreach (Student s1 in result)
            // {
            //     Console.WriteLine(s1.Name);
            // }

            // descending
            // IOrderedEnumerable<Student> result = Student.GetAllStudents().OrderByDescending(s => s.Name);
            // IOrderedEnumerable<Student> result = from student in Student.GetAllStudents()
            //                                      orderby student.Name descending
            //                                      select student;
//         }
//     }
// }


// 11
// OrderBy or OrderByDescending work fine when we want to sort a collection just by one value or expression.
// If we want to sort by more than one value or expression, that's when we use ThenBy or ThenByDescending along with OrderBy or OrderByDescending.

// OrderBy or OrderByDescending performs the primary sort. ThenBy or ThenByDescending is used for adding secondary sort. 
// Secondary sort operators (ThenBy or ThenByDescending) can be used more than once in the same LINQ query.

// using System;
// using System.Collections.Generic;
// using System.Linq;
// namespace Demo
// {
//     class Program
//     {
//         static void Main()
//         {
            // eg1 sort by total marks then by name then by studentId
            // IOrderedEnumerable<Student> result = Student.GetAllStudents()
            // .OrderBy(s => s.TotalMarks).OrderBy(s => s.Name);  // This not works as it sorts acc to marks and name both not in sequence

            // IOrderedEnumerable<Student> result = Student.GetAllStudents()
            // .OrderBy(s => s.TotalMarks).ThenBy(s => s.Name).ThenByDescending(s => s.studentId);

            // IOrderedEnumerable<Student> result = from s in Student.GetAllStudents()
            //                                      orderby s.TotalMarks, s.Name, s.studentId descending
            //                                      select s;

            // reverse
//             IEnumerable<Student> result = Student.Reverse();

//             foreach (Student s in result)
//             {
//                 Console.WriteLine(s.TotalMarks + "\t" + s.Name + "\t" + s.StudentID);
//             }
//         }
//     }
// }