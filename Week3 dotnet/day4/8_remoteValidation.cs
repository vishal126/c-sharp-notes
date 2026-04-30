// What is Remote Validation in ASP.NET MVC Application?
// Sometimes, to check if a field value is valid or not, we may need to make a database call.
// eg. To register a user, we need a unique username. So, to check, if the username is not taken already, we have to make a call to the server and check the database table.
// RemoteAttribute is useful in situations like above.

//  Step 1: Create Users table
// Create table Users
// (
//   [UserID] int primary key identity,
//   [FullName] nvarchar(50),
//   [UserName] nvarchar(50),
//   [Password] nvarchar(50) 
// )


// Step2: Create one ASP.NET MVC application with the name “RemoteValidationInMVC"

// Step3:Create an ado.net entity data model using table Users. Save and build the solution.

// It will create the following model
// namespace RemoteValidationInMVC.Models
// {
//     public partial class User
//     {
//         public int UserID { get; set; }
//         public string FullName { get; set; }
//         public string UserName { get; set; }
//         public string Password { get; set; }
//     }
// }

// Step4: Add HomeController with the following settings
// Template = MVC5 controller with views, using Entity Framework
// Model Class = User (RemoteValidationInMVC.Models)
// Data context class = UserDBContext (RemoteValidationInMVC.Models)
// Controller Name = HomeController

// Step5:
// Copy and paste the following function in HomeController.
// This is the method that gets called to perform the remote validation.
// An AJAX request is issued to this method. If this method returns true, validation succeeds, else validation fails and the form is prevented from being submitted.
// The parameter name (UserName) must match the field name on the view.
// If they don’t match, the model binder will not be able to bind the value with the parameter, and validation may not work as expected.

// [HttpPost]
// public JsonResult IsUserNameAvailable(string UserName)
// {
//     return Json(!db.Users.Any(x => x.UserName == UserName),
//                                          JsonRequestBehavior.AllowGet);
// }

// Step6:
// Right-click on the Models folder and a class file with the name PUser.cs
// Copy and paste the following code
// Notice that the name of the method (IsUserNameAvailable) and the controller name (Home) and the error message are passed as arguments to Remote Attribute
// Remote is the attribute for validation in Data Annotation, which is used in model class to validate records instantly.

// using System.Web.Mvc;
// using System.ComponentModel.DataAnnotations;
// namespace RemoteValidationInMVC.Models
// {
//     [MetadataType(typeof(UserMetaData))]
//     public partial class User
//     {
//     }

//     public class UserMetaData
//     {
//         [Remote("IsUserNameAvailable", "Home",HttpMethod ="POST", ErrorMessage = "UserName already in use.")]
//         public string UserName { get; set; }
//     }
// }


// In the above example, we have defined a few properties of the Remote attribute to work on remote validation properly, let’s know them in brief.
// IsUserNameAvailable: This is the JsonResult method which checks the details from the database and returns true or false.
// Home: This is the MVC Controller name and inside that, the IsUserNameAvailable JsonResult method is defined to check the details from the database.
// HttpMethod: This is the HttpMethod type which is called on Remote attribute e.g. Get, Put, Post. This is optional to define.
// ErrorMessage: This is used to show the message on the client-side. 

// There are many optional properties of the Remote attribute which are used as per the validation requirements.

// Step7:
// Include references to the following CSS and script files in Create.cshtml view.
// jquery.validate and jquery.validate.unobtrusive script files are required for remote validation to work.

// <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />
// <script src="~/Scripts/jquery-1.7.1.min.js" type="text/javascript"></script> 
// <script src="~/Scripts/jquery.validate.min.js" type="text/javascript"></script> 
// <script src="~/Scripts/jquery.validate.unobtrusive.js" type="text/javascript"></script>


// Step8:
// Make sure ClientValidation and UnobtrusiveJavaScript are enabled in web.config

// <add key=”ClientValidationEnabled” value=”true” />
// <add key=”UnobtrusiveJavaScriptEnabled” value=”true” />