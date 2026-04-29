// App_Data:
// The App_Data folder of an ASP.NET MVC application contains application-related data files like .mdf files, LocalDB, XML files, etc.
// The most important point that you need to remember is IIS is never going to serve files from this App_Data folder.

// App_Start:
// It contains configuration-related class files which are needed to be executed at the time of application starts.
// The classes like BundleConfig, FilterConfig, RouteConfig, IdentityConfig, etc are stored within this folder.

// Content:
// The Content Folder of an ASP.NET MVC application contains static files such as image files, CSS files, icons files, etc.

// Controllers:
// It contains all the controllers of our application.
// The Controllers are nothing but classes that are inherited from the base Controller class.
// It is this class that actually handles the user’s request i.e. the incoming HTTP Requests and returns a response.

// Fonts:
// The Fonts folder of an ASP.NET MVC application contains the custom font files that are required for the application.

// Models:
// It contains the class files which are used to store the domain data (you can also say business data) as well as business logic to manage the data.

// Scripts:
// It contains all the JavaScript files that are required for your application.

// Views:
// It contains all the “.cshtml” files of your application.
// In MVC, the .cshtml file is a file where we need to write the HTML code along with the C# code.
// The Views folder also includes separate folders for each and every controller for your application.

// Global.asax:
// The Global.asax file in an ASP.NET MVC application allows us to write the code that we want to run at the application level or you can say global level, such as Application_BeginRequest, Application_Error, Application_Start, Session_Start, Session_End, etc.

// Packages.config:
// The Packages.config file in an ASP.NET MVC application is managed by NuGet Package Manager which will keep track of what packages and versions have been installed in your application.

// Web.config:
// The Web.config file of an ASP.NET MVC application is one of the most useful and important files which contains the application-level configurations such as connection strings, global variables, etc.



// latest folder structure:
// Comparing the Folders: Old vs. New
// Feature	              Legacy MVC                	            Modern .NET Core        	Purpose
// Static Files       	  Scattered in Content, Scripts, fonts. 	wwwroot (Unified)	        Images, CSS, and JS. Only files in wwwroot are public to the internet.
// App Startup            Global.asax and App_Start.	            Program.cs	                This is the entry point where the "Waiter" (Server) starts.
// Configuration	      Web.config (XML).	                        appsettings.json	        Storing database strings and API keys in a readable format.
// Logic	              Controllers & Models.	                    Controllers & Models.	    These remain largely the same to preserve the MVC pattern.