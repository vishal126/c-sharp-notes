// In the ASP.NET MVC application, we can pass the model data from a controller to a view in many ways such as by using ViewBag, ViewData, TempData, Session, and Application as well as you can also use strongly typed views.

// What is ViewData in ASP.NET MVC?
// The ViewData in ASP.NET MVC Framework is a mechanism to pass the data from a controller action method to a view.
// ViewData is defined as a property in the ControllerBase class and its type is ViewDataDictionary.
// public ViewDataDictionary ViewData { get; set; }

// definition of the ViewDataDictionary class.
// [DefaultMember("Item)]
// public class ViewDataDictionary : IDictionary<string, object>

// ViewData in ASP.NET MVC Framework is a dictionary object
// it is a dictionary object, it is going to store the data in the form of key-value pairs where each key must be a string and the value that we are passing to the dictionary is going to be stored in the form of an object type. 


// How to Pass and Retrieve data From ViewData in ASP.NET MVC?
// The most important point that you need to remember is, as it stores the data in the form of an object while retrieving the data from ViewData type casting is required
// If you are accessing string data from the ViewData, then it is not required to typecast the ViewData to string type. But it is mandatory to typecast explicitly to the actual type if you are accessing data other than the string type.

// ViewData in ASP.NET MVC with String Type:
// Controller
// ViewData["Header"] = "Employee Details";

// View
// @ViewData["Header"]   ->  As we are accessing the data is of string type so there is no need to type cast the ViewData to string type.

// ViewData in ASP.NET MVC with Complex Type:
// Controller
// ViewData["Employee"] = employee;

// View
// @{
//     var employee = ViewData["Employee"] as FirstMVCDemo.Models.Employee;  -> As the data stored in the ViewData dictionary is of Employee Type, so we need to explicitly cast it to Employee Type.
// }


// Example of ViewData in ASP.NET MVC Application:
// Passing ViewData From a Controller Action Method to a View:
// using FirstMVCDemo.Models;
// using System.Web.Mvc;
// namespace FirstMVCDemo.Controllers
// {
//     public class HomeController : Controller
//     {
//         public ActionResult Index()
//         {
//             EmployeeBusinessLayer employeeBL = new EmployeeBusinessLayer();
//             Employee employee = employeeBL.GetEmployeeDetails(102);

//             ViewData["Employee"] = employee;
//             ViewData["Header"] = "Employee Details";

//             return View();
//         }
//     }
// }


// Accessing ViewData in a View:
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
//         var employee = ViewData["Employee"]
//             as FirstMVCDemo.Models.Employee;
//      // in the above method if the data is missing or is the wrong type, it will return null instead of crashing.

//      // or

//         var employee = (Employee)ViewData["Employee];
//      // in the above method if ViewData["Employee"] is null or the wrong type, the application will crash immediately.
//     }

//     <h2>@ViewData["Header"]</h2>
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


// The "Layout" Concept
// Usually, you don't want to rewrite your navigation bar, footer, and CSS links on every single page of your website. Instead, ASP.NET MVC uses a "Master Page" called _Layout.cshtml (located in the Views/Shared folder).
// This layout file holds the "shell" of your website. When you create a normal View, it automatically injects itself into the middle of that shell.

// When you write Layout = null;, you are telling the server: "Ignore the master template. Give me a completely blank canvas. I will write 100% of the HTML (including the <html>, <head>, and <body> tags) myself from scratch."

// How the View "Catches" the Controller's Return
// When you write return View(); in your Controller, ASP.NET MVC follows a strict Naming Convention:
// The Folder: It looks in Views/[ControllerName]/.
// The File: It looks for a file named [ActionName].cshtml.

