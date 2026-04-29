// What are Action Selectors in ASP.NET MVC?
// The Actions are the public methods of a controller in ASP.NET MVC Application that responds to incoming HTTP Requests.
// The Action Selectors in ASP.NET MVC are the attributes that can be applied to the action methods of a controller and are used to control which action method gets invoked in response to a particular request.
// That means Action Selectors in ASP.NET MVC Framework help the routing engine to select the correct action method to handle a particular request.


// Types of Action Selectors in ASP.NET MVC.
// ActionName: This attribute allows you to give an action method an "alias." The name in the URL will be different from the actual C# method name.
// ActionVerbs: These are the most common selectors. They restrict an action based on the "intent" of the request (GET, POST, PUT, DELETE).
// NonAction: If you have a helper method (like a complex calculation) that needs to be public for some reason, but you don't want it to be accessible via a URL.

// Adding Model classes in the Models folder:
// Product.cs
// public class Product
// {
//     public int ProductId { get; set; }
//     public string ProductName { get; set; }
//     public int Price { get; set; }
//     public string Category { get; set; }
// }

// public class DataAccessElectronics
// {
//     public List<Product> GetDataElectronics()
//     {
//             List<Product> ElectronicsProductList = new List<Product>()
//             {
//                 new Product() { ProductId = 1, ProductName = "Desktop", Price = 34000, Category = "Electronics" },
//                 new Product() { ProductId = 2, ProductName = "Laptop", Price = 34000, Category = "Electronics" },
//                 new Product() { ProductId = 3, ProductName = "Router", Price = 34000, Category = "Electronics" },
//                 new Product() { ProductId = 4, ProductName = "Mouse", Price = 34000, Category = "Electronics" },
//                 new Product() { ProductId = 5, ProductName = "USB HDD", Price = 34000, Category = "Electronics" },
//                 new Product() { ProductId = 6, ProductName = "LCD", Price = 34000, Category = "Electronics" }
//             };

//             return ElectronicsProductList;
//     }
// }


// Product – This is an entity class containing properties for Product information.
// DataAccessElectronics – This class contains the method for returning all Electronics products.


// Understanding ActionName Action Selector in ASP.NET MVC:
// The ActionName action selector in the ASP.NET MVC Application is used when we want to invoke an action method with a different name, than what is already given to the action method.

// HomeController.cs
// public class HomeController : Controller
// {
//     public string Index()
//     {
//         return "Index action method invoked";
//     }
// }


// The URL “/Home/Index“ would invoke the Index() action method in HomeController.
// If you want to invoke the Index() action method, with the URL “/Home/List”, then you need to decorate the action method with the ActionName attribute as shown below.

// public class HomeController : Controller
// {
//     [ActionName("List")]
//     public string Index()
//     {
//         return "Index action method invoked";
//     }
// }


// Now, if you navigate to /Home/Index, you will get an error – “The resource cannot be found“.
// and the view name should be as per the action name ie List

// HomeController.cs
// public class HomeController : Controller
// {
//     [ActionName("List")]
//     public ActionResult Index()
//     {
//         DataAccessElectronics DAE = new DataAccessElectronics();
//         List<Product> ElectronicsList = DAE.GetDataElectronics();
//         return View(ElectronicsList);
//     }
// }


// List.cshtml
// @model IEnumerable<ActionSelectorsinMVC.Models.Product>

// @{
//     ViewBag.Title = "Index";
// }

// <h2>Product List</h2>

// <table class="table">
//     <tr>
//         <th>
//             @Html.DisplayNameFor(model => model.ProductName)
//         </th>
//         <th>
//             @Html.DisplayNameFor(model => model.Price)
//         </th>
//         <th>
//             @Html.DisplayNameFor(model => model.Category)
//         </th>
        
//     </tr>

// @foreach (var item in Model) {
//     <tr>
//         <td>
//             @Html.DisplayFor(modelItem => item.ProductName)
//         </td>
//         <td>
//             @Html.DisplayFor(modelItem => item.Price)
//         </td>
//         <td>
//             @Html.DisplayFor(modelItem => item.Category)
//         </td>
//     </tr>
// }
// </table>


// Now for some reason, if you want to use “Index” as the view name then we need to use the other overloaded version of the View Extension method which takes the view name as a parameter.
// So, modify the controller action method as shown below. Here, you can notice, we have passed the first parameter as Index which is nothing but the view name.

// public class HomeController : Controller
// {
//     [ActionName("List")]
//     public ActionResult Index()
//     {
//         DataAccessElectronics DAE = new DataAccessElectronics();
//         List<Product> ElectronicsList = DAE.GetDataElectronics();
//         return View("Index", ElectronicsList);
//     }
// }

// With the above changes in place, now when you run the application and navigate to /Home/List, it will display the results by using the Index view.


// Modern .net core
// your modern trainee projects, you might see [Route("List")] used instead of [ActionName("List")]. They achieve similar results, but [ActionName] specifically changes the "identity" of the action in the eyes of the View Engine and other MVC filters.