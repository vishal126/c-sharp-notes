// To write LINQ queries we use the LINQ standard query operators.
// select, from, where, orderby, join, groupby

// 2 ways
// 1. using lambda expressions
// 2. using sql like query expressions

// no performance difference between both

// note: behind the scene, LINQ queries written using SQL like query expressions are translated into their lambda expressions before they are compiled.

// the standard query operators are implemented as extension methods on IEnumerable<T> interface


// eg
// public class Student
// {
//     public int ID {get; set;}
//     public string Name {get; set;}
//     public string Gender {get; set;}

//     public static List<Student> GetAllStudents() {students}
// }

// LINQ query using Lambda Expressions.
// IEnumerable<Student> students = Student.GetAllStudents().Where(student => student.Gender == "Male");

// LINQ query using SQL like query expression
// IEnumerable<Student> students = from student in Student.GetAllStudents() where student.Gender == "Male" select student;

// var query = customers.Where(c => c.City == "London").Select(c => c.Name);