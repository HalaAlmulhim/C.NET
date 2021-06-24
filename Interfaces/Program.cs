using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike myBike = new Bike(10, 1);
            Horse mrEd = new Horse("Mr. Ed", 300);
            IRideable [] MyRideables = new IRideable[]{
                myBike,
                mrEd
            };
            foreach(IRideable rideable in MyRideables){
                rideable.Ride(50);
            }
        }
    }
}
