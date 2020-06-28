using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleFleet.VehicleFolder;

namespace CarProject.VehicleFolder
{
    public partial class DeleteCarForm : Form
    {
        public DeleteCarForm()
        {
            InitializeComponent();
            vehicleList.MultiSelect = true;
            vehicleList.GridLines = true; // gridlines
            vehicleList.FullRowSelect = true;

            foreach (Vehicle vehicles in AccessList.vehicles)
            {
                ListViewItem id = new ListViewItem(vehicles.Id.ToString(), 0);
                id.SubItems.Add(vehicles.Brand);
                id.SubItems.Add(vehicles.GetVehicleType());
                id.SubItems.Add(vehicles.Color);
                id.SubItems.Add(vehicles.GetDriverName());
                vehicleList.Items.Add(id); //Add the items to the ListView.
            }
            vehicleList.Columns.Add("License", -2, HorizontalAlignment.Left);
            vehicleList.Columns.Add("Brand", -2, HorizontalAlignment.Left);
            vehicleList.Columns.Add("Type", -2, HorizontalAlignment.Left);
            vehicleList.Columns.Add("Color", -2, HorizontalAlignment.Left);
            vehicleList.Columns.Add("Driver", -2, HorizontalAlignment.Left);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delVehicleBtn_Click(object sender, EventArgs e)
        {
            if (vehicleList.SelectedItems.Count == 0) MessageBox.Show("You need to select vehicle first.");
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the following vehicles? It can not be undone.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (ListViewItem item in vehicleList.SelectedItems)
                    {
                        foreach (Vehicle vehicle in AccessList.vehicles)
                        {
                            if (int.Parse(item.Text) == vehicle.Id)
                            {
                                AccessList.vehicles.Remove(vehicle);
                                break;
                            }

                        }
                    }
                    vehicleList.Items.Clear();
                    foreach (Vehicle vehicles in AccessList.vehicles)
                    {
                        ListViewItem id = new ListViewItem(vehicles.Id.ToString(), 0);
                        id.SubItems.Add(vehicles.Brand);
                        id.SubItems.Add(vehicles.GetVehicleType());
                        id.SubItems.Add(vehicles.Color);
                        id.SubItems.Add(vehicles.GetDriverName());
                        vehicleList.Items.Add(id); //Add the items to the ListView.
                    }
                }
            }
        }
    }
}
