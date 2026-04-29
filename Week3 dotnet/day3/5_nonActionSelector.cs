// Why do we need a Non-Action Selector in the ASP.NET MVC Application?
// By default, in ASP.NET MVC, an action method is a public method in a controller that can be invoked using a URL request. But in some scenarios, we need to restrict the public methods of a controller to be invoked by a URL i.e. we don’t want the action method to be invoked using URL request.

// To restrict access to the public methods in a controller, we need to decorate the action method with the Non-Action attribute.
// The Non-Action is another built-in Action Selector Attribute, which indicates that a public method of a Controller is not an action method. It is used when we want that method shouldn’t be treated as an action method.



// Understanding Non-Action Attribute in the ASP.NET MVC Application with an Example.
// public class HomeController : Controller
// {
//     [HttpGet]
//     public string Method1()
//     {
//         return "<h1>Method 1 Invoked</h1>";
//     }

//     [HttpGet]
//     public string Method2()
//     {
//         return "<h1>Method 2 Invoked</h1>";
//     }
// }


// Let’s say Method2() is doing some internal work, and we don’t want it to be invoked using a URL request. To achieve this, we need to decorate Method2() with the NonAction attribute as shown in the below code

// [NonAction]
// public string Method2()
// {
//     return "<h1>Method 2 Invoked</h1>";
// }

// Now, if we navigate to URL /Home/Method2, we will get an error saying – The resource cannot be found.



// Another way to restrict access to methods in a controller is by making them private. 
// private string Method2()
// {
//     return "<h1>Method 2 Invoked</h1>";
// }

// In general, it’s a bad design to have a public method in a controller that is not an action method. If we have any such method for performing business calculations, it should be somewhere in the model and not in the controller.


// The Model (Employee.cs)
// namespace attributes.Models
// {
//     public class Employee
//     {
//         public int Id { get; set; }
//         public string FullName { get; set; }
//         public decimal Salary { get; set; }
//     }
// }


// The Controller (EmployeeController.cs)
// using Microsoft.AspNetCore.Mvc;
// using attributes.Models;

// namespace attributes.Controllers
// {
//     public class EmployeeController : Controller
//     {
//         // A regular action: URL /Employee/Index works!
//         public IActionResult Index()
//         {
//             return Content("Index page loaded");
//         }

//         // [NonAction] makes this method INVISIBLE to the browser
//         [NonAction]
//         public decimal GetBonusAmount(decimal salary)
//         {
//             return salary * 0.10m; // 10% Bonus logic
//         }

//         // A regular action that USES the NonAction method
//         public IActionResult Details(int id)
//         {
//             decimal baseSalary = 50000;
//             // The controller can still call the method internally!
//             decimal bonus = GetBonusAmount(baseSalary); 
            
//             return Content($"Salary: {baseSalary}, Bonus: {bonus}");
//         }
//     }
// }