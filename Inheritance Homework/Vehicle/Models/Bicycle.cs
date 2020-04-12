using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibrary.Models
{
    class Bicycle : WheeledVehicle
    {
        public int NumberOfSpeedLevels { get; set; }
        public bool IsElectric { get; set; }

        public Bicycle()
        {
            Id = 1
            Type = "Bicycle";
            NumOfWheeles = 2;
        }

        public Bicycle( string manufacturer, string model, int numOfSpeedLevels, bool isElectric)
        {
            
            Manufacturer = manufacturer;
            Model = model;
            NumberOfSpeedLevels = numOfSpeedLevels;
            IsElectric = isElectric;
        }

        public void Ride()
        {
            Console.WriteLine("Zooom, ZOOOOM");
        }

        public override void Repair()
        {
            Console.WriteLine("Repair the bike");
        }
    }
}
