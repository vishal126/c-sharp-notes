// an Action Result is the final package of information that a Controller sends back to the user's browser after it finishes doing its job.

// ActionResult vs IActionResult
// In your older MVC tutorial, you will see methods written like this:
// public ActionResult Create()

// In modern ASP.NET Core, we use the interface version:
// public IActionResult Create()


// document
// Action Results in ASP.NET MVC
// Request and Response ----> Controller -----> View
//                                |
//                                |
//                  Different types of action result.

// What is the Action Method in ASP.NET MVC?
// All the public methods inside a Controller which respond to the URL are known as Action Methods.
// When creating an Action Method, we must follow the below rules.
// The action method must be public.
// It cannot be overloaded
// It cannot be a static method
// ActionResult is the base class of all the result types that an action method returns


// What is the Action Result in ASP.NET MVC?
// Action Result is the return type of an action method.
// The action result is an abstract class
// It is the base class for all types that an action method returns
// View, Partial View, Redirect, Json, Content, File, Redirect To Action, etc. are derived from the abstract Action Result class and these types can also be used as the return type of an action method.

// ActionResult ---->view
//                -->Partial View
//                -->Redirect
//                -->Json
//                -->Content
//                -->File
//                -->Redirect to Action


// ActionResult Class:
// ActionResult is an Abstract class having one constructor and one method.
// The constructor is basically used to initializes a new instance of the ActionResult class.
// The ExecuteResult method enables the processing of the result of an action method by a custom type that inherits from the ActionResult class.
// The ExecuteResult method takes one parameter i.e. context i.e. the context in which the result is executed.
// The context includes the information of Controller, HTTP Content, request context, and route data.

// namespace System.Web.Mvc
// {
//     // Summary:
//     //Represents the result of an action method.
//     public abstract class ActionResult
//     {
//         // Summary: Initializes a new instance of the System.Web.Mvc.ActionResult class.
//         protected ActionResult();
//         // Summary: Enables processing of the result of an action method by a custom type that inherits
//         // from the System.Web.Mvc.ActionResult class.
//         // Parameters: 
//         //  context:
//         //      The context in which the result is executed. The context information includes
//         //      the controller, HTTP content, request context, and route data.
//         public abstract void ExecuteResult (ControllerContext context);
//     }
// }


// Why is ActionResult an abstract class in ASP.NET MVC?
// It’s because different controller action methods can return different types of results as per the business needs and still the ASP.NET MVC Framework handles them properly.

// Types of Action Results
// Each Action Result returns a different type of result format.
// ActionResult is the base class of all the result types.
// 1. ViewResult – Represents HTML and markup.
// 2. PartialViewResult – Represents HTML and markup.
// 3. EmptyResult – Represents no result.
// 4. RedirectResult – Represents a redirection to a new URL.
// 5. RedirectToActionResult – It is returning the result to a specified controller and action method
// 6. JsonResult – Represents a JavaScript Object Notation result that can be used in an AJAX application.
// 7. JavaScriptResult – Represents a JavaScript script.
// 8. ContentResult – Represents a text result.
// 9. FileContentResult – Represents a downloadable file (with the binary content).
// 10. FilePathResult – Represents a downloadable file (with a path).
// 11. FileStreamResult – Represents a downloadable file (with a file stream).


// Example
// the action method return type is ActionResult, and the method returning two types of results. First is, return View which is similar to return new ViewResult().
// Second is, return RedirectToAction(); which is similar to return new RedirectToActionResult()

// <span style="color: #000000; font-family: arial, helvetica, sans-serif;">public ActionResult ChooseView()
// {
//     if (DateTime.Now.Day % 2 == 0)
//     {
//         return View("View1");
//     }
//     else
//     {
//         return RedirectToAction("View2");
//     }
// }
// </span>


// Categorized of Action Results:
// These results are categorized into three sections: 
// 1. Content-returning
// 2. Redirection
// 3. Status.


// Content-Returning Action Result in ASP.NET MVC:
// The Content-Returning ActionResults in ASP.NET MVC are responsible for returning content to the browser or calling the script.

// ViewResult
// PartialViewResult
// FileResult
// ContentResult
// EmptyResult
// JsonResult
// JavaScriptResult


// Redirection Action Result in ASP.NET MVC:
// The Redirection ActionResults in ASP.NET MVC are responsible for redirecting to other URLs or actions.
// RedirectResult
// RedirectToRouteResult
// RedirectToActionResult


// Status Action Result in ASP.NET MVC:
// The Status ActionResults in ASP.NET MVC are responsible for returning status codes to the browser.
// HttpStatusCodeResult
// HttpUnauthorizedResult
// HttpNotFoundResult


// What should be the return type of an action method – ActionResult or specific derived type? 
// It basically depends on the situation. If your action method returns one type of result, then it is good to use a specific derived type based on the return value. But, if your action method returns different kinds of results based on different conditions, then you should use ActionResult as the return type.

// public ActionResult Index()
// {
//     if (Your_Condition)
//         return View();    // returns ViewResult object
//     else
//         return Json("Data");  // returns JsonResult object
// }

// public JsonResult Index()
// {
//     return Json("Data");  // returns JsonResult object
// }