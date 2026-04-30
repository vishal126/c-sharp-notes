// JSON Result in ASP.NET MVC
// This action result returns the data in JSON Format i.e. in the form of key-value pairs.
// we need to call this method using Ajax from a view.

// eg
// Let’s modify the Home Controller
// public class HomeController : Controller
// {
//     [HttpGet]
//     public JsonResult Index()
//     {
//         return Json(new { Name = "John Smith", ID = 4, DateOfBirth = new DateTime(1999, 12, 31) });
//     }
// }


// Now, run the application and navigates to Home/Index in the URL and you will get the following error.
// This request has been blocked because sensitive information could be disclosed to third party websites when this is used in a GET request

// MVC is trying to protect you here; it doesn’t want you to share JSON information over a GET request because it could potentially contain sensitive information.
// This is attempting to protect you from an exploit known as JSON Hijacking.

// You can turn off this error by modifying the Index method as shown below.
// public class HomeController : Controller
// {
//     [HttpGet]
//     public JsonResult Index()
//     {
//         return Json(new { Name = "John Smith", ID = 4, DateOfBirth = new DateTime(1999, 12, 31) },
//             JsonRequestBehavior.AllowGet);
//     }
// }

// JsonRequestBehavior.AllowGet does exactly what it sounds like; it allows the browsers to access JSON information in a GET request. I would only recommend turning this on if you know what you are doing since it could potentially expose you to JSON Hijacking.

// There are six overloaded versions available for this JSON as shown in the below image.
// protected internal JsonResult Json(object data, string contentType);
// protected internal virtual JsonResult Json(object data, string contentType, Encoding contentEncoding);
// protected internal JsonResult Json(object data, JsonRequestBehavior behavior);
// protected internal JsonResult Json(object data, string contentType, JsonRequestBehavior behavior);
// protected internal virtual JsonResult Json(object data, string contentType, Encoding contentEncoding, JsonRequestBehavior behavior);
// protected internal JsonResult Json(object data);

// Parameters:
// data: The JavaScript object graph to serialize.
// contentType: The content type (MIME type).
// contentEncoding: The content-encoding.
// behavior: The JSON request behavior.


// JSON with Complex Type in ASP.NET MVC Application:
// First Create a Model in the Models folder with the name Person.cs and then copy and paste the following code into it.
// public class Person
// {
//     public int Id { get; set; }
//     public string FirstName { get; set; }
//     public string LastName { get; set; }
// }

// // Modify Home Controller
// public class HomeController : Controller
// {
//     [HttpGet]
//     public ActionResult Index()
//     {
//            var persons = new List<Person>  
//            {  
//                 new Person{Id=1, FirstName="Harry", LastName="Potter"},  
//                 new Person{Id=2, FirstName="James", LastName="Raj"}  
//            };
//            return Json(persons, "application/json", System.Text.Encoding.UTF8 ,JsonRequestBehavior.AllowGet);
//     }
// }


// While returning more data in JSON format, there is a need to mention the maximum length. Assign the maximum length of data Using “MaxJsonLength” property as shown in the below code.
// public class HomeController : Controller
// {
//     [HttpGet]
//     public ActionResult Index()
//     {
//             var persons = new List<Person>  
//             {  
//                 new Person{Id=1, FirstName="Harry", LastName="Potter"},  
//                 new Person{Id=2, FirstName="James", LastName="Raj"}  
//             };

//             var jsonResult = Json(persons, "application/json", System.Text.Encoding.UTF8 ,JsonRequestBehavior.AllowGet);
//             jsonResult.MaxJsonLength = int.MaxValue;
//             return jsonResult;
//     }
// }

// The Modern Way: ASP.NET Core
// Modern browsers fixed the JSON Hijacking vulnerability years ago. Because of this, Microsoft completely removed JsonRequestBehavior.AllowGet from ASP.NET Core.