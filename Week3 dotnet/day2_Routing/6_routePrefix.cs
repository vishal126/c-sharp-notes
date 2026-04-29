// Why do we need Route Prefix in ASP.NET MVC Attribute Routing?
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
//         [Route("students")]
//         public ActionResult GetAllStudents()
//         {
//             return View(students);
//         }

//         [HttpGet]
//         [Route("students/{studentID}")]
//         public ActionResult GetStudentByID(int studentID)
//         {
//             Student studentDetails = students.FirstOrDefault(s => s.Id == studentID);
//             return View(studentDetails);
//         }

//         [HttpGet]
//         [Route("students/{studentID}/courses")]
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


// In above code we are using route attributes at the action level to define routes.
// all the routes in the StudentsController start with the same prefix i.e. students.
// That means “students” is the common prefix for all the routes in Student Controller.

// instead of writing the common prefix “students” at each action method, we can specify the common prefix students for the entire Student Controller (for all the action methods of student controller) using the [RoutePrefix] attribute at the controller level.
// namespace AttributeRoutingDemoInMVC.Controllers
// {
//     [RoutePrefix("students")]
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
//         [Route]
//         //This will be translated to /students 
//         public ActionResult GetAllStudents()
//         {
//             return View(students);
//         }

//         [HttpGet]
//         [Route("{studentID}")]
//         //This will be translated to /students/2
//         public ActionResult GetStudentByID(int studentID)
//         {
//             Student studentDetails = students.FirstOrDefault(s => s.Id == studentID);
//             return View(studentDetails);
//         }

//         [HttpGet]
//         [Route("{studentID}/courses")]
//         //This will be translated to /students/2/course
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


// we applied the [RoutePrefix(“students”)] attribute at the Controller level
// This Route Prefix attribute eliminates the need to repeat the common prefix “students” on each and every controller action method. However, sometimes we may need to override the route prefix attribute. 



// How to Override Route Prefix Attribute in ASP.NET MVC Attribute Routing?
// Modals/Teacher.cs
// namespace AttributeRoutingDemoInMVC.Models
// {
//     public class Teacher
//     {
//         public int Id { get; set; }
//         public string Name { get; set; }
//     }
// }


// StudentsController
// namespace AttributeRoutingDemoInMVC.Controllers
// {
//     [RoutePrefix("students")]
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
//         [Route]
//         //This will be translated to /students 
//         public ActionResult GetAllStudents()
//         {
//             return View(students);
//         }

//         [HttpGet]
//         [Route("{studentID}")]
//         //This will be translated to /students/2
//         public ActionResult GetStudentByID(int studentID)
//         {
//             Student studentDetails = students.FirstOrDefault(s => s.Id == studentID);
//             return View(studentDetails);
//         }

//         [HttpGet]
//         [Route("{studentID}/courses")]
//         //This will be translated to /students/2/course
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

//         public ActionResult GetTeachers()
//         {
//             List<Teacher> teachers = new List<Teacher>()
//             {
//                 new Teacher() { Id = 1, Name = "James" },
//                 new Teacher() { Id = 2, Name = "Patrik" },
//                 new Teacher() { Id = 3, Name = "Smith" }
//             };
//             return View(teachers);
//         }
//     }
// }



// GetTeachers.cshtml
// @model IEnumerable<AttributeRoutingDemoInMVC.Models.Teacher>
// @{
//     ViewBag.Title = "GetTeachers";
// }
// <h2>GetTeachers</h2>
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


// We want the GetTeachers() method to be mapped to URI “/tech/teachers”.

// [Route("tech/teachers")]
// public ActionResult GetTeachers()
// {
//     List<Teacher> teachers = new List<Teacher>()
//             {
//                 new Teacher() { Id = 1, Name = "James" },
//                 new Teacher() { Id = 2, Name = "Patrik" },
//                 new Teacher() { Id = 3, Name = "Smith" }
//             };
//     return View(teachers);
// }

// If we use the [Route] attribute on the GetTeachers() method as shown in the above code and when we navigate to tech/teachers URL, we will get the following error.

// server error in '/' application

// But if we navigate to /students/tech/teachers then we will get the output as expected that is the list of teachers.
// This is because the [RoutePrefix(“students”)] attribute on StudentsController.
// there is definitely a need to override the RoutePrefix attribute used on the StudentsController.

// To override the RoutePrefix attribute, we need to use the ~ (tilde) symbol while defining the route as shown in the below code.

// we are using [Route(“~/tech/teachers”)] attribute and the tilde (~) symbol in the Route attribute will override or you can ignore the Route Prefix attribute defined at the StudentsController level.

// [Route("~/tech/teachers")]
// public ActionResult GetTeachers()
// {
//     List<Teacher> teachers = new List<Teacher>()
//             {
//                 new Teacher() { Id = 1, Name = "James" },
//                 new Teacher() { Id = 2, Name = "Patrik" },
//                 new Teacher() { Id = 3, Name = "Smith" }
//             };
//     return View(teachers);
// }


// What is the use of the RoutePrefix Attribute in ASP.NET MVC Attribute Routing?
// RoutePrefix attribute is used to specify the common route prefix at the controller level to eliminate the need to repeat that common route prefix on each and every controller action method


// How to override the route prefix? 
// Use ~ character to override the route prefix


// Modern .net core
// in ASP.NET Core, we usually just use a standard [Route] attribute at the controller level to achieve the same thing.

// [Route("students")] // This acts as the Prefix
// public class StudentsController : Controller
// {
//     [HttpGet]
//     [Route("")] // Maps to: /students
//     public ActionResult GetAllStudents() { ... }

//     [HttpGet]
//     [Route("{studentID}")] // Maps to: /students/1
//     public ActionResult GetStudentByID(int studentID) { ... }
// }


// The "Tilde" Overrider (~)
// [Route("~/teachers/list")]
// public ActionResult GetTeachers() { ... }


