using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleFleet.DriverFolder;

namespace VehicleFleet.VehicleFolder.CarFolder
{
    public sealed class Truck : Car
    {

        public Truck(int id, string brand, string color) : base(id, brand, color)
        {
        }
        public override string GetDrivers()
        {
            return base.GetDrivers();
        }
        public override string GetVehicleType()
        {
            return "Truck";
        }
        public override string ToString()
        {
            if (this.SecondDriver is Driver)
            {
                return base.ToString() + "\nDriver: " + this.SecondDriver.ToString();
            }
            else return base.ToString();
        }
    }
}
