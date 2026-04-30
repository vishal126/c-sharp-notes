// ValidationMessage Attribute in ASP.NET MVC:
// The Html.ValidationMessage() is an extension method, that is a loosely typed method.
// It displays a validation message if an error exists for the specified field in the ModelStateDictionary object.

// The Validation Method Signature is given below:
// MvcHtmlString ValidateMessage(string modelName, string validationMessage, object htmlAttributes)

// Consider the following ValidationMessage example.
// @Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = “form-control” } })
// @Html.ValidationMessage(“FirstName”, “”, new { @class = “text-danger” })

// In the above example, the first parameter in the ValidationMessage method is a property name for which we want to show the error message e.g. Employee First Name. The second parameter is for the custom error messages and the third parameter is for html attributes like css, style, etc.

// The ValidationMessage() method will only display an error if you have configured the DataAnnotations attribute to the specified property in the model class.

// The above code will generate following html.
// <input    class="form-control text-box single-line" 
// data-val="true" 
// data-val-required="First Name is Required" 
// id="FirstName" 
// name="FirstName" 
// type="text" 
// value="">

// <span    class="field-validation-valid text-danger" 
// data-valmsg-for="FirstName" 
// data-valmsg-replace="true"></span>


// Now, when the user submits a form without entering a FirstName, then ASP.NET MVC uses a data- attribute of HTML5 for the validation and validation message will be injected, when the validation error occurs, as shown below.

// <span class=”text-danger field-validation-error”
// data-valmsg-for=”FirstName”
// data-valmsg-replace=”true”>
// <span for=”FirstName” generated=”true” class=””>First Name is Required</span>
// </span>



// ValidationMessageFor Attribute in ASP.NET MVC:
// The Html.ValidationMessageFor() is a strongly typed extension method. It displays a validation message if an error exists for the specified field in the ModelStateDictionary object.

// The validationMessageFor signature is given below.
// MvcHtmlString ValidateMessage(Expression<Func<dynamic, TProperty>> expression, string validationMessage, object htmlAttributes)

// Consider the following ValidationMessageFor() example.
// @Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = “form-control” } })
// @Html.ValidationMessageFor(model => model.FirstName, “”, new { @class = “text-danger” })

// The ValidationMessageFor() method will only display an error if you have configured the DataAnnotations attribute to the specifed property in the model class.


// The above code will generate following html.
// <input  class="form-control text-box single-line" 
// data-val="true" 
// data-val-required="First Name is Required" 
// id="FirstName" 
// name="FirstName" 
// type="text" 
// value="">

// <span   class="field-validation-valid text-danger" 
// data-valmsg-for="FirstName" 
// data-valmsg-replace="true"></span>

// Now, when the user submits the form without entering the FirstName then ASP.NET MVC uses the data- attribute of HTML5 for the validation and the validation message will be injected when validation error occurs, as shown below.
// <span class=”text-danger field-validation-error”
// data-valmsg-for=”FirstName”
// data-valmsg-replace=”true”>
// <span for=”FirstName” generated=”true” class=””>First Name is Required</span>
// </span>


// ValidationSummary Attribute in ASP.NET MVC Application:
// The ValidationSummary helper method generates an unordered list (ul element) of validation messages that are in the ModelStateDictionary object.
// The ValidationSummary can be used to display all the error messages for all the fields.
// It can also be used to display custom error messages. 


// Displaying all validation errors at one place using validation summary HTML helper
// To display all errors at one place, use ValidationSummary() HTML helper. 

// @Html.ValidationSummary(false, “Please fix the following errors and then submit the form”)


// Modern Core Way: <span asp-validation-for="FirstName" class="text-danger"></span>

// The Modern Core Translation:
// We use the asp-validation-summary tag helper instead of true/false booleans.

// Show All Errors: <div asp-validation-summary="All" class="text-danger"></div>

// Show Model Only: <div asp-validation-summary="ModelOnly" class="text-danger"></div> (This is the industry standard. You show field errors next to the text boxes, and major system errors at the top).