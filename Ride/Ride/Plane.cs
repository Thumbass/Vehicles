namespace Ride
{
    class Plane : Vehicle, IVehicle
    {
        public override ModeOfTransportation TravelMode
        {
            get { return travelMode; }
        }

        public Plane()
        {
            travelMode = ModeOfTransportation.Air;
        }
    }
}