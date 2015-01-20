using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {
        int fuelAmount;
        string model;
        string colour;
        int noOfDoors;
        int milesDriven;

        public Car(string model, string colour, int noOfDoors, int miles)
        {
            this.model = model;
            this.colour = colour;
            this.noOfDoors = noOfDoors;
            this.milesDriven = miles;
            fuelAmount = 100 - (miles / 10);
        }

        public int Fuel
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }

           public override string ToString()
        {
            return "model: " + model + "\n" + "colour: " + colour + "\n" + "Number of doors: " + noOfDoors; 
        }

        
        
      
        
    }

}
