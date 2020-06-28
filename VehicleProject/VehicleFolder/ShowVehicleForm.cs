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
    public partial class ShowCarForm : Form
    {
        public ShowCarForm()
        {
            InitializeComponent();
            vehicleList.GridLines = true; // gridlines

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
    }
}
