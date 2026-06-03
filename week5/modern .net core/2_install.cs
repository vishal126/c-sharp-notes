// Installing the Core Framework
// EF Core isn't a single massive download; it is distributed as modular NuGet packages.
// You only install the specific "Database Provider" package for the database you intend to use (e.g., SQL Server, SQLite).

// .NET CLI (Cross-Platform): dotnet add package Microsoft.EntityFrameworkCore.SqlServer
// Visual Studio Package Manager Console (PMC): Install-Package Microsoft.EntityFrameworkCore.SqlServer

// Installing EF Core Tools (For Migrations & Scaffolding)
// To actually create databases from your C# code (Migrations) or generate C# code from an existing database (Scaffolding)

// .NET CLI (dotnet ef): Works on Windows, Mac, and Linux.
// Install the tool globally on your machine: dotnet tool install --global dotnet-ef
// Crucial step: You must also install the Microsoft.EntityFrameworkCore.Design package into your specific project for these commands to work.

// Package Manager Console (VS/Windows Only): Uses PowerShell commands like Add-Migration.
// Install via PMC: Install-Package Microsoft.EntityFrameworkCore.Tools

