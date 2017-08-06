using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ride
{
    class Car : Vehicle, IVehicle
    {
        
        public override ModeOfTransportation TravelMode
        {
            get { return travelMode; }
        }

        public Car()
        {
            travelMode = ModeOfTransportation.Land;
        }
    }
}
