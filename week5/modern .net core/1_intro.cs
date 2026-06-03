// The "Model First" approach (using the visual .edmx drag-and-drop designer) is completely dead.
// Today, you only have two approaches: Code First (which Microsoft now just calls standard EF Core with Migrations) and Database First (Reverse Engineering).

// Prerequisites for Both Approaches
// In modern .NET, you don't use the old GUI tools to install EF.
// You use NuGet packages. For SQL Server,
// you will need to install these three packages via the NuGet Package Manager or the .NET CLI:

// 1. Microsoft.EntityFrameworkCore.SqlServer (The database provider)
// 2. Microsoft.EntityFrameworkCore.Tools (Allows you to run migration commands)
// 3. Microsoft.EntityFrameworkCore.Design (Allows the CLI to build your context)

// Approach 1: Code First (The Modern Default)
// You write your C# classes, and EF Core generates the database for you.

// Step 1: Write your POCO Classes (Models)
// public class ClassRoom
// {
//     public int Id { get; set; } // EF Core automatically makes this the Primary Key
//     public string ClassName { get; set; }
    
//     // Navigation property for the 1-to-Many relationship
//     public ICollection<Student> Students { get; set; } 
// }

// public class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }

//     // Foreign Key
//     public int ClassRoomId { get; set; }
//     public ClassRoom ClassRoom { get; set; }
// }

// Step 2: Create the DbContext

// using Microsoft.EntityFrameworkCore;

// public class AppDbContext : DbContext
// {
//     // The constructor accepts options (like the connection string) from Program.cs
//     public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

//     public DbSet<Student> Students { get; set; }
//     public DbSet<ClassRoom> ClassRooms { get; set; }
// }

// Step 3: Register it in Program.cs (Dependency Injection)
// Inside Program.cs
// builder.Services.AddDbContext<AppDbContext>(options =>
//     options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Step 4: Run Migrations
// Open your Package Manager Console (PMC) and tell EF Core to look at your C# code and build the SQL database:

// Add-Migration InitialCreate (This writes a C# file detailing the schema changes)
// Update-Database (This actually executes the SQL commands on your server)



// Approach 2: Database First (Scaffolding)
// If you are connecting an ASP.NET Core app to a massive, already-existing SQL database,
// you don't want to manually type out hundreds of C# classes. You use the CLI to "Scaffold" (reverse-engineer) the database.

// Step 1: Run the Scaffold Command
// Open the Package Manager Console and run a single command containing your connection string.

// Scaffold-DbContext "Server=YOUR_SERVER;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

// Step 2: What Happens Next?
// EF Core will instantly connect to your database, read the schema, and automatically generate your AppDbContext.cs and all your entity classes (like Student.cs and ClassRoom.cs) inside the Models folder.

// From that point forward, you register it in Program.cs exactly like Step 3 above, and start querying your data using LINQ.




// official docs

// Entity Framework (EF) Core is a lightweight, extensible, open source and cross-platform version of the popular Entity Framework data access technology.

// EF Core can serve as an object-relational mapper (O/RM), which:
// 1. Enables .NET developers to work with a database using .NET objects.
// 2. Eliminates the need for most of the data-access code that typically needs to be written.

// The model
// With EF Core, data access is performed using a model.
// A model is made up of entity classes and a **context object** that represents a session with the database.
// The context object allows querying and saving data.

// EF supports the following model development approaches:
// 1. Generate a model from an existing database.
// 2. Hand-code a model to match the database.

// Once a model is created, use EF Migrations to create a database from the model. Migrations allow evolving the database as the model changes.

// using System.Collections.Generic;
// using Microsoft.EntityFrameworkCore;

// namespace Intro;

// public class BloggingContext : DbContext
// {
//     public DbSet<Blog> Blogs { get; set; }
//     public DbSet<Post> Posts { get; set; }

//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//     {
//         optionsBuilder.UseSqlServer(
//             @"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;ConnectRetryCount=0");
//     }
// }

// public class Blog
// {
//     public int BlogId { get; set; }
//     public string Url { get; set; }
//     public int Rating { get; set; }
//     public List<Post> Posts { get; set; }
// }

// public class Post
// {
//     public int PostId { get; set; }
//     public string Title { get; set; }
//     public string Content { get; set; }

//     public int BlogId { get; set; }
//     public Blog Blog { get; set; }
// }


// Querying
// Instances of your entity classes are retrieved from the database using LINQ.

// using (var db = new BloggingContext())
// {
//     var blogs = await db.Blogs
//         .Where(b => b.Rating > 3)
//         .OrderBy(b => b.Url)
//         .ToListAsync();
// }


// Saving data
// Data is created, deleted, and modified in the database using instances of your entity classes.

// using (var db = new BloggingContext())
// {
//     var blog = new Blog { Url = "http://sample.com" };
//     db.Blogs.Add(blog);
//     await db.SaveChangesAsync();
// }