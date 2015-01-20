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
            int disDriven;

            Car car;
            Console.Write("Enter ditance driven: ");
            disDriven = Convert.ToInt16(Console.ReadLine());
            car = new Car("bob", "bob", 5, disDriven);
            Console.WriteLine(car.ToString());
            Console.WriteLine("Fuel left: " + car.Fuel + "%");
            Console.ReadLine();
        }
      

    }
}
