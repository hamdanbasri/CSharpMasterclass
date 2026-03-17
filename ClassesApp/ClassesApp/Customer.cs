using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // DEFAULT CUSTOMER
        public Customer()
        {
            Name = "No Name";
            Address = "No Address";
            ContactNumber = "No Contact Number";
        }

        // CUSTOM CONSTRUCTOR
        public Customer(string name, string address, string contactNumber) 
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;            
        }

        public Customer(string name)
        {
            Name=name;
        }

        public void SetDetails(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
    }
}
