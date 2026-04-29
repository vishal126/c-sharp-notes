// Required Attribute in ASP.NET MVC:
// Our business requirement is that the First name and Last Name of an employee can’t be empty.

// The Required attribute makes the model property as required.
// [Required]
// public string FirstName
// {
//     get;
//     set;
// }
// [Required]
// public string LastName
// {
//     get;
//     set;
// }


// The Required attribute raises a validation error, if either the property value is null or empty.
// The Required attribute raises a validation error, if either the property value is null or empty.

// if you want to provide some user-defined error message when validation fails, then you can use the other overloaded version of the Required attribute which accepts ErrorMessage as an input parameter as shown below.
// [Required(ErrorMessage = "First Name is Required")]
// public string FirstName
// {
//     get;
//     set;
// }
// [Required(ErrorMessage = "Last Name is Required")]
// public string LastName
// {
//     get;
//     set;
// }



// StringLength Attribute in ASP.NET MVC
// our business requirement is that the employee’s LastName should not be greater than 30 characters that mean we need to set a maximum of 30 characters that can be entered for the employee the last name.
// We can achieve this very easily using the StringLength data annotation attribute in the ASP.NET MVC application.
// [Required(ErrorMessage = "Last Name is Required")]
// [StringLength(30)]
// public string LastName
// {
//     get;
//     set;
// }


// Note: We can apply multiple validation attributes on a single property.
// The MinimumLength is an optional named parameter that is used to specify the minimum length for a string. We can also specify the user-defined error message as shown below. Here, we specify the minimum length as 4 and the ErrorMessage as the Last name should be between 4 and 30 characters.

// [Required(ErrorMessage = "Last Name is Required")]
// [StringLength(30, MinimumLength = 4,
//                   ErrorMessage = "Last name should be between 4 and 30 characters")]
// public string LastName
// {
//     get;
//     set;
// }