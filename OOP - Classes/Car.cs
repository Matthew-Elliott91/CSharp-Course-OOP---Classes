using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Classes
{
    internal class Car
    {
        // member variable
        // private hides the variable from other classes 
        private string _model = "";
        private string _brand = "";
        private bool _isLuxury;

        public static int NumberOfCars = 0;
        

        //Property
        
        // Defining what happens when using the get method
        public string Brand {
            get
            {
                if (_isLuxury)
                {
                    return _brand + " -Luxury Edition";
                } else
                {
                    return _brand;
                }
            }

            // Defining what can be entered as the brand value using a property or Set method
        
          set { 
               if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You didnt enter a brand!!");
                    _brand = "DefaultValue";
                } else
                {
                    _brand = value;
                }   
               }

        }
        
        public string Model { get => _model; set => _model = value; }
        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        // Constructer
        public Car(string model, string brand, bool isLuxury)
        {
            NumberOfCars++;
            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;
            Console.WriteLine($"An object of Car has been created, its model is {model} and its brand is {brand}!");
        }

        public Car()
        {
            NumberOfCars++;
        }
        public void Drive()
        {
            Console.WriteLine($"Im Driving a {this.Brand}, its model is a {this._model}.");
        }
    }
}
