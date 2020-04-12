using System;
using System.Collections.Generic;
using System.Text;
using Vehicle.Enum;

namespace VehicleLibrary.Models
{
    public  class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }
        public int BatteryPrecentage { get; set; }
        
        public ElectricCar()
        {
            EngineType = EngineType.Electric;
            Id = 3;
            Type = "Car";
            NumOfWheeles = 4;
            FuleConsumption = 0;
        }

        public ElectricCar(string manufacturer, string model, int numberOfDoors, int maxSpeed, int batteryCapacity, int batteryPrecentage)
        {
            Manufacturer = manufacturer;
            Model = model;
            NumOfDoors = numberOfDoors;
            MaxSpeed = maxSpeed;
            BatteryCapacity = batteryCapacity;
            BatteryPrecentage = batteryPrecentage;
        }

        public void Recharge()
        {
            if(BatteryPrecentage < 20)
            {
                Console.WriteLine($"Recharge the car");
            }
            else
            {
                Console.WriteLine($"Don't Recharge");
            }
            
        }

        public override void Drive()
        {
            Console.WriteLine($"The Electric car max speed is {MaxSpeed}");
        }
    }
}
