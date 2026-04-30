// Remote validation in MVC when javascript is disabled:
// The Remote attribute only works when JavaScript is enabled.
// If the end-user disables JavaScript on his/her machine then the validation does not work.
// This is because RemoteAttribute requires JavaScript to make an asynchronous AJAX call to the server-side validation method.
// As a result, the user will be able to submit the form, bypassing the validation in place. This is why it is always important to have server-side validation.


// To make server-side validation work, when JavaScript is disabled, there are 2 ways
// Add model validation error dynamically in the controller action method
// Create a custom remote attribute and override IsValid() method



// Add model validation error dynamically in the controller action method
// Modify the Create action method that is decorated with the [HttpPost] attribute
// [HttpPost]
// [ValidateAntiForgeryToken]
// public ActionResult Create([Bind(Include = "UserID,FullName,UserName,Password")] User user)
// {
//     // Check if the UserName already exists, and if it does, add Model validation error
//     if (db.Users.Any(x => x.UserName == user.UserName))
//     {
//         ModelState.AddModelError("UserName", "UserName already in use");
//     }
//     if (ModelState.IsValid)
//     {
//         db.Users.Add(user);
//         db.SaveChanges();
//         return RedirectToAction("Index");
//     }
//     return View(user);
// }


// delegating the responsibility of performing validation, to a controller action method violates the separation of concerns within MVC.
// Ideally, all validation logic should be in the Model.


// Creating a Custom Remote Attribute
// Common/RemoteClientServer.cs
// namespace RemoteValidationInMVC.Common
// {
//     public class RemoteClientServerAttribute : RemoteAttribute
//     {
//         protected override ValidationResult IsValid(object value, ValidationContext validationContext)
//         {
//             // Get the controller using reflection
//             Type controller = Assembly.GetExecutingAssembly().GetTypes()
//                 .FirstOrDefault(type => type.Name.ToLower() == string.Format("{0}Controller",
//                     this.RouteData["controller"].ToString()).ToLower());
//             if (controller != null)
//             {
//                 // Get the action method that has validation logic
//                 MethodInfo action = controller.GetMethods()
//                     .FirstOrDefault(method => method.Name.ToLower() ==
//                         this.RouteData["action"].ToString().ToLower());
//                 if (action != null)
//                 {
//                     // Create an instance of the controller class
//                     object instance = Activator.CreateInstance(controller);
//                     // Invoke the action method that has validation logic
//                     object response = action.Invoke(instance, new object[] { value });
//                     if (response is JsonResult)
//                     {
//                         object jsonData = ((JsonResult)response).Data;
//                         if (jsonData is bool)
//                         {
//                             return (bool)jsonData ? ValidationResult.Success :
//                                 new ValidationResult(this.ErrorMessage);
//                         }
//                     }
//                 }
//             }

//             return ValidationResult.Success;
//             // If you want the validation to fail, create an instance of ValidationResult
//             // return new ValidationResult(base.ErrorMessageString);
//         }

//         public RemoteClientServerAttribute(string routeName)
//             : base(routeName)
//         {
//         }
//         public RemoteClientServerAttribute(string action, string controller)
//             : base(action, controller)
//         {
//         }
//         public RemoteClientServerAttribute(string action, string controller,
//             string areaName) : base(action, controller, areaName)
//         {
//         }
//     }
// }


// Step: Open “User.cs” file, that is present in “Models” folder. Decorate “UserName” property with RemoteClientServerAttribute.

// using System.ComponentModel.DataAnnotations;
// using RemoteValidationInMVC.Common;

// namespace RemoteValidationInMVC.Models
// {
//     [MetadataType(typeof(UserMetadata))]
//     public partial class User
//     {
//     }

//     public class UserMetadata
//     {
//         [RemoteClientServer("IsUserNameAvailable", "Home",
//             ErrorMessage = "UserName already in use")]
//         public string UserName { get; set; }
//     }
// }