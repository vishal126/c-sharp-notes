// LINQ operators categories based on execution behaviour
// 1. Deferred or Lazy Operators - These query operators use deferred execution. Examples - select, where, Take, Skip etc.
// 2. Immediate or Greedy Operators - These query operators use immediate execution. Examples - count, average, min, max, ToList etc

using System;
using System.Collections.Generic;
using System.Linq;
namespace Demo
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; } 
    }
    class Program
    {
        public static void Main()
        {
            List<Student> listStudents = new List<Student>
            {
                new Student { StudentID= 101, Name = "Mary", TotalMarks = 900 },
                new Student { StudentID= 103, Name = "Pam", TotalMarks = 800},
                new Student { StudentID= 102, Name = "Tom", TotalMarks = 800 }
            };

            // deferred execution
            // this query is executed in the below foreach loop.
            // IEnumerable<Student> result = from student in listStudents
            //                                 where student.TotalMarks == 800
            //                                 select student;
            
            // // To see that i have added new student which will also printed in the loop.
            // listStudents.Add(new Student() { StudentID = 104, Name = "Tim", TotalMarks = 800 });

            // foreach (Student s in result)
            // {
            //     Console.WriteLine(s.StudentID + "\t" + s.Name + "\t" + s.TotalMarks);
            // }

            Console.WriteLine();

            // immediate execution
            // use any of the immediate operator
            IEnumerable<Student> resultI = (from student in listStudents
                                            where student.TotalMarks == 800
                                            select student).ToList();
            
            // To see that i have added new student which will not printed in the loop.
            listStudents.Add(new Student() { StudentID = 104, Name = "Tim", TotalMarks = 800 });

            foreach (Student s in resultI)
            {
                Console.WriteLine(s.StudentID + "\t" + s.Name + "\t" + s.TotalMarks);
            }
        }
    }
}