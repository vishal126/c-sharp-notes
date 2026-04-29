// What is a ViewModel in ASP.NET MVC?
// a single model object may not contain all the necessary data required for a view.
// For example, a view may require different model data. Then in such situations like this, we need to use the concept ViewModel.
//  A ViewModel in ASP.NET MVC application is a model which contains more than one model data required for a particular view. As this model is specific for a particular view, we call this ViewModel in ASP.NET MVC.


// Understanding ViewModel in ASP.NET MVC:
// View modal Representation in ASP.NET MVC application

// Employee Model                   Employee Address Model
//    Model 1                               Model 2
//      |                                      |
//      |                                      |
//      ----------------------------------------
//                          |
//                          v
//              EmployeeDetails ViewModel
//              Model1 + Model2 + Additional -----> View
//              Required Properties


// Creating the Required Models:
// Employee.cs
// namespace FirstMVCDemo.Models
// {
//     public class Employee
//     {
//         public int EmployeeId { get; set; }
//         public string Name { get; set; }
//         public string Gender { get; set; }
//         public string Department { get; set; }
//         public decimal Salary { get; set; }
//         public int AddressId { get; set; }
//     }
// }


// Address.cs
// namespace FirstMVCDemo.Models
// {
//     public class Address
//     {
//         public int AddressId { get; set; }
//         public string Country { get; set; }
//         public string State { get; set; }
//         public string City { get; set; }
//         public string Pin { get; set; }
//     }
// }


// Creating the ViewModel in ASP.NET MVC:
// The View Model that we are going to create will represent the Employee Model + Employee Address Model + Some additional properties like title and page header.
// In the ASP.NET MVC application, you can create the View Models anywhere within your project, but it is always a good programming practice to create all the View Models within a special folder called ViewModels.


// ViewModels/EmployeeDetailsViewModel.cs
// using FirstMVCDemo.Models;
// namespace FirstMVCDemo.ViewModels
// {
//     public class EmployeeDetailsViewModel
//     {
//         public Employee Employee { get; set; }
//         public Address Address { get; set; }
//         public string PageTitle { get; set; }
//         public string PageHeader { get; set; }
//     }
// }


// Creating Employee Controller:
// EmployeeController.cs
// using FirstMVCDemo.ViewModels;
// using FirstMVCDemo.Models;
// using System.Web.Mvc;

// namespace FirstMVCDemo.Controllers
// {
//     public class EmployeeController : Controller
//     {
//         public ViewResult Details()
//         {
//             //Employee Basic Details
//             Employee employee = new Employee()
//             {
//                 EmployeeId = 101,
//                 Name = "Dillip",
//                 Gender = "Male",
//                 Department = "IT",
//                 Salary = 10000,
//                 AddressId = 1001
//             };

//             //Employee Address
//             Address address = new Address()
//             {
//                 AddressId = 1001,
//                 City = "Bhubaneswar",
//                 State = "Odisha",
//                 Country = "India",
//                 Pin = "755019"
//             };

//             //Creating the View model
//             EmployeeDetailsViewModel employeeDetailsViewModel = new EmployeeDetailsViewModel()
//             {
//                 Employee = employee,
//                 Address = address,
//                 PageTitle = "Employee Details Page",
//                 PageHeader = "Employee Details",
//             };

//             //Pass the employeeDetailsViewModel to the view
//             return View(employeeDetailsViewModel);
//         }
//     }
// }



// Creating the Details View:
// Details.cshtml
// @model FirstMVCDemo.ViewModels.EmployeeDetailsViewModel

// @{ 
//     Layout = null;
// }
// <html xmlns="http://www.w3.org/1999/xhtml">
// <head>
//     <title>@Model.PageTitle</title>
// </head>
// <body>
//     <h1>@Model.PageHeader</h1>
//     <div>
//         EmployeeID : @Model.Employee.EmployeeId
//     </div>
//     <div>
//         Name : @Model.Employee.Name
//     </div>
//     <div>
//         Gender : @Model.Employee.Gender
//     </div>
//     <div>
//         Department : @Model.Employee.Department
//     </div>
//     <div>
//         Salary : @Model.Employee.Salary
//     </div>

//     <h1>Employee Address</h1>
//     <div>
//         City : @Model.Address.City
//     </div>
//     <div>
//         State : @Model.Address.State
//     </div>
//     <div>
//         Country : @Model.Address.Country
//     </div>
//     <div>
//         Pin : @Model.Address.Pin
//     </div>
// </body>
// </html>