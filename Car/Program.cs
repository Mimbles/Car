using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {

        static void Main(string[] args)
        {
            Car car;
            car = new Car("Ford Fiesta", "Silver", 3);
            
            Console.WriteLine(car.Fuel); // 100% by default
            car.DistanceDrive(100); // 100 miles is 10% of the total fuel
            Console.WriteLine(car.Fuel) // We can see the fuel has decresed by 10%
            car.DistanceDrive(9999999) // We have insufficient fuel for this trip
            
            Console.ReadLine();
        }
      

    }
}
