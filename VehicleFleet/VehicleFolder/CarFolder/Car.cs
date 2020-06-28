using VehicleFleet.DriverFolder;

namespace VehicleFleet.VehicleFolder.CarFolder
{
    public abstract class Car : Vehicle
    {
        private int amoutOfDrivers = 2;
        private Driver secondDriver;

        protected Car(int id, string brand, string color) : base(id, brand, color)
        {
        }
        public Driver SecondDriver { get => secondDriver; set => secondDriver = value; }

        public override string GetDrivers()
        {
            return base.GetDrivers() + "\nDriver 2: " + this.SecondDriver.ToString();
        }
    }
}
