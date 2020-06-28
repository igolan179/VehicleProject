using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleFleet.DriverFolder;
using VehicleFleet.VehicleFolder;

namespace CarProject.DriverFolder
{
    public partial class ShowDriverForm : Form
    {
        public ShowDriverForm()
        {
            InitializeComponent();
            driverList.GridLines = true; // gridlines
            foreach (Driver driver in AccessList.drivers)
            {
                ListViewItem id = new ListViewItem(driver.Id.ToString(), 0);
                id.SubItems.Add(driver.Name);
                foreach (Vehicle vehicle in AccessList.vehicles)
                {
                    if (vehicle.GetDriverID() == driver.Id) // if driver drives vehicles
                    {
                        id.SubItems.Add(vehicle.Brand);
                        id.SubItems.Add(vehicle.GetVehicleType());
                        break;
                    }
                }
                driverList.Items.Add(id);
            }
            driverList.Columns.Add("ID", -2, HorizontalAlignment.Left);
            driverList.Columns.Add("Name", -2, HorizontalAlignment.Left);
            driverList.Columns.Add("Vehicle", -2, HorizontalAlignment.Left);
            driverList.Columns.Add("Vehicle Type", -2, HorizontalAlignment.Left);

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
