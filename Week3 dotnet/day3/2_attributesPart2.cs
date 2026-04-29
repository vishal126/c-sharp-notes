// UIHint
// HiddenInput
// ReadOnly


// UIHint Attribute in ASP.NET MVC Application:
// Models/ModifyEmployee.cs
// namespace AttributesInMVC.Models
// {
//     [MetadataType(typeof(EmployeeMetaData))]
//     public partial class Employee
//     {
//     }

//     public class EmployeeMetaData
//     {
//         [DataType(DataType.Url)]
//         public string PersonalWebSite { get; set; }
//     }
// }


// Modify the Details action method of EmployeeController as shown below
// namespace AttributesInMVC.Controllers
// {
//     public class EmployeeController : Controller
//     {
//         public ActionResult Details(int id)
//         {
//             EmployeeDBContext dbContext = new EmployeeDBContext();
//             Employee employee = dbContext.Employees.Single(x => x.Id == id);
//             return View(employee);
//         }
//     }
// }


// Modify the Details.cshtml view as shown below.
// @model AttributesInMVC.Models.Employee
// @{
//     ViewBag.Title = "Details";
// }
// @Html.DisplayForModel()

// At this point, build the application and navigate to http://localhost:61449/Employee/Details/1. When you click on the personal website link, the target page will open in the same window.



// How to open the page in a new window?
// Views/Shared/DisplayTemplates/Url.cshtml
// <a href=”@ViewData.Model” target=”_blank”>@ViewData.Model</a>

// The downside of this approach is that from now on all the links, will open in a new window.

// To overcome this, please follow the below steps.
// Rename Url.cshtml to OpenInNewWindow.cshtml
// Decorate the “PersonalWebSite” property in EmployeeMetaData class with UIHint attribute and specify the name of the template to use. In our case, the name of the template is “OpenInNewWindow” as shown below.

// namespace AttributesInMVC.Models
// {
//     [MetadataType(typeof(EmployeeMetaData))]
//     public partial class Employee
//     {
//     }

//     public class EmployeeMetaData
//     {
//         [DataType(DataType.Url)]
//         [UIHint("OpenInNewWindow")]
//         public string PersonalWebSite { get; set; }
//     }
// }


// So, the UIHint Attribute in ASP.NET MVC is used to specify the name of the template to use to display the data field on the model properties. 




// Hidden Input Attribute in ASP.NET MVC:
// The HiddenInput attribute in ASP.NET MVC is used to generate an HTML element with the input type=hidden.
// This attribute is extremely useful when you don’t want the user to see or edit the property, property, but you need to post the property value to the server when the form is submitted, so the correct record can be updated
// The Hidden Input attribute is present in the System.Web.Mvc namespace.



// Readonly Attribute in ASP.NET MVC:
// The ReadOnly attribute is present in System.ComponentModel namespace.
// attribute is used to make a property read-only.
// we will still be able to change the property value on the view, but once we post the form the model binder will respect the read-only attribute and will not move the value to the property.
// We can also, make the property of a class readonly simply, by removing the SET accessor

// Modifying the ModifyEmployee.cs file:  
// namespace AttributesInMVC.Models
// {
//     [MetadataType(typeof(EmployeeMetaData))]
//     public partial class Employee
//     {
//     }

//     public class EmployeeMetaData
//     {
//         // Id property is hidden and cannot be changed
//         [HiddenInput(DisplayValue = false)]
//         public int Id { get; set; }

//         // EmailAddress is read only
//         [ReadOnly(true)]
//         [DataType(DataType.EmailAddress)]
//         public string EmailAddress { get; set; }

//         [ScaffoldColumn(true)]
//         [DataType(DataType.Currency)]
//         public int? Salary { get; set; }

//         [DataType(DataType.Url)]
//         [UIHint("OpenInNewWindow")]
//         public string PersonalWebSite { get; set; }

//         [DisplayAttribute(Name = "Full Name")]
//         public string FullName { get; set; }

//         [DisplayFormat(DataFormatString = "{0:d}")]
//         public DateTime? HireDate { get; set; }

//         [DisplayFormat(NullDisplayText = "Gender not specified")]
//         public string Gender { get; set; }
//     }
// }


// Changes to EmployeeController.cs file
// using System.Web.Mvc;
// using AttributesInMVC.Models;
// using System.Data.Entity;

// namespace AttributesInMVC.Controllers
// {
//     public class EmployeeController : Controller
//     {
//         public ActionResult Details(int id)
//         {
//             EmployeeDBContext dbContext = new EmployeeDBContext();
//             Employee employee = dbContext.Employees.Single(x => x.Id == id);
//             return View(employee);
//         }

//         public ActionResult Edit(int id)
//         {
//             EmployeeDBContext dbContext = new EmployeeDBContext();
//             Employee employee = dbContext.Employees.Single(x => x.Id == id);

//             return View(employee);
//         }

//         [HttpPost]
//         public ActionResult Edit(Employee employee)
//         {
//             if (ModelState.IsValid)
//             {
//                 EmployeeDBContext dbContext = new EmployeeDBContext();
//                 Employee employeeFromDB = dbContext.Employees.Single(x => x.Id == employee.Id);

//                 // Populate all the properties except EmailAddrees
//                 employeeFromDB.FullName = employee.FullName;
//                 employeeFromDB.Gender = employee.Gender;
//                 employeeFromDB.Age = employee.Age;
//                 employeeFromDB.HireDate = employee.HireDate;
//                 employeeFromDB.Salary = employee.Salary;
//                 employeeFromDB.PersonalWebSite = employee.PersonalWebSite;

//                 dbContext.Entry(employeeFromDB).State = EntityState.Modified;
//                 dbContext.SaveChanges();
//                 return RedirectToAction("Details", new { id = employee.Id });
//             }
//             return View(employee);
//         }
//     }
// }


// Create Edit.cshtml view and copy and paste the following code
// @model AttributesInMVC.Models.Employee
// @{
//     ViewBag.Title = "Edit";
// }

// <div style="font-family:Arial">
//     @using (Html.BeginForm())
//     {
//         @Html.EditorForModel()
//         <br />
//         <br />
//         <input type="submit" value="Save" />
//     }
// </div>


