// ASP.NET MVC Attribute Routing with Optional Parameter:
// You can also define a URI parameter as optional by adding a question mark (“?”) to the route parameter.
// You can also specify the default value by using parameter = value.

// In the MVC action method, we place a question mark after the parameter studentName within the Route attribute as [Route(“MVCTest/{studentName ?}”)] which makes the studentName parameter optional. 
// If you have not specified any value for the studentName parameter in the URL, then it will store a null value in it and if you specified any value in the URL for the studentName parameter, then that value will be mapped to the studentName Parameter.
// In the WEBAPI action method, we have specified a default value for the studentName Parameter directly in the Route attribute as Route(“WEBAPITest/{studentName = Pranaya}”)].

// namespace AttributeRoutingDemoInMVC.Controllers
// {
//     public class HomeController : Controller
//     {
//         // Optional URI Parameter
//         // URL: /MVCTest/
//         // URL: /MVCTest/Pranaya
//         [Route("MVCTest/{studentName ?}")]
//         public ActionResult MVC(string studentName)
//         {
//             ViewBag.Message = "Welcome to ASP.NET MVC!";
//             return View();
//         }

//         // Optional URI Parameter with default value
//         // URL: /WEBAPITest/
//         // URL: /WEBAPITest/Pranaya
//         [Route("WEBAPITest/{studentName = Pranaya}")]
//         public ActionResult WEBAPI(string studentName)
//         {
//             ViewBag.Message = "Welcome to ASP.NET WEB API!";
//             return View();
//         }
//     }
// }