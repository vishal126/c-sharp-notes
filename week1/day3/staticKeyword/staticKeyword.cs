// namespace StaticKeywordDemo
// {
//     public class CountryMaster
//     {
//         public string CountryCode { get; set; }
//         public string CountryName { get; set; }
//         private string ComputerName
//         {
//             get
//             {
//                 return System.Environment.MachineName;
//             }
//         }
//         public void Insert()
//         {
//             //Logic to Insert the Country Details into the Database
//             //ComputerName property tells from which computer the Record is being Inserted
//         }
//     }
// }

// ComputerName function is used in customer.cs so we need to make this method as public.
// namespace StaticKeywordDemo
// {
//     public class CountryMaster
//     {
//         public string CountryCode { get; set; }
//         public string CountryName { get; set; }
//         public string ComputerName
//         {
//             get
//             {
//                 return System.Environment.MachineName;
//             }
//         }
//         public void Insert()
//         {
//             //Logic to Insert the Country Details into the Database
//             //ComputerName property tells from which computer the Record is being Inserted
//         }
//     }
// }


// we violate the OOPs principle.

// How we are Violating the OOPs Principle?
// Once you created the Customer class object, and when you write the object name and dot operator, then the intelligence will show you all the public members of the Customer class
// we have exposed the CustomerCode, CustomerName, Insert, and IsEmpty methods
// There is a clear violation of the Abstraction OOPs Principle. Abstraction means showing only what is necessary
// The IsEmpty method is for internal use i.e. used by other internal methods of the class and not by the consumer of the class.
// In this case, the Program class is the consumer of the Customer class i.e. Program class is going to consume the Customer class. As we make the IsEmpty method as public, we are violating the OOPs principle.
// In the same way, we are also violating the abstraction principle with the CountryMaster object as we are exposing the ComputerName property to the external world.


// How to solve the above problem?
// we need to create a commonTask.cs

// namespace StaticKeyowrdDemo
// {
//     public class CountryMaster
//     {
//         public string CountryCode { get; set; }
//         public string CountryName { get; set; }
//         private string ComputerName
//         {
//             get
//             {
//                 CommonTask commonTask = new CommonTask();
//                 return commonTask.ComputerName;
//             }
//         }

//         public void Insert()
//         {
//             CommonTask commonTask = new CommonTask();
//             if (!commonTask.IsEmpty(CountryCode) && !commonTask.IsEmpty(CountryName))
//             {
//                 //Logic to Insert the Country Details into the Database
//                 //ComputerName property tells from which computer the Record is being Inserted
//             }
//         }
//     }
// }


// How do we avoid Inheritance, how do we avoid abstraction, or how do we avoid the OOPs principle in a class?
// Modify the CountryMaster class:
namespace StaticKeyowrdDemo
{
    public class CountryMaster
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        private string ComputerName
        {
            get
            {
                return CommonTask.GetComputerName();
            }
        }

        public void Insert()
        {
            if (!CommonTask.IsEmpty(CountryCode) && !CommonTask.IsEmpty(CountryName))
            {
                //Insert the data
            }
        }
    }
}