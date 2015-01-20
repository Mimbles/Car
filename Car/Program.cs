using System;
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
            car = new Car("bob", "bob", 5, 50);
            Console.WriteLine(car.ToString());
            Console.WriteLine("Fuel left: "+car.Fuel + "%");
            Console.ReadLine();
        }

    }
   
}
