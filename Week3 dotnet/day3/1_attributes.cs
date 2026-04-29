// Display      ---> to show header formatted (ie FullName - Full Name)
// DisplayName  -|
// DisplayFormat -> to get datePart of datetime data type [DisplayFormat(DataFormatString = "{0:d}")]
    //[DisplayFormatAttribute(DataFormatString="{0:d}")]
    //To get time in 24 hour notation
       //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyyHH:mm:ss}")]

    //To get time in 12 hour notation with AM PM
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyyhh:mm:sstt}")]
        // public DateTime? HireDate { get; set; }

    // Display only Time Part
        // [DataType(DataType.Time)]

    // If gender is NULL, "Gender not specified" text will be displayed.
        // [DisplayFormat(NullDisplayText = "Gender not specified")]
    
// ScaffoldColumn
    //If you don't want to display a column use ScaffoldColumn attribute.
        //This only works when you use @Html.DisplayForModel() helper
        //[ScaffoldColumn(false)]
        //public int? Salary { get; set; }

// DataTypeAttribute
    // Display currency symbol. For country specific currency, set culture using globalization element in 
    // web.config.  For Great Britain Pound symbol<globalization culture="en-gb"/>
        // [DataType(DataType.Currency)]
        // public int? Salary { get; set; }

    // Display mailto hyperlink
        // [DataType(DataType.EmailAddress)]
        // public string EmailAddress { get; set; }
        // // Generate a hyperlink
        // [DataType(DataType.Url)]
        // public string PersonalWebSite { get; set; }


// DisplayColumnAttribute 
// The DisplayColumn attribute is useful when a class has a property of the complex type, and we want to pick only one property of that complex object for display purposes.



// Creating the Database Table:
// We are going to use the following Employee table.
// id   FullName            Gender     Age   HireDate                   EmailAddress                    Salary          PersonalWebSite
// 1    Pranaya Rout        Male        29   2017-01-02 17:53:46.833    info@dotnettutorials.net        55000           http://dotnettutorials.net/
// 2    Anurag Mohanty      NULL        28   2015-05-02 19:43:25:967    info@dotnettutorials.net        45000           http://dotnettutorials.net/
// 2    Priyanka Dewangan   Female      27   2016-05-02 19:43:25:967    info@dotnettutorials.net        50000           http://dotnettutorials.net/


// Please use below SQL Script to create and populate the Employee table that we are going to use in this article.
// -- Create Employee Table
// Create table Employee
// (
//   Id int primary key identity,
//   FullName nvarchar(100),
//   Gender nvarchar(10),
//   Age int,
//   HireDate DateTime,
//   EmailAddress nvarchar(100),
//   Salary int,
//   PersonalWebSite nvarchar(100)
// ) 
// GO
  
// -- Insert some test data into Employee Table
// Insert into Employee values
// ('Pranaya Rout', 'Male', 29, '2017-01-02 17:53:46.833', 'info@dotnettutorials.net', 55000, 'https://dotnettutorials.net/')
// Insert into Employee values
// ('Anurag Mohanty', NULL, 28, '2015-05-02 19:43:25.965', 'info@dotnettutorials.net', 45000,'https://dotnettutorials.net/')
// Insert into Employee values
// ('Priyanka Dewangan', 'Female', 27, '2016-05-02 19:43:25.965', 'info@dotnettutorials.net', 50000,'https://dotnettutorials.net/')
// GO


// Create an empty ASP.NET MVC application:
// Create an empty ASP.NET MVC Project with the name AttributesInMVC.
// Generate the ADO.NET Entity Data model for table Employee using the database first approach.
// It will create the following Employee Model

// namespace AttributesInMVC.Models
// {
//     using System;
//     using System.Collections.Generic;
    
//     public partial class Employee
//     {
//         public int Id { get; set; }
//         public string FullName { get; set; }
//         public string Gender { get; set; }
//         public Nullable<int> Age { get; set; }
//         public Nullable<System.DateTime> HireDate { get; set; }
//         public string EmailAddress { get; set; }
//         public Nullable<int> Salary { get; set; }
//         public string PersonalWebSite { get; set; }
//     }
// }


// Creating Employee Controller:
// EmployeeController
// using AttributesInMVC.Models;
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


// Creating Details View:
// @model AttributesInMVC.Models.Employee
// @{
//     ViewBag.Title = "Details";
// }

// <div>
//     <h4>Employee Details</h4>
//     <dl class="dl-horizontal">
//         <dt>
//             @Html.DisplayNameFor(model => model.FullName)
//         </dt>

//         <dd>
//             @Html.DisplayFor(model => model.FullName)
//         </dd>

//         <dt>
//             @Html.DisplayNameFor(model => model.Gender)
//         </dt>

//         <dd>
//             @Html.DisplayFor(model => model.Gender)
//         </dd>

//         <dt>
//             @Html.DisplayNameFor(model => model.Age)
//         </dt>

//         <dd>
//             @Html.DisplayFor(model => model.Age)
//         </dd>

//         <dt>
//             @Html.DisplayNameFor(model => model.HireDate)
//         </dt>

//         <dd>
//             @Html.DisplayFor(model => model.HireDate)
//         </dd>

//         <dt>
//             @Html.DisplayNameFor(model => model.EmailAddress)
//         </dt>

//         <dd>
//             @Html.DisplayFor(model => model.EmailAddress)
//         </dd>

//         <dt>
//             @Html.DisplayNameFor(model => model.Salary)
//         </dt>

//         <dd>
//             @Html.DisplayFor(model => model.Salary)
//         </dd>

//         <dt>
//             @Html.DisplayNameFor(model => model.PersonalWebSite)
//         </dt>

//         <dd>
//             @Html.DisplayFor(model => model.PersonalWebSite)
//         </dd>
//     </dl>
// </div>


// Now, run the application and navigate to the URL http://localhost:61449/Employee/Details/1 and It will display the employee information as shown below.
// Employee Details
// FullName         Pranaya Rout
// Gender           Male
// Age              29
// Hiredate         02-01-2017 17:53:46
// Email            info@dotnet.net
// PersonalWebsite  https://dotnettutorials.net

// Notice that the output is not that pretty. We can control the display of data in a view using display attributes that are found in the System.ComponentModel.DataAnnotations namespace.


// Creating Employee Partial Class:
// We need to create a partial “Employee” class and we need to decorate that class with the display attributes.
// Models/ModifyEmployee.cs

// namespace AttributesInMVC.Models
// {
//     [MetadataType(typeof(EmployeeMetaData))]
//     public partial class Employee
//     {
//     }

//     public class EmployeeMetaData
//     {
//         //If you want "FullName" to be displayed as "Full Name", 
//         //use DisplayAttribute or DisplayName attribute.
//         //DisplayName attribute is in System.ComponentModel namespace.
//         //[DisplayAttribute(Name="Full Name")]
//         //[Display(Name = "Full Name")]
//         [DisplayName("Full Name")]
//         public string FullName { get; set; }

//         //To get only the date part in a datetime data type
//         //[DisplayFormat(DataFormatString = "{0:d}")]
//         //[DisplayFormatAttribute(DataFormatString="{0:d}")]

//         //To get time in 24 hour notation
//         //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyyHH:mm:ss}")]

//         //To get time in 12 hour notation with AM PM
//         //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyyhh:mm:sstt}")]
//         // public DateTime? HireDate { get; set; }

//         // Display only Time Part
//         // [DataType(DataType.Time)]
//         // Display only Date Part
//         [DataType(DataType.Date)]
//         public DateTime? HireDate { get; set; }

//         // If gender is NULL, "Gender not specified" text will be displayed.
//         [DisplayFormat(NullDisplayText = "Gender not specified")]
//         public string Gender { get; set; }

//         //If you don't want to display a column use ScaffoldColumn attribute.
//         //This only works when you use @Html.DisplayForModel() helper
//         //[ScaffoldColumn(false)]
//         //public int? Salary { get; set; }

//         // Display currency symbol. For country specific currency, set culture using globalization element in 
//         //web.config.  For Great Britain Pound symbol<globalization culture="en-gb"/>
//         [DataType(DataType.Currency)]
//         public int? Salary { get; set; }

//         // Display mailto hyperlink
//         [DataType(DataType.EmailAddress)]
//         public string EmailAddress { get; set; }

//         // Generate a hyperlink
//         [DataType(DataType.Url)]
//         public string PersonalWebSite { get; set; }
//     }
// }


// Make sure to include the following using statements:
// using System.ComponentModel.DataAnnotations;
// using System.ComponentModel;


// Now Run the application and see the output as shown below.
// Employee Details
// Full Name        Pranaya Rout
// Gender           Male
// Age              29
// HireDate         02-01-2017
// EmailAddress     info@dotnettutorials.net
// Salary           ₹ 55,000.00
// PersonalWebsite  https://dotnettutorials.net

// The DisplayColumn attribute is useful when a class has a property of the complex type, and we want to pick only one property of that complex object for display purposes.


// Let’s understand this with an example.
// Models/Company.cs
// namespace AttributesInMVC.Models
// {
//     public class Company
//     {
//         public Employee CompanyDirector
//         {
//             get
//             {
//                 EmployeeDBContext dbContext = new EmployeeDBContext();
//                 return dbContext.Employees.Single(x => x.Id == 1);
//             }
//         }
//     }
// }


// Notice that, this class has CompanyDirector property which returns an Employee object. The employee is a complex type so; Employee object has got several properties. If we want FullName to be used for display purposes, then make the following changes.
// Modifying the ModifyEmployee.cs

// namespace AttributesInMVC.Models
// {
//     [MetadataType(typeof(EmployeeMetaData))]
//     [DisplayColumn("FullName")]
//     public partial class Employee
//     {
//     }

//     public class EmployeeMetaData
//     {
//         [DisplayName("Full Name")]
//         public string FullName { get; set; }

//         [DataType(DataType.Date)]
//         public DateTime? HireDate { get; set; }
        
//         [DisplayFormat(NullDisplayText = "Gender not specified")]
//         public string Gender { get; set; }
        
//         [DataType(DataType.Currency)]
//         public int? Salary { get; set; }
        
//         [DataType(DataType.EmailAddress)]
//         public string EmailAddress { get; set; }
        
//         [DataType(DataType.Url)]
//         public string PersonalWebSite { get; set; }
//     }
// }




// Modern .net core
// Data Annotations: These are built-in attributes that allow you to control how your data looks and behaves in the UI without changing your logic.

// Why use Metadata Classes?
// we use tools like Entity Framework that auto-generate your model classes. If you add attributes directly to those generated files, your code will be overwritten the next time the database updates.

// The solution is to use a Partial Class combined with a Metadata Class.

// Key Built-in Attributes Explained
// Attribute        Purpose                                                 Real-World Example
// [DisplayName]    Changes the label text in the UI.                       "Changes FullName to ""Full Name""."
// [DataType]       "Specifies the type of data (Date, Currency, Email)."   Automatically adds a $ or € to a salary.
// [DisplayFormat]  Handles formatting and null values.                     "If gender is null, shows ""Gender not specified""."
// [ScaffoldColumn] Hides a column from automatic UI generation.            Set to false to hide sensitive data like Salary.
// [DisplayColumn]  Pick one property to represent a whole object.          Shows only the Name when a Company object is displayed.


// 1. What is Entity Framework? 
// EF is an Object-Relational Mapper (ORM). It maps your database tables to C# classes (Objects).
// Database Table (e.g., Employees) becomes a C# Class (Employee).
// Table Rows become C# Objects (instances of that class).
// Table Columns become C# Properties (Id, Name, etc.).

// Instead of writing SELECT * FROM Employees WHERE Id = 1, you simply write: db.Employees.Single(x => x.Id == 1);

// 2. How is it "Autogenerated"?
// In the Database-First Approach (which your tutorial uses), you point Visual Studio at an existing SQL database. The "ADO.NET Entity Data Model" wizard then performs these steps:
// Reads the Schema: It looks at your SQL tables, relationships (Foreign Keys), and data types.
// Generates Code: It creates a file (usually ending in .Context.cs and .Designer.cs).
// The Result: It writes the C# classes for you. If you have 50 tables, it writes 50 classes in seconds.

// The Danger: Because this code is written by a machine, you should never edit those files. If you change the database and click "Update Model," EF will delete the old files and recreate them—wiping out any code or attributes you manually added.


// 3. What does the partial class do here?
// The partial keyword is the "Secret Weapon" that allows you to customize autogenerated code without losing your changes.
// In C#, a partial class allows you to split one single class definition across two different physical files. When the project compiles, the computer merges them into one.

// How it works in your project:
// File 1 (Autogenerated): Contains the properties like Id, Name, Salary. (Generated by EF).
// File 2 (Your File): You create this file manually. You also name it public partial class Employee.

// The Magic: Because they are both partial, you can add Attributes (like [DisplayName] or [DataType]) in your file. When you refresh the database model, EF only overwrites File 1. Your File 2 remains untouched.


// 4. Why the "Metadata" Class?
// This is because C# doesn't allow you to "re-declare" a property in a partial class just to add an attribute to it.

// Partial Class: Acts as the "Hook" to the autogenerated class.
// MetadataType Attribute: Tells .NET, "Hey, for the rules/formatting of this class, go look at this other class over here (the Metadata class)."
// Metadata Class: A simple class where you list the properties you want to format.


// 1. The [DataType] Enumeration
// Attribute,HTML Result,Usage
// [DataType(DataType.Password)],"<input type=""password"">",Masks the characters with dots.
// [DataType(DataType.MultilineText)],<textarea>,Creates a multi-line box instead of a single line.
// [DataType(DataType.PhoneNumber)],"<input type=""tel"">",Triggers the numeric keypad on mobile devices.
// [DataType(DataType.Upload)],"<input type=""file"">",Allows the user to select a file for upload.
// [DataType(DataType.ImageUrl)],<img> tag support,Tells the UI that this string is a path to an image.


// 2. Deep Dive into [DisplayFormat]
// This is one of the most powerful attributes because it controls the "rendering" of a value.
// ApplyFormatInEditMode: By default, formatting only happens in "Read-Only" mode. If you want the currency symbol or date format to stay visible while the user is typing in a textbox, set this to true.
// Example: [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]

// ConvertEmptyStringToNull: If a user leaves a textbox empty, this decides if the C# property becomes an empty string "" or null.
// HtmlEncode: Set to false if the string contains HTML tags that you actually want the browser to render (like <b>Text</b>) instead of showing the raw tags.

// 3. Validation Attributes (Crucial for EF)
// When you move to Entity Framework, these attributes automatically generate the validation logic for your database and your forms.
// [Required]: Ensures the field cannot be empty. It generates a NOT NULL constraint in the database.
// [StringLength(100, MinimumLength = 5)]: Sets both the maximum and minimum characters allowed.
// [Range(18, 60)]: Used for numbers (like Age) to ensure the value falls within a specific window.
// [RegularExpression(@"...")]: Used for complex patterns like Zip Codes or specific ID formats.
// [Compare("Password")]: Often used for a "Confirm Password" field to ensure it matches the original password field.

// 4. Database-Specific Attributes
// These help Entity Framework understand how to build your SQL tables.
// [Key]: Explicitly tells EF that this property is the Primary Key (useful if your column isn't named "Id").
// [NotMapped]: Tells EF: "Keep this property in my C# class, but do not create a column for it in the SQL database." (Great for calculated properties like FullName which just combines FirstName + LastName).
// [ForeignKey("DepartmentId")]: Links a property to another table.

// we use ModelMetadataType(typeof(EmployeeMetaData)) instead of metadataType[]


// Modern way is to create a viewModel  
// public class EmployeeDetailsViewModel
// {
//     [DisplayName("Full Name")]
//     public string FullName { get; set; }

//     [DataType(DataType.Currency)]
//     public int? Salary { get; set; }
    
//     [DataType(DataType.Date)]
//     public DateTime? HireDate { get; set; }
    
//     // Only include properties the View actually needs
// }

// Map the data in the Controller
// public ActionResult Details()
// {
//     // 1. Get the data from the source
//     var employee = new Employee { FullName = "Vishal", Salary = 15000 };

//     // 2. Map it to the ViewModel
//     var viewModel = new EmployeeDetailsViewModel
//     {
//         FullName = employee.FullName,
//         Salary = employee.Salary
//     };

//     // 3. Pass the ViewModel to the view
//     return View(viewModel);
// }

// Update the View
// @model attributes.Models.EmployeeDetailsViewModel