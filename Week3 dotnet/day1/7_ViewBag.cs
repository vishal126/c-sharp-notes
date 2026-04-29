// What is ViewBag in ASP.NET MVC?
// Mechanism to pass the data from a controller action method to a view.

// If you go to the definition, of ViewBag, then you will see that it is defined as a property in the ControllerBase class with the following signature.
// [Dynamic]
// public dynamic ViewBag { get; }

// Dynamic data type means at runtime based on the value, it will decide the data type.

// How to Pass and Retrieve data From ViewBag in ASP.NET MVC?
// ***** As the ViewBag is operating on the new dynamic data type. The advantage is that we do not require typecasting while accessing the data from a ViewBag irrespective of the data that we are accessing.

// ViewBag in ASP.NET MVC with String Type:
// (Controller)
// Storing Data in ViewBag
// ViewBag.Header = "Employee Details";

// (View)
// Accessing Data from ViewBag
// @ViewBag.Header - Type casting is not required.


// ViewBag in ASP.NET MVC with Complex Type:
// (Controller)
// Storing Complex Type in ViewBag
// ViewBag.Employee = employee;

// (View)
// Accessing Complex Type from ViewBag
// Typecasting is not Required
// @ {
//      var employee = ViewBag.Employee;
// }


// Example of ViewBag in MVC Application:
// HomeController
// using FirstMVCDemo.Models;
// using System.Web.Mvc;
// namespace FirstMVCDemo.Controllers
// {
//     public class HomeController : Controller
//     {
//         public ActionResult Index()
//         {
//             EmployeeBusinessLayer employeeBL = new EmployeeBusinessLayer();
//             Employee employee = employeeBL.GetEmployeeDetails(101);
            
//             ViewBag.Employee = employee;
//             ViewBag.Header = "Employee Details";
            
//             return View();
//         }
//     }
// }

// Accessing the ViewBag in a View in ASP.NET MVC
// Index.cshtml view file
// @{
//     Layout = null;
// }
// <!DOCTYPE html>
// <html>
// <head>
//     <meta name="viewport" content="width=device-width" />
//     <title>Page Title</title>  
// </head>
// <body>
//     @{
//         var employee = ViewBag.Employee;
//     }
//     <h2>@ViewBag.Header</h2>
//     <table style="font-family:Arial">
//         <tr>
//             <td>Employee ID:</td>
//             <td>@employee.EmployeeId </td>
//         </tr>
//         <tr>
//             <td>Name:</td>
//             <td>@employee.Name</td>
//         </tr>
//         <tr>
//             <td>Gender:</td>
//             <td>@employee.Gender</td>
//         </tr>
//         <tr>
//             <td>City:</td>
//             <td>@employee.City</td>
//         </tr>
//         <tr>
//             <td>Salary:</td>
//             <td>@employee.Salary</td>
//         </tr>
//         <tr>
//             <td>Address:</td>
//             <td>@employee.Address</td>
//         </tr>
//     </table>
// </body>
// </html>

// Internally, ViewBag is a wrapper around ViewData. So, it will throw a runtime exception if the ViewBag property name matches the key of ViewData.

// The ViewData is a dictionary object whereas the ViewBag is a dynamic property.
// In ViewData, we use the string as the key to store and retrieve the data whereas in ViewBag we use the dynamic properties to store and retrieve data.

// Null Check   -	Often needed before casting (viewData,  Handled gracefully (viewBag)