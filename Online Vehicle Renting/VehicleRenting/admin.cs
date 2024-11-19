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
    public partial class admin : Form
    {
        string id;
        string title;
        public admin()
        {
            InitializeComponent();
        }
        public admin(string id, string title)
        {
            InitializeComponent();
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

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void buttonManageDriver_Click(object sender, EventArgs e)
        {
            this.Hide();
            manageDriver manageDriver = new manageDriver("admin");
            manageDriver.Show();
        }

        private void buttonManageEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            manageStaff manageStaff = new manageStaff();
            manageStaff.Show();
        }

        private void buttonMyAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminAccount adminAccount = new adminAccount(id, title);
            adminAccount.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 Form1 = new Form1();
            Form1.Show();
        }
    }
}
