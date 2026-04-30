// Empty Result in ASP.NET MVC
// the action is specifically intended to return nothing.
// EmptyResult doesn’t have a helper
//  if an action returns null, MVC will detect that and make it return an EmptyResult

// Home Controller
// public class HomeController : Controller
// {
//     public EmptyResult Empty()
//     {
//         return new EmptyResult();
//     }

//     public ActionResult NothingReturned()
//     {
//         return null; //Returns an EmptyResult
//     }
// }


