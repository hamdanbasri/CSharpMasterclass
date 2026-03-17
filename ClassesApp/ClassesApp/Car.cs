using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Car
    {
        // BACKING FIELDS FOR THE PROPERTIES BELOW, YOU DONT NEED A BACKING FIELD WHEN YOU DONT NEED TO MANUALLY OVERWRITE
        private string _model = "";
         
        private string _brand = "";

        private bool _isLuxury;

        // Property
        public string Model { get => _model; set => _model = value; }
        public string Brand 
        { 
            get
            {
                if(_isLuxury)
                {
                    return _brand + " - Luxury Edition";
                }
                else
                {
                    return _brand;
                }
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered NOTHING! ");
                    _brand = "DEFAULTVALUE";
                }
                else
                {

                    _brand = value;
                }
            }
        }

        public bool IsLuxury { get => _isLuxury;
            set => _isLuxury = value; }

        //Custom Constructor
        public Car(string model, string brand, bool isLuxury) 
        {
            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;
            Console.WriteLine($"A {Brand} of the model {Model} has been created!");
        }

        public void Drive()
        {
            Console.WriteLine($"I'm a {Brand} {Model} and I am being driven");
        }
    }
}
