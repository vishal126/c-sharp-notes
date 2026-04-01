// What is Garbage Collection in .NET Framework?
// When a dot net application runs, lots of objects are created. At a given point in time, it is possible that the application does not use some of those objects.
// The Garbage Collector in the .NET Framework is nothing but a Small Routine, or you can say it’s a Background Process Thread that runs periodically and tries to identify what objects are not being used currently by the application and de-allocates the memory of those objects.

// Note: The Garbage Collector will destroy only the unused managed objects. It does not clean unmanaged objects. 


// Garbage Collection Generations in .NET Framework
// Garbage Collection (GC) in the .NET Framework uses a generational model to manage memory more efficiently.
// This model organizes objects into three generations based on their lifetimes and survival rate through GC cycles.

// Generation 0
// Short-Lived Objects: Generation 0 (Gen 0) contains newly created objects that are short-lived. These are typically temporary objects.
// Frequent Collection: Gen 0 is collected more frequently than the other generations. Most objects are reclaimed for garbage collection in this generation since they are short-lived.
// Efficiency: The collection process is generally fast because it involves only a small portion of the heap.
// Example: Temporary variables, small objects, and objects that are used briefly in methods.


// Generation 1
// Buffer Generation: Generation 1 (Gen 1) serves as a buffer between short-lived objects in Gen 0 and long-lived objects in Gen 2.
// Promotion: Objects that survive a Gen 0 GC are promoted to Gen 1. These are typically objects that have a longer lifetime than those in Gen 0 but are not permanent
// Intermediate Lifetime: Gen 1 is collected less frequently than Gen 0. The objects here have an intermediate lifetime.
// Example: Objects that survive several GC cycles but are not used throughout the application’s lifetime.


// Generation 2
// Long-Lived Objects: Generation 2 (Gen 2) contains long-lived objects. These are objects that have survived multiple rounds of GC in the previous generations.
// Least Frequently Collected: Gen 2 is collected less frequently than Gen 0 and Gen 1. The GC process here can be more time-consuming because it involves a larger portion of the heap.
// Examples: Static objects, objects tied to the application’s life, and large objects that require significant memory resources.


// What is the .NET Memory Profiler?
// .NET Memory Profiler is a powerful tool for finding memory leaks and optimizing memory usage in programs written in C#, VB.NET, or any other .NET Language.
// With the help of the profiling guides, the automatic memory analyzer, and specialized trackers, you can make sure that your program has no memory or resource leaks and that the memory usage is as optimal as possible.



// How does using a Destructor in a Class end up in a Double Garbage Collector Loop?
// The location from where you would like to call the Clean-Up is the destructor of a class.This looks to be the best place to write the clean-up code. But, a big problem is associated with it when you write clean-up in a destructor
// When you define a destructor in your class, the Garbage Collector before destroying the object, will go and ask the question to class, do you have a destructor, if you have a destructor, then move the object to the next generation bucket
// it will not clean up the object having a destructor at that moment itself, even though it is not used. So, it will wait for the destructor to run, and then it will go and clean up the object. Because of this, you will find more objects in Generation 1 and Generation 2 than in Generation 0.


// using System;
// namespace GarbageCollectionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             for (int i = 0; i <= 1000000; i++)
//             {
//                 MyClass1 obj1 = new MyClass1();
//                 MyClass2 obj2 = new MyClass2();
//                 MyClass3 obj3 = new MyClass3();
//             }
//         }
//     }

//     public class MyClass1
//     {
//         ~MyClass1()
//         {
//             //Here, you need to write the code for
//             //Unmanaged resource clean up
//         }
//     }

//     public class MyClass2
//     {
//         ~MyClass2()
//         {            
//             //Here, you need to write the code for
//             //Unmanaged resource clean up
//         }
//     }

//     public class MyClass3
//     {
//         ~MyClass3()
//         {
//             //Here, you need to write the code for
//             //Unmanaged resource clean up
//         }
//     }
// }


// How to Overcome the above Problem?
// This problem can be overcome by using something called the Finalized Dispose pattern.
// To implement this, your class should implement the IDisposable interface and provide the implementation for the Dispose method.
// Within the Dispose method, you need to write the clean-up code for unmanaged objects, and in the end, you need to call GC.
// SuppressFinalize(true) method by passing true as the input value.
// This method suppresses any kind of destructor and just goes and cleans up the objects.using System;


// namespace GarbageCollectionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             for (int i = 0; i <= 1000000; i++)
//             {
//                 MyClass1 obj1 = new MyClass1();
//                 obj1.Dispose();
//                 MyClass2 obj2 = new MyClass2();
//                 obj2.Dispose();
//                 MyClass3 obj3 = new MyClass3();
//                 obj3.Dispose();
//             }
//         }
//     }

//     public class MyClass1 : IDisposable
//     {

//         #region IDisposable Support
//         private bool disposedValue = false; // To detect redundant calls

//         protected virtual void Dispose(bool disposing)
//         {
//             if (!disposedValue)
//             {
//                 if (disposing)
//                 {
//                     // TODO: dispose managed state (managed objects).
//                 }

//                 // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
//                 // TODO: set large fields to null.

//                 disposedValue = true;
//             }
//         }

//         // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
//         ~MyClass1()
//         {
//             // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
//             Dispose(false);
//         }

//         // This code added to correctly implement the disposable pattern.
//         public void Dispose()
//         {
//             // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
//             Dispose(true);
//             // TODO: uncomment the following line if the finalizer is overridden above.
//              GC.SuppressFinalize(this);
//         }
//         #endregion

//     }

//     public class MyClass2 : IDisposable
//     {

//         #region IDisposable Support
//         private bool disposedValue = false; // To detect redundant calls

//         protected virtual void Dispose(bool disposing)
//         {
//             if (!disposedValue)
//             {
//                 if (disposing)
//                 {
//                 }
//                 disposedValue = true;
//             }
//         }

//         // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
//         ~MyClass2()
//         {
//             // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
//             Dispose(false);
//         }

//         // This code added to correctly implement the disposable pattern.
//         public void Dispose()
//         {
//             // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
//             Dispose(true);
//             // TODO: uncomment the following line if the finalizer is overridden above.
//             GC.SuppressFinalize(this);
//         }
//         #endregion

//     }

//     public class MyClass3 : IDisposable
//     {
//         #region IDisposable Support
//         private bool disposedValue = false; 

//         protected virtual void Dispose(bool disposing)
//         {
//             if (!disposedValue)
//             {
//                 if (disposing)
//                 {
//                 }
                
//                 disposedValue = true;
//             }
//         }
        
//         ~MyClass3()
//         {
//             Dispose(false);
//         }

//         public void Dispose()
//         {
//             Dispose(true);
//             GC.SuppressFinalize(this);
//         }
//         #endregion
//     }
// }