namespace Ride
{
    class Boat : Vehicle, IVehicle
    {

        public override ModeOfTransportation TravelMode
        {
            get { return travelMode; }
        }

        public Boat()
        {
            travelMode = ModeOfTransportation.Sea;
        }
    }
}