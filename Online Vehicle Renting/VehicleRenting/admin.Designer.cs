
namespace VehicleRenting
{
    partial class admin
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
            this.buttonManageDriver = new System.Windows.Forms.Button();
            this.buttonManageStaff = new System.Windows.Forms.Button();
            this.buttonMyAccount = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonManageDriver
            // 
            this.buttonManageDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageDriver.Location = new System.Drawing.Point(253, 97);
            this.buttonManageDriver.Name = "buttonManageDriver";
            this.buttonManageDriver.Size = new System.Drawing.Size(236, 41);
            this.buttonManageDriver.TabIndex = 0;
            this.buttonManageDriver.Text = "Manage Driver";
            this.buttonManageDriver.UseVisualStyleBackColor = true;
            this.buttonManageDriver.Click += new System.EventHandler(this.buttonManageDriver_Click);
            // 
            // buttonManageStaff
            // 
            this.buttonManageStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageStaff.Location = new System.Drawing.Point(253, 155);
            this.buttonManageStaff.Name = "buttonManageStaff";
            this.buttonManageStaff.Size = new System.Drawing.Size(236, 41);
            this.buttonManageStaff.TabIndex = 1;
            this.buttonManageStaff.Text = "Manage Staff";
            this.buttonManageStaff.UseVisualStyleBackColor = true;
            this.buttonManageStaff.Click += new System.EventHandler(this.buttonManageEmployee_Click);
            // 
            // buttonMyAccount
            // 
            this.buttonMyAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMyAccount.Location = new System.Drawing.Point(253, 213);
            this.buttonMyAccount.Name = "buttonMyAccount";
            this.buttonMyAccount.Size = new System.Drawing.Size(236, 41);
            this.buttonMyAccount.TabIndex = 2;
            this.buttonMyAccount.Text = "My Account";
            this.buttonMyAccount.UseVisualStyleBackColor = true;
            this.buttonMyAccount.Click += new System.EventHandler(this.buttonMyAccount_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(72, 362);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(620, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonMyAccount);
            this.Controls.Add(this.buttonManageStaff);
            this.Controls.Add(this.buttonManageDriver);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonManageDriver;
        private System.Windows.Forms.Button buttonManageStaff;
        private System.Windows.Forms.Button buttonMyAccount;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button1;
    }
}