// What is Attribute Routing in ASP.NET MVC?
// If we are defining Routes by using the [Route] attribute is called Attribute Routing.
// It provides you more control over the URIs by defining routes directly on actions and controllers in your ASP.NET MVC application.

// Note: The earlier style of routing, called convention-based routing, is still fully supported by ASP.NET MVC 5. In fact, you can combine both these routing approaches in the same project.

// Why do we need Attribute Routing in ASP.NET MVC Application?
// Models/Student.cs
// namespace AttributeRoutingDemoInMVC.Models
// {
//     public class Student
//     {
//         public int Id { get; set; }
//         public string Name { get; set; }
//     }
// }

// Creating Students Controller:
// StudentsController.cs

// namespace AttributeRoutingDemoInMVC.Controllers
// {
//     public class StudentsController : Controller
//     {
//         static List<Student> students = new List<Student>()
//         {
//             new Student() { Id = 1, Name = "Pranaya" },
//             new Student() { Id = 2, Name = "Priyanka" },
//             new Student() { Id = 3, Name = "Anurag" },
//             new Student() { Id = 4, Name = "Sambit" }
//         };

//         [HttpGet]
//         public ActionResult GetAllStudents()
//         {
//             return View(students);
//         }

//         [HttpGet]
//         public ActionResult GetStudentByID(int studentID)
//         {
//             Student studentDetails = students.FirstOrDefault(s => s.Id == studentID);
//             return View(studentDetails);
//         }

//         [HttpGet]
//         public ActionResult GetStudentCourses(int studentID)
//         {
//             List<string> CourseList = new List<string>();

//             if (studentID == 1)
//                 CourseList = new List<string>() { "ASP.NET", "C#.NET", "SQL Server" };
//             else if (studentID == 2)
//                 CourseList = new List<string>() { "ASP.NET MVC", "C#.NET", "ADO.NET" };
//             else if (studentID == 3)
//                 CourseList = new List<string>() { "ASP.NET WEB API", "C#.NET", "Entity Framework" };
//             else
//                 CourseList = new List<string>() { "Bootstrap", "jQuery", "AngularJs" };

//             ViewBag.CourseList = CourseList;

//             return View();
//         }
//     }
// }


// GetAllStudents.cshtml
// @model IEnumerable<AttributeRoutingDemoInMVC.Models.Student>
// @{
//     ViewBag.Title = "GetAllStudents";
// }
// <h2>GetAllStudents</h2>
// <table class="table">
//     <tr>
//         <th>
//             @Html.DisplayNameFor(model => model.Id)
//         </th>
//         <th>
//             @Html.DisplayNameFor(model => model.Name)
//         </th>

//     </tr>

//     @foreach (var item in Model)
//     {
//         <tr>
//             <td>
//                 @Html.DisplayFor(modelItem => item.Id)
//             </td>
//             <td>
//                 @Html.DisplayFor(modelItem => item.Name)
//             </td>
//         </tr>
//     }

// </table>


// GetStudentByID.cshtml
// @model AttributeRoutingDemoInMVC.Models.Student
// @{
//     ViewBag.Title = "GetStudentByID";
// }
// <h2>GetStudentByID</h2>
// <div>
//     <h4>Student</h4>
//     <hr />
//     <dl class="dl-horizontal">
//         <dt>
//             @Html.DisplayNameFor(model => model.Name)
//         </dt>
//         <dd>
//             @Html.DisplayFor(model => model.Name)
//         </dd>
//         <dt>
//             @Html.DisplayNameFor(model => model.Id)
//         </dt>
//         <dd>
//             @Html.DisplayFor(model => model.Id)
//         </dd>
//     </dl>
// </div>


// GetStudentCourses.cshtml
// @{
//     ViewBag.Title = "GetStudentCourses";
// }
// <h2>GetStudentCourses</h2>
// @foreach (var item in ViewBag.CourseList)
// {
//     <li>@item</li>
// }


// RouteConfig.cs
// namespace AttributeRoutingDemoInMVC
// {
//     public class RouteConfig
//     {
//         public static void RegisterRoutes(RouteCollection routes)
//         {
//             routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

//             routes.MapRoute(
//                 name: "Default",
//                 url: "{controller}/{action}/{id}",
//                 defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
//             );
//         }
//     }
// }


// Now we can access the above three methods using the following URL
// http://localhost:58316/Students/GetAllStudents
// http://localhost:58316/Students/GetStudentByID?studentID=1
// http://localhost:58316/Students/GetStudentCourses?studentID=1


// resources often contain child resources like Clients have Orderes; Movies have Actors, and Books have Authors.
// It’s natural to create URIs that reflects these relations like as /clients/1/orders

// If we want the URL Pattern “/students/1/courses” and if that URL Pattern should be mapped to GetStudentCourses(int studentID), then this type of URL is very difficult to create using the convention-based routing in ASP.NET MVC Application. But by using Attribute Routing which is a new feature introduced in ASP.NET MVC 5, this type of URL pattern can be achieved very easily.




// How to use Attribute Routing in ASP.NET MVC?
// The first thing that you need to do is Enabling Attribute Routing in RouteConfig.cs class.


// How to Enabling Attribute Routing in ASP.NET MVC Application?
// add a call to routes.MapMvcAttributeRoutes() method within the RegisterRoutes() method of RouteConfig.cs file.

// namespace AttributeRoutingDemoInMVC
// {
//     public class RouteConfig
//     {
//         public static void RegisterRoutes(RouteCollection routes)
//         {
//             routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

//             //Enabling attribute routing 
//             routes.MapMvcAttributeRoutes();

//             routes.MapRoute(
//                 name: "Default",
//                 url: "{controller}/{action}/{id}",
//                 defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
//             );
//         }
//     }
// }



// Using Route Attribute in ASP.NET MVC:
// Modify the GetStudentCourses Action Method as shown below. As you can see, here we decorate the GetStudentCourses Action Method with [Route(“students/{studentID}/courses”)] Attribute. 

// [HttpGet]
// [Route("students/{studentID}/courses")]
// public ActionResult GetStudentCourses(int studentID)
// {
//     List<string> CourseList = new List<string>();

//     if (studentID == 1)
//         CourseList = new List<string>() { "ASP.NET", "C#.NET", "SQL Server" };
//     else if (studentID == 2)
//         CourseList = new List<string>() { "ASP.NET MVC", "C#.NET", "ADO.NET" };
//     else if (studentID == 3)
//         CourseList = new List<string>() { "ASP.NET WEB API", "C#.NET", "Entity Framework" };
//     else
//         CourseList = new List<string>() { "Bootstrap", "jQuery", "AngularJs" };

//     ViewBag.CourseList = CourseList;

//     return View();
// }


// What are the advantages of using Attribute Routing in ASP.NET MVC5?
// It gives us more control over the URIs than convention-based routing. Creating URI patterns like hierarchies of resources (For example, students have courses, Departments have employees) is very difficult with convention-based routing.
// Reduces the chances for errors, if a route is modified incorrectly in RouteConfig.cs then it may affect the entire application’s routing.
// May decouple controller and action names from route entirely.
// Easy to map two routes pointing to the same action.


// Modern asp.net core
// 1. Why you need this for your Banking App
// Imagine you want to see the details of a specific transaction.
// Convention URL: mybank.com/Transaction/GetDetailsByTransactionID?transactionID=500 (Ugly and long)
// Attribute URL: mybank.com/transaction/500/details (Clean and professional)

// [Route("transaction/{id}/details")]
// public ActionResult GetDetails(int id) { ... }


// 2. Key Syntax: The [Route] Attribute
// Level A: Controller Level (Route Prefix)
// If every action in your controller starts with the same word, put it at the top.
// [Route("bank")]
// public class AccountController : Controller {
//     [Route("profile")] // Resulting URL: bank/profile
//     public ActionResult Profile() { ... }
// }


// Level B: Action Level
// This is where you define the specific path and parameters.
// {id}: A required parameter.
// {id:int}: A parameter with a constraint (must be a number).


// 3. Advantages
// Readability, Child Resources, Flexibility