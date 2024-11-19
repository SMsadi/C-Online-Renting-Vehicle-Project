
namespace VehicleRenting
{
    partial class passenger1
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
            this.labelPassengerName = new System.Windows.Forms.Label();
            this.labelPassengerLocation = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPassengerName = new System.Windows.Forms.TextBox();
            this.textBoxPassengerPhone = new System.Windows.Forms.TextBox();
            this.textBoxPassengerLocation = new System.Windows.Forms.TextBox();
            this.buttonPassengerClear = new System.Windows.Forms.Button();
            this.buttonPassengerExit = new System.Windows.Forms.Button();
            this.buttonPassengerNext = new System.Windows.Forms.Button();
            this.labelPassengerDestination = new System.Windows.Forms.Label();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPassengerName
            // 
            this.labelPassengerName.AutoSize = true;
            this.labelPassengerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassengerName.Location = new System.Drawing.Point(156, 97);
            this.labelPassengerName.Name = "labelPassengerName";
            this.labelPassengerName.Size = new System.Drawing.Size(55, 20);
            this.labelPassengerName.TabIndex = 0;
            this.labelPassengerName.Text = "Name";
            // 
            // labelPassengerLocation
            // 
            this.labelPassengerLocation.AutoSize = true;
            this.labelPassengerLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassengerLocation.Location = new System.Drawing.Point(155, 132);
            this.labelPassengerLocation.Name = "labelPassengerLocation";
            this.labelPassengerLocation.Size = new System.Drawing.Size(78, 20);
            this.labelPassengerLocation.TabIndex = 1;
            this.labelPassengerLocation.Text = "Location";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(156, 198);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(60, 20);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Phone";
            // 
            // textBoxPassengerName
            // 
            this.textBoxPassengerName.Location = new System.Drawing.Point(336, 99);
            this.textBoxPassengerName.Name = "textBoxPassengerName";
            this.textBoxPassengerName.Size = new System.Drawing.Size(169, 20);
            this.textBoxPassengerName.TabIndex = 3;
            this.textBoxPassengerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPassengerPhone
            // 
            this.textBoxPassengerPhone.Location = new System.Drawing.Point(336, 200);
            this.textBoxPassengerPhone.Name = "textBoxPassengerPhone";
            this.textBoxPassengerPhone.Size = new System.Drawing.Size(169, 20);
            this.textBoxPassengerPhone.TabIndex = 4;
            // 
            // textBoxPassengerLocation
            // 
            this.textBoxPassengerLocation.Location = new System.Drawing.Point(336, 134);
            this.textBoxPassengerLocation.Name = "textBoxPassengerLocation";
            this.textBoxPassengerLocation.Size = new System.Drawing.Size(169, 20);
            this.textBoxPassengerLocation.TabIndex = 5;
            // 
            // buttonPassengerClear
            // 
            this.buttonPassengerClear.Location = new System.Drawing.Point(336, 251);
            this.buttonPassengerClear.Name = "buttonPassengerClear";
            this.buttonPassengerClear.Size = new System.Drawing.Size(75, 23);
            this.buttonPassengerClear.TabIndex = 6;
            this.buttonPassengerClear.Text = "Clear";
            this.buttonPassengerClear.UseVisualStyleBackColor = true;
            this.buttonPassengerClear.Click += new System.EventHandler(this.buttonPassengerClear_Click);
            // 
            // buttonPassengerExit
            // 
            this.buttonPassengerExit.Location = new System.Drawing.Point(160, 387);
            this.buttonPassengerExit.Name = "buttonPassengerExit";
            this.buttonPassengerExit.Size = new System.Drawing.Size(75, 23);
            this.buttonPassengerExit.TabIndex = 8;
            this.buttonPassengerExit.Text = "Exit";
            this.buttonPassengerExit.UseVisualStyleBackColor = true;
            this.buttonPassengerExit.Click += new System.EventHandler(this.buttonPassengerExit_Click);
            // 
            // buttonPassengerNext
            // 
            this.buttonPassengerNext.Location = new System.Drawing.Point(430, 251);
            this.buttonPassengerNext.Name = "buttonPassengerNext";
            this.buttonPassengerNext.Size = new System.Drawing.Size(75, 23);
            this.buttonPassengerNext.TabIndex = 9;
            this.buttonPassengerNext.Text = "Next";
            this.buttonPassengerNext.UseVisualStyleBackColor = true;
            this.buttonPassengerNext.Click += new System.EventHandler(this.buttonPassengerNext_Click);
            // 
            // labelPassengerDestination
            // 
            this.labelPassengerDestination.AutoSize = true;
            this.labelPassengerDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassengerDestination.Location = new System.Drawing.Point(156, 165);
            this.labelPassengerDestination.Name = "labelPassengerDestination";
            this.labelPassengerDestination.Size = new System.Drawing.Size(101, 20);
            this.labelPassengerDestination.TabIndex = 10;
            this.labelPassengerDestination.Text = "Destination";
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(336, 167);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(169, 20);
            this.textBoxDestination.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passenger1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.labelPassengerDestination);
            this.Controls.Add(this.buttonPassengerNext);
            this.Controls.Add(this.buttonPassengerExit);
            this.Controls.Add(this.buttonPassengerClear);
            this.Controls.Add(this.textBoxPassengerLocation);
            this.Controls.Add(this.textBoxPassengerPhone);
            this.Controls.Add(this.textBoxPassengerName);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelPassengerLocation);
            this.Controls.Add(this.labelPassengerName);
            this.Name = "passenger1";
            this.Text = "passenger";
            this.Load += new System.EventHandler(this.passenger1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPassengerName;
        private System.Windows.Forms.Label labelPassengerLocation;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPassengerName;
        private System.Windows.Forms.TextBox textBoxPassengerPhone;
        private System.Windows.Forms.TextBox textBoxPassengerLocation;
        private System.Windows.Forms.Button buttonPassengerClear;
        private System.Windows.Forms.Button buttonPassengerExit;
        private System.Windows.Forms.Button buttonPassengerNext;
        private System.Windows.Forms.Label labelPassengerDestination;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.Button button1;
    }
}