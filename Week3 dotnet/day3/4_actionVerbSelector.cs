// Action Verb Action Selector in ASP.NET MVC Application:
// We need to use the Action Verb Selector when we want to control the invocation of an action method based on the request type in the ASP.NET MVC Application.
// We can define two different action methods with the same name but one action method responds to an HTTP Get request while the other action method responds to an HTTP Post request.

// Database Required:
// CREATE TABLE Employee(
//   [EmployeeId] [int] PRIMARY KEY IDENTITY(1,1),
//   [FullName] [nvarchar](100),
//   [Gender] [nvarchar](10),
//   [EmailAddress] [nvarchar](100),
//   [Salary] DECIMAL(18, 2)
// )

// -- Populate the following test data
// Insert into Employee values('Pranaya Rout', 'Male', 'pranayakumar777@gmail.com', 10000)
// Insert into Employee values('Bikash Rout', 'Male', 'pranayakumar7@gmail.com', 10000)


// Adding ADO.NET Entity Data Model:


// Adding Employee Controller:
// In the below code, the “Edit” action method that is decorated with the [AcceptVerbs(HttpVerbs.Get)] accept verb responds to the GET request, whereas the “Edit” action method which is decorated with [AcceptVerbs(HttpVerbs.Post)] accept verb responds to POST request.
// The default is GET.
// So, if we don’t decorate an action method with any accept verb, then, by default, the method responds to the GET request

// namespace ActionSelectorsinMVC.Controllers
// {
//     public class EmployeeController : Controller
//     {
//         EmployeeDBContext dbContext = new EmployeeDBContext();
//         public ActionResult Index()
//         {
//             List<Employee> ListEmployees = dbContext.Employees.ToList();
//             return View(ListEmployees);
//         } 

//         [AcceptVerbs(HttpVerbs.Get)]
//         public ActionResult Edit(int id)
//         {
//             Employee employee = dbContext.Employees.Where(x => x.EmployeeId == id).FirstOrDefault();
//             return View(employee);
//         }

//         [AcceptVerbs(HttpVerbs.Post)]
//         public ActionResult Edit(Employee employee)
//         {
//             if (ModelState.IsValid)
//             {
//                 dbContext.Entry(employee).State = EntityState.Modified;
//                 dbContext.SaveChanges();
//                 return RedirectToAction("Index");
//             }
//             return View(employee);
//         }
//     }
// }


// Add Index and Edit view.


// HttpGet and HttpPost Attribute in ASP.NET MVC:
// Right-click on Index view and select Add View and provide the following details and click on the Add button.
// Right-click on the Edit action method and click on Add View and provide the following details and click on the Add button.


// HttpGet and HttpPost Attribute in ASP.NET MVC:
// Instead of using [AcceptVerbs(HttpVerbs.Get)] and [AcceptVerbs(HttpVerbs.Post)] attribute, we can also use HttpGet and HttpPost attributes.
// public class EmployeeController : Controller
// {
//     EmployeeDBContext dbContext = new EmployeeDBContext();
//     public ActionResult Index()
//     {
//         List<Employee> ListEmployees = dbContext.Employees.ToList();
//         return View(ListEmployees);
//     }

//     [HttpGet]
//     public ActionResult Edit(int id)
//     {
//         Employee employee = dbContext.Employees.Where(x => x.EmployeeId == id).FirstOrDefault();
//         return View(employee);
//     }

//     [HttpPost]
//     public ActionResult Edit(Employee employee)
//     {
//         if (ModelState.IsValid)
//         {
//             dbContext.Entry(employee).State = EntityState.Modified;
//             dbContext.SaveChanges();
//             return RedirectToAction("Index");
//         }
//         return View(employee);
//     }
// }