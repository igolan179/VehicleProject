using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarProject.VehicleFolder;
using CarProject.DriverFolder;
using VehicleFleet.VehicleFolder;
using VehicleFleet.DriverFolder;
using VehicleFleet.VehicleFolder.CarFolder;
using VehicleFleet.VehicleFolder.BicycleFolder;

namespace CarProject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            List<Vehicle> vehicles = new List<Vehicle>();
            List<Driver> drivers = new List<Driver>();
            Driver bob = new Driver(123456789, "Bob");
            Driver steve = new Driver(987654321, "Steve");
            Driver arnold = new Driver(111111111, "Arnold");
            SportCar mazdaCar = new SportCar(1548967, "Mazda", "Red");
            Truck fordTruck = new Truck(5686623, "Ford", "White");
            Bicycle bmx = new Bicycle(1775483, "BMX", "Blue");
            mazdaCar.FirstDriver = bob;
            bmx.FirstDriver = arnold;
            AccessList.drivers.Add(steve);
            AccessList.drivers.Add(arnold);
            AccessList.drivers.Add(bob);
            AccessList.vehicles.Add(mazdaCar);
            AccessList.vehicles.Add(fordTruck);
            AccessList.vehicles.Add(bmx);

        }
        private void addCarBtn_Click(object sender, EventArgs e)
        {
            AddCarForm addCarForm = new AddCarForm();
            addCarForm.Show();
        }

        private void showCarBtn_Click(object sender, EventArgs e)
        {
            ShowCarForm showCarForm = new ShowCarForm();
            showCarForm.Show();
        }

        private void delCarBtn_Click(object sender, EventArgs e)
        {
            DeleteCarForm showCarForm = new DeleteCarForm();
            showCarForm.Show();
        }

        private void addDriverBtn_Click(object sender, EventArgs e)
        {
            AddDriverForm addDriverForm = new AddDriverForm();
            addDriverForm.Show();
        }

        private void showDriverBtn_Click(object sender, EventArgs e)
        {
            ShowDriverForm showDriverForm = new ShowDriverForm();
            showDriverForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteDriverForm delDriverForm = new DeleteDriverForm();
            delDriverForm.Show();
        }

        private void assignDriverBtn_Click(object sender, EventArgs e)
        {
            AssignDriverForm assignDriverForm = new AssignDriverForm();
            assignDriverForm.Show();
        }

    }
}
