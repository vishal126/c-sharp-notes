// What is Abstraction in C#?
// The process of representing the essential features without including the background details is called Abstraction.

// Real-Time Example of Abstraction
// To take a real-time example, when we log in to any social networking site like Facebook, Twitter, LinkedIn, etc., we enter our user ID and password, and then we get logged in. Here, we don’t know how they are processing the data or what logic or algorithm they are using for login.
// This information is abstracted/hidden from us since they are not essential to us. This is basically what abstraction is.


// Another real-time example is an ATM machine

// Example to Understand Abstraction Principle in C#:
// using System;
// namespace GarbageCollectionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Transaction doing SBI Bank");
//             SBI sbi = new SBI();
//             sbi.ValidateCard();
//             sbi.WithdrawMoney();
//             sbi.CheckBalanace();
//             sbi.BankTransfer();
//             sbi.MiniStatement();

//             Console.WriteLine("\nTransaction doing AXIX Bank");
//             AXIX AXIX = new AXIX();
//             AXIX.ValidateCard();
//             AXIX.WithdrawMoney();
//             AXIX.CheckBalanace();
//             AXIX.BankTransfer();
//             AXIX.MiniStatement();
//         }
//     }
    
//     public class SBI 
//     {
//         public void BankTransfer()
//         {
//             Console.WriteLine("SBI Bank Bank Transfer");
//         }

//         public void CheckBalanace()
//         {
//             Console.WriteLine("SBI Bank Check Balanace");
//         }

//         public void MiniStatement()
//         {
//             Console.WriteLine("SBI Bank Mini Statement");
//         }

//         public void ValidateCard()
//         {
//             Console.WriteLine("SBI Bank Validate Card");
//         }

//         public void WithdrawMoney()
//         {
//             Console.WriteLine("SBI Bank Withdraw Money");
//         }
//     }

//     public class AXIX 
//     {
//         public void BankTransfer()
//         {
//             Console.WriteLine("AXIX Bank Bank Transfer");
//         }

//         public void CheckBalanace()
//         {
//             Console.WriteLine("AXIX Bank Check Balanace");
//         }

//         public void MiniStatement()
//         {
//             Console.WriteLine("AXIX Bank Mini Statement");
//         }

//         public void ValidateCard()
//         {
//             Console.WriteLine("AXIX Bank Validate Card");
//         }

//         public void WithdrawMoney()
//         {
//             Console.WriteLine("AXIX Bank Withdraw Money");
//         }
//     }
// }


// How to Implement Abstraction Principle in C#?
// 1. Using Interface
// 2. Using Abstract Classes and Abstract Methods



// Example to Implement Abstraction Principle in C# using Interface:
// using System;
// namespace GarbageCollectionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Transaction doing SBI Bank");
//             IBank sbi = BankFactory.GetBankObject("SBI");
//             sbi.ValidateCard();
//             sbi.WithdrawMoney();
//             sbi.CheckBalanace();
//             sbi.BankTransfer();
//             sbi.MiniStatement();

//             Console.WriteLine("\nTransaction doing AXIX Bank");
//             IBank AXIX = BankFactory.GetBankObject("AXIX");
//             AXIX.ValidateCard();
//             AXIX.WithdrawMoney();
//             AXIX.CheckBalanace();
//             AXIX.BankTransfer();
//             AXIX.MiniStatement();
//         }
//     }

//     public interface IBank
//     {
//         void ValidateCard();
//         void WithdrawMoney();
//         void CheckBalanace();
//         void BankTransfer();
//         void MiniStatement();
//     }

//     public class BankFactory
//     {
//         public static IBank GetBankObject(string bankType)
//         {
//             IBank BankObject = null;
//             if (bankType == "SBI")
//             {
//                 BankObject = new SBI();
//             }
//             else if (bankType == "AXIX")
//             {
//                 BankObject = new AXIX();
//             }
//             return BankObject;
//         }
//     }

//     public class SBI : IBank
//     {
//         public void BankTransfer()
//         {
//             Console.WriteLine("SBI Bank Bank Transfer");
//         }

//         public void CheckBalanace()
//         {
//             Console.WriteLine("SBI Bank Check Balanace");
//         }

//         public void MiniStatement()
//         {
//             Console.WriteLine("SBI Bank Mini Statement");
//         }

//         public void ValidateCard()
//         {
//             Console.WriteLine("SBI Bank Validate Card");
//         }

//         public void WithdrawMoney()
//         {
//             Console.WriteLine("SBI Bank Withdraw Money");
//         }
//     }

//     public class AXIX : IBank
//     {
//         public void BankTransfer()
//         {
//             Console.WriteLine("AXIX Bank Bank Transfer");
//         }

//         public void CheckBalanace()
//         {
//             Console.WriteLine("AXIX Bank Check Balanace");
//         }

//         public void MiniStatement()
//         {
//             Console.WriteLine("AXIX Bank Mini Statement");
//         }

//         public void ValidateCard()
//         {
//             Console.WriteLine("AXIX Bank Validate Card");
//         }

//         public void WithdrawMoney()
//         {
//             Console.WriteLine("AXIX Bank Withdraw Money");
//         }
//     }
// }


// Example to Implement Abstraction Principle in C# using Abstract Class and Abstract Methods:
// using System;
// namespace GarbageCollectionDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Transaction doing SBI Bank");
//             IBank sbi = BankFactory.GetBankObject("SBI");
//             sbi.ValidateCard();
//             sbi.WithdrawMoney();
//             sbi.CheckBalanace();
//             sbi.BankTransfer();
//             sbi.MiniStatement();

//             Console.WriteLine("\nTransaction doing AXIX Bank");
//             IBank AXIX = BankFactory.GetBankObject("AXIX");
//             AXIX.ValidateCard();
//             AXIX.WithdrawMoney();
//             AXIX.CheckBalanace();
//             AXIX.BankTransfer();
//             AXIX.MiniStatement();
//         }
//     }

//     public abstract class IBank
//     {
//         public abstract void ValidateCard();
//         public abstract void WithdrawMoney();
//         public abstract void CheckBalanace();
//         public abstract void BankTransfer();
//         public abstract void MiniStatement();
//     }

//     public class BankFactory
//     {
//         public static IBank GetBankObject(string bankType)
//         {
//             IBank BankObject = null;
//             if (bankType == "SBI")
//             {
//                 BankObject = new SBI();
//             }
//             else if (bankType == "AXIX")
//             {
//                 BankObject = new AXIX();
//             }
//             return BankObject;
//         }
//     }

//     public class SBI : IBank
//     {
//         public override void BankTransfer()
//         {
//             Console.WriteLine("SBI Bank Bank Transfer");
//         }

//         public override void CheckBalanace()
//         {
//             Console.WriteLine("SBI Bank Check Balanace");
//         }

//         public override void MiniStatement()
//         {
//             Console.WriteLine("SBI Bank Mini Statement");
//         }

//         public override void ValidateCard()
//         {
//             Console.WriteLine("SBI Bank Validate Card");
//         }

//         public override void WithdrawMoney()
//         {
//             Console.WriteLine("SBI Bank Withdraw Money");
//         }
//     }

//     public class AXIX : IBank
//     {
//         public override void BankTransfer()
//         {
//             Console.WriteLine("AXIX Bank Bank Transfer");
//         }

//         public override void CheckBalanace()
//         {
//             Console.WriteLine("AXIX Bank Check Balanace");
//         }

//         public override void MiniStatement()
//         {
//             Console.WriteLine("AXIX Bank Mini Statement");
//         }

//         public override void ValidateCard()
//         {
//             Console.WriteLine("AXIX Bank Validate Card");
//         }

//         public override void WithdrawMoney()
//         {
//             Console.WriteLine("AXIX Bank Withdraw Money");
//         }
//     }
// }

// Note: Using abstract class, we can achieve 0 to 100% abstraction. The reason is that you can also provide implementation to the methods inside the abstract class. It does not matter whether you implement all methods or none of the methods inside the abstract class. This is allowed, which is not possible with an interface.


// Advantages of Abstraction Principle in C#
// 1. The Abstraction Principle reduces the complexity of viewing things. It only provides the method signature by hiding how the method is actually implemented.
// 2. The Abstraction Principle helps to increase the security of an application, we are only providing the necessary details to call the method by hiding how the methods are actually implemented.
// 3. the enhancement will become very easy because without affecting end-users, we can able to perform any type of changes in our internal system.
// 4. Without the Abstraction principle, maintaining application code is very complex. Abstraction gives one structure to program code.


// Encapsulation is about hiding Data.
// Abstraction is about hiding Complexity.