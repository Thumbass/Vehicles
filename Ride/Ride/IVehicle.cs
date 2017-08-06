namespace Ride
{
    interface IVehicle
    {
        ModeOfTransportation TravelMode { get;  }
        string Location();
        void PrintTransport();

    }
}
