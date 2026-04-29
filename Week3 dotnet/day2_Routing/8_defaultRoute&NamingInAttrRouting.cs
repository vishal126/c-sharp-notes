// Default Route in ASP.NET MVC Attribute Routing:
// You can also apply the Route attribute on top of the controller (i.e. at the controller level), to capture the default action method as the parameter.
// That route would then be applied to all actions in the controller; unless a specific Route has been defined on a specific action, overriding the default setting on the controller

// namespace AttributeRoutingDemoInMVC.Controllers
// {
//     [RoutePrefix("MyPage")]
//     [Route("action = Index")]
//     public class HomeController : Controller
//     {
//         // URL: /MyPage/
//         public ActionResult Index()
//         {
//             ViewBag.Message = "Index Page";
//             return View();
//         }

//         // URL: /MyPage/Contact
//         public ActionResult Contact()
//         {
//             ViewBag.Message = "Contact page";
//             return View();
//         }

//         // URL: /MyPage/About
//         public ActionResult About()
//         {
//             ViewBag.Message = "About";
//             return View();
//         }
//     }
// }


// Route Names in Attribute Routing
// You can specify a name for a route, in order to easily allow URI generation for it. For example, for the following route:
// namespace AttributeRoutingDemoInMVC.Controllers
// {
//     [Route("menu", Name = "mymenu")]
//     public class MenuController : Controller
//     {
//         public ActionResult MainMenu()
//         {
//             ViewBag.Message = "Menu Page";
//             return View();
//         }
//     }
// }


// You could generate a link using Url.RouteUrl:
// <a href=”@Url.RouteUrl(“mymenu”)“>Main menu</a>