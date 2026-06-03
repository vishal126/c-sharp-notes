// LINQ  projection operators
// Select
// SelectMany

// These are used to transform the results of a query. Select clause in SQL allows to specify what columns we want to retrieve.
// In a similar fashion LINQ select std query operator allows us to specify what properties we want to retrieve. It also allows us to perform calculations.


// eg
// public class Employee
// {
//     public int EmployeeID {get; set;}
//     public string FirstName {get; set;}
//     public string LastName {get; set;}
//     public string Gender {get; set;}
//     public int AnnualSalary {get; set;}
// }

// Using the SELECT projection operator
// 1. we can select just EmployeeID property
// 2. We can select multiple properties (FirstName & Gender) into an anonymous type
// 3. Perform calculations
//      MonthlySalary = AnnualSalary/2
//      FullName = FirstName + " " + LastName

// Employee.cs
// using System;

// namespace Demo
// {
//     public class Employee
//     {
//         public int EmployeeID {get; set;}
//         public string FirstName {get; set;}
//         public string LastName {get; set;}
//         public string Gender {get; set;}
//         public int AnnualSalary {get; set;}

//         public static List<Employee> GetAllEmployees()
//         {
//             List<Employee> listEmployees = new List<Employee>
//             {
//                 new Employee
//                 {
//                     EmployeeID = 101,
//                     FirstName = "Tom",
//                     LastName = "Daely",
//                     Gender = "Male",
//                     AnnualSalary = 60000
//                 },
//                 new Employee
//                 {
//                     EmployeeID = 102,
//                     FirstName = "Tom",
//                     LastName = "Daely",
//                     Gender = "Male",
//                     AnnualSalary = 72000
//                 },
//                 new Employee
//                 {
//                     EmployeeID = 103,
//                     FirstName = "Tom",
//                     LastName = "Daely",
//                     Gender = "Female",
//                     AnnualSalary = 60000
//                 },
//                 new Employee
//                 {
//                     EmployeeID = 104,
//                     FirstName = "Pam",
//                     LastName = "Daely",
//                     Gender = "Female",
//                     AnnualSalary = 84000
//                 }
//             };
//         }
//     }
// }

// Program.cs
// using System;
// using System.Linq;

// namespace Demo
// {
//     class Program
//     {
//         static void Main()
//         {
            // IEnumerable<int> result = Employee.GetAllEmployees().Select(emp => emp.EmployeeID);

            // foreach (int  id in result)
            // {
            //     Console.WriteLine(id);
            // }

            // var result = Employee.GetAllEmployees().Select(emp => new { FirstName = emp.FirstName, Gender = emp.Gender });

            // foreach(var v in result)
            // {
            //     Console.WriteLine(v.FirstName + " - " + v.Gender);
            // }

            // Compute full name and monthlySalary

            // var result = Employee.GetAllEmployees().Select(emp => new {FullName = emp.FirstName + " " + emp.LastName,  MonthlySalary = emp.AnnualSalary / 12});

            // foreach(var v in result)
            // {
            //     Console.WriteLine(v.FullName + " - " + v.MonthlySalary); 
            // }


            // give 10% bonus to all employees whose annual salary is greater than 50000 & project all such emp's FirstName, AnnualSalary & Bonus into anonymous type.

            // var result = Employee.GetAllEmployees().Where(emp => emp.AnnualSalary > 50000).Select(emp => new { Name = emp.FirstName, Salary = emp.AnnualSalary, Bonus = emp.AnnualSalary * .1 });

            // foreach (var v in result)
            // {
            //     Console.WriteLine(v.Name + " : " + v.Salary + " - " + v.Bonus);
            // }
//         }
//     }
// }


// SelectMany operator
// SelectMany is used to project each element of a sequence to an IEnumerable<T> and flattens the resulting sequences into one sequence.

// Subject property in this class is a collection of strings
// public class Student
// {
//     public string Name { get; set; }
//     public string Gender { get;  set; }
//     public List<string> Subjects { get; set; }
// }


// Student.cs
// using System.Collections.Generic;

// namespace Demo
// {
//     public class Student
//     {
//         public string Name { get; set; }
//         public string Gender { get;  set; }
//         public List<string> Subjects { get; set; }

//         public static List<Student> GetAllStudents(){/*students*/}
//     }
// }


// Program.cs
using System;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main()
        {
            // IEnumerable<string> subjects = Student.GetAllStudents().SelectMany(s => s.Subjects);

            // foreach (string subject in subjects)
            // {
            //     Console.WriteLine(subject);
            // }

            // sql like syntax
            // IEnumerable<string> subjects = from student in Student.GetAllStudents()
            //                                 from subject in student.Subjects
            //                                 select subject;

            // foreach (string subject in subjects)
            // {
            //     Console.WriteLine(subject);
            // }

            // project each string to IEnumerable<char>.
            // string[] stringArray =
            // {
            //     "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            //     "0123456789"
            // };

            // IEnumerable<char> result = stringArray.SelectMany(s => s);

            // foreach(char c in result)
            // {
            //     Console.WriteLine(c);
            // }

            // sql like syntax
            // string[] stringArray =
            // {
            //     "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            //     "0123456789"
            // };

            // IEnumerable<char> result = from s in stringArray
            //                             from c in s
            //                             select c;

            // foreach(char c in result)
            // {
            //     Console.WriteLine(c);
            // }

            // retrieve distince subjects
            // IEnumerable<string> subjects = Student.GetAllStudents().SelectMany(s => s.Subjects).Distinct();

            // IEnumerable<string> subjects = (from student in Student.GetAllStudents()
            //                                 from subject in student.Subjects
            //                                 select subject).Distinct();

            // foreach (string subject in subjects)
            // {
            //     Console.WriteLine(subject);
            // }

            
            // select student name along with all the subjects
            // var result = Student.GetAllStudents().SelectMany(s => s.Subjects, (student, subject) => new { StudentName = student.Name, Subject = subject});

            // var result = from student in Student.GetAllStudents()
            //              from subject in student.Subjects
            //              select new { StudentName = studnet.Name, Subject = subject};

            // foreach (var v in result)
            // {
            //     Console.WriteLine(v.StudentName + " - " + v.Subject);
            // }



        }
    }
}