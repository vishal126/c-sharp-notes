// It defines the DbContext as a short-lived "Unit of Work" that tracks changes and commits them to the database

// The "Unit of Work" Lifetime
// A DbContext is designed to be short-lived. It is not a permanent connection to the database that stays open forever.

// The standard lifecycle:
// 1. Create the DbContext instance.
// 2. Query data (EF Core starts tracking those entities in memory).
// 3. Modify the data (add, edit, delete).
// 4. Call SaveChanges() or SaveChangesAsync() (EF Core translates the tracked changes into a single SQL transaction).
// 5. Dispose of the DbContext immediately to free up unmanaged memory resources.


// ASP.NET Core Dependency Injection (DI)
// In modern .NET web apps, you rarely use the new keyword to create a DbContext. 
// Instead, you wire it up in Program.cs so the framework handles the creation and disposal for you.

// AddDbContext: You register it using builder.Services.AddDbContext<ApplicationDbContext>(...)

// The "Scoped" Lifetime: By default, ASP.NET Core registers the DbContext as a Scoped service.
//  This is perfect for web APIs because it means exactly one DbContext instance is created per HTTP request.
//  When the HTTP request finishes and sends a response to the user, the framework automatically disposes of the context.

// Constructor Injection: To use it in a Controller, you simply ask for it in the constructor, and the DI container hands it to you.


// Thread Safety & Factories
// DbContext is NOT thread-safe
// The Danger of Async: If you start a database query but forget to put the await keyword in front of it, and then your code tries to run a second query on that exact same DbContext instance, your application will crash with an InvalidOperationException.

// You can never have two threads touching the same DbContext at the exact same time.

// The Factory Pattern (IDbContextFactory):
// In applications like Blazor (where a user's connection stays open for a long time) or background worker services, the "Scoped" HTTP request model doesn't work.
// Instead of injecting the context directly, you use AddDbContextFactory. You inject the Factory, and call _contextFactory.CreateDbContext() whenever you need a fresh, isolated context for a background thread.

// ConfigureDbContext: Introduced in EF9, this allows reusable class libraries to append configurations (like adding Logging or Interceptors) to a DbContext without overriding the main application's connection string.