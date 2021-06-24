using System;

namespace Interfaces
{
    public class Bike : Vehicle, IRideable{
        public int numSpeeds{get; set;}
        private double Odometer;
        public Bike (int speeds, int passengers): base(passengers){
            numSpeeds = speeds;
        }
        // public void Ride(double distance){
        //     Odometer += distance;
        // }
        public double DistanceTraveled{
            get{return Odometer;}
            set{Odometer = value;}
        }
        public void Ride(double distance){
            DistanceTraveled += distance;
            Console.WriteLine($"You traveled {distance} kilometers, this bike has traveled a total of {DistanceTraveled}kilometers!");
        }
        
    }
}