using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle : ICompany
    {
        public int NumberOfWheels { get; set; }
        public bool IsDriveable { get; set; }
        public bool HasSteeringWheel { get; set; }
        public string MakesSound { get; set; }

        public void DisplayDetails();
        

    }
}
