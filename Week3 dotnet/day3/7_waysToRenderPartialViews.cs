// Different Ways to Render Partial Views in ASP.NET MVC Application
// Html.RenderPartial
// Html.Partial
// Html.RenderAction
// Html.Action
// jQuery Load function


// Rendering Partial Views using Html.RenderPartial Helper Method in ASP.NET MVC Application
// 4 overloaded versions available
// public static void RenderPartial(this HtmlHelper htmlHelper, string partialViewName);
// public static void RenderPartial(this HtmlHelper htmlHelper, string partialViewName, ViewDataDictionary viewData);
// public static void RenderPartial(this HtmlHelper htmlHelper, string partialViewName, object model);
// public static void RenderPartial(this HtmlHelper htmlHelper, string partialViewName, object model, ViewDataDictionary viewData);


// Parameters:
// htmlHelper: The HTML helper instance that this method extends
// partialViewName: The name of the partial view.
// viewData: The view data for the partial view.
// model: The model for the partial view.


// How to use the RenderPartial Helper Method to Call Partial Views in MVC
// Modify the Index action method of the Product Controller to call Partial view using Html.RenderPartial() method
// @model IEnumerable<PartialViewInMVC.Models.Product>

// @{
//     ViewBag.Title = "Index";
// }

// @{Html.RenderPartial("ProductDetails", Model);}


// It works when you have the partial view located in the Shared folder. If your partial view is located in a different folder, then you will have to mention the full path of view as shown below.
// @{Html.RenderPartial(“~/Views/Home/ProductDetails.cshtml”, Model);}



// Points to Remember while working with Html.RenderPartial:
// RenderPartial() is a void method that writes the output to the response stream.  The “void” method in C# needs a”;” and hence must be enclosed by { }.
// This method result will be directly written to the HTTP response stream. That means this method generates the response as part of the same HTTP response of the main view. It uses the same TextWriter object used by the current web page.
// This method returns void.
// Simple to use and no need to create any action.
// This method is faster as its result is directly written to the response stream, making it fast.
// If you have a model associated with the View and the model required for the partial view is part of ViewModel, then the RenderPartial method is ideal to use.


// Html.Partial Helper Method in ASP.NET MVC Application
// 4 overloaded versions
// public static MvcHtmlString Partial(this HtmlHelper htmlHelper, string partialViewName);
// public static MvcHtmlString Partial(this HtmlHelper htmlHelper, string partialViewName, ViewDataDictionary viewData);
// public static MvcHtmlString Partial(this HtmlHelper htmlHelper, string partialViewName, object model);
// public static MvcHtmlString Partial(this HtmlHelper htmlHelper, string partialViewName, object model, ViewDataDictionary viewData);

// Parameters:
// htmlHelper: The HTML helper instance that this method extends
// partialViewName: The name of the partial view to render
// viewData: The view data dictionary for the partial view.
// model: The model for the partial view.

// Returns: The partial view that is rendered as an HTML-encoded string.



// How to use the Partial Helper method to call Partial Views in MVC?
// @model IEnumerable<PartialViewInMVC.Models.Product>
// @{
//     ViewBag.Title = "Index";
// }
// @Html.Partial("ProductDetails", Model)


// If your partial view is located in a different folder, then you will have to mention the full path of the view
// @Html.Partial(“~/Views/Shared/ProductDetails.cshtml”, Model)



// Points to Remember while working with Html.Partial in MVC:
// The Partial() Helper method in MVC is a method that returns a MvcHtmlString. In Razor, You can call a property or a method that returns such a string with just a @ prefix to distinguish it from plain HTML.
// Renders the partial view as an HTML-encoded string.
// This method result can be stored in a variable since it returns a string type value.
// Simple to use and no need to create any action.
// Like the RenderPartial method, the Partial method is also useful when displaying data in the partial view is already in the corresponding view model.




// Html.RenderAction in ASP.NET MVC Application
// For rendering Partial view using Html.RenderAction help method, we required the Controller Action method, which returns PartialViewResult.
// Add the following GetProducts method in the Product Controller class.

// public PartialViewResult GetProducts()
// {
//             List<Product> products = new List<Product>()
//             {
//                 new Product { ProductID =1, Name ="Product 1", Category = "Category 1", Description ="Description 1", Price = 10m},
//                 new Product { ProductID =2, Name ="Product 2", Category = "Category 1", Description ="Description 2", Price = 20m},
//                 new Product { ProductID =3, Name ="Product 3", Category = "Category 1", Description ="Description 3", Price = 30m},
//                 new Product { ProductID =4, Name ="Product 4", Category = "Category 2", Description ="Description 4", Price = 40m},
//                 new Product { ProductID =5, Name ="Product 5", Category = "Category 2", Description ="Description 5", Price = 50m},
//                 new Product { ProductID =6, Name ="Product 6", Category = "Category 2", Description ="Description 6", Price = 50m}
//             };
//             return PartialView("ProductDetails", products);
// }


// RenderAction Helper Method in ASP.NET MVC
// 6 overloaded versions

// public static void RenderAction(this HtmlHelper htmlHelper, string actionName);
// public static void RenderAction(this HtmlHelper htmlHelper, string actionName, object route Values);
// public static void RenderAction(this HtmlHelper htmlHelper, string actionName, Route ValueDictionary routeValues);
// public static void RenderAction(this HtmlHelper htmlHelper, string actionName, string controllerName);
// public static void RenderAction(this HtmlHelper htmlHelper, string actionName, string controllerName, object route Values);
// public static void RenderAction(this HtmlHelper htmlHelper, string actionName, string controllerName, RouteValueDictionary route Values);


// Parameters:
// htmlHelper: The HTML helper instance that this method extends.
// actionName: The name of the child action method to invoke.
// controllerName: The name of the controller that contains the action method.
// object routeValues: An object that contains the parameters for a route. You can use routeValues to provide the parameters that are bound to the action method parameters. The routeValues parameter is merged with the original route values and overrides them.
// RouteValueDictionary routeValues: A dictionary that contains the parameters for a route. You can use routeValues to provide the parameters that are bound to the action method parameters. The routeValues parameter is merged with the original route values and overrides them.


// How to use the RenderAction Helper method to call Partial Views in MVC?
// @{
    // ViewBag.Title = "Index";
// }

// @{Html.RenderAction("GetProducts", "Product");}



// Points to Remember while working with Html.RenderAction in MVC:
// This method result will be directly written to the HTTP response stream of the parent web page like Html.RenderPartial. That means it uses the same TextWriter object as used in the current webpage/template.
// We need to create a child action for rendering the partial view for this method.
// The RenderAction method is useful when the displaying data in the partial view is independent of the corresponding view model.
// This method is the best choice when you want to cache a partial view.
// This method is faster than HTML.Action Helper Method, as its result is directly written to the HTTP response stream, which makes it fast.



// Html.Action Helper Method in ASP.NET MVC Application
// For rendering a partial view using Html.Action, we required the Controller Action method, which returns PartialViewResult

// 6 overloaded versions
// public static MvcHtmlString Action(this HtmlHelper htmlHelper, string actionName);
// public static MvcHtmlString Action(this HtmlHelper htmlHelper, string actionName, object routeValues);
// public static MvcHtmlString Action(this HtmlHelper htmlHelper, string actionName, RouteValueDictionary routeValues);
// public static MvcHtmlString Action(this HtmlHelper htmlHelper, string actionName, string controllerName);
// public static MvcHtmlString Action(this HtmlHelper htmlHelper, string actionName, string controllerName, object routeValues);
// public static MvcHtmlString Action(this HtmlHelper htmlHelper, string actionName, string controllerName, RouteValueDictionary routeValues);


// Parameters:
// htmlHelper: The HTML helper instance that this method extends.
// actionName: The name of the action method to invoke.
// controllerName: The name of the controller that contains the action method.
// object routeValues: An object that contains the parameters for a route. You can use routeValues to provide the parameters that are bound to the action method parameters. The routeValues parameter is merged with the original route values and overrides them.
// RouteValueDictionary routeValues: A dictionary that contains the parameters for a route. You can use routeValues to provide the parameters that are bound to the action method parameters. The routeValues parameter is merged with the original route values and overrides them.

// Returns: The child action result in an HTML string.


// How to use the Action Helper method to call Partial Views in MVC?
// @{
//     ViewBag.Title = "Index";
// }

// @Html.Action("GetProducts", "Product")


// Points to Remember while working with Html.Action Method in MVC:
// Renders the partial view as an HtmlString.
// We need to create a child action for rendering the partial view for this method.
// This method result can be stored in a variable since it returns a string type value.
// The action method is useful when displaying data in the partial view independent of the corresponding view model.
// This method is also the best choice when you want to cache a partial view.



// Render Partial View Using jQuery in ASP.NET MVC.
// We can load our partial view using the jQuery load method. It makes Ajax requests to the controller action method and load output in HTML control like div.
// Add a div in the index.cshtml file as shown below and add a script to load the output of the action method GetProducts.

// @{
//     ViewBag.Title = "Index";
// }

// <div id="partialviews">
// </div>

// <script src="https://code.jquery.com/jquery-1.10.2.js"></script>
// <script type="text/jscript">
//     $(document).ready(function () {
//         $("#partialviews").load('/Product/GetProducts');
//     });
// </script>



// When would you use Partial() over RenderPartial() and vice versa in ASP.NET MVC?
// The main difference is that “RenderPartial()” returns void, and the output will be written directly to the output stream, whereas the “Partial()” method returns MvcHtmlString, which can be assigned to a variable and manipulated if required. So, when there is a need to assign the output to a variable for manipulating it, use Partial(); instead, use RenderPartial().

// Which one is better for performance?
// From a performance perspective, rendering directly to the output stream is better. RenderPartial() does exactly the same thing and is better for performance than Partial(). 

// When would you use Action() over RenderAction() and vice versa in ASP.NET MVC?
// The main difference is that “RenderAction()” returns void, and the output will be written directly to the output stream, whereas the “Action()” method returns MvcHtmlString, which can be assigned to a variable and manipulated if required. So, when there is a need to assign the output to a variable for manipulating it, use Action(); instead, use RenderAction().




// Replaced by Tag Helpers
// Html.Partial and Html.RenderPartial still exist (as PartialAsync and RenderPartialAsync), but they are considered the "old way."

// The Modern Way: You use the <partial name="_MyView" /> tag helper we set up earlier. Behind the scenes, Microsoft optimized this tag to give you the performance of RenderPartial with the clean look of standard HTML.

// Completely Removed from .NET Core
// Html.Action and Html.RenderAction do not exist in modern .NET. Microsoft completely removed "Child Actions" because they caused performance bottlenecks.

// The Modern Way: If you need a partial view to fetch its own data from a database (like a dynamic Shopping Cart or a Trending Sidebar), you now use something called a View Component.