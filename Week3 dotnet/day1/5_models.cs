// What are the Models in ASP.NET MVC?
// The Models in ASP.NET MVC application are the component that contains a set of classes that are used to represent the business data (or domain data) as well as logic to manage the business data.
// i.e. the state of the application in memory.

// Example to Understand Models in ASP.NET MVC.
// We need to display the employee information on a webpage as shown below.
// Employee Details
// EID      101
// Name     Vishal
// Gender   Male
// City     Jaipur
// Salary   1000
// Address  Udaipur

// In order to store the employee data, we are going to use the Employee model class.
// To do so,  right-click on the “Models” folder and then select Add => Class option. Provide the name as Employee.cs and finally click on the Add button.

// Now open the Employee.cs class file and then copy and paste the following code.
// namespace FirstMVCDemo.Models
// {
//     public class Employee
//     {
//         public int EmployeeId { get; set; }
//         public string Name { get; set; }
//         public string Address { get; set; }
//         public string City { get; set; }
//         public string Gender { get; set; }
//         public decimal Salary { get; set; }
//     }
// }

// This is our Employee model which is going to hold the employee data in memory

// Creating EmployeeBusinessLayer Model:
// Right-click on the Models folder and then add a new class file with the name EmployeeBusinessLayer.cs
// namespace FirstMVCDemo.Models
// {
//     public class EmployeeBusinessLayer
//     {
//         public Employee GetEmployeeDetails(int EmployeeId)
//         {
//             //Here we hardcoded the data
//             //later we will discuss how to retrieve
//             //the data from a database

//             Employee employee = new Employee()
//             {
//                 EmployeeId = EmployeeId,
//                 Name = "Pranaya",
//                 Gender = "Male",
//                 City = "Mumbai",
//                 Salary = 1000,
//                 Address = "Andheri"
//             };

//             return employee;
//         }
//     }
// }


// Modifying the HomeController
// using FirstMVCDemo.Models;
// using System.Web.Mvc;
// namespace FirstMVCDemo.Controllers
// {
//     public class HomeController : Controller
//     {
//         public ActionResult Index(int id)
//         {
//             EmployeeBusinessLayer employeeBL = new EmployeeBusinessLayer();
//             Employee employee = employeeBL.GetEmployeeDetails(id);
//             return View();
//         }
//     }
// }