namespace CarProject.VehicleFolder
{
    partial class DeleteCarForm
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
            this.delVehicleBtn = new System.Windows.Forms.Button();
            this.delCarLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.vehicleList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // delVehicleBtn
            // 
            this.delVehicleBtn.Location = new System.Drawing.Point(700, 414);
            this.delVehicleBtn.Name = "delVehicleBtn";
            this.delVehicleBtn.Size = new System.Drawing.Size(88, 29);
            this.delVehicleBtn.TabIndex = 7;
            this.delVehicleBtn.Text = "Delete";
            this.delVehicleBtn.UseVisualStyleBackColor = true;
            this.delVehicleBtn.Click += new System.EventHandler(this.delVehicleBtn_Click);
            // 
            // delCarLabel
            // 
            this.delCarLabel.AutoSize = true;
            this.delCarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delCarLabel.Location = new System.Drawing.Point(12, 8);
            this.delCarLabel.Name = "delCarLabel";
            this.delCarLabel.Size = new System.Drawing.Size(186, 29);
            this.delCarLabel.TabIndex = 6;
            this.delCarLabel.Text = "List of Vehicles :";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(12, 414);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 5;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // vehicleList
            // 
            this.vehicleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleList.HideSelection = false;
            this.vehicleList.Location = new System.Drawing.Point(12, 41);
            this.vehicleList.Name = "vehicleList";
            this.vehicleList.Size = new System.Drawing.Size(776, 368);
            this.vehicleList.TabIndex = 31;
            this.vehicleList.UseCompatibleStateImageBehavior = false;
            this.vehicleList.View = System.Windows.Forms.View.Details;
            // 
            // DeleteCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vehicleList);
            this.Controls.Add(this.delVehicleBtn);
            this.Controls.Add(this.delCarLabel);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteCarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Vehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delVehicleBtn;
        private System.Windows.Forms.Label delCarLabel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ListView vehicleList;
    }
}