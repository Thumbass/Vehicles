using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ride
{
    enum ModeOfTransportation
    {
        NotClear, Land, Sea, Air
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car Lexus = new Car();
            Boat Tugboat = new Boat();
            Plane JumboJet = new Plane();
            List<Vehicle> Vehicles = new List<Vehicle>();
            Vehicles.Add(Tugboat);
            Vehicles.Add(Lexus);
            Vehicles.Add(JumboJet);

            foreach (Vehicle item in Vehicles)
            {
                item.Location();
                item.PrintTransport();
            }
            Console.WriteLine($"We have {Vehicles.Count} vehicles in total.");
            Console.Read();

        }
    }
}