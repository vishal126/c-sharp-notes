// Content Result in ASP.NET MVC:
// The Content Result in ASP.NET MVC returns different content formats to the view like HTML format, JavaScript format, or any other format.
// We need to use the ContentResult in the ASP.NET MVC Application when we want to allow the action to specify what should it returned. All we need to do is specify the content and MIME type.

// Example to Understand Content Result in MVC:
// HomeController
// public class HomeController : Controller
// {
//     public ContentResult Index()
//     {
//         return Content("<h3>Here's a custom content header</h3>", "text/html", System.Text.Encoding.UTF8);
//     }
// }

// There are three different overloaded versions
// protected internal ContentResult Content (string content);
// protected internal virtual ContentResult Content (string content, string contentType, Encoding contentEncoding);
// protected internal ContentResult Content (string content, string contentType);

// Parameters:
// content: The content to write to the response.
// contentType: The content type (MIME type).
// contentEncoding: The content-encoding.


// ContentResult vs String:
// public class HomeController : Controller
// {
//     public string Index()
//     {
//         return "<h3>Here's a custom content header</h3>";
//     }
// }

// ASP.NET MVC Framework actually creates a ContentResult and wraps it around the returned value and it doesn’t have to be a string. But if we return null, in that case, MVC returns an EmptyResult

// When we need to explicitly return ContentResult:
// It reinforces the fact that the method is an action, rather than a regular method, so devs are less likely to make mistakes like casually renaming it.
// If in the future you need to specify the content type you won’t need to change the method signature.
// It doesn’t hide the ToString() call. This doesn’t matter if you’re returning a string, but returning a complex type could have unexpected results.