namespace CarProject
{
    partial class Main
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
            this.addVehicleBtn = new System.Windows.Forms.Button();
            this.showVehicleBtn = new System.Windows.Forms.Button();
            this.delVehicleBtn = new System.Windows.Forms.Button();
            this.mainTitle = new System.Windows.Forms.Label();
            this.addDriverBtn = new System.Windows.Forms.Button();
            this.assignDriverBtn = new System.Windows.Forms.Button();
            this.showDriverBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addVehicleBtn
            // 
            this.addVehicleBtn.Location = new System.Drawing.Point(12, 456);
            this.addVehicleBtn.Name = "addVehicleBtn";
            this.addVehicleBtn.Size = new System.Drawing.Size(96, 30);
            this.addVehicleBtn.TabIndex = 0;
            this.addVehicleBtn.Text = "Add Vehicle";
            this.addVehicleBtn.UseVisualStyleBackColor = true;
            this.addVehicleBtn.Click += new System.EventHandler(this.addCarBtn_Click);
            // 
            // showVehicleBtn
            // 
            this.showVehicleBtn.Location = new System.Drawing.Point(114, 456);
            this.showVehicleBtn.Name = "showVehicleBtn";
            this.showVehicleBtn.Size = new System.Drawing.Size(96, 30);
            this.showVehicleBtn.TabIndex = 1;
            this.showVehicleBtn.Text = "Show Vehicle";
            this.showVehicleBtn.UseVisualStyleBackColor = true;
            this.showVehicleBtn.Click += new System.EventHandler(this.showCarBtn_Click);
            // 
            // delVehicleBtn
            // 
            this.delVehicleBtn.Location = new System.Drawing.Point(216, 456);
            this.delVehicleBtn.Name = "delVehicleBtn";
            this.delVehicleBtn.Size = new System.Drawing.Size(96, 30);
            this.delVehicleBtn.TabIndex = 2;
            this.delVehicleBtn.Text = "Delete Vehicle";
            this.delVehicleBtn.UseVisualStyleBackColor = true;
            this.delVehicleBtn.Click += new System.EventHandler(this.delCarBtn_Click);
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.Location = new System.Drawing.Point(12, 9);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(385, 55);
            this.mainTitle.TabIndex = 4;
            this.mainTitle.Text = "Vehicle Manager";
            // 
            // addDriverBtn
            // 
            this.addDriverBtn.Location = new System.Drawing.Point(352, 456);
            this.addDriverBtn.Name = "addDriverBtn";
            this.addDriverBtn.Size = new System.Drawing.Size(96, 30);
            this.addDriverBtn.TabIndex = 5;
            this.addDriverBtn.Text = "Add Driver";
            this.addDriverBtn.UseVisualStyleBackColor = true;
            this.addDriverBtn.Click += new System.EventHandler(this.addDriverBtn_Click);
            // 
            // assignDriverBtn
            // 
            this.assignDriverBtn.Location = new System.Drawing.Point(656, 456);
            this.assignDriverBtn.Name = "assignDriverBtn";
            this.assignDriverBtn.Size = new System.Drawing.Size(96, 30);
            this.assignDriverBtn.TabIndex = 6;
            this.assignDriverBtn.Text = "Assign Driver";
            this.assignDriverBtn.UseVisualStyleBackColor = true;
            this.assignDriverBtn.Click += new System.EventHandler(this.assignDriverBtn_Click);
            // 
            // showDriverBtn
            // 
            this.showDriverBtn.Location = new System.Drawing.Point(454, 456);
            this.showDriverBtn.Name = "showDriverBtn";
            this.showDriverBtn.Size = new System.Drawing.Size(96, 30);
            this.showDriverBtn.TabIndex = 7;
            this.showDriverBtn.Text = "Show Drivers";
            this.showDriverBtn.UseVisualStyleBackColor = true;
            this.showDriverBtn.Click += new System.EventHandler(this.showDriverBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Delete Driver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 498);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showDriverBtn);
            this.Controls.Add(this.assignDriverBtn);
            this.Controls.Add(this.addDriverBtn);
            this.Controls.Add(this.mainTitle);
            this.Controls.Add(this.delVehicleBtn);
            this.Controls.Add(this.showVehicleBtn);
            this.Controls.Add(this.addVehicleBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addVehicleBtn;
        private System.Windows.Forms.Button showVehicleBtn;
        private System.Windows.Forms.Button delVehicleBtn;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Button addDriverBtn;
        private System.Windows.Forms.Button assignDriverBtn;
        private System.Windows.Forms.Button showDriverBtn;
        private System.Windows.Forms.Button button1;
    }
}

