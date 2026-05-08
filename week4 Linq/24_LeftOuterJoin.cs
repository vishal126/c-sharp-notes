// all the matching elements + all the non matching  elements from the left collection are included in the result set.

using  System;
using System.ComponentModel.DataAnnotations;
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
                new Employee { ID = 5, Name = "Mary"}
            };
        }
    }

    class Program
    {
        public static void Main()
        {
            // var result = from e in Employee.GetAllEmployees()
            //              join d in Department.GetAllDepartments()
            //              on e.DepartmentID equals d.ID into eGroup
            //              from d in eGroup.DefaultIfEmpty()
            //              select new
            //              {
            //                 EmployeeName = e.Name,
            //                 DepartmentName = d == null ? "No Departmet" : d.Name
            //              };

            var result = Employee.GetAllEmployees()
                         .GroupJoin(Department.GetAllDepartments(),
                                    e => e.DepartmentID,
                                    d => d.ID,
                                    (emp, depts) => new
                                    {
                                        emp,
                                        depts
                                    })
                         .SelectMany(z => z.depts.DefaultIfEmpty(), 
                                     (a, b) => new
                                     {
                                         EmployeeName = a.emp.Name,
                                         DepartmentName = b == null ? "No Department" : b.Name
                                     });

            foreach (var v in result)
            {
                Console.WriteLine(v.EmployeeName + "\t" + v.DepartmentName);
            }
        }
    }
}