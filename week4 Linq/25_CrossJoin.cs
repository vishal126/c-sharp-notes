// It produces a Cartesian product ie when we cross join two sequences, every element in the first collection is combined with every element in the second collection.
// The total number of elements in the resultant sequece will always be equal to the product of the elements in the two source sequences.

// The on keyword that specifies the JOIN KEY is not required.

using  System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Demo
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Department> GetAllDepartments()
        {
            return new List<Department>()
            {
                new Department { ID = 1, Name = "IT"},
                new Department { ID = 2, Name = "HR"}
            };
        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }
        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>()
            {
                new Employee { ID = 1, Name = "Mark", DepartmentID = 1},
                new Employee { ID = 2, Name = "Steve", DepartmentID = 2},
                new Employee { ID = 3, Name = "Ben", DepartmentID=1},
                new Employee { ID = 4, Name = "Philip", DepartmentID=1},
                new Employee { ID = 5, Name = "Mary", DepartmentID = 2}
            };
        }
    }

    class Program
    {
        public static void Main()
        {
            // var result = from d in Department.GetAllDepartments()
            //              from e in Employee.GetAllEmployees()
            //              select new { e, d };

            // var result = Employee.GetAllEmployees().SelectMany(e => Department.GetAllDepartments(),
            //                                                    (e, d) => new { e, d });

            var result = Employee.GetAllEmployees().Join(Department.GetAllDepartments(),
                                                         e => true,
                                                         d => true,                                                        
                                                         (e, d) => new { e, d });

            foreach(var v in result)
            {
                Console.WriteLine(v.e.Name + "\t" + v.d.Name);
            }
        }
    }
}