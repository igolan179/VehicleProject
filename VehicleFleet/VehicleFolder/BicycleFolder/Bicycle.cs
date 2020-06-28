using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleFleet.DriverFolder;

namespace VehicleFleet.VehicleFolder.BicycleFolder
{
    public sealed class Bicycle : Vehicle
    {
        
        public Bicycle(int id, string brand, string color) : base(id, brand, color)
        {
        }

        public override string GetDrivers()
        {
            return base.GetDrivers();
        }
        public override string GetVehicleType()
        {
            return "Bicycle";
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
