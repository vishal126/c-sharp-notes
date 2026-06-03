// DbContext Pooling vs. Connection Pooling
// Database Connection Pooling (Lower Level): Opening a physical connection over the network to a SQL database is slow.
// The database driver (ADO.NET) automatically keeps a pool of open network connections.
// When EF Core needs to execute a query, it borrows an open connection, runs the query,
// and immediately returns the connection to the pool.

// DbContext Pooling (EF Core Level): Instantiating a new DbContext class requires allocating memory and setting up internal services.
// In high-traffic APIs, creating and destroying 10,000 DbContext objects a second causes "Garbage Collection" spikes.

// DbContext Pooling (AddPooledDbContextFactory) keeps the actual C# DbContext objects alive in memory, wipes their state clean when you are done, and hands them to the next user.

// Warning: Because pooled contexts are kept alive as "Singletons", you cannot inject scoped data (like a User ID or Tenant ID) in the OnConfiguring method, as it only runs once per object's lifetime.


// Query Caching & Parameterization
// When you write a LINQ query (db.Posts.Where(p => p.Title == "Hello")), EF Core has to do heavy math to translate that C# code into a SQL string.
// To save time, EF Core caches the resulting SQL based on the "shape" of your LINQ query.

// The Constant Mistake: If you write Where(p => p.Title == "post1") and then Where(p => p.Title == "post2"), EF Core sees two entirely different query shapes.
// It compiles them twice, caches them twice, and forces the SQL database to create two separate query execution plans. This destroys performance and memory.

// The Parameter Fix:
// By using a variable (Where(p => p.Title == myVariable)), EF Core compiles the query once as WHERE Title = @p0.
// It reuses the exact same translation forever, no matter what the variable's value is.


// Advanced: Compiled Queries & Compiled Models
// For ultra-low-latency applications (e.g., financial trading platforms or massive enterprise apps), even the tiny overhead of looking up a cached query or booting up a large data model is too slow.

// Compiled Queries (EF.CompileAsyncQuery): This allows you to manually compile a LINQ query into a raw .NET Delegate once.
// When you invoke the delegate, it completely bypasses EF Core's LINQ processing tree and fires the SQL instantly.

// Compiled Models (dotnet ef dbcontext optimize): If your application has 500+ database tables, the very first time a user hits your API,
// EF Core might take several seconds to map all 500 classes into memory. The "optimize" command pre-compiles this mapping into static C# files,
// dropping startup time from seconds to milliseconds.