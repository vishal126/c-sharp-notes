using  System;
using System.Runtime.CompilerServices;

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
                new Department { ID = 2, Name = "HR"},
                new Department { ID = 3, Name = "XX"},
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
            // Group join
            // Note: INTO  keyword is used along with JOIN operator to implement Group join.

            // To print the Department and Employee Names we use 2 foreach loops

            var result = from d in Department.GetAllDepartments()
                         join e in Employee.GetAllEmployees()
                         on d.ID equals e.DepartmentID into eGroup
                         select new { Department = d, Employees = eGroup };

            foreach(var department in employeesByDepartment)
            {
                Console.WriteLine(department.Department.Name);
                foreach (var employee in department.Employees)
                {
                    Console.WriteLine(" " + employee.Name);
                }
                Console.WriteLine(); 
            }

            // Inner Join
            // It produces a flat result set
            // To print Department & Employee Names we use just 1 foreach loop
            var result = from e in Employee.GetAllEmployees()
                         join d in Department.GetAllDepartments()
                         on e.DepartmentID equals d.ID
                         select new { e, d };

            foreach(var employee in result)
            {
                Console.WriteLine(employee.EmployeeName + "\t" + employee.DepartmentName);
            }
        }
    }
}

// Join is similar to INNER JOIN in SQL and GroupJoin is similar to OUTER JOIN in SQL