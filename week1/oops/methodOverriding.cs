// Method Overriding
// The process of re-implementing the superclass non-static, non-private, and non-sealed method in the subclass with the same signature is called Method Overriding.


// When do we need to override a method in C#?
// If the Super Class or Parent Class method logic is not fulfilling the Sub Class or Child Class business requirements, then the Sub Class or Child Class needs to override the superclass method with the required business logic.


// How can we Override a Parent Class Method under Child Class in C#?
// first the method in the parent class must be declared as virtual by using the virtual keyword, then only the child classes get permission for overriding that method.
// If the child class wants to override the parent class virtual method, then the child class can override it with the help of the override modifier.
// overriding the parent class virtual methods under the child classes is not mandatory.

// class Class1
// {
//     // virtual fn. (overridable method)
//     public virtual void Show()
//     {
//         // parent class logic same for all child classes
//     }
// }

// class Class2 : Class1
// {
//     // Overriding Virtual Method
//     public override void Show()
//     {
//         // child class reimplementing the logic
//     }
// }

// class Class3 : Class1
// {
//     // overriding virtual method is optional
// }



// Example to Understand Method Overriding in C#
// using System;
// namespace PolymorphismDemo
// {
//     class Class1
//     {
//         //Virtual Function (Overridable Method)
//         public virtual void Show()
//         {
//             //Parent Class Logic Same for All Child Classes
//             Console.WriteLine("Parent Class Show Method");
//         }
//     }

//     class Class2 : Class1
//     {
//         //Overriding Method
//         public override void Show()
//         {
//             //Child Class Reimplementing the Logic
//             Console.WriteLine("Child Class Show Method");
//         } 
//     }
    
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Class1 obj1 = new Class2();
//             obj1.Show();

//             Class2 obj2 = new Class2();
//             obj2.Show();
//         }
//     }
// }


// Why in both cases the Child Class Show Method is Invoked?
// we need to understand two things i.e. what happens at the time of compilation and what happens at the time of execution for a method call.

// let us understand what Compiler and CLR do when each statement is executed.
// Please observe the first statement. Here, you can see that the reference variable obj1 type is Class1 and this obj1 reference variable points to the object whose type is Class2.

// Class1 obj1 (reference vairable obj1 type) = new Class2(); (reference variable obj1 pointing the object whose type is Class2)
// Class1 is the superclass and Class2 is the subclass.
//  point that you need to keep in mind is that the Super Class Reference Variable Can hold the Subclass object reference and but the reverse is not possible.*****

// Now, observe the following statement.
// obj1.Show();
// obj1 => Reference variable type = Class1
// obj2 => Pointing to Object whose type = Class2

// Compilation => compiler will check the reference variable type
// Runtime => CLR will check the object type

// At the time of compilation, the function call will bind with its function definition. That means the compiler will create a link between the function call and function definition.
// To bind the function, the compiler will check the type of the reference variable and will check if that method or function is available in that type or not.
// If available then compilation will be done successfully and if not available then compilation will fail and you will get a compilation error.
// In our example, the Show method is available in Class1 (type of the reference variable obj1) and hence compilation is successful.

// At the time of program execution, the CLR will check the object type and it is going to execute the method from the reference object type.
// If the method is not available in the corresponding object type, then it will try to execute the method from the Parent class of the object type.
// In our case, the Show method is available in the class Class2 and hence this method is going to be executed from the class Class2. This is because of method overriding and this is also called Dynamic Polymorphism or Runtime Polymorphism.


// What is Dynamic Polymorphism or Runtime Polymorphism?
// The function call is bounded to the class at the time of compilation, if the function is going to be executed by CLR from a different class at run-time rather than the class bounded at compilation-time, then it is called Run-Time Polymorphism.


// What is Static Polymorphism or Compile Time Polymorphism?
// The function call is bounded to the class at the time of compilation, if the function is going to be executed from the same bounded class at run-time, then it is called Compile-Time Polymorphism.

// Note: The point that you need to keep in mind is that the overriding method is always going to be executed from the current class object. The superclass method is called the overridden method and the sub-class method is called the overriding method.

// using System;
// namespace PolymorphismDemo
// {
//     class Class1
//     {
//         //Virtual Function (Overridable Method)
//         public virtual void Show()
//         {
//             //Parent Class Logic Same for All Child Classes
//             Console.WriteLine("Parent Class Show Method");
//         }
//     }

//     class Class3 : Class1
//     {
//         //Not Overriding the Virtual Method
//     }
    
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Class3 obj3 = new Class3();
//             obj3.Show();

//             Class1 obj4 = new Class3();
//             obj4.Show();
//         }
//     }
// }



// How can we execute the superclass method if it is overridden in the sub-class in C#?
// By creating the parent class object under the child class, we can call the parent class methods from the child class, or by using the base keyword, we can call parent class methods from the child class, but this and the base keyword cannot be used under the static block.

// Using the base keyword to call the Parent Class Methods in C#:
// using System;
// namespace PolymorphismDemo
// {
//     class Class1
//     {
//         //Virtual Function (Overridable Method)
//         public virtual void Show()
//         {
//             //Parent Class Logic Same for All Child Classes
//             Console.WriteLine("Parent Class Show Method");
//         }
//     }

//     class Class2 : Class1
//     {
//         //Overriding Method
//         public override void Show()
//         {
//             base.Show(); //Calling Parent Class Show method
//             Console.WriteLine("Child Class Show Method");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Class1 obj1 = new Class2();
//             obj1.Show();

//             Class2 obj2 = new Class2();
//             obj2.Show();
//         }
//     }
// }


// Calling Parent Class Methods by creating the Parent Class Object under the Child Class:
// using System;
// namespace PolymorphismDemo
// {
//     class Class1
//     {
//         public virtual void Show()
//         {
//             Console.WriteLine("Parent Class Show Method");
//         }
//     }

//     class Class2 : Class1
//     {
//         public override void Show()
//         {
//             //Creating an instance of Parent Class
//             Class1 class1 = new Class1();
//             //Calling Parent Class Show method
//             class1.Show(); 
//             Console.WriteLine("Child Class Show Method");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Class1 obj1 = new Class2();
//             obj1.Show();

//             Class2 obj2 = new Class2();
//             obj2.Show();
//         }
//     }
// }


// Method Overriding Real-Time Example in C#
// application to calculate bonuses based on the designation of the Employees.
// If the designation is Developer, then the employee gets either 50000 or 20% of the Salary as a bonus (whichever is higher).
// If the designation is Manager, then the employee gets either 50000 or 25% of the Salary as a bonus (whichever is higher).
// If the designation is Admin, then the employee will get a fixed 50000 as a bonus.


// using System;
// namespace MethodOverriding
// {
//     public class Employee
//     {
//         public int Id { get; set; }
//         public string Name { get; set; }
//         public string Designation { get; set; }
//         public double Salary { get; set; }

//         public virtual double CalculateBonus(double Salary)
//         {
//             return 50000;
//         }
//     }

//     public class Developer : Employee
//     {
//         //50000 or 20% Bonus to Developers which is greater
//         public override double CalculateBonus(double Salary)
//         {
//             double baseSalry = base.CalculateBonus(Salary);
//             double calculatedSalary = Salary * .20;
//             if (baseSalry >= calculatedSalary)
//             {
//                 return baseSalry;
//             }
                
//             else
//             {
//                 return calculatedSalary;
//             }
//         }
//     }

//     public class Manager : Employee
//     {
//         //50000 or 25% Bonus to Developers which is greater
//         public override double CalculateBonus(double Salary)
//         {
//             double baseSalry = base.CalculateBonus(Salary);
//             double calculatedSalary = Salary * .25;
//             if (baseSalry >= calculatedSalary)
//             {
//                 return baseSalry;
//             }
//             else
//             {
//                 return calculatedSalary;
//             }
//         }
//     }

//     public class Admin : Employee
//     {
//         //return fixed bonus 50000
//         //no need to overide the method
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Employee emp1 = new Developer
//             {
//                 Id = 1001,
//                 Name = "Ramesh",
//                 Salary = 500000,
//                 Designation = "Developer"
//             };
//             double bonus = emp1.CalculateBonus(emp1.Salary);
//             Console.WriteLine($"Name: {emp1.Name}, Designation: {emp1.Designation}, Salary: {emp1.Salary}, Bonus:{bonus}");
//             Console.WriteLine();

//             Employee emp2 = new Manager
//             {
//                 Id = 1002,
//                 Name = "Sachin",
//                 Salary = 800000,
//                 Designation = "Manager"
//             };
//             bonus = emp2.CalculateBonus(emp2.Salary);
//             Console.WriteLine($"Name: {emp2.Name}, Designation: {emp2.Designation}, Salary: {emp2.Salary}, Bonus:{bonus}");
//             Console.WriteLine();

//             Employee emp3 = new Admin
//             {
//                 Id = 1003,
//                 Name = "Rajib",
//                 Salary = 300000,
//                 Designation = "Admin"
//             };
//             bonus = emp3.CalculateBonus(emp3.Salary);
//             Console.WriteLine($"Name: {emp3.Name}, Designation: {emp3.Designation}, Salary: {emp3.Salary}, Bonus:{bonus}");
//             Console.WriteLine();

//             Employee emp4 = new Developer
//             {
//                 Id = 1004,
//                 Name = "Priyanka",
//                 Salary = 2000000,
//                 Designation = "Developer"
//             };
//             bonus = emp1.CalculateBonus(emp4.Salary);
//             Console.WriteLine($"Name: {emp4.Name}, Designation: {emp4.Designation}, Salary: {emp4.Salary}, Bonus:{bonus}");
//         }
//     }
// }