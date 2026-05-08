// It belong to grouping Operators category.
// This operator takes a flat sequence of items, organize that sequence into groups (IGrouping<K,V>) based on a specific key and return groups of sequences.

// In short, GroupBy creates and returns a sequence of IGrouping<K,V>

// eg.1 GetEmployee Count By Department

// var employeeGroup = from employee in Employee.GetAllEmployees()
//                     group employee by employee.Department;

// foreach (var group in employeeGroup)
// {
//     Console.WriteLine("{0} - {1}", group.Key, group.Count());
// }

// eg.2 get employee count by department and also each employee and department name
// var employeeGroup = from employee in Employee.GetAllEmployees()
//                     group employee by employee.Department;

// foreach (var group in employeeGroup)
// {
//     Console.WriteLine("{0} - {1}", group.key, group.Count());
//     Console.WriteLine("---------");
//     foreach (var employee in group)
//     {
//         Console.WriteLine(employee.Name + "\t" + employee.Department);
//     }
//     Console.WriteLine();
//     Console.WriteLine();
// }

// eg.3 get emp cnt by dept and also each emp and dept name.
// Data should be sorted first by Department in ascending order and then by Employee Name in ascending order.
// var employeeGroup = from employee in Employee.GetAllEmployees()
//                     group employee by employee.Department into eGroup
//                     orderby eGroup.Key
//                     select new {
//                                    Key = eGroup.Key,
//                                    Employees = eGroup.OrderBy(x=>x.Name)
//                                };

// foreach (var group in employeeGroup)
// {
//     Console.WriteLine("{0} - {1}", group.key, group.Employees.Count());
//     Console.WriteLine("---------");
//     foreach (var employee in group.Employees)
//     {
//         Console.WriteLine(employee.Name + "\t" + employee.Department);
//     }
//     Console.WriteLine();
//     Console.WriteLine();
// }



// Program.cs
// namespace Demo
// {
//     class Program
//     {
//         public static void Main()
//         {
//             // eg.1
//             var employeeGroups = Employee.GetAllEmployees().GroupBy(x => x.Department);

//             foreach (var group in employeeGroup)
//             {
//                 Console.WriteLine("{0} - {1}", group.Key, group.Count());
//                 Console.WriteLine("{0} - {1}", group.Key, group.Count(x => x.Gender == "Male"));
//             }

//             // eg.2
//             var employeeGroup = from employee in Employee.GetAllEmployees()
//                     group employee by employee.Department;

//             foreach (var group in employeeGroup)
//             {
//                 Console.WriteLine("{0} - {1}", group.key, group.Count());
//                 Console.WriteLine("---------");
//                 foreach (var employee in group)
//                 {
//                     Console.WriteLine(employee.Name + "\t" + employee.Department);
//                 }
//                 Console.WriteLine();
//                 Console.WriteLine();
//             }

//             // eg.3
//             var employeeGroup = from employee in Employee.GetAllEmployees()
//                     group employee by employee.Department into eGroup
//                     orderby eGroup.Key
//                     select new {
//                                    Key = eGroup.Key,
//                                    Employees = eGroup.OrderBy(x=>x.Name)
//                                };

//             foreach (var group in employeeGroup)
//             {
//                 Console.WriteLine("{0} - {1}", group.key, group.Employees.Count());
//                 Console.WriteLine("---------");
//                 foreach (var employee in group.Employees)
//                 {
//                     Console.WriteLine(employee.Name + "\t" + employee.Department);
//                 }
//                 Console.WriteLine();
//                 Console.WriteLine();
//             }
//         }
//     }
// }