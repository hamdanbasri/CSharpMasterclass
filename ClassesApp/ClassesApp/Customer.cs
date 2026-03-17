using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Customer
    {
        // STATIC FIELD TO HOLD THE NEXT ID
        private static int nextId = 0;

        // READ ONLY INSTANCE FIELD INITIALIZED FROM THE CONSTRUCTOR
        private readonly int _id;
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // DEFAULT CUSTOMER
        public Customer()
        {
            _id = nextId++;
            Name = "No Name";
            Address = "No Address";
            ContactNumber = "No Contact Number";
        }

        // CUSTOM CONSTRUCTOR
        public Customer(string name, string address, string contactNumber)
        {
            _id = nextId++;
            Name = name;
            Address = address;
            ContactNumber = contactNumber;            
        }

        public Customer(string name)
        {
            _id = nextId++;
            Name =name;
        }

        // DEFAULT PARAMETERS CONTACT NUMBER
        public void SetDetails(string name, string address, string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Customers name is: {Name} and custom id is: {_id}");
        }

        public static void DoCustomerStuff()
        {
            Console.WriteLine("Doing some customer stuff");
        }
    }
}
