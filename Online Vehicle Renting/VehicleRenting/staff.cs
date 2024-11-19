using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRenting
{
    public partial class staff : Form
    {
        private string id = "";
        private string title = "";
        public staff()
        {
            InitializeComponent();
        }
        public staff(string id,string title)
        {
            this.id = id;
            this.title = title;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You really want to close the application", "Close window", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                Application.Exit();
            }
        }

        private void buttonManageDriver_Click(object sender, EventArgs e)
        {
            this.Hide();
            manageDriver manageDriver = new manageDriver("staff");
            manageDriver.Show();
        }

        private void buttonManagePassenger_Click(object sender, EventArgs e)
        {
            this.Hide();
            managePassenger managePassenger = new managePassenger();
            managePassenger.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 Form1 = new Form1();
            Form1.Show();
        }
    }
}
