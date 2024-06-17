using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle
    {
        public bool HasTruckBed { get; set; }
        public bool HasRollBar { get; set; }
        public int NumberOfWheels { get; set; }
        public bool IsDriveable { get; set; }
        public bool HasSteeringWheel { get; set; }
        public string MakesSound { get; set; }
        public string Logo { get; set; }
        public bool HasTargetMarket { get; set; }

        public void DisplayDetails()
        {
      Console.WriteLine($"This truck is a {Logo} and it {(HasTruckBed? "has a truck bed" : "does not have a truck bed.")}" +
      $"...and has a horn that goes {MakesSound}... it also..." +
      $"{(HasSteeringWheel ? "has a steering wheel" : "does not have steering wheel.")} and " +
      $"{(HasTargetMarket ? "has a target market" : "does not have target market.")}..." +
      $"as well as {(HasRollBar ? "has roll bar" : "does not have roll bar")} " +
      $"and {(IsDriveable ? "is driveable" : "is not driveable")}");
        }
    }

}
