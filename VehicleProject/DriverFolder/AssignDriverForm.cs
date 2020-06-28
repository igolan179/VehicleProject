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
    public partial class AssignDriverForm : Form
    {
        public AssignDriverForm()
        {
            InitializeComponent();
            driverList.GridLines = true;
            driverList.FullRowSelect = true;
            driverList.MultiSelect = false;
            assignDriverList.GridLines = true;

            bool carlessDriver;
            foreach (Driver driver in AccessList.drivers)
            {
                carlessDriver = true;
                foreach (Vehicle vehicle in AccessList.vehicles)
                {
                    if (vehicle.GetDriverID() == driver.Id) // if driver drives vehicles
                    {
                        carlessDriver = false;
                        break;
                    }
                }
                if (carlessDriver)
                {
                    ListViewItem id = new ListViewItem(driver.Id.ToString(), 0);
                    id.SubItems.Add(driver.Name);
                    driverList.Items.Add(id);
                }
            }
            driverList.Columns.Add("ID", -2, HorizontalAlignment.Left);
            driverList.Columns.Add("Name", -2, HorizontalAlignment.Left);

            assignDriverList.Columns.Add("ID", 75, HorizontalAlignment.Left);
            assignDriverList.Columns.Add("Name", -2, HorizontalAlignment.Left);

            vehicleList.Columns.Add("License", 50, HorizontalAlignment.Left);
            vehicleList.Columns.Add("Brand", 75, HorizontalAlignment.Left);
            vehicleList.Columns.Add("Type", 75, HorizontalAlignment.Left);
            vehicleList.Columns.Add("Color", 50, HorizontalAlignment.Left);

            foreach (Vehicle vehicle in AccessList.vehicles)
            {
                vehicleCB.Items.Add(vehicle.Id);
            }

        }


        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vehicleCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            vehicleList.Items.Clear();
            ListViewItem id = new ListViewItem(AccessList.vehicles[vehicleCB.SelectedIndex].Id.ToString(), 0);
            id.SubItems.Add(AccessList.vehicles[vehicleCB.SelectedIndex].Brand);
            id.SubItems.Add(AccessList.vehicles[vehicleCB.SelectedIndex].GetVehicleType());
            id.SubItems.Add(AccessList.vehicles[vehicleCB.SelectedIndex].Color);
            vehicleList.Items.Add(id); //Add the items to the ListView.
            assignDriverList.Items.Clear();
            if (AccessList.vehicles[vehicleCB.SelectedIndex].hasDriver())
            {
                ListViewItem driverId = new ListViewItem(AccessList.vehicles[vehicleCB.SelectedIndex].FirstDriver.Id.ToString(), 0);
                driverId.SubItems.Add(AccessList.vehicles[vehicleCB.SelectedIndex].FirstDriver.Name);
                assignDriverList.Items.Add(driverId);
            }
        }

        private void assignBtn_Click(object sender, EventArgs e)
        {
            if (driverList.SelectedItems.Count == 0) MessageBox.Show("You need to select a driver first.");
            else if (assignDriverList.Items.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to assign the following driver? It will replace the current driver.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (ListViewItem item in driverList.SelectedItems) // only 1 item for now
                    {
                        foreach (Driver driver in AccessList.drivers)
                        {
                            if (int.Parse(item.Text) == driver.Id)
                            {
                                AccessList.vehicles[vehicleCB.SelectedIndex].FirstDriver = driver;
                                break;
                            }
                        }
                    }
                    driverList.Items.Clear();
                    assignDriverList.Items.Clear();
                    bool carlessDriver;
                    foreach (Driver driver in AccessList.drivers)
                    {
                        carlessDriver = true;
                        foreach (Vehicle vehicle in AccessList.vehicles)
                        {
                            if (vehicle.GetDriverID() == driver.Id) // if driver drives vehicles
                            {
                                carlessDriver = false;
                                break;
                            }
                        }
                        if (carlessDriver)
                        {
                            ListViewItem id = new ListViewItem(driver.Id.ToString(), 0);
                            id.SubItems.Add(driver.Name);
                            driverList.Items.Add(id);
                        }
                    }
                    if (AccessList.vehicles[vehicleCB.SelectedIndex].hasDriver())
                    {
                        ListViewItem driverId = new ListViewItem(AccessList.vehicles[vehicleCB.SelectedIndex].FirstDriver.Id.ToString(), 0);
                        driverId.SubItems.Add(AccessList.vehicles[vehicleCB.SelectedIndex].FirstDriver.Name);
                        assignDriverList.Items.Add(driverId);
                    }
                }
            }
            else
            {
                foreach (ListViewItem item in driverList.SelectedItems) // only 1 item for now
                {
                    foreach (Driver driver in AccessList.drivers)
                    {
                        if (int.Parse(item.Text) == driver.Id)
                        {
                            AccessList.vehicles[vehicleCB.SelectedIndex].FirstDriver = driver;
                            break;
                        }
                    }
                }
                driverList.Items.Clear();
                assignDriverList.Items.Clear();
                bool carlessDriver;
                foreach (Driver driver in AccessList.drivers)
                {
                    carlessDriver = true;
                    foreach (Vehicle vehicle in AccessList.vehicles)
                    {
                        if (vehicle.GetDriverID() == driver.Id) // if driver drives vehicles
                        {
                            carlessDriver = false;
                            break;
                        }
                    }
                    if (carlessDriver)
                    {
                        ListViewItem id = new ListViewItem(driver.Id.ToString(), 0);
                        id.SubItems.Add(driver.Name);
                        driverList.Items.Add(id);
                    }
                }
                if (AccessList.vehicles[vehicleCB.SelectedIndex].hasDriver())
                {
                    ListViewItem driverId = new ListViewItem(AccessList.vehicles[vehicleCB.SelectedIndex].FirstDriver.Id.ToString(), 0);
                    driverId.SubItems.Add(AccessList.vehicles[vehicleCB.SelectedIndex].FirstDriver.Name);
                    assignDriverList.Items.Add(driverId);
                }
            }
        }

        private void unassignBtn_Click(object sender, EventArgs e)
        {
            if (assignDriverList.Items.Count == 0) MessageBox.Show("There is no driver to unassign.");
            else
            {
                AccessList.vehicles[vehicleCB.SelectedIndex].FirstDriver = null;
                driverList.Items.Clear();
                assignDriverList.Items.Clear();
                bool carlessDriver;
                foreach (Driver driver in AccessList.drivers)
                {
                    carlessDriver = true;
                    foreach (Vehicle vehicle in AccessList.vehicles)
                    {
                        if (vehicle.GetDriverID() == driver.Id) // if driver drives vehicles
                        {
                            carlessDriver = false;
                            break;
                        }
                    }
                    if (carlessDriver)
                    {
                        ListViewItem id = new ListViewItem(driver.Id.ToString(), 0);
                        id.SubItems.Add(driver.Name);
                        driverList.Items.Add(id);
                    }
                }
                if (AccessList.vehicles[vehicleCB.SelectedIndex].hasDriver())
                {
                    ListViewItem driverId = new ListViewItem(AccessList.vehicles[vehicleCB.SelectedIndex].FirstDriver.Id.ToString(), 0);
                    driverId.SubItems.Add(AccessList.vehicles[vehicleCB.SelectedIndex].FirstDriver.Name);
                    assignDriverList.Items.Add(driverId);
                }
            }
        }
    }
}

