// Specialization in C#
// cuboid ---> rectangle
// the Rectangle class is already existing and from the Rectangle class, we have defined a new class with some extra features i.e. we have a specialized class that is Cuboid. This is a specialization in C#.

// using System;
// namespace IsAHasADemo
// {
//     public class Program
//     {
//         static void Main()
//         {
//             Cuboid cuboid = new Cuboid(3, 5, 7);
//             Console.WriteLine($"Volume is : {cuboid.Volume()}");
//             Console.WriteLine($"Area is : {cuboid.Area()}");
//             Console.WriteLine($"Perimeter is : {cuboid.Perimeter()}");
//         }
//     }
//     class Rectangle
//     {
//         public int Length;
//         public int Breadth;
//         public int Area()
//         {
//             return Length * Breadth;
//         }
//         public int Perimeter()
//         {
//             return 2 * (Length + Breadth);
//         }
//     }
//     class Cuboid : Rectangle
//     {

//         public int Height;
//         public Cuboid(int l, int b, int h)
//         {
//             Length = l;
//             Breadth = b;
//             Height = h;
//         }
//         public int Volume()
//         {
//             return Length * Breadth * Height;
//         }
//     }
// }

// This is specialization. Something is already existing and then we are deriving something from that existing one by adding some extra features.


// Generalization in C#
// Let’s say we have 3 classes that are Square, Rectangle, and Circle. Then for all of these three classes, we are defining one class that is Shape. And Square, Rectangle, and Circle are inherited from the Shape class.

// square --------
//                |
// rectangle ----------> shape
//                |
// circle --------


// So, among these classes which one is existing first? We know that all the shapes i.e. square, rectangle and circle really exist in the real world. So, we are calling them shapes.
// Do you think Shape really exists in the real world? No. It is just a virtual term. If I asked you to show me some shapes, then you’ll be drawing a rectangle, a circle, a square, a Rhombus, etc. but you cannot show me just a shape. So, Shape is a term or generic term, or generalized term which does not exist in the real world.

// using System;
// namespace IsAHasADemo
// {
//     public class Program
//     {
//         static void Main()
//         {
//             Innova innova = new Innova();
//             innova.Start();
//             innova.Stop();

//             BMW bmw = new BMW();
//             bmw.Start();
//             bmw.Stop();
//         }
//     }
//     interface ICar
//     {
//         void Start();
//         void Stop();
//     }

//     public class Innova : ICar
//     {
//         public void Start()
//         {
//             Console.WriteLine($"Innova Start");
//         }
//         public void Stop()
//         {
//             Console.WriteLine($"Innova Stop");
//         }
//     }
//     public class BMW : ICar
//     {
//         public void Start()
//         {
//             Console.WriteLine($"BMW Start");
//         }
//         public void Stop()
//         {
//             Console.WriteLine($"BMW Stop");
//         }
//     }
// }


// Summary of Generalization and Specialization in C#
// the point that you need to remember is both generalization and specialization achieve using only inheritance.
// In specialization, the parent was existing and the child was defined later.
// In generalization, the child class was existing then we define the base class.
// So, specialization is a top-down approach and generalization is a bottom-up approach.

// In specialization, the base class has something to give to the child class whereas, in generalization, the base class doesn’t have anything to give to their child classes. Just their purpose is to group them together so that we can easily manage all those things.

// The purpose of generalization is to achieve polymorphism and the purpose of specialization is to share its features with its child classes.