// DataType Attribute in ASP.NET MVC:
// DataType Attribute in ASP.NET MVC Framework enables us to provide the runtime information about the specific purpose of the properties.
// For example, a property of type string can have various scenarios as it might hold an Email address, URL, or password.
// There are various data types that include Currency, Date, Time, Password and MultilineText, etc.
// [DataType(DataType.PostalCode, ErrorMessage = "Please Enter a valid PIN/ZIP Code")]
// public string PostalCode
// {
//     get;
//     set;
// }

// [DataType(DataType.Url, ErrorMessage = "Please Enter a valid URL")]
// public string URL
// {
//     get;
//     set;
// }

// [DataType(DataType.Password)]
// public string Password
// {
//     get;
//     set;
// }
// [DataType(DataType.PhoneNumber, ErrorMessage = "Please Enter a valid Phone Number")]
// public string Mobile
// {
//     get;
//     set;
// }


// Password:
// When we set the DataType as a password, we will see the password field in a non-readable format.
// [DataType(DataType.Password)]
// [Required(ErrorMessage = "Password is Required")]
// public string Password
// {
//     get;
//     set;
// }
// [DataType(DataType.Password)]
// [Required(ErrorMessage = "Confirm Password is Required")]
// public string ConfirmPassword
// {
//     get;
//     set;
// }



// Compare Attribute in ASP.NET MVC Application:
// Compare Attribute in ASP.NET MVC Framework is used to compare 2 properties of a model that have the same value.
// Comparing email addresses and passwords is the common use case of Compare attribute.

// [DataType(DataType.Password)]
// [Required(ErrorMessage = "Password is Required")]
// public string Password
// {
//     get;
//     set;
// }
// [DataType(DataType.Password)]
// [Required(ErrorMessage = "Confirm Password is Required")]
// [Compare("Password", ErrorMessage = "Password and Confirm Password do not match"]
// public string ConfirmPassword
// {
//     get;
//     set;
// }