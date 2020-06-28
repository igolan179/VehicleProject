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

namespace CarProject.DriverFolder
{
    public partial class AddDriverForm : Form
    {
        public AddDriverForm()
        {
            InitializeComponent();
            idTB.ResetText(); // remove the default "0" at the numericupdown box
            idTB.Controls[0].Visible = false;
            driverList.GridLines = true; // gridlines
            foreach (Driver driver in AccessList.drivers)
            {
                ListViewItem id = new ListViewItem(driver.Id.ToString(), 0);
                id.SubItems.Add(driver.Name);
                driverList.Items.Add(id);
            }
            driverList.Columns.Add("ID", -2, HorizontalAlignment.Left);
            driverList.Columns.Add("Name", -2, HorizontalAlignment.Left);

        }
        bool idFlag = false;
        bool nameFlag = false;

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void nameTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (nameTB.TextLength >= 1)
            {
                okLabelHandler(requiredNameLabel);
                nameFlag = true;
            }
            else
            {
                requiredLabelHandler(requiredNameLabel);
                nameFlag = false;
            }
        }

        private void addDriverBtn_Click(object sender, EventArgs e)
        {
            if (!nameFlag || !idFlag) // if something wrong with the form
            {
                MessageBox.Show("Please Fill the form correctly and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool duplicateCheck = false;
                foreach (Driver driver in AccessList.drivers)
                {
                    if (idTB.Value == driver.Id)
                    {
                        duplicateCheck = true;
                    }
                }
                if (duplicateCheck) MessageBox.Show("ID already exist. Please enter a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    AccessList.drivers.Add(new Driver(Convert.ToInt32(idTB.Value), nameTB.Text));

                    driverList.Items.Clear();
                    foreach (Driver driver in AccessList.drivers)
                    {
                        ListViewItem id = new ListViewItem(driver.Id.ToString(), 0);
                        id.SubItems.Add(driver.Name);
                        driverList.Items.Add(id);
                    }
                    idTB.ResetText();
                    nameTB.ResetText();
                    requiredLabelHandler(requiredIdLabel);
                    requiredLabelHandler(requiredNameLabel);
                    idFlag = false;
                    nameFlag = false;
                }
            }
        }

        private void idTB_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (isValidIsraeliID(Convert.ToInt32(idTB.Value)) && idTB.Value >= 100000000)
            {
                okLabelHandler(requiredIdLabel);
                idFlag = true;
            }
            else
            {
                incorrectLabelHandler(requiredIdLabel);
                idFlag = false;
            }
        }

        private void idTB_Enter(object sender, EventArgs e)
        {
            toolTipHandlerNumeric(idTB, "Must be legit Israeli ID");
        }

        #region Functions
        public void toolTipHandlerNumeric(NumericUpDown textBox, string text)
        {
            int VisibleTime = 4000;

            ToolTip tt = new ToolTip();
            tt.Show(text, textBox, 0, 25, VisibleTime);
        }

        public bool isValidIsraeliID(int id)
        {
            string m_PERID = id.ToString();
            char[] digits = m_PERID.PadLeft(9, '0').ToCharArray();
            int[] oneTwo = { 1, 2, 1, 2, 1, 2, 1, 2, 1 };
            int[] multiply = new int[9];
            int[] oneDigit = new int[9];
            for (int i = 0; i < 9; i++)
                multiply[i] = Convert.ToInt32(digits[i].ToString()) * oneTwo[i];
            for (int i = 0; i < 9; i++)
                oneDigit[i] = (int)(multiply[i] / 10) + multiply[i] % 10;
            int sum = 0;
            for (int i = 0; i < 9; i++)
                sum += oneDigit[i];
            if (sum % 10 == 0) return true;
            else return false;

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
            label.Text = "Not Valid!";
            label.ForeColor = System.Drawing.Color.Red;
        }
        #endregion  
    }
}
