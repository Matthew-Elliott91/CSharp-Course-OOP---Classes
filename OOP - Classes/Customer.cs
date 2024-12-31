using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Classes
{
    internal class Customer
    {
        public string Name { get; set; } 
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // Default constructer

        public Customer()
        {
            Name = "Default Name";
            Address = "No Address";
            ContactNumber = "No Contact Number";
        }
        

      
        // Custom Constructer with optional parameters
        public Customer(string name, string address = "NA", string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        // creating methods for classes
        public void SetDetails(string name, string address, string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;

        }

        public static void DoSomeCustomerStuff()
        {
            Console.WriteLine("I did some customer stuff");
        }
    }
}
