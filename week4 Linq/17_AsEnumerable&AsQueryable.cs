// Both of these operators belong to conversion operators category.

// AsQueryable operator: There are 2 overloaded versions of this method One overloaded version converts
// System.Collections.IEnumerable  to System.Linq.IQueryable

// The other overloaded version converts a generic
// System.Collections.Generic.IEnumerable<T> to a generic System.Linq.IQueryable<T>

// The main use of AsQUeryable operator is in unit testing to mock a queryable data source using an in-menory datasource.


// AsEnumerable operator breaks the query into 2 parts
// 1. The INSIDE PART (query before AsEnumerable) is executed as Linq-to-SQL
// 2. The OUTSIDE PART (query after AsEnumerable) is executed as Linq-to-Objects

// sql db query
// Create Table Employees{
//     ID int primary key identity,
//     Name nvarchar (50),
//     Gender nvarchar(50),
//     Salary int
// }
// GO

// Insert into Employees Values ('Mark', 'Male', '60000')
// Insert into Employees Values('Steve', 'Male', '45000')
// Insert into Employees Values('Ben', 'Male', '170000')
// Insert into Employees Values ('Philip', 'Male', '45000')
// Insert into Employees Values ('Mary', 'Female', '30000')
// Insert into Employees Values ('Valarie', 'Female', '35000')
// Insert into Employees Values ('John', 'Male', '80000')
// Insert into Employees Values ('Pam', 'Female', '85000')
// Insert into Employees Values ('Stacey', 'Female', '65000')
// Insert into Employees Values (Andy', 'Male', '73000')
// Insert into Employees Values ('Edward', 'Male', '65000')
// GO


// Program.cs
// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace Demo
// {
//     class Program
//     {
//         public static void Main()
//         {
//             EmployeeDBDataContext db = new EmployeeDBDataContext();

//             var result = db.Employees.
//                             AsEnumerable(). // the query before this will only be executed in sql server which will fetch all records and columns and the query after this will be executed in memory
//                             Where(x => x.Gender == "Male").
//                             OrderByDescending(x => x.Salary).
//                             ake(5);

//             foreach(var e in result)
//             {
//                 Console.WriteLine(e.Name + "\t" + e.Salary + "\t" + e.Gender);
//             }
//         }
//     }
// }


// So in this eg the following SQL query is executed against SQL server, all the data is brought into the console application and then
// the WHERE, ORDERBY & TOP operators are applied on the client-side

// Select [t0].[ID], [t0].[Name], [t0].[Gender], [t0].[Salary]
// From [dbo].[Employees] AS [t0]

// So in short, use AsEnumerable operator to move query processing to the client side.