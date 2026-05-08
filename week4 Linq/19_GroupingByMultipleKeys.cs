// An anonymous type is usually used when we want to group by multiple keys

// Example 1: Group employees by Department and then by Gender.
// The employee groups should be sorted first by Department and then by Gender in ascending order
// Also, employees within each group must be sorted in ascending order by Name

// var employeeGroups = Employee.GetAllEmployees()
//                      .GroupBy(x => new { x.Department, x.Gender })
//                      .OrderBy(g => g.Key.Department).ThenBy(g => g.Key.Gender)
//                      .Select(g => new
//                      {
//                         Dept = g.Key.Department,
//                         Gender = g.Key.Gender,
//                         Employees = g.OrderBy(x => x.Name)
//                      });


// using System;
// using System.Linq;

// namespace Demo
// {
//     class Program
//     {
//         public static void Main()
//         {
//             var employeeGroups = Employee.GetAllEmployees()
//                      .GroupBy(x => new { x.Department, x.Gender })
//                      .OrderBy(g => g.Key.Department).ThenBy(g => g.Key.Gender)
//                      .Select(g => new
//                      {
//                         Dept = g.Key.Department,
//                         Gender = g.Key.Gender,
//                         Employees = g.OrderBy(x => x.Name)
//                      });

//             var employeeGroups = from employee in Employee.GetAllEmployees()
//                                  group employee by new { employee.Department, employee.Gender } into eGroup
//                                  orderby eGroup.Key.Department, eGroup.Key.Gender
//                                  select new
//                                  {
//                                     Dept = g.Key.Department,
//                                     Gender = g.Key.Gender,
//                                     Employees = g.OrderBy(x => x.Name)
//                                  };

//             foreach (var group in employeeGroups)
//             {
//                 Console.WriteLine("{0} department {1} employees count = {2}", group.Dept, group.Gender, group.Employees.Count());
//                 Console.WriteLine("-------------------------------------------------------------");
//                 foreach (var employee in group.Employees)
//                 {
//                     Console.WriteLine(employee.Name + "\t" + employee.Gender + "\t" + employee.Department);
//                 }
//                 Console.WriteLine(); Console.WriteLine();
//             }
//         }
//     }
// }