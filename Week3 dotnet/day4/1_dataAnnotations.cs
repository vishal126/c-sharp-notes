// Why do we need Data Annotation Attributes in ASP.NET MVC?
// it’s a challenging job for a web developer to validate the user input for any Web application.
// we not only validate the business logic at the client-side that is in the browser, but also we need to validate the business logic running on the Server.
// That means as a developer we need to validate the business logic both at the client-side as well as server-side.

// The client-side validation of the business logic gives the users immediate feedback on the information they entered into a web page and which is an expected feature in today’s web applications. Along the same line, the server-side validation logic is in place because we never trust the information coming from the network. 


// What are the Validations?
// some rules set by the developer on the input fields of a web page so as to satisfy the business rules for that particular input field in order have to maintain the proper data in a system.

// There are two types of validations:
// Server-side Validations
// Client Side Validations


// When we talk about the validation in the ASP.NET MVC framework, we primarily focus on validating the model value


// In ASP.NET MVC web applications, we can do the following three types of validations:
// HTML validation / JavaScript validation (i.e. Client-Side Validation)
// ASP.NET MVC Model validation (i.e. Server-side Validation)
// Database validation (i.e. Server-side Validation)


// ASP.NET MVC Framework provides a concept called Data Annotation which is used for model validation. It’s inherited from System.ComponentModel.DataAnnotations assembly.


// The System.ComponentModel.DataAnnotations assembly has many built-in validation attributes, for example:
// Required
// Range
// RegularExpression,
// Compare
// StringLength
// Data type


// Along with the above build-in validation attributes, there are also many data types the user can select to validate the input. Using this data type attribute, the user can validate the exact data type as in the following:
// Credit Card number
// Currency
// Custom
// Date
// DateTime
// Duration
// Email Address
// HTML
// Image URL
// Multiline text
// Password
// Phone number
// Postal Code
// Upload



// Let’s create an empty ASP.NET MVC application with the name DataAnnotationInMVC.
// Models/Employee.cs
// namespace DataAnnotationInMVC.Models
// {
//     public class Employee
//     {
//         public Guid EmployeeId
//         {
//             get;
//             set;
//         }
//         public string FirstName
//         {
//             get;
//             set;
//         }
//         public string LastName
//         {
//             get;
//             set;
//         }
//         public int Age
//         {
//            get;
//            set;
//         }
//         public DateTime DateOfBirth
//         {
//             get;
//             set;
//         }
//         public string Address
//         {
//             get;
//             set;
//         }
//         public string Mobile
//         {
//             get;
//             set;
//         }
        
//         public string PostalCode
//         {
//             get;
//             set;
//         }

//         public string EmailId
//         {
//             get;
//             set;
//         }
        
//         public string UserName
//         {
//             get;
//             set;
//         }
//         public string Password
//         {
//             get;
//             set;
//         }
//         public string ConfirmPassword
//         {
//             get;
//             set;
//         }
//         public string URL
//         {
//             get;
//             set;
//         }
//     }
// }



// Adding EmployeeContoller
// using DataAnnotationInMVC.Models;
// namespace DataAnnotationInMVC.Controllers
// {
//     public class EmployeeController : Controller
//     { 
//         public ActionResult Index()
//         {
//             return View();
//         }
//         public ActionResult Create()
//         {
//             return View();
//         }
//         [HttpPost]
//         public ActionResult Create(Employee employee)
//         {
//             try
//             {
//                 if (ModelState.IsValid)
//                 {
//                     return RedirectToAction("Index");
//                 }
//                 return View();
//             }
//             catch
//             {
//                 return View();
//             }
//         }
//     }
// }


// Create the Create.cshtml view
// @model DataAnnotationInMVC.Models.Employee

// @{
//     ViewBag.Title = "Create Employee";
//     Layout = "~/Views/Shared/_Layout.cshtml";
// }

// <h2>Create Employee</h2>

// @using (Html.BeginForm()) 
// {
//     @Html.AntiForgeryToken()
    
//     <div class="form-horizontal">
//         <hr/>
//         @Html.ValidationSummary(true, "", new { @class = "text-danger" })
//         <div class="form-group">
//             @Html.LabelFor(model => model.FirstName, htmlAttributes: new { @class = "control-label col-md-2" })
//             <div class="col-md-10">
//                 @Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = "form-control" } })
//                 @Html.ValidationMessageFor(model => model.FirstName, "", new { @class = "text-danger" })
//             </div>
//         </div>

//         <div class="form-group">
//             @Html.LabelFor(model => model.LastName, htmlAttributes: new { @class = "control-label col-md-2" })
//             <div class="col-md-10">
//                 @Html.EditorFor(model => model.LastName, new { htmlAttributes = new { @class = "form-control" } })
//                 @Html.ValidationMessageFor(model => model.LastName, "", new { @class = "text-danger" })
//             </div>
//         </div>

//         <div class="form-group">
//             @Html.LabelFor(model => model.Age, htmlAttributes: new { @class = "control-label col-md-2" })
//             <div class="col-md-10">
//                 @Html.EditorFor(model => model.Age, new { htmlAttributes = new { @class = "form-control" } })
//                 @Html.ValidationMessageFor(model => model.Age, "", new { @class = "text-danger" })
//             </div>
//         </div>

//         <div class="form-group">
//             @Html.LabelFor(model => model.DateOfBirth, htmlAttributes: new { @class = "control-label col-md-2" })
//             <div class="col-md-10">
//                 @Html.EditorFor(model => model.DateOfBirth, new { htmlAttributes = new { @class = "form-control" } })
//                 @Html.ValidationMessageFor(model => model.DateOfBirth, "", new { @class = "text-danger" })
//             </div>
//         </div>

//         <div class="form-group">
//             @Html.LabelFor(model => model.Address, htmlAttributes: new { @class = "control-label col-md-2" })
//             <div class="col-md-10">
//                 @Html.EditorFor(model => model.Address, new { htmlAttributes = new { @class = "form-control" } })
//                 @Html.ValidationMessageFor(model => model.Address, "", new { @class = "text-danger" })
//             </div>
//         </div>

//         <div class="form-group">
//             @Html.LabelFor(model => model.Mobile, htmlAttributes: new { @class = "control-label col-md-2" })
//             <div class="col-md-10">
//                 @Html.EditorFor(model => model.Mobile, new { htmlAttributes = new { @class = "form-control" } })
//                 @Html.ValidationMessageFor(model => model.Mobile, "", new { @class = "text-danger" })
//             </div>
//         </div>

//         <div class="form-group">
//             @Html.LabelFor(model => model.PostalCode, htmlAttributes: new { @class = "control-label col-md-2" })
//             <div class="col-md-10">
//                 @Html.EditorFor(model => model.PostalCode, new { htmlAttributes = new { @class = "form-control" } })
//                 @Html.ValidationMessageFor(model => model.PostalCode, "", new { @class = "text-danger" })
//             </div>
//         </div>

//         <div class="form-group">
//             @Html.LabelFor(model => model.EmailId, htmlAttributes: new { @class = "control-label col-md-2" })
//             <div class="col-md-10">
//                 @Html.EditorFor(model => model.EmailId, new { htmlAttributes = new { @class = "form-control" } })
//                 @Html.ValidationMessageFor(model => model.EmailId, "", new { @class = "text-danger" })
//             </div>
//         </div>

//         <div class="form-group">
//             @Html.LabelFor(model => model.UserName, htmlAttributes: new { @class = "control-label col-md-2" })
//             <div class="col-md-10">
//                 @Html.EditorFor(model => model.UserName, new { htmlAttributes = new { @class = "form-control" } })
//                 @Html.ValidationMessageFor(model => model.UserName, "", new { @class = "text-danger" })
//             </div>
//         </div>

//         <div class="form-group">
//             @Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "control-label col-md-2" })
//             <div class="col-md-10">
//                 @Html.EditorFor(model => model.Password, new { htmlAttributes = new { @class = "form-control" } })
//                 @Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" })
//             </div>
//         </div>

//         <div class="form-group">
//             @Html.LabelFor(model => model.ConfirmPassword, htmlAttributes: new { @class = "control-label col-md-2" })
//             <div class="col-md-10">
//                 @Html.EditorFor(model => model.ConfirmPassword, new { htmlAttributes = new { @class = "form-control" } })
//                 @Html.ValidationMessageFor(model => model.ConfirmPassword, "", new { @class = "text-danger" })
//             </div>
//         </div>

//         <div class="form-group">
//             @Html.LabelFor(model => model.URL, htmlAttributes: new { @class = "control-label col-md-2" })
//             <div class="col-md-10">
//                 @Html.EditorFor(model => model.URL, new { htmlAttributes = new { @class = "form-control" } })
//                 @Html.ValidationMessageFor(model => model.URL, "", new { @class = "text-danger" })
//             </div>
//         </div>

//         <div class="form-group">
//             <div class="col-md-offsest-2 col-md-10">
//                 <input type="submit" value="Create" class="btn btn-danger" />
//             </div>
//         </div>
//     </div>
// }


// Enabling Client-Side Validation in ASP.NET MVC Application:
// The Validation attributes in ASP.NET MVC Framework provide both the client-side and server-side validation.
// There are 2 simple steps to enable the client-side validation in the ASP.NET MVC application.
// In the First step, we need to Enable ClientValidation and UnobtrusiveJavaScript in the web.config file
// Add the following two keys within the appSettings section of your web config file.

// <appSettings> 
//   <add key="ClientValidationEnabled" value="true" />
//   <add key="UnobtrusiveJavaScriptEnabled" value="true" />
// </appSettings>


// In the second step, we need to include the references to the following javascript files. Add the following javascript files in sequence in the _Layout.cshtml view which is inside the shared folder as our create.cshtml view uses _Layout.cshtml view
// <script src="~/Scripts/jquery-1.10.2.js"></script>
// <script src="~/Scripts/jquery.validate.js"></script>
// <script src="~/Scripts/jquery.validate.unobtrusive.js"></script>


// In real-time we need to include the references to the javascript files in the master page which avoids the need to reference them on each and every view where we need the validation.
// The order in which the script files are referenced is also important. jquery.validate is dependent on jquery and /jquery.validate.unobtrusive is dependent on jquery.validate, so they should be referenced in the above order.
// Otherwise, client-side validation will not work as expected.
// In short, JavaScript is parsed “top-down”, so all dependencies need to be referenced before the dependent reference.

// With the above 2 changes, validation should now happen on the client-side without a round trip to the server. If the client disables javascript in the browser, then client-side validation does not work, but the server-side validation will continue to work as expected. 


// Modern 
// 5. Enabling Client-Side Validation (Crucial Step)
// You don't need to touch the web.config file anymore. Instead, whenever you create a form view (like Create.cshtml), scroll to the very bottom and add this section:
// @section Scripts {
//     @{await Html.RenderPartialAsync("_ValidationScriptsPartial");}
// }


// UnobtrusiveJavaScriptEnabled
// What it is: A setting that tells ASP.NET how to write HTML for client-side validation. "Unobtrusive" means "not getting in the way" or "keeping things clean."

// The Old Way (Obtrusive):
// Years ago, if a text box was required, ASP.NET would write messy inline JavaScript right inside the HTML tag, like this:
// <input type="text" name="Age" onblur="checkRequired(); checkNumber();" />

// The Modern Way (Unobtrusive):
// When this is enabled (which it is by default), ASP.NET keeps the HTML clean. It relies entirely on HTML5 data- attributes.
// <input type="text" name="Age" data-val="true" data-val-required="Age is required" />

// How it works together:

// ASP.NET generates those clean data-val attributes based on your Data Annotations (like [Required]).

// A small JavaScript library called jquery.validate.unobtrusive.js quietly runs in the background.

// It scans the page for those data-val attributes and automatically wires up the red error messages without cluttering your HTML.


