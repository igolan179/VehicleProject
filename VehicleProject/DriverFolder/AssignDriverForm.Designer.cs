namespace CarProject.DriverFolder
{
    partial class AssignDriverForm
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
            this.vehicleLabel = new System.Windows.Forms.Label();
            this.assignDriverList = new System.Windows.Forms.ListView();
            this.vehicleCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.driverList = new System.Windows.Forms.ListView();
            this.assignBtn = new System.Windows.Forms.Button();
            this.unassignBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.vehicleList = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vehicleLabel
            // 
            this.vehicleLabel.AutoSize = true;
            this.vehicleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleLabel.Location = new System.Drawing.Point(478, 65);
            this.vehicleLabel.Name = "vehicleLabel";
            this.vehicleLabel.Size = new System.Drawing.Size(214, 29);
            this.vehicleLabel.TabIndex = 32;
            this.vehicleLabel.Text = "Choose a Vehicle :";
            // 
            // assignDriverList
            // 
            this.assignDriverList.FullRowSelect = true;
            this.assignDriverList.HideSelection = false;
            this.assignDriverList.Location = new System.Drawing.Point(544, 246);
            this.assignDriverList.Name = "assignDriverList";
            this.assignDriverList.Size = new System.Drawing.Size(261, 65);
            this.assignDriverList.TabIndex = 31;
            this.assignDriverList.UseCompatibleStateImageBehavior = false;
            this.assignDriverList.View = System.Windows.Forms.View.Details;
            // 
            // vehicleCB
            // 
            this.vehicleCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehicleCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleCB.FormattingEnabled = true;
            this.vehicleCB.Location = new System.Drawing.Point(698, 66);
            this.vehicleCB.Name = "vehicleCB";
            this.vehicleCB.Size = new System.Drawing.Size(159, 28);
            this.vehicleCB.TabIndex = 33;
            this.vehicleCB.SelectedIndexChanged += new System.EventHandler(this.vehicleCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "Available Drivers :";
            // 
            // driverList
            // 
            this.driverList.FullRowSelect = true;
            this.driverList.HideSelection = false;
            this.driverList.Location = new System.Drawing.Point(12, 62);
            this.driverList.Name = "driverList";
            this.driverList.Size = new System.Drawing.Size(420, 427);
            this.driverList.TabIndex = 34;
            this.driverList.UseCompatibleStateImageBehavior = false;
            this.driverList.View = System.Windows.Forms.View.Details;
            // 
            // assignBtn
            // 
            this.assignBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignBtn.Location = new System.Drawing.Point(303, 423);
            this.assignBtn.Name = "assignBtn";
            this.assignBtn.Size = new System.Drawing.Size(115, 51);
            this.assignBtn.TabIndex = 36;
            this.assignBtn.Text = "Assign";
            this.assignBtn.UseVisualStyleBackColor = true;
            this.assignBtn.Click += new System.EventHandler(this.assignBtn_Click);
            // 
            // unassignBtn
            // 
            this.unassignBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unassignBtn.Location = new System.Drawing.Point(614, 317);
            this.unassignBtn.Name = "unassignBtn";
            this.unassignBtn.Size = new System.Drawing.Size(115, 51);
            this.unassignBtn.TabIndex = 37;
            this.unassignBtn.Text = "Unassign";
            this.unassignBtn.UseVisualStyleBackColor = true;
            this.unassignBtn.Click += new System.EventHandler(this.unassignBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(458, 466);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 38;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // vehicleList
            // 
            this.vehicleList.FullRowSelect = true;
            this.vehicleList.HideSelection = false;
            this.vehicleList.Location = new System.Drawing.Point(483, 100);
            this.vehicleList.Name = "vehicleList";
            this.vehicleList.Size = new System.Drawing.Size(374, 81);
            this.vehicleList.TabIndex = 39;
            this.vehicleList.UseCompatibleStateImageBehavior = false;
            this.vehicleList.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 40;
            this.label2.Text = "Driver :";
            // 
            // AssignDriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vehicleList);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.unassignBtn);
            this.Controls.Add(this.assignBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.driverList);
            this.Controls.Add(this.vehicleCB);
            this.Controls.Add(this.vehicleLabel);
            this.Controls.Add(this.assignDriverList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AssignDriverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Driver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vehicleLabel;
        private System.Windows.Forms.ListView assignDriverList;
        private System.Windows.Forms.ComboBox vehicleCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView driverList;
        private System.Windows.Forms.Button assignBtn;
        private System.Windows.Forms.Button unassignBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ListView vehicleList;
        private System.Windows.Forms.Label label2;
    }
}