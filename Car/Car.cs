using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {
        int fuelAmount = 100; // We assume the tank starts with 100% of the potential fuel for simplicity
        string model;
        string colour;
        int noOfDoors;

        public Car(string model, string colour, int noOfDoors)
        {
            this.model = model;
            this.colour = colour;
            this.noOfDoors = noOfDoors;
        }

        public int Fuel
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }

           public override string ToString()
        {
            return "Model: " + model + "\n" + "Colour: " + colour + "\n" + "Number of doors: " + noOfDoors + "\n" + "Amount of Fuel" + fuelAmount + "%"; 
        }

           public void DistanceDrive()
           {
               Console.WriteLine("How many miles do you want to drive?");
               milesDriven = Convert.ToInt32(Console.ReadLine());
               
               //Check the car has sufficient fuel for the trip
               if (Math.Ceiling(milesDriven / 10) < fuelAmount)
               {
                   Console.WriteLine("Insuffient fuel");
                   return;
               }
               else
               {
                   //Driving a car uses fuel, so the total amount of fuel should be reduced
                   //10 Miles = 1% of fuel
                   //Always round up to the nearest %
                   fuelAmount -= Math.Ceiling(milesDriven / 10);
               }
               
           }

        
        
      
        
    }

}
