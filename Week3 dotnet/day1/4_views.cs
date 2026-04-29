// What are ASP.NET MVC Views?
// The view component contains the logic to represent the model data as a user interface with which the end-user can interact.
// Typically, it creates the user interface with the data from the model provided to it by the controller.
// We can consider the Views in ASP.NET MVC as HTML templates embedded with Razor syntax which generates HTML content that sends to the client.


// Where ASP.NET MVC View Files are Stored?
// In ASP.NET MVC, the views are having a “.cshtml” extension when we use C# as the programming language with Razor syntax.
// Usually, each controller will have its own folder in which the controller-specific .cshtml files (views) are going to be saved.
// eg. If you have a HomeController.cs, its views must be in Views/Home/.
//     If you have a StudentController.cs, its views must be in Views/Student/.
// The controller-specific folders are going to be created within the Views folder.
// The most important point that you need to keep in mind is the view file name and the controller action name is going to be the same.

// Example to Understand ASP.NET MVC Views:
// Let’s say, we created an ASP.NET MVC application with two controllers i.e. StudentController and HomeController.
// The HomeController that we created is having the following three action methods.
// AboutUs()
// ContactUs()
// Index()

// Similarly, the StudentController is created with the following four action methods.
// Index()
// Details()
// Edit()
// Delete()

// As we have two controllers in our application, so there are two folders created with the Views folder one per Controller.
// The Home  Folder is going to contain all the view files (i.e. cshtml files) which are specific to HomeController.
// the Student Folder is going to contain all the .cshtml files which are specific to Student Controller.


// Understanding Views in ASP.NET MVC with Examples:
// modify the HomeController as shown below
// using System.Web.Mvc;
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

// In the above HomeController, we created an Action method that is going to return a view. In order to return a view from an action method in ASP.NET MVC Application, we need to use the View() extension method which is provided by System.Web.Mvc.Controller Base class. Now run the application and navigate to the “/Home/Index” URL and you will get the following error.
// the view 'Index' not found.


// Let us understand why we got the above error.
// As we are returning 
// a view from the Index action method of Home Controller, by default the MVC Framework will look for a file with the name Index.aspx or Index.ascx within the Home and Shared folder of the application if the view engine is APSX
// If it is not found there then it will search for a view file with the name Index.cshtml or Index.vbhtml within the Home and Shared folder of your application.


// Adding Views in ASP.NET MVC Application
// Once the Index view is created, then copy and paste the following into it.

// @{
//     Layout = null;
// }

// <!DOCTYPE html>

// <html>
// <head>
//     <meta name="viewport" content="width=device-width" />
//     <title>Index</title>
// </head>
// <body>
//     <div> 
//         <h1>Index View Coming From Views/Home Folder</h1>
//     </div>
// </body>
// </html>


// Advantages of Using Views in ASP.NET MVC Application:
// Separation of concerns (separates the UI from the rest of the application)
// The common or repetitive sections of the web pages can be easily reused by using layout and partial views.