// What is Routing in ASP.NET MVC?
// The ASP.NET MVC Routing module is responsible for mapping the incoming browser requests (i.e. the incoming URL or incoming HTTP Requests) to a particular controller action method.
// This mapping is done by the routing rules defined for your application.

// For example, if we issue a request to the “/Home/Index” URL, then it is the Index action method of the Home Controller class that is going to handle the request as shown in the below.
// http://localhost:52190/Home/Index

// public class HomeController : Controller
// {
//     public ViewResult Index()
//     {
//         return View();
//     }
// }


// What are the different types of Routing supported by ASP.NET MVC?
// two ways
// 1. Convention Based Routing
// 2. Attribute-Based Routing


// How does the Routing work in ASP.NET Web Form?
// In ASP.NET Web Forms application, each and every URL should be matched with a specific .aspx file.
// eg. a URL http://dotnettutorials/employeeinfo.aspx must match with a physical file i.e. employeeinfo.aspx that contains necessary code and HTML for rendering the response to the browser.
// So in the case of ASP.NET Web Forms, the URL pointing to the file must have its physical existence.

// Then ASP.NET Framework introduced the concept of Routing to eliminate the need of mapping each and every URL to a physical file.
// The Routing Concept enables us to define the URL pattern that maps to the request handler. That request handler can be a class (class methods) or file.
// In the case of the ASP.NET Webform application, the request handler is a file (i.e. aspx file) and in the case of ASP.NET MVC Framework, the request handler is the Controller Methods i.e. action methods.


// What is a Route in ASP.NET MVC Application?
// The Route defines the URL pattern and the handler information.
// The handler can be a physical file, such as an ASPX file in the case of the WebForms application.
// A handler can also be a class that processes the request, such as a controller in the case of the ASP.NET MVC application. 

// ***** In the ASP.NET MVC application, all the Routes (URL pattern and Handler Information) are stored in the RouteTable and then the Routing engine uses this RouteTable to determine the appropriate handler class for an incoming HTTP request.


// How Does the Routing work in ASP.NET MVC Application?
// https://dotnettutorials.net/wp-content/uploads/2018/07/Routing-in-ASP.NET-MVC-Application-768x567.png

// [Url Request] -> Routing Engine[Route Table] -> (Url mathces with Configured Routes?) -(yes)-> [execute the controller Action Method] -> [Response]
//                                                                  |
//                                                                  v
//                                                              404 Error

// In simple words, we can say that Routing in ASP.NET MVC is a pattern matching mechanism that handles the incoming HTTP request (i.e. incoming URL) and figures out what to do with that incoming HTTP request.


// The routing functionality is implemented in the *****System.Web.Routing.


// How to Configure a Route in ASP.NET MVC?
// Every ASP.NET MVC application must configure (register) at least one route in the RouteConfig class and by default, the ASP.NET MVC Framework provides one default route.
// But you can configure as many routes as you want.
// You can register a route within the RegisterRoutes method of RouteConfig class, which you can find with the RouteConfig.cs class file under the App_Start folder.
// namespace FirstMVCDemo
// {
//     public class RouteConfig
//     {
//         public static void RegisterRoutes(RouteCollection routes)
//         {
//             routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

//             routes.MapRoute(
//                 name: "Default", //Route Name
//                 url: "{controller}/{action}/{id}", //Route Pattern
//                 defaults: new
//                 {
//                     controller = "Home", //Controller Name
//                     action = "Index", //Action method Name
//                     id = UrlParameter.Optional //Defaut value for above defined parameter
//                 }
//             );
//         }
//     }
// }


// Default Route in ASP.NET MVC?
// The Routing is configured using the MapRoute() extension method of the RouteCollection class, where the Route name is “Default” and the URL pattern is “{controller}/{action}/{id}“.
// The Defaults value for the controller is Home, and the default action method is Index and the id parameter is optional.

// This Route information i.e. the Route Name, URL Pattern, and handler information i.e. the controller name, action method name are stored in the Route table at the application start-up i.e. when the application runs for the first time.

// Here Defaults specifies which controller, action method, or value of id parameter should be used if they do not exist in the incoming request URL. In the same way, you can configure other routes using the MapRoute method of RouteCollection.

// Note: The route name should be unique across the entire application. Route name can’t be duplicated.


// Understanding the URL Pattern in ASP.NET MVC Routing:
// The URL pattern is considered only after the domain name in the URL.
// For example, Suppose your web application is running on www.dotnettutorials.net then the URL pattern “{controller}/{action}/{id}”  for your application would be look like www.dotnettutorials.net/{controller}/{action}/{id}.

// Anything after the “www.dotnettutorials.net/” would be considered as the controller name. In the same way, anything after the controller name would be considered as the action name and the value of the id parameter.


// How to Register Routes in ASP.NET MVC?
// Once you create the Route, next we need to register the Route at the Application Level.
// To register something at the application level, ASP.NET MVC Framework provides the Global.asax file.
// This file contains one class called MvcApplication which is inherited from the System.Web.HttpApplication class.
// This class provides many methods such as Application_BeginRequest, Application_Error, Application_Start, Session_Start, Session_End, etc. So, the question is in which method, we need to register the Routes?
// We want the Route Table to load all the Routes at the Application Startup i.e. when we run the application for the first time. So, we need to register the routes within the Application_Start method by calling RouteConfig.RegisterRoutes(RouteTable.Routes) method.

// If you open the Global.asax file, you will find the following code in it.
// namespace FirstMVCDemo
// {
//     public class MvcApplication : System.Web.HttpApplication
//     {
//         protected void Application_Start()
//         {
//              AreaRegistration.RegisterAllAreas();
//              FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
//              RouteConfig.RegisterRoutes(RouteTable.Routes);
//              BundleConfig.RegisterBundles(BundleTable.Bundles);
//         }
//     }
// }



// Understanding ASP.NET MVC Routing with an Example:
// To understand ASP.NET MVC Routing lets create a controller called HomeController as shown below

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


// Example to understand Routing:
// http://localhost:53605/ => controller = Home, action = Index, id = none, since default value of controller and action are Home and Index respectively.
// http://localhost:53605/Home => controller = Home, action = Index, id = none, since default value of action is Index
// http://localhost:53605/Home/Index => controller = Home, action = Index, id=none
// http://localhost:53605/Home/Index/5 => controller = Home, action = Index, id = 5


// How is the routing table created in ASP.NET MVC?
// When an MVC application first starts, the Application_Start() method in global.asax is called. This method calls the RegisterRoutes() method. The RegisterRoutes() method creates the routing table for the ASP.NET MVC application.



// Modern dotnet
// In a modern .NET Core Empty Project, Microsoft removed the App_Start folder, RouteConfig.cs, and Global.asax entirely.

// How Routing works in .NET Core Program.cs
// Instead of the RegisterRoutes method, you now configure routing directly in the Middleware Pipeline using MapControllerRoute.
// Program.cs
// var builder = WebApplication.CreateBuilder(args);

// // 1. Add services to the container (Replacement for Config files)
// builder.Services.AddControllersWithViews(); 

// var app = builder.Build();

// // 2. Configure the HTTP request pipeline
// if (!app.Environment.IsDevelopment())
// {
//     app.UseExceptionHandler("/Home/Error");
// }

// app.UseStaticFiles();

// // 3. The replacement for RouteConfig.cs
// app.UseRouting();

// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=Home}/{action=Index}/{id?}"); // id? means optional

// app.Run();