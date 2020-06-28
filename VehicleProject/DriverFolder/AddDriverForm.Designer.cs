namespace CarProject.DriverFolder
{
    partial class AddDriverForm
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
            this.carListLabel = new System.Windows.Forms.Label();
            this.driverList = new System.Windows.Forms.ListView();
            this.addDriverBtn = new System.Windows.Forms.Button();
            this.addDriverLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.requiredNameLabel = new System.Windows.Forms.Label();
            this.requiredIdLabel = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.idTB)).BeginInit();
            this.SuspendLayout();
            // 
            // carListLabel
            // 
            this.carListLabel.AutoSize = true;
            this.carListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carListLabel.Location = new System.Drawing.Point(362, 10);
            this.carListLabel.Name = "carListLabel";
            this.carListLabel.Size = new System.Drawing.Size(132, 29);
            this.carListLabel.TabIndex = 45;
            this.carListLabel.Text = "Driver List :";
            // 
            // driverList
            // 
            this.driverList.HideSelection = false;
            this.driverList.Location = new System.Drawing.Point(367, 71);
            this.driverList.Name = "driverList";
            this.driverList.Size = new System.Drawing.Size(437, 409);
            this.driverList.TabIndex = 44;
            this.driverList.UseCompatibleStateImageBehavior = false;
            this.driverList.View = System.Windows.Forms.View.Details;
            // 
            // addDriverBtn
            // 
            this.addDriverBtn.Location = new System.Drawing.Point(120, 281);
            this.addDriverBtn.Name = "addDriverBtn";
            this.addDriverBtn.Size = new System.Drawing.Size(98, 40);
            this.addDriverBtn.TabIndex = 43;
            this.addDriverBtn.Text = "Add";
            this.addDriverBtn.UseVisualStyleBackColor = true;
            this.addDriverBtn.Click += new System.EventHandler(this.addDriverBtn_Click);
            // 
            // addDriverLabel
            // 
            this.addDriverLabel.AutoSize = true;
            this.addDriverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDriverLabel.Location = new System.Drawing.Point(20, 10);
            this.addDriverLabel.Name = "addDriverLabel";
            this.addDriverLabel.Size = new System.Drawing.Size(157, 29);
            this.addDriverLabel.TabIndex = 42;
            this.addDriverLabel.Text = "Add a Driver :";
            this.addDriverLabel.UseMnemonic = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(23, 134);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(71, 24);
            this.nameLabel.TabIndex = 38;
            this.nameLabel.Text = "Name :";
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.Location = new System.Drawing.Point(122, 131);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(166, 29);
            this.nameTB.TabIndex = 34;
            this.nameTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nameTB_KeyUp);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(20, 457);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 33;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(23, 87);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(37, 24);
            this.idLabel.TabIndex = 47;
            this.idLabel.Text = "ID :";
            // 
            // requiredNameLabel
            // 
            this.requiredNameLabel.AutoSize = true;
            this.requiredNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredNameLabel.ForeColor = System.Drawing.Color.Red;
            this.requiredNameLabel.Location = new System.Drawing.Point(297, 138);
            this.requiredNameLabel.Name = "requiredNameLabel";
            this.requiredNameLabel.Size = new System.Drawing.Size(62, 13);
            this.requiredNameLabel.TabIndex = 49;
            this.requiredNameLabel.Text = "Required!";
            // 
            // requiredIdLabel
            // 
            this.requiredIdLabel.AutoSize = true;
            this.requiredIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredIdLabel.ForeColor = System.Drawing.Color.Red;
            this.requiredIdLabel.Location = new System.Drawing.Point(296, 91);
            this.requiredIdLabel.Name = "requiredIdLabel";
            this.requiredIdLabel.Size = new System.Drawing.Size(62, 13);
            this.requiredIdLabel.TabIndex = 48;
            this.requiredIdLabel.Text = "Required!";
            // 
            // idTB
            // 
            this.idTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTB.Location = new System.Drawing.Point(120, 85);
            this.idTB.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(166, 29);
            this.idTB.TabIndex = 50;
            this.idTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.idTB_KeyUp_1);
            // 
            // AddDriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 497);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.requiredNameLabel);
            this.Controls.Add(this.requiredIdLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.carListLabel);
            this.Controls.Add(this.driverList);
            this.Controls.Add(this.addDriverBtn);
            this.Controls.Add(this.addDriverLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.closeBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDriverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Driver";
            ((System.ComponentModel.ISupportInitialize)(this.idTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label carListLabel;
        private System.Windows.Forms.ListView driverList;
        private System.Windows.Forms.Button addDriverBtn;
        private System.Windows.Forms.Label addDriverLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label requiredNameLabel;
        private System.Windows.Forms.Label requiredIdLabel;
        private System.Windows.Forms.NumericUpDown idTB;
    }
}