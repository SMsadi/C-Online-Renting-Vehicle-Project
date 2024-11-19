
namespace VehicleRenting
{
    partial class staff
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonManagePassenger = new System.Windows.Forms.Button();
            this.buttonManageDriver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(84, 346);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonManagePassenger
            // 
            this.buttonManagePassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManagePassenger.Location = new System.Drawing.Point(265, 202);
            this.buttonManagePassenger.Name = "buttonManagePassenger";
            this.buttonManagePassenger.Size = new System.Drawing.Size(236, 41);
            this.buttonManagePassenger.TabIndex = 5;
            this.buttonManagePassenger.Text = "Manage Passenger";
            this.buttonManagePassenger.UseVisualStyleBackColor = true;
            this.buttonManagePassenger.Click += new System.EventHandler(this.buttonManagePassenger_Click);
            // 
            // buttonManageDriver
            // 
            this.buttonManageDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageDriver.Location = new System.Drawing.Point(265, 119);
            this.buttonManageDriver.Name = "buttonManageDriver";
            this.buttonManageDriver.Size = new System.Drawing.Size(236, 41);
            this.buttonManageDriver.TabIndex = 4;
            this.buttonManageDriver.Text = "Manage Driver";
            this.buttonManageDriver.UseVisualStyleBackColor = true;
            this.buttonManageDriver.Click += new System.EventHandler(this.buttonManageDriver_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonManagePassenger);
            this.Controls.Add(this.buttonManageDriver);
            this.Name = "staff";
            this.Text = "Staff";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonManagePassenger;
        private System.Windows.Forms.Button buttonManageDriver;
        private System.Windows.Forms.Button button1;
    }
}