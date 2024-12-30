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
        // Constructer
        public Car(string model, string brand)
        {
            _model = model;
            _brand = brand;
            Console.WriteLine($"An object of Car has been created, its model is {model} and its brand is {brand}!");
        }
    }
}
