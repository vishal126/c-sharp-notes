// Custom Validation Attribute in MVC
// At the moment, any value outside the range of “01/01/1970” and “01/01/2005” for DateOfBirth filed will raise a validation error. 
// [Range(typeof(DateTime), "01-01-1970", "01-01-2005",
//                     ErrorMessage = "Date of Birth Must be between 01-01-1970 and 01-01-2005")]
// [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
// public DateTime DateOfBirth
// {
//     get;
//     set;
// }


// But, let’s say, we want the end date to be today’s date instead of the hardcode “01/01/2005” value. To achieve this we would be tempted to use DateTime.Now.ToShortDateString() as shown below.
// [Range(typeof(DateTime), "01-01-1970", DateTime.Now.ToShortDateString(),
//                     ErrorMessage = "Date of Birth Must be between 01-01-1970 and Current Date")]
// [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
// public DateTime DateOfBirth
// {
//     get;
//     set;
// }


// At this point, if you compile your application, you will get the error saying – An attribute argument must be a constant expression, typeof expression or array creation expression of an attribute parameter type.
// Why does this happen?
// In C#, Attributes (like [Range]) are considered metadata. They are baked into your application's code exactly at the moment you compile (build) the project.

// Because DateTime.Now is constantly changing every single second (Run-time), the compiler cannot bake it into the code. It demands a hardcoded, unchanging value (Compile-time) like "01/01/2000".



// To fix this error, we can create a custom DateRangeAttribute. Here are the steps
// Right-click on the project name in solution explorer, and add “Common” folder.
// Then Right-click on the “Common” folder and add a class file with the name DateRangeAttribute.cs
// Copy and paste the following code in DateRangeAttribute.cs class file. 

// using System.ComponentModel.DataAnnotations;

// namespace DataAnnotationInMVC.Common
// {
//     public class DateRangeAttribute : RangeAttribute
//     {
//         public DateRangeAttribute(string minimumValue)
//             : base(typeof(DateTime), minimumValue, DateTime.Now.ToShortDateString())
//         {

//         }
//     }
// }

// Finally, decorate the “DateOfBirth” property with our custom DateRangeAttribute.

// [DateRange("01/01/2000", ErrorMessage = "Date of Birth Must be between 01-01-1970 and Current Date")]
// [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
// public DateTime DateOfBirth
// {
//     get;
//     set;
// }



// Another example of creating a custom validation attribute in ASP.NET MVC. 
// our business rules have changed, and the DateOfBirth property should allow any valid date that is <= Today’s Date
// there is no minimum value restriction and the maximum value should be less than or equal to Today’s date.
// To achieve this, let’s add another custom validation attribute. Here are the steps

// Right-click on the “Common” folder and add a class file with the name CurrentDateAttribute.cs
// Copy and paste the following code in CurrentDateAttribute.cs class file. 

// using System.ComponentModel.DataAnnotations;
// namespace DataAnnotationInMVC.Common
// {
//     public class CurrentDateAttribute : ValidationAttribute
//     {
//         public override bool IsValid(object value)
//         {
//             DateTime dateTime = Convert.ToDateTime(value);
//             return dateTime <= DateTime.Now;
//         }
//     }
// }


// Decorate the “DateOfBirth“ property with our custom CurrentDateAttribute as shown below.
// [CurrentDate]
// [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
// public DateTime DateOfBirth
// {
//     get;
//     set;
// }


// Please note that the validation error message can be customized using the named parameter “ErrorMessage” as shown below.
// [CurrentDate(ErrorMessage = "Hire Date must be less than or equal to Today's Date")]
// [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
// public DateTime DateOfBirth
// {
//     get;
//     set;
// }