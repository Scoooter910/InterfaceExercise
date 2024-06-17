using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public bool HasTrunk { get; set; }
        public bool HasFrontWheelDrive { get; set; }
        public int NumberOfWheels { get; set; }
        public bool IsDriveable { get; set; }
        public bool HasSteeringWheel { get; set; }
        public string MakesSound { get; set; }
        public string Logo { get; set; }
        public bool HasTargetMarket { get; set; }

        public void DisplayDetails()
        {
       Console.WriteLine($"This car is an {Logo} and it {(HasTrunk ? "has a trunk" : "does not have trunk.")}" +
       $"...and has a horn that goes {MakesSound}... it also..." +
       $"{(HasSteeringWheel ? "has a steering wheel" : "does not have steering wheel.")} and " +
       $"{(HasTargetMarket ? "has a target market" : "does not have target market.")}..." +
       $"as well as {(HasFrontWheelDrive ? "has front wheel drive" : "does not have front wheel drive")} " +
       $"and {(IsDriveable ? "is driveable" : "is not driveable")}");
        }
    }
}
