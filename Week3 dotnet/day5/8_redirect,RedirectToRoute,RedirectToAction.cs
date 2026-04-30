// Redirect Result in ASP.NET MVC
// you want to redirect to a specific URL, then you need to use the Redirect method and this method takes the URL to redirect.

// public class HomeController : Controller
// {
//     public RedirectResult Index()
//     {
//         return Redirect("https://dotnettutorials.net");
//     }
// }

// This works great for redirecting to outside sites from the current application, but not for redirecting to other pages within the same application
// For that, we can use RedirectToRouteResult.
// Redirect result is returning the result to a specific URL
// It is rendered to the page by URL. If we give the wrong URL, it will show 404-page errors


// RedirectToRoute Result in ASP.NET MVC
// The RedirectToRouteResult is used whenever we need to go from one action method to another action method within the same or different controller in ASP.NET MVC Application.

// public class HomeController : Controller
// {
//     public RedirectToRouteResult Index()
//     {
//         return RedirectToRoute(new { controller = "Home", action = "About" });
//     }
// }

// That’s not very friendly though. There’s a better way, an overload of this helper called RedirectToAction:



// RedirectToAction Result in ASP.NET MVC
// The RedirectToAction Result in ASP.NET MVC is returning the result to a specified controller and action method.
// Suppose the action name is not available but mentioned in the current controller, then it will show a 404 error page.

// public class HomeController : Controller
// {
//     public ActionResult Index()
//     {
//         return RedirectToAction("Login", "Account");
//     }
// }