// Encapsulation
// Encapsulation Hides the internal state and functionality of an object and only allows access through a public set of functions.
// The process of binding or grouping the State (i.e., Data Members) and Behaviour (i.e., Member Functions) together into a single unit (i.e., class, interface, struct, etc.) is called Encapsulation

// The Encapsulation Principle ensures that the state and behavior of a unit (i.e., class, interface, struct, etc.) cannot be accessed directly from other units (i.e., class, interface, struct, etc.).

// namespace EncapsulationDemo
// {
//     class Bank
//     {
//         public long AccountNumber;
//         public string Name;
//         public int Balance;

//         public void GetBalance()
//         {
//         }
//         public void WithdrawAmount()
//         {
//         }
//         public void Deposit()
//         {
//         }
//     }
// }

// The variables(AccountNumber, Name, and Balance) and methods(GetBalance, WithdrawAmount, and Deposit) of the class are bound in a single unit, which is the Bank class.

// Here, the encapsulation binds the implementation details of the Bank class with it and hides it from other classes.

// if other classes want to access these details, they need to create the object of the Bank class to access its data and behavior, as shown in the code below.
// namespace EncapsulationDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Bank bank = new Bank();
//             bank.AccountNumber = 12345678;
//             bank.Name = "Pranata";
//             bank.GetBalance();
//             bank.WithdrawAmount();
//         }
//     }
// }


// Similarly, if you create an interface, struct, or enum, that is also an example of encapsulation.
// The biggest advantage of Encapsulation is Data Hiding.

// What is Data Hiding in C#?
// Data hiding or Information Hiding is a Process in which we hide internal data from outside the world.
// The purpose of data hiding is to protect the data from misuse by the outside world.
// Data hiding is also known as Data Encapsulation.

// How can we Implement Data Hiding or Data Encapsulation in C#?
// In C#, Data Encapsulation is implemented.
// 1. By declaring the variables as private (to restrict their direct access from outside the class)
// 2. By defining one pair of public setter and getter methods or properties to access private variables from outside the class.

// Data Encapsulation or Data Hiding in C# is implemented by using the Access Specifiers.



// Implementing Data Encapsulation or Data Hiding in C# using Setter and Getter Methods:
// using System;
// namespace EncapsulationDemo
// {
//     public class Bank
//     {
//         //Hiding class data by declaring the variable as private
//         private double balance;

//         //Creating public Setter and Getter methods

//         //Public Getter Method
//         //This method is used to return the data stored in the balance variable
//         public double GetBalance()
//         {
//             //add validation logic if needed
//             return balance;
//         }

//         //Public Setter Method
//         //This method is used to stored the data  in the balance variable
//         public void SetBalance(double balance)
//         {
//             // add validation logic to check whether data is correct or not
//             this.balance = balance;
//         }
//     }
//     class Program
//     {
//         public static void Main()
//         {
//             Bank bank = new Bank();
//             //You cannot access the Private Variable
//             //bank.balance; //Compile Time Error

//             //You can access the private variable via public setter and getter methods
//             bank.SetBalance(500);
//             Console.WriteLine(bank.GetBalance());
//         }
//     }
// }


// What are the Advantages of Providing Variable Access via Setter and Getter Methods in C#?
// data validation
// security


// Implementing Data Encapsulation or Data Hiding in C# using Properties:
// Properties in C# help in protecting a field or variable of a class by reading and writing the values to it. 

// using System;
// namespace EncapsulationDemo
// {
//     public class Bank
//     {
//         private double _Amount;
//         public double Amount
//         {
//             get
//             {
//                 return _Amount;
//             }
//             set
//             {
//                 // Validate the value before storing it in the _Amount variable
//                 if (value < 0)
//                 {
//                     throw new Exception("Please Pass a Positive Value");
//                 }
//                 else
//                 {
//                     _Amount = value;
//                 }
//             }
//         }
//     }
//     class Program
//     {
//         public static void Main()
//         {
//             try
//             {
//                 Bank bank = new Bank();
//                 //We cannot access the _Amount Variable directly
//                 //bank._Amount = 50; //Compile Time Error
//                 //Console.WriteLine(bank._Amount); //Compile Time Error

//                 //Setting Positive Value using public Amount Property
//                 bank.Amount= 10;

//                 //Setting the Value using public Amount Property
//                 Console.WriteLine(bank.Amount);
                
//                 //Setting Negative Value
//                 bank.Amount = -150;
//                 Console.WriteLine(bank.Amount);
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine(ex.Message);
//             }
//         }
//     }
// }


// Advantages of Encapsulation in C#:
// 1. Data protection
// 2. Achieving Data Hiding
// 3. Security
// 4. Flexibility
// 5. Control