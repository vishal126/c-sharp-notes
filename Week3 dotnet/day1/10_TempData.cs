// Why do we need TempData in the ASP.NET MVC Application?

// The limitation of both ViewData and ViewBag is they are limited to one HTTP request only.
// So, if redirection occurs then their values become null means they will lose the data they hold.
// we need to use tempData when we need to pass data from one controller to another controller


// What is TempData in ASP.NET MVC?
// The TempData in ASP.NET MVC Framework is one of the mechanisms to pass a small amount of temporary data from a controller action method to a view as well as from a controller action method to another action method either within the same controller or to a different controller.

// TempData value will become null once the subsequent request is completed by default. But if you want then you can also change this default behavior.

// If you have a look at the definition Controller class, then you will find the following signature of the TempData property.
// public TempDataDictionary TempData { get; set; }

// The return type of the TempData is TempDataDictionary.
// public class TempDataDictionary : IDictionary<string, object>;


// How to Pass and Retrieve data From TempData in ASP.NET MVC:
// The most important point that you need to remember is, as it stores the data in the form of an object so while retrieving the data from TempData type casting is required.

// Syntax to store data in TempData
// TempData["YourData"] = "SomeData";

// Syntax to retrieve data from TempData
// string strData = TempData["YourData"].ToString();


// Let us understand TempData in ASP.NET MVC with one example.
// Employee Controller
// namespace FirstMVCDemo.Controllers
// {
//     public class EmployeeController : Controller
//     {
//         public ActionResult Method1()
//         {
//             TempData["Name"] = "Pranaya";
//             TempData["Age"] = 30;
//             return View();
//         }

//         public ActionResult Method2()
//         {
//             string Name;
//             int Age;

//             if (TempData.ContainsKey("Name"))
//                 Name = TempData["Name"].ToString();

//             if (TempData.ContainsKey("Age"))
//                 Age = int.Parse(TempData["Age"].ToString());

//             // do something with user Name or Age here 
//             return View();
//         }

//         public ActionResult Method3()
//         {
//             string Name;
//             int Age;

//             if (TempData.ContainsKey("Name"))
//                 Name = TempData["Name"].ToString();

//             if (TempData.ContainsKey("Age"))
//                 Age = int.Parse(TempData["Age"].ToString());

//             // do something with userName or userAge here 
//             return View();
//         }
//     }
// }

// Let’s understand TempData
// 1st Request: http://localhost:xxxxx/Employee/Method1
// 2nd Request: http://localhost:xxxxx/Employee/Method2
// 3rd Request: http://localhost:xxxxx/Employee/Method3

// As you can see in the above example, we add Name and Age in TempData in the first request,
// and in the second subsequent request, we access the data from the TempData which we stored in the first request.
// However, we can’t get the same data in the third request because TempData will be cleared out after the second request.

// How to retain TempData values in the consecutive request?
// In order to retain the TempData value in the third consecutive request, we need to call TempData.Keep() method.

// namespace FirstMVCDemo.Controllers
// {
//     public class EmployeeController : Controller
//     {
//         public ActionResult Method1()
//         {
//             TempData["Name"] = "Pranaya";
//             TempData["Age"] = 30;
//             return View();
//         }

//         public ActionResult Method2()
//         {
//             string Name;
//             int Age;

//             if (TempData.ContainsKey("Name"))
//                 Name = TempData["Name"].ToString();

//             if (TempData.ContainsKey("Age"))
//                 Age = int.Parse(TempData["Age"].ToString());

//             TempData.Keep();

//             // do something with userName or userAge here 
//             return View();
//         }

//         public ActionResult Method3()
//         {
//             string Name;
//             int Age;

//             if (TempData.ContainsKey("Name"))
//                 Name = TempData["Name"].ToString();

//             if (TempData.ContainsKey("Age"))
//                 Age = int.Parse(TempData["Age"].ToString());

//             // do something with userName or userAge here 
//             return View();
//         }
//     }
// }

// There are two overloaded versions of the Keep Method. They are as follows:
// public void Keep(): It will mark all keys in the temp data dictionary for retention.
// public void Keep(string key): It will mark the specified key in the temp data dictionary for retention. Here, the key parameter is the key to retain in the dictionary