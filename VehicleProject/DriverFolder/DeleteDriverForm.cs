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
    public partial class DeleteDriverForm : Form
    {
        public DeleteDriverForm()
        {
            InitializeComponent();
            driverList.GridLines = true; // gridlines
            driverList.FullRowSelect = true;
            driverList.MultiSelect = true;
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

        private void delDriverBtn_Click(object sender, EventArgs e)
        {
            if (driverList.SelectedItems.Count == 0) MessageBox.Show("You need to select driver first.");
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the following drivers? It can not be undone.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (ListViewItem item in driverList.SelectedItems)
                    {
                        foreach (Driver driver in AccessList.drivers)
                        {
                            if (int.Parse(item.Text) == driver.Id)
                            {
                                AccessList.drivers.Remove(driver);
                                break;
                            }

                        }
                    }
                    driverList.Items.Clear();
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
                }
            }
        }
    }
}
