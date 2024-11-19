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
    public partial class passenger1 : Form
    {
        private string id = "";
        private string title = "";
        public passenger1()
        {
            InitializeComponent();
        }

        public passenger1(string id, string title)
        {
            this.id = id;
            this.title = title;
        }

        private void buttonPassengerExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You really want to close the application", "Close window", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                Application.Exit();
            }
        }

        private void buttonPassengerClear_Click(object sender, EventArgs e)
        {
            textBoxPassengerName.Clear();
            textBoxPassengerLocation.Clear();
            textBoxPassengerPhone.Clear();
            textBoxDestination.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void passenger1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPassengerNext_Click(object sender, EventArgs e)
        {

            if (textBoxPassengerName.Text !="" && textBoxPassengerLocation.Text != "" && textBoxPassengerPhone.Text != "" && textBoxDestination.Text != "")
            {
                StoreInfo si = new StoreInfo();
                si.name = textBoxPassengerName.Text;
                si.location = textBoxPassengerLocation.Text;
                si.destination = textBoxDestination.Text;
                si.phone = textBoxPassengerPhone.Text;
                
                this.Hide();
                passenger2 Psngr2 = new passenger2(si);
                Psngr2.Show();
            }
            else { MessageBox.Show("Please fill up the form"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 Form1 = new Form1();
            Form1.Show();
        }
    }
}
