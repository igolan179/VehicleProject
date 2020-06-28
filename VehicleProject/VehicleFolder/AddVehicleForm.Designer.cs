namespace CarProject
{
    partial class AddCarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addVehicleBtn = new System.Windows.Forms.Button();
            this.addVehicleLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.licenseLabel = new System.Windows.Forms.Label();
            this.brandTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vehicleList = new System.Windows.Forms.ListView();
            this.licenseTB = new System.Windows.Forms.NumericUpDown();
            this.closeBtn = new System.Windows.Forms.Button();
            this.typeCB = new System.Windows.Forms.ComboBox();
            this.requiredLicenseLabel = new System.Windows.Forms.Label();
            this.requiredBrandLabel = new System.Windows.Forms.Label();
            this.requiredTypeLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.colorCB = new System.Windows.Forms.ComboBox();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.licenseTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addVehicleBtn
            // 
            this.addVehicleBtn.Location = new System.Drawing.Point(110, 329);
            this.addVehicleBtn.Name = "addVehicleBtn";
            this.addVehicleBtn.Size = new System.Drawing.Size(98, 40);
            this.addVehicleBtn.TabIndex = 27;
            this.addVehicleBtn.Text = "Add";
            this.addVehicleBtn.UseVisualStyleBackColor = true;
            this.addVehicleBtn.Click += new System.EventHandler(this.addVehicleBtn_Click);
            // 
            // addVehicleLabel
            // 
            this.addVehicleLabel.AutoSize = true;
            this.addVehicleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVehicleLabel.Location = new System.Drawing.Point(11, 14);
            this.addVehicleLabel.Name = "addVehicleLabel";
            this.addVehicleLabel.Size = new System.Drawing.Size(173, 29);
            this.addVehicleLabel.TabIndex = 26;
            this.addVehicleLabel.Text = "Add a Vehicle :";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(12, 168);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(63, 24);
            this.typeLabel.TabIndex = 24;
            this.typeLabel.Text = "Type :";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLabel.Location = new System.Drawing.Point(12, 124);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(75, 24);
            this.brandLabel.TabIndex = 22;
            this.brandLabel.Text = "Brand  :";
            // 
            // licenseLabel
            // 
            this.licenseLabel.AutoSize = true;
            this.licenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseLabel.Location = new System.Drawing.Point(12, 78);
            this.licenseLabel.Name = "licenseLabel";
            this.licenseLabel.Size = new System.Drawing.Size(86, 24);
            this.licenseLabel.TabIndex = 21;
            this.licenseLabel.Text = "License :";
            this.licenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brandTB
            // 
            this.brandTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandTB.Location = new System.Drawing.Point(113, 121);
            this.brandTB.Name = "brandTB";
            this.brandTB.Size = new System.Drawing.Size(166, 29);
            this.brandTB.TabIndex = 19;
            this.brandTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.brandTB_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "Vehicle List :";
            // 
            // vehicleList
            // 
            this.vehicleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleList.HideSelection = false;
            this.vehicleList.Location = new System.Drawing.Point(358, 76);
            this.vehicleList.Name = "vehicleList";
            this.vehicleList.Size = new System.Drawing.Size(437, 409);
            this.vehicleList.TabIndex = 29;
            this.vehicleList.UseCompatibleStateImageBehavior = false;
            this.vehicleList.View = System.Windows.Forms.View.Details;
            // 
            // licenseTB
            // 
            this.licenseTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseTB.Location = new System.Drawing.Point(113, 76);
            this.licenseTB.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.licenseTB.Name = "licenseTB";
            this.licenseTB.Size = new System.Drawing.Size(166, 29);
            this.licenseTB.TabIndex = 33;
            this.licenseTB.Enter += new System.EventHandler(this.licenseTB_Enter);
            this.licenseTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.licenseTB_KeyDown);
            this.licenseTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.licenseTB_KeyUp);
            // 
            // closeBtn
            // 
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Location = new System.Drawing.Point(10, 464);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 34;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click_2);
            // 
            // typeCB
            // 
            this.typeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Items.AddRange(new object[] {
            "Bicycle",
            "Sport Car",
            "Truck"});
            this.typeCB.Location = new System.Drawing.Point(113, 165);
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(166, 28);
            this.typeCB.TabIndex = 35;
            this.typeCB.SelectedIndexChanged += new System.EventHandler(this.typeCB_SelectedIndexChanged);
            // 
            // requiredLicenseLabel
            // 
            this.requiredLicenseLabel.AutoSize = true;
            this.requiredLicenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredLicenseLabel.ForeColor = System.Drawing.Color.Red;
            this.requiredLicenseLabel.Location = new System.Drawing.Point(289, 83);
            this.requiredLicenseLabel.Name = "requiredLicenseLabel";
            this.requiredLicenseLabel.Size = new System.Drawing.Size(62, 13);
            this.requiredLicenseLabel.TabIndex = 36;
            this.requiredLicenseLabel.Text = "Required!";
            // 
            // requiredBrandLabel
            // 
            this.requiredBrandLabel.AutoSize = true;
            this.requiredBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredBrandLabel.ForeColor = System.Drawing.Color.Red;
            this.requiredBrandLabel.Location = new System.Drawing.Point(290, 129);
            this.requiredBrandLabel.Name = "requiredBrandLabel";
            this.requiredBrandLabel.Size = new System.Drawing.Size(62, 13);
            this.requiredBrandLabel.TabIndex = 37;
            this.requiredBrandLabel.Text = "Required!";
            // 
            // requiredTypeLabel
            // 
            this.requiredTypeLabel.AutoSize = true;
            this.requiredTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredTypeLabel.ForeColor = System.Drawing.Color.Red;
            this.requiredTypeLabel.Location = new System.Drawing.Point(290, 172);
            this.requiredTypeLabel.Name = "requiredTypeLabel";
            this.requiredTypeLabel.Size = new System.Drawing.Size(62, 13);
            this.requiredTypeLabel.TabIndex = 38;
            this.requiredTypeLabel.Text = "Required!";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.Location = new System.Drawing.Point(12, 215);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(65, 24);
            this.speedLabel.TabIndex = 32;
            this.speedLabel.Text = "Color :";
            // 
            // colorCB
            // 
            this.colorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorCB.FormattingEnabled = true;
            this.colorCB.Items.AddRange(new object[] {
            "Random",
            "White",
            "Red",
            "Blue",
            "Black",
            "Green",
            "Yellow"});
            this.colorCB.Location = new System.Drawing.Point(113, 215);
            this.colorCB.Name = "colorCB";
            this.colorCB.Size = new System.Drawing.Size(166, 28);
            this.colorCB.TabIndex = 39;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataSource = typeof(VehicleFleet.VehicleFolder.Vehicle);
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(807, 499);
            this.Controls.Add(this.colorCB);
            this.Controls.Add(this.requiredTypeLabel);
            this.Controls.Add(this.requiredBrandLabel);
            this.Controls.Add(this.requiredLicenseLabel);
            this.Controls.Add(this.typeCB);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.licenseTB);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vehicleList);
            this.Controls.Add(this.addVehicleBtn);
            this.Controls.Add(this.addVehicleLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.licenseLabel);
            this.Controls.Add(this.brandTB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Vehicle";
            ((System.ComponentModel.ISupportInitialize)(this.licenseTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addVehicleBtn;
        private System.Windows.Forms.Label addVehicleLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label licenseLabel;
        private System.Windows.Forms.TextBox brandTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView vehicleList;
        private System.Windows.Forms.NumericUpDown licenseTB;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ComboBox typeCB;
        private System.Windows.Forms.Label requiredLicenseLabel;
        private System.Windows.Forms.Label requiredBrandLabel;
        private System.Windows.Forms.Label requiredTypeLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.ComboBox colorCB;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
    }
}