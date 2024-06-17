using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car();
            car1.HasTrunk = true;
            car1.HasFrontWheelDrive = true;
            car1.NumberOfWheels = 4;
            car1.IsDriveable = true;
            car1.HasSteeringWheel = true;
            car1.MakesSound = "Beep Beep";
            car1.Logo = "Audi";
            car1.HasTargetMarket = true;



            SUV suv1 = new SUV();
            suv1.NumberOfSeats = 8;
            suv1.HasAllWheelDrive = true;
            suv1.NumberOfWheels = 4;
            suv1.IsDriveable = true;
            suv1.HasSteeringWheel = true;
            suv1.MakesSound = "Honk Honk";
            suv1.Logo = "Ford";
            suv1.HasTargetMarket = true;

            


            Truck truck1 = new Truck();
            truck1.HasTruckBed = true;
            truck1.HasRollBar = true;
            truck1.NumberOfWheels = 4;
            truck1.IsDriveable = true;
            truck1.HasSteeringWheel = true;
            truck1.MakesSound = "Ooooga";
            truck1.Logo = "GMC";
            truck1.HasTargetMarket = true;


            car1.DisplayDetails();
            truck1.DisplayDetails();
            suv1.DisplayDetails();
           
 








            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            
            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            
        }
    }
}
