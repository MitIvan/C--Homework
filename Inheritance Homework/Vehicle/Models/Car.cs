using System;
using System.Collections.Generic;
using System.Text;
using Vehicle.Enum;

namespace VehicleLibrary.Models
{
    public class Car : WheeledVehicle
    {
        public EngineType EngineType { get; set; }
        public int FuleConsumption { get; set; }
        public int NumOfDoors { get; set; }
        public int MaxSpeed { get; set; }

        public Car()
        {
            Id = 2;
            Type = "Car";
            NumOfWheeles = 4;
        }

        public Car(string manufacturer, string model, EngineType engine, int fuelConsumption, int numberOfDoors, int maxSpeed)
        {
            Manufacturer = manufacturer;
            Model = model;
            EngineType = engine;
            FuleConsumption = fuelConsumption;
            NumOfDoors = numberOfDoors;
            MaxSpeed = maxSpeed;
        }

        public virtual void Drive()
        {
            Console.WriteLine("Brrrrm, Brrrm ");
        }

        public override void Repair()
        {
            Console.WriteLine("Repair the car");
        }
    }
}
