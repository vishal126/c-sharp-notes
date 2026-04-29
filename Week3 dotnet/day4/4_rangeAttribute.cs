// Range Attribute in ASP.NET MVC Application
// let’s validate the Age field, and enforce users to enter a value between 25 and 60.
// We can achieve this very easily by using the RangeAttribute in ASP.NET MVC Application.
// The Range attributes specify the minimum and maximum constraints for a numerical number.

// [Range(25, 60, ErrorMessage = "Age must be between 25 and 60")]
// public int Age
// {
//     get;
//     set;
// }


// Range Attribute with DateTime fields in ASP.NET MVC Application.
// [Range(typeof(DateTime), "01-01-1970", "01-01-2005",
//                     ErrorMessage = "Date of Birth Must be between 01-01-1970 and 01-01-2005")]
// [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
// public DateTime DateOfBirth
// {
//     get;
//     set;
// }


// MinLength and MaxLength Attribute in ASP.NET MVC Application
// These two attributes are used to specify the Minimum Length and Maximum Length of a property.
// [MinLength(5, ErrorMessage = "The Address must be at least 5 characters")]
// [MaxLength(25, ErrorMessage = "The Address cannot be more than 25 characters")]
// public string Address
// {
//     get;
//     set;
// }


// when the Range attribute is used with DateTime fields, the client-side validation does not work as expected
// Why does this happen?
// It happens because of Culture Settings. In the US, a date is MM/DD/YYYY. In the UK and India, it is DD/MM/YYYY.
// When ASP.NET sends the [Range] date rules to the browser, the JavaScript (jQuery Validator) gets confused by the local browser's date format and often throws a validation error even if the date is correct.

// The Modern Solution:
// Instead of fighting with the [Range] attribute for dates, most modern .NET developers build a Custom Validation Attribute specifically for dates (e.g., [DateOfBirthRange]) which we will look at next!