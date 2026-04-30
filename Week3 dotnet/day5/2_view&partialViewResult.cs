// View Result and Partial View Result in ASP.NET MVC
// Create a New ASP.NET MVC Application

// View Result in ASP.NET MVC:
// The View Result in MVC returns the result to a View Page.
// The View Result can return data to the View Page through the model class.

// The ViewResult is a class and is derived from the “ViewResultBase” class.
// The “ViewResultBase” is derived from ActionResult class.
// So, ViewResult is indirectly derived from the ActionResult abstract class.

// public class ViewResult: ViewResultBase {
//     public ViewResult();
//     public string MasterName { get; set; }
//     protected override ViewEngineResult FindView(ControllerContext context);
// }

// public abstract class ViewResultBase: ActionResult
// {
//     protected ViewResultBase();
//     public object Model { get; }
//     public TempDataDictionary TempData { get; set; }
//     public IView View { get; set; }
//     public dynamic ViewBag {get; }
//     public ViewDataDictionary ViewData { get; set; }
//     public ViewEngineCollection ViewEngineCollection { get; set; }
//     public string ViewName { get; set; }
//     public override void ExecuteResult (ControllerContext context);
//     protected abstract ViewEngineResult FindView(ControllerContext context);
// }


// Example: Let’s see the HomeController Index Action method to understand View Result
// public class HomeController : Controller
// {
//     public ViewResult Index()
//     {
//         return View();
//     }
// }

// MVC will look for a View named “Index” in the Views/Home subfolder and then look in the Views/Shared subfolder.
// If it doesn’t find it, then it will throw an InvalidOperationException.


// What if I wanted to return a view other than the one that matches the action name? Then we need to specify the View name.
// public class HomeController : Controller
// {
//     public ViewResult Index()
//     {
//         return View("About");
//     }
// }



// Partial View Result in ASP.NET MVC Application
// The Partial View Result in MVC is returning the result to a Partial View Page.
// A partial view is one of the views that we can call inside a Normal view page.

// let’s add a Partial View inside the Shared Folder.
// _ViewStart.cshtml

// Now open _PartialView.cshtml file and then Copy and paste the below code into it.
// <h3>Its a Partial View</h3>

// As shown below, let’s modify the index action method to Return a Partial View.
// public class HomeController : Controller
// {
//     public PartialViewResult Index()
//     {
//         return PartialView("_PartialView");
//     }
// }


// When you call return View(), ASP.NET doesn't just process your specific View file (like Create.cshtml). It also grabs your _Layout.cshtml file, wraps the layout around your view, and sends the entire massive package (including the <head>, <body>, navbar, and footer) to the browser.

// View Components
// A View Component is like a mini-controller. It can talk to the database by itself! We use View Components today for complex chunks like a "Shopping Cart Dropdown" that needs to calculate totals from the database regardless of what page the user is currently on.