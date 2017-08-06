using System;

namespace Ride
{
    abstract class Vehicle 
    {
      
        string location = null;

        protected ModeOfTransportation travelMode;
        public Vehicle()
        {
            travelMode = ModeOfTransportation.NotClear;
        }
        public virtual ModeOfTransportation TravelMode
        {
            get { return travelMode; }            
        }
        
        public string Location()
        {
           
            if (this.TravelMode == ModeOfTransportation.Land)
            {
                location = "on the";
            }
            else
            {
                location = "in the";
            }
            
            return location;
        }
        public virtual void PrintTransport()
        {
            string _travelMode = TravelMode.ToString();
            Console.WriteLine($"This is my vehicle which travels {location} { _travelMode}.");
        }
    }
}