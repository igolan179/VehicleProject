namespace CarProject.DriverFolder
{
    partial class DeleteDriverForm
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
            this.delDriverBtn = new System.Windows.Forms.Button();
            this.delCarLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.driverList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // delDriverBtn
            // 
            this.delDriverBtn.Location = new System.Drawing.Point(700, 414);
            this.delDriverBtn.Name = "delDriverBtn";
            this.delDriverBtn.Size = new System.Drawing.Size(88, 29);
            this.delDriverBtn.TabIndex = 11;
            this.delDriverBtn.Text = "Delete";
            this.delDriverBtn.UseVisualStyleBackColor = true;
            this.delDriverBtn.Click += new System.EventHandler(this.delDriverBtn_Click);
            // 
            // delCarLabel
            // 
            this.delCarLabel.AutoSize = true;
            this.delCarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delCarLabel.Location = new System.Drawing.Point(12, 8);
            this.delCarLabel.Name = "delCarLabel";
            this.delCarLabel.Size = new System.Drawing.Size(170, 29);
            this.delCarLabel.TabIndex = 10;
            this.delCarLabel.Text = "List of Drivers :";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(12, 414);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // driverList
            // 
            this.driverList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverList.HideSelection = false;
            this.driverList.Location = new System.Drawing.Point(12, 41);
            this.driverList.Name = "driverList";
            this.driverList.Size = new System.Drawing.Size(776, 368);
            this.driverList.TabIndex = 32;
            this.driverList.UseCompatibleStateImageBehavior = false;
            this.driverList.View = System.Windows.Forms.View.Details;
            // 
            // DeleteDriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.driverList);
            this.Controls.Add(this.delDriverBtn);
            this.Controls.Add(this.delCarLabel);
            this.Controls.Add(this.closeBtn);
            this.Name = "DeleteDriverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete a Driver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delDriverBtn;
        private System.Windows.Forms.Label delCarLabel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ListView driverList;
    }
}