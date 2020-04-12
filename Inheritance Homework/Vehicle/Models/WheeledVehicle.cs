using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibrary.Models
{
    public class WheeledVehicle : Vehicle
    {
        public int NumOfWheeles { get; set; }
        public string Type { get; set; }

        public WheeledVehicle () { }


        public virtual void Repair()
        {
            Console.WriteLine($"Repair not needed");
        }
    }
}
