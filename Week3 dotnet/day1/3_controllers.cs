// What is a Controller in an ASP.NET MVC application?
// A controller in an ASP.NET MVC Application is a class having a set of public methods.
// These public methods of the controller class are called action methods or simple actions.
// These action methods in the ASP.NET MVC application are going to handle the incoming HTTP Requests.

// The Controllers in an ASP.NET MVC application logically group similar types of actions together.
// This grouping of actions together allows us to define sets of rules such as routing, caching, and authorization which are going to be applied collectively.
// By convention, in ASP.NET MVC, the controller classes should reside in the project’s root-level Controllers folder and should be inherited from the System.Web.Mvc.Controller base class.


// Creating an Empty ASP.NET MVC application:
// Adding Controller to the Project:
// 1. Right Click on the “Controllers” folder
// 2. Select Add > Controller
// 3. Select MVC 5 Controller – Empty
// 4. Click on the ADD button


// if we run the app now then we will get "view 'index' not found"

// Fixing the Error:
// we need to add a view with the name “Index”
// namespace FirstMVCDemo.Controllers
// {
//     public class HomeController : Controller
//     {
//         public ActionResult Index()
//         {
//             return View();
//         }
//     }
// }

// To fix the issue, modify the return type of the Index() action method from “ActionResult” to “string”.
// Then return a string such as “Hello MVC 5 Application” as shown below.

// namespace FirstMVCDemo.Controllers
// {
//     public class HomeController : Controller
//     {
//         public string Index()
//         {
//             return "Hello MVC 5 Application";
//         }
//     }
// }


// So the next obvious question that should come to your mind is where this mapping is defined.
// the mapping is defined within the RegisterRoutes() method of the RouteConfig class.
// modern: in Program.cs

// In short
// A controller in ASP.NET MVC Application is a class that is inherited from System.Web.Mvc.Controller.
// The MVC controller is the one that is going to interact with both Models and views.
// The controller class contains a set of public methods which are also called the action methods. It is these action methods which is going to handle the incoming HTTP Requests.
// In ASP.NET MVC, every controller class name must end with the word “Controller”. For example, the controller for the home page must be HomeController, and the controller for a student must be StudentController.
// Every controller class must be located in the Controllers folder.
