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
using VehicleFleet.VehicleFolder.BicycleFolder;
using VehicleFleet.VehicleFolder.CarFolder;

namespace CarProject
{
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
            licenseTB.ResetText(); // remove the default "0" at the numericupdown box
            licenseTB.Controls[0].Visible = false;
            colorCB.SelectedIndex = 0; // The combo box default value will be Random
            vehicleList.GridLines = true; // gridlines

            foreach (Vehicle vehicles in AccessList.vehicles)
            {
                ListViewItem id = new ListViewItem(vehicles.Id.ToString(), 0);
                id.SubItems.Add(vehicles.Brand);
                id.SubItems.Add(vehicles.GetVehicleType());
                id.SubItems.Add(vehicles.Color);
                vehicleList.Items.Add(id); //Add the items to the ListView.
            }
            vehicleList.Columns.Add("License", -2, HorizontalAlignment.Left);
            vehicleList.Columns.Add("Brand", -2, HorizontalAlignment.Left);
            vehicleList.Columns.Add("Type", -2, HorizontalAlignment.Left);
            vehicleList.Columns.Add("Color", -2, HorizontalAlignment.Left);
        }

        bool licenseFlag = false;
        bool brandFlag = false;
        bool typeFlag = false;


        private void closeBtn_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void licenseTB_Enter(object sender, EventArgs e)
        {
            toolTipHandlerNumeric(licenseTB, "Must contain 7 digits.");
        }

        private void licenseTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (licenseTB.Value >= 1000000 && licenseTB.Value <= 9999999)
            {
                okLabelHandler(requiredLicenseLabel);
                licenseFlag = true;
            }
            else
            {
                incorrectLabelHandler(requiredLicenseLabel);
                licenseFlag = false;
            }
        }


        private void licenseTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Back)
            {
                if (licenseTB.Value >= 1000000 && licenseTB.Value <= 9999999)
                {
                    okLabelHandler(requiredLicenseLabel);
                    licenseFlag = true;
                }
                else
                {
                    incorrectLabelHandler(requiredLicenseLabel);
                    licenseFlag = false;
                }
            }
        }

        private void brandTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (brandTB.TextLength >= 1)
            {
                okLabelHandler(requiredBrandLabel);
                brandFlag = true;
            }
            else
            {
                requiredLabelHandler(requiredBrandLabel);
                brandFlag = false;
            }
        }

        private void typeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            okLabelHandler(requiredTypeLabel);
            typeFlag = true;
        }

        private void addVehicleBtn_Click(object sender, EventArgs e)
        {
            if (!licenseFlag || !brandFlag || !typeFlag) // if something wrong with the form
            {
                MessageBox.Show("Please Fill the form correctly and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool duplicateCheck = false;
                foreach (Vehicle vehicle in AccessList.vehicles)
                {
                    if (licenseTB.Value == vehicle.Id)
                    {
                        duplicateCheck = true;
                    }
                }
                if (duplicateCheck) MessageBox.Show("License already exist. Please enter a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string color = colorCB.Text;
                    if (color == "Random") color = randomColorHandler();
                    if (typeCB.SelectedIndex == 0) // if bicycle is checked
                    {
                        AccessList.vehicles.Add(new Bicycle(Convert.ToInt32(licenseTB.Value), brandTB.Text, color));
                    }
                    if (typeCB.SelectedIndex == 1) // if sport car is checked
                    {
                        AccessList.vehicles.Add(new SportCar(Convert.ToInt32(licenseTB.Value), brandTB.Text, color));

                    }
                    if (typeCB.SelectedIndex == 2) // if truck is checked
                    {
                        AccessList.vehicles.Add(new Truck(Convert.ToInt32(licenseTB.Value), brandTB.Text, color));
                    }
                    vehicleList.Items.Clear();
                    foreach (Vehicle vehicles in AccessList.vehicles)
                    {
                        ListViewItem id = new ListViewItem(vehicles.Id.ToString(), 0);
                        id.SubItems.Add(vehicles.Brand);
                        id.SubItems.Add(vehicles.GetVehicleType());
                        id.SubItems.Add(vehicles.Color);
                        vehicleList.Items.Add(id); //Add the items to the ListView.
                    }
                    licenseTB.ResetText();
                    brandTB.ResetText();
                    requiredLabelHandler(requiredLicenseLabel);
                    requiredLabelHandler(requiredBrandLabel);
                    licenseFlag = false;
                    brandFlag = false;
                }
            }
        }
        #region Functions
        public void toolTipHandlerNumeric(NumericUpDown textBox, string text)
        {
            int VisibleTime = 4000;

            ToolTip tt = new ToolTip();
            tt.Show(text, textBox, 0, 25, VisibleTime);
        }
        public void toolTipHandlerTextBox(TextBox textBox, string text)
        {
            int VisibleTime = 4000;

            ToolTip tt = new ToolTip();
            tt.Show(text, textBox, 0, 25, VisibleTime);
        }
        public void okLabelHandler(Label label)
        {
            label.Text = "OK!";
            label.ForeColor = System.Drawing.Color.Green;
        }
        public void requiredLabelHandler(Label label)
        {
            label.Text = "Required!";
            label.ForeColor = System.Drawing.Color.Red;
        }
        public void incorrectLabelHandler(Label label)
        {
            label.Text = "Incorrect!";
            label.ForeColor = System.Drawing.Color.Red;
        }

        public string randomColorHandler()
        {
            string[] colors = { "White", "Red", "Blue", "Black", "Green", "Yellow" };
            Random rand = new Random();
            int index = rand.Next(colors.Length);
            return colors[index];
        }
        #endregion  
    }
}
