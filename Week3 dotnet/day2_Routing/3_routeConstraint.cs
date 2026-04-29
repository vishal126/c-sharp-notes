// What are Route Constraints in ASP.NET MVC Application?
// They allow us to apply a regular expression to a URL segment to restrict whether the route will match the request.
// or
// the Route constraint is a way to put some validation around the defined route.

// eg
// namespace FirstMVCDemo
// {
//     public class RouteConfig
//     {
//         public static void RegisterRoutes(RouteCollection routes)
//         {
//             routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
//             routes.MapRoute(
//                 name: "Default", //Route Name
//                 url: "{controller}/{action}/{id}", //Route Pattern
//                 defaults: new
//                 {
//                     controller = "Home", //Controller Name
//                     action = "Index", //Action method Name
//                     id = UrlParameter.Optional //Defaut value for above defined parameter
//                 }
//             );
//         }
//     }
// }

// Now you want to restrict the incoming request URL with numeric id only.


// Restrict to numeric Id only
// There is another overloaded version of the MapRoute extension method which takes constraints as a parameter.
// Using this parameter we can set a regular expression that will validate the incoming URL route parameters.

// In the below code, you can observe, we have passed constraints :new { id = @”\d+” } as the fourth parameter to the MapRoute extension method, and this regular expression will restrict the id parameter to be numeric only,

// namespace FirstMVCDemo
// {
//     public class RouteConfig
//     {
//         public static void RegisterRoutes(RouteCollection routes)
//         {
//             routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
//             routes.MapRoute(
//                 name: "Default", //Route Name
//                 url: "{controller}/{action}/{id}", //Route Pattern
//                 defaults: new
//                 {
//                     controller = "Home", //Controller Name
//                     action = "Index", //Action method Name
//                     id = UrlParameter.Optional //Defaut value for above defined parameter
//                 },
//                 constraints :new { id = @"\d+" } //Restriction for id
//             );
//         }
//     }
// }

// So now if you give a non-numeric value for the id parameter then that request will be handled by another route or if there are no matching routes then the “The resource could not be found” error will be thrown.



// Creating Route Constraint for Restricting Controller and Actions
// Suppose you want to restrict the user for those URLs that have controller name with H prefix and action name should be only Details or About.



// What is the difference between Routing and URL Rewriting?
// URL rewriting is focused on mapping one URL (new URL) to another URL (old URL) while routing is focused on mapping a URL to a resource i.e. controller action method.
// URL rewriting rewrites your old URL to a new one while routing never rewrites your old URL to a new one but it maps to the original route.



// modern .net core
// 1. Restricting by Data Type (The Numeric ID)
// Since you're using .NET Core, you don't need to write the messy regex for simple things. You can use Inline Constraints directly in the pattern string:
// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller}/{action}/{id:int?}"); // Notice :int here

// 2. Restricting to Specific Values
// Sometimes you want a route to only work for specific pages.
// Regex Example: action = "^Details$|^About$"
// This means: "Match ONLY if the action is exactly 'Details' OR exactly 'About'."

// pattern: "Transaction/{action:regex(^(Credit|Debit)$)}/{id}"


// 3. Routing vs. URL Rewriting
// Feature	                    URL Rewriting (Old)	                            Routing (New)
// Concept              Changing a URL on the fly (Alias).                      Mapping a URL to a Code Handler.
// Visibility       The browser might see a different URL than the server.      The URL stays the same; the server just knows who handles it.
// Focus                    Physical files (.aspx, .php).                       Action Methods inside Controllers.
// SEO                      Used to hide ugly parameters.                       Naturally creates clean, readable URLs.