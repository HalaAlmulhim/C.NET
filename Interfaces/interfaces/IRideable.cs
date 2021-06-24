namespace Interfaces
{
    interface IRideable{
        double DistanceTraveled{get; set;}
        void Ride(double distance);
    }
}