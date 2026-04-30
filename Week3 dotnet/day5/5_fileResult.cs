// File Result in ASP.NET MVC:
// The FileResult actions are used to read and write files.
// FileResult is the parent of all file-related action results
// The File Result returns different types of file formats
// We implement the file download concept in ASP.NET MVC using file results

// public class HomeController : Controller
// {
//     public FileResult Index()
//     {
//         return File("Web.Config", "text");
//     }
// }


// There are six overloaded versions of the File methods
// protected internal FileContentResult File(byte[] fileContents, string contentType);
// protected internal virtual FileContentResult File(byte[] fileContents, string contentType, string fileDownloadName);
// protected internal FileStreamResult File(Stream fileStream, string contentType);
// protected internal virtual FileStreamResult File(Stream fileStream, string contentType, string fileDownloadName);
// protected internal FilePathResult File(string fileName, string contentType);
// protected internal virtual FilePathResult File(string fileName, string contentType, string fileDownloadName);


// Parameters:
// fileName: The path of the file to send to the response.
// contentType: The content type (MIME type).
// fileStream: The stream to send to the response.
// fileContents: The binary content to send to the response.
// fileDownloadName: The filename to use in the file-download dialog box that is displayed in the browser.


// Example to Understand File Result in ASP.NET MVC Application:
// if you just specify a URL and a MIME (Multipurpose Internet Mail Extensions) type, then the browser attempts to display the file specified (the supported browsers are Firefox, Chrome, and IE10).

// Let’s create a folder called “Files” and a text file to this folder with the name “SimpleText.txt”.
// Within the SimpleText.txt file write down the following
// This is a Text file

// Next, modify the Home Controller to use File Result as shown below
// public class HomeController : Controller
// {
//     public FileResult Index()
//     {
//         return File(Url.Content("~/Files/SimpleText.txt"), "text/plain");
//     }
// }

// We can also just return the byte array for the file content, which (in Chrome at least) will display the file in the browser:
// public class HomeController : Controller
// {
//     public FileResult Index()
//     {
//         byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath("~/Files/SimpleText.txt"));
//         return File(fileBytes, "text/plain");
//     }
// }


// Another overload will specify a download name, and using this overload causes the browser to download the file, rather than just display it:
// public class HomeController : Controller
// {
//     public FileResult Index()
//     {
//         return File(Url.Content("~/Files/SimpleText.txt"), "text/plain", "testFile.txt");
//     }
// }


// The Modern Update: Server.MapPath does not exist in modern ASP.NET Core!
// Modern applications are designed to run anywhere (Windows, Linux, Mac, or Docker containers), so the old way of mapping folder paths had to be rewritten. Furthermore, modern .NET Core requires all publicly accessible files to live inside the wwwroot folder.
// To get the path to a file today, you use Dependency Injection to ask the server for the current hosting environment (IWebHostEnvironment).

// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Hosting; // Required for IWebHostEnvironment
// using System.IO;

// public class HomeController : Controller
// {
//     private readonly IWebHostEnvironment _env;

//     // 1. Inject the environment into the Controller's constructor
//     public HomeController(IWebHostEnvironment env)
//     {
//         _env = env;
//     }

//     public IActionResult DownloadTextFile()
//     {
//         // 2. Combine the wwwroot path with your file name
//         string path = Path.Combine(_env.WebRootPath, "Files", "SimpleText.txt");

//         // 3. Read the bytes and return the file
//         byte[] fileBytes = System.IO.File.ReadAllBytes(path);
        
//         return File(fileBytes, "text/plain", "testFile.txt");
//     }
// }