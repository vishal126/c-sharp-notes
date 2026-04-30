// JavaScript Result in ASP.NET MVC:
// potentially dangerous ActionResult is JavaScriptResult.
// It returns a script that is to be executed by the browser

// Step 1: Add this JavaScriptResult() method in home controller.
// public class HomeController : Controller
// {
//     public ActionResult Index()
//     {
//         return View();
//     }

//     [HttpGet]
//     public JavaScriptResult WarningMessage()
//     {
//         var msg = "alert('Are you sure want to Continue?');";
//         return new JavaScriptResult() { Script = msg };
//     }
// }

// Step 2: Open Index.cshtml and add the following code.
// @{
//     ViewBag.Title = "DOT NET TUTORIALS";
// }
// <script src="~/Scripts/jquery-1.10.2.js"></script>
// <div class="jumbotron">
//     <h2 style="color:chocolate">Welcome to Dot Net Tutorials</h2>
// </div>
// <script>
//     $(document).ready(function () {
//         $("button").click(function () {
//             $.getScript("/Home/WarningMessage");
//         });
//     });
// </script>
// <button>Show Message</button>

// removed completely form modern dotnet