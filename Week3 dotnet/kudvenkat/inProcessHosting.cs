// ASP.NET InProcess Hosting

// Some of the Tasks that CreateDefaultBuilder() performs:
// 1. Setting up the web server
// 2. Loading the host and application configuration from various configuration sources
// 3. Configuring logging

// An asp.net application can be hosted
// InProcess or
// OutOfProcess


// InProcess hosting
// To configure InProcess hosting
// <AspNetCoreHostingModel>InProcess</AspNetCoreHostingModel>

// CreateDefaultBuilder() method calls UseIIS() method and host the app inside of the IIS worker process (w3wp.exe or iisexpress.exe)

// InProcess hosting delivers significantly higher request throughput than OutOfProcess hosting.

// To get the process name executing the app
// System.Diagonistics.Process.GetCurrentProcess().ProcessName

// With Out process hosting
// 2 web servers - internal and external web server
// The internal web server is Kestrel
// The external web server can be IIS, Nginx or Apache

// What is kestrel
// Cross platform web server for Asp.Net core
// kestrel can be used by itself as an edge server
// The process used to host the app is dotnet.exe
