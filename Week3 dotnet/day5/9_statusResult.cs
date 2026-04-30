// Status Results in ASP.NET MVC Application
// The Status Action Results will return status codes to the browser for it to use
// HttpStatusCodeResult
// HttpUnauthorizedResult
// HttpNotFoundResult


// HttpStatusCodeResult in ASP.NET MVC:
// HttpStatusCodeResult in ASP.NET MVC Framework returns an HTTP status code to the browser, along with a custom message to be displayed

// using System.Net;
// using System.Web.Mvc;
// public class HomeController : Controller
// {
//     public HttpStatusCodeResult UnauthorizedStatusCode()
//     {
//         return new HttpStatusCodeResult(HttpStatusCode.Unauthorized, "You are not authorized to access this controller action.");
//     }
//     public HttpStatusCodeResult BadGateway()
//     {
//         return new HttpStatusCodeResult(HttpStatusCode.BadGateway, "I have no idea what this error means.");
//     }
// }

// There is no helper method for this ActionResult.
// The HttpStatusCode enumeration contains all HTTP status codes (so that you don’t have to remember what 402 or 307 mean).
// These are useful in exception-driven scenarios where you have custom error pages defined


// HttpUnauthorizedResult in ASP.NET MVC
// Returning an HttpUnauthorizedResult is the same as returning HttpStatusCodeResult with HttpStatusCode.Unauthorized, it’s just more readable:

// using System.Web.Mvc;
// public class HomeController : Controller
// {
//     public HttpStatusCodeResult UnauthorizedResult()
//     {
//         return new HttpUnauthorizedResult("You are not authorized to access this controller action.");
//     }
// }


// HttpNotFoundResult in ASP.NET MVC
// This is also an overload of HttpStatusCodeResult, but unlike HttpUnauthorizedResult, it actually does have a helper method:

// using System.Web.Mvc;
// public class HomeController : Controller
// {
//     public HttpNotFoundResult NotFound()
//     {
//         return HttpNotFound("We didn't find that action, sorry!");
//     }
// }


// In modern ASP.NET Core, Microsoft realized developers use these so often that they built helper methods directly into the Controller for almost every status code imaginable. You rarely have to use the new keyword anymore!

// HttpNotFoundResult (The 404 Error)
// public IActionResult GetUserProfile(int id)
// {
//     var user = _context.Users.Find(id);

//     // If the database returns nothing, trigger a 404!
//     if (user == null) 
//     {
//         return NotFound("Sorry, we couldn't find that user."); 
//     }

//     return View(user);
// }


// HttpUnauthorizedResult
// public IActionResult DeleteDatabase()
// {
//     // If they aren't logged in, block them with a 401
//     if (!User.Identity.IsAuthenticated)
//     {
//         return Unauthorized("You must be logged in to do this.");
//     }

//     // ... delete logic here
//     return Content("Deleted!");
// }


// HttpStatusCodeResult
// public IActionResult BadGateway()
// {
//     // 502 is the official internet code for a Bad Gateway
//     return StatusCode(502, "I have no idea what this error means either.");
// }

// public IActionResult CorruptedData()
// {
//     // 400 is the code for a Bad Request (user sent bad data)
//     return BadRequest("The form data was corrupted."); 
// }