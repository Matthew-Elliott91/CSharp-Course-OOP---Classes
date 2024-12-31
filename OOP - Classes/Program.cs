using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace OOP___Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // creating an instance or object of the class car
            Car skoda = new Car("Octavia", "Skoda", false);
            Car bmw = new Car("i7", "BMW", true);

            //Setting Brand
            Console.WriteLine("Please enter the Brand Name for Skoda");
            skoda.Brand = Console.ReadLine();
            Console.WriteLine("Please enter the brand name for BMW");
            bmw.Brand = Console.ReadLine();

            //Getting Brand
            Console.WriteLine($"You set the brand for skoda as {skoda.Brand}");
            Console.WriteLine($"You set the brand for BMW as {bmw.Brand}");
            */
            /*
            Customer matthew = new Customer("Matthew");
            Customer sarah = new Customer("Sarah", "little winging", "1234567");
            Console.WriteLine($"The name of the customer is {matthew.Name}.");
            // Creating a default customer
            Customer myCustomer = new Customer();
            Console.WriteLine("Enter the Customers name");
            myCustomer.Name = Console.ReadLine();
            
            Console.WriteLine(myCustomer.Name);
            */

            // Calling methods on classes from the program
            /*
            Car skoda = new Car("Octavia", "Skoda", false);
            Car myBmw = new Car("i7", "BMW", true);

            skoda.Drive();
            myBmw.Drive();

            Customer newCustomer = new Customer();
            newCustomer.SetDetails("Matthew", "Main Street 1");

            Customer customer1 = new Customer("Frank");
            Console.WriteLine($"Contactnumber of Frank is {customer1.ContactNumber}");
            */

            //Named Parameter
            /*
            Console.WriteLine(AddNum(firstNum: 12, secondNum: 24));


            static int AddNum(int firstNum, int secondNum)
            {
                return firstNum + secondNum;
            }
            */

            /*
            Customer customer = new Customer();
            customer.SetDetails("Matthew", "Holly Street", "123456789");

            Customer.DoSomeCustomerStuff();
            */
            Car car = new Car();
            Car car2 = new Car();
            Car car3 = new Car("A3", "Audi", false);

            // accessing the public static variable NumberOfCars
            Console.WriteLine($"We produced {Car.NumberOfCars} cars.");

        }   
    }
}
