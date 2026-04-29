// Creating Custom Routes in ASP.NET MVC Application:
// if we want to configure any routes then we need to configure the routes within the RegisterRoute method of RouteConfig class using the MapRoute extension method.
// While configuring the Routes, at least two parameters we need to provide to the MapRoute method i.e. Route name and URL pattern. The Default parameter is optional

// Route Names must be unique.
// namespace FirstMVCDemo
// {
//     public class RouteConfig
//     {
//         public static void RegisterRoutes(RouteCollection routes)
//         {
//             routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

//             routes.MapRoute(
//                 name: "Employee",
//                 url: " Employee/{id}",
//                 defaults: new { controller = "Employee", action = "Index" }
//             );
            
//             routes.MapRoute(
//                 name: "Default", //Route Name
//                 url: "{controller}/{action}/{id}", //Route Pattern
//                 defaults: new
//                 {
//                     controller = "Home", //Controller Name
//                     action = "Index", //Action method Name
//                     id = UrlParameter.Optional //Defaut value for above defined parameter
//                 }
//             );
//         }
//     }
// }

// Employee Controller
// namespace FirstMVCDemo.Controllers
// {
//     public class EmployeeController : Controller
//     {
//         public ActionResult Index()
//         {
//             return View();
//         }
//     }
// }


// The URL pattern for the Employee route is Employee/{id} which specifies that any URL that starts with domainName/Employee, must be handled by EmployeeController.
// Notice that we haven’t specified {action} in the URL pattern because we want every URL that starts with Employee should always use Index action of EmployeeController.
// The ASP.NET MVC framework evaluates each route in sequence. It starts with the first configured route and if the incoming URL doesn’t satisfy the First URL pattern of the route then it will evaluate the second route and so on.

// The following URLs will be mapped to the Employee route.
// http://localhost:53605/Employee
// http://localhost:53605/Employee/Index
// http://localhost:53605/Employee/Index/3


// .net core modern
// Inside Program.cs
// app.UseRouting();

// // CUSTOM ROUTE (Specific)
// app.MapControllerRoute(
//     name: "EmployeeRoute",
//     pattern: "Employee/{id?}", 
//     defaults: new { controller = "Employee", action = "Index" });

// // DEFAULT ROUTE (General)
// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=Home}/{action=Index}/{id?}");