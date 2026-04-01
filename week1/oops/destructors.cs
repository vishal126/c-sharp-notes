// What are Destructors in C#?
// Destructors which are also called Finalizers in C# are used to perform any necessary final clean-up when a class instance is being collected by the garbage collector.
// the same name as the class name but prefixed with ~ tilde.

// class Example
// {
//     // Constructor
//     public Example(int x, int y)
//     {
        
//     }

//     // Destructor
//     ~Example()
//     {
        
//     }
// }


// When is a Destructor method Called in C#?
// A destructor method gets called automatically by the garbage collector when the object of the class is destroyed. So, the point that you need to remember is that the destructor methods are automatically called by the garbage collector.



// When will the Object of a Class get Destroyed in C#?
// 1. At the end of the program execution, each and every object that is associated with the program will be destroyed by the garbage collector.
// 2. The Implicit calling of the garbage collector occurs sometime in the middle of the program execution provided the memory is full so the garbage collector will identify unused objects of the program and destroys them.
// 3. The Explicit calling of the garbage collector can also be done in the middle of program execution by the programmer with the help of the “Collect()” statement so that if there are any unused objects associated with the program will be destroyed in the middle of the program execution.



// using System;
// namespace DestructorExample
// {
//     class DestructorDemo
//     {
//         public DestructorDemo()
//         {
//             Console.WriteLine("Constructor Object Created");
//         }
//         ~DestructorDemo()
//         {
//             string type = GetType().Name;
//             Console.WriteLine($"Object {type} is Destroyed");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             DestructorDemo obj1 = new DestructorDemo();
//             DestructorDemo obj2 = new DestructorDemo();

//             //Making obj1 for Garbage Collection
//             obj1 = null;
//         }
//     }
// }

// You can see the statements written inside the destructor are not printed in the output. Then you might be thinking that our destructor is not executed even though we made the obj2 value null. This is not right. The point that you need to remember is that the destructor method is implicitly called by the garbage collector and we cannot predict when it calls the destructor method.



// If you want, then you can also make an explicit call to the garbage collector in the middle of the application execution to destroy the unused object. 
// using System;
// namespace DestructorExample
// {
//     class DestructorDemo
//     {
//         public DestructorDemo()
//         {
//             Console.WriteLine("Constructor Object Created");
//         }
//         ~DestructorDemo()
//         {
//             string type = GetType().Name;
//             Console.WriteLine($"Object {type} is Destroyed");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             DestructorDemo obj1 = new DestructorDemo();
//             DestructorDemo obj2 = new DestructorDemo();

//             //Making obj1 for Garbage Collection
//             obj1 = null;
//             GC.Collect();
//         }
//     }
// }


// the above code will work in visual studio


// Points to Remember while working with Destructors
// 1. Destructors (or Finalizers) cannot be defined in structs.
// 2. In a class, we can only define one Destructor (or Finalizer).
// 3. Destructors cannot be called Explicitly. They are invoked automatically by the garbage collector. At most what we can do is, we can request the Garbage collector to execute the Destructor by calling the GC.Collect() method.
// 4. A Destructor does not take any modifiers or does not have any parameters.


// Destructor implicitly calls the **Finalize** method on the base class of the object.
// a call to a destructor is implicitly translated.

// the destructor is converted to Finalize method. So, whatever code you have written inside the destructor, those codes will be goes inside the try block of the Finalize method and that block code executes and clean-up the resources.
// Once the try block completes its execution, then the finally block is going to be executed. Finally is one block which is guaranteed to be executed. From the finally block, we are again invoking the parent class Finally method, and the parent class finalize method again going to do the same thing.
// This design means that the Finalize method is called recursively for all instances in the inheritance chain, from the most-derived to the least-derived.


// using System;
// namespace DestructorExample
// {
//     public class First
//     {
//         ~First()
//         {
//             Console.WriteLine("Destructor of First Called");
//         }
//     }

//     public class Second : First
//     {
//         ~Second()
//         {
//             Console.WriteLine("Destructor of Second Called");
//         }
//     }

//     public class Third : Second
//     {
//         ~Third()
//         {
//             Console.WriteLine("Destructor of Third Called");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Third obj = new Third();
//             obj = null;
//             GC.Collect();
//         }
//     }
// }



// note 1: Empty Destructors should not be used in our application. Unnecessary destructors, including empty destructors, destructors that only call the base class destructor, or destructors that only call conditionally emitted methods, cause a needless loss of performance.
// note 2: As a developer, we have no control over when the destructor is called and executed.


// When to use Destructor in C#?
// when our application works with unmanaged resources, such as windows, files, and network connections, we should use a destructor to free the memory for those unmanaged resources.



// Explicit Release of Resources using Dispose Pattern in C#:
// If our application is using an expensive external resource, then it is recommended to provide an explicit way to release the resources before the garbage collector frees the object.
// To release the resource, it is recommended to implement a Dispose method of the IDisposable interface that performs the necessary clean-up for the object.
// So, basically, we need our class to inherit from the IDisposable interface and provide the implementation for the Dispose methods.


// using System;
// public class UmmanagedResource : IDisposable
// {
//     #region IDisposable Support
//     private bool disposedValue = false; // To detect redundant calls

//     protected virtual void Dispose(bool disposing)
//     {
//         if (!disposedValue)
//         {
//             if (disposing)
//             {
//                 // TODO: dispose managed state (managed objects).
//             }

//             // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
//             // TODO: set large fields to null.

//             disposedValue = true;
//         }
//     }

//     // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
//     // ~UmmanagedResource() {
//     //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
//     //   Dispose(false);
//     // }

//     // This code added to correctly implement the disposable pattern.
//     public void Dispose()
//     {
//         // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
//         Dispose(true);
//         // TODO: uncomment the following line if the finalizer is overridden above.
//         // GC.SuppressFinalize(this);
//     }
//     #endregion
// }


// using System;
// namespace DestructorDemo
// {
//     public class UmmanagedResource : IDisposable
//     {
//         #region IDisposable Support
//         private bool disposedValue = false; // To detect redundant calls

//         protected virtual void Dispose(bool disposing)
//         {
//             if (!disposedValue)
//             {
//                 if (disposing)
//                 {
//                     //Write Code Here to Destroy the Managed Resources
//                     Console.WriteLine("Managed Resources Destroyed by Dispose Method");
//                 }

//                 //Write Code Here to Destroy the Umanaged Resources
//                 Console.WriteLine("Unmanaged Resources Destroyed by Dispose Method");
//                 disposedValue = true;
//             }
//             else
//             {
//                 Console.WriteLine("Resources are Already Destroyed by Dispose Method");
//             }
//         }

//         ~UmmanagedResource()
//         {
//             //Write Code here to Destroy the Object
//             Console.WriteLine("Request Comes to Destructor to Destroy the Resources");
//             Dispose(false);
//         }

//         // This code added to correctly implement the disposable pattern.
//         public void Dispose()
//         {
//             //Write Code here to Destroy the Object
//             Console.WriteLine("Request Comes to Dispose Method to Destroy the Resources");
//             Dispose(true);
//             GC.SuppressFinalize(this);
//         }
//         #endregion
//     }
//     class Program
//     {
//         static void Main()
//         {
//             UmmanagedResource resource = null;
//             try
//             {
//                 resource = new UmmanagedResource();
//                 Console.WriteLine("Using Resources");
//             }
//             finally
//             {
//                 if (resource != null)
//                 {
//                     Console.WriteLine("Calling Dispose Method to Destroy Resources");
//                     resource.Dispose();
//                 }
//             }

//             //Trying to Call the Dispose Method again
//             Console.WriteLine();
//             Console.WriteLine("Trying to Call the Dispose Method Again To Destroy Resources");
//             resource.Dispose();
//         }
//     }
// }