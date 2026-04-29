// What is Regular Expression Attribute in ASP.NET MVC?
// The Regular Expression Attribute is generally used for pattern matching validations in ASP.NET MVC applications.

// Let’s understand the Regular expression attribute with an example.
// we need to validate the Email ID of an employee.

// [Required(ErrorMessage = "Email id is required")]
// [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
//                             ErrorMessage = "Please enter a valid email address")]
// public string EmailId
// {
//     get;
//     set;
// }


// Here is the requirement for validating Name property
// [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]
// public string UserName
// {
//     get;
//     set;
// }


// The Old Regex Way:
// [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_{|}~-]+(?:.[a-z0-9!#$%&'*+/=?^_{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Invalid Email")]

// The Modern .NET Way:
// [EmailAddress(ErrorMessage = "Please enter a valid email address")]


// Always use [EmailAddress], [Phone], or [Url] if they fit your needs before trying to write a custom Regular Expression!