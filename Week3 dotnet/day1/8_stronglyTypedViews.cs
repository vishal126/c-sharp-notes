// Creating Strongly Typed View in MVC
// we need to pass the model object as a parameter to the View() extension method.

// The Controller base class provide us the following four overloaded versions of View() extension method which we can use to pass the model data from the controller action method to a view.
// protected internal ViewResult View(object model);
// protected internal ViewResult View(IView view, object model);
// protected internal ViewResult View(string viewName, object model);
// protected internal ViewResult View(string viewName, string masterName, object model);

// Home Controller - Index method to pass the Employee object as a parameter to the View extension method.
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
//             ViewBag.Header = "Employee Details";
            
//             return View(employee);
//         }
//     }
// }


// Changes in Index.cshtml View:
// In order to create a strongly typed view in ASP.NET MVC Application, we need to specify the model type within the view by using the @model directive.
// As here, the Employee class is going to be the model so we need to specify the model directive as shown below.
// @model FirstMVCDemo.Models.Employee

// The above statement will tell that we are going to use FirstMVCDemo.Models.Employee as the model for this view.
// Here in the directive (@model), the letter m is in lowercase and the statement should not be terminated with the semicolon.

// Then we can access the model properties simply by using @Model, here the letter M is in uppercase.
// So, in our example, we can access the Employee object properties such as Name, Gender, City, Salary, etc. by using @Model.Name, @Model.Gender, @Model.City, and @Model.Salary respectively.

// So Modify the Index.cshtml view file as shown below to make the view as strongly typed.
// @model FirstMVCDemo.Models.Employee
// <!DOCTYPE html>
// <html>
// <head>
//     <meta name="viewport" content="width=device-width" />
//     <title>Page Title</title>  
// </head>
// <body>
//     <h2>@ViewBag.Header</h2>
//     <table style="font-family:Arial">
//         <tr>
//             <td>Employee ID:</td>
//             <td>@Model.EmployeeId </td>
//         </tr>
//         <tr>
//             <td>Name:</td>
//             <td>@Model.Name</td>
//         </tr>
//         <tr>
//             <td>Gender:</td>
//             <td>@Model.Gender</td>
//         </tr>
//         <tr>
//             <td>City:</td>
//             <td>@Model.City</td>
//         </tr>
//         <tr>
//             <td>Salary:</td>
//             <td>@Model.Salary</td>
//         </tr>
//         <tr>
//             <td>Address:</td>
//             <td>@Model.Address</td>
//         </tr>
//     </table>
// </body>
// </html>


// Advantages
// Strongly Typed View in ASP.NET MVC provides compile-time error checking as well as intelligence support.
// If we misspell the property name, then it comes to know at compile time rather than at runtime.