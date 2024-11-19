using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VehicleRenting
{
    public partial class passenger2 : Form
    {
        StoreInfo si = new StoreInfo();
        public passenger2()
        {
            InitializeComponent();
        }
        public passenger2(StoreInfo si)
        {
            InitializeComponent();
            this.si = si;
        }
        private void checkedListBoxPrivateCar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void insertStoreInfo()
        {
            if (si.insert())
            {
                MessageBox.Show("Data inserted");
                new Form1().ShowDialog();
                this.Close();
            }
        }

        private void buttonPassengerSubmit_Click(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                si.vehicle = "Microbus";
                insertStoreInfo();
               // MessageBox.Show();
            }
            else if(radioButton3.Checked)
            {
                si.vehicle = "Minibus";
                insertStoreInfo();
            }
            else if(radioButton1.Checked)
            {
                si.vehicle = "Private car";
                insertStoreInfo();
            }
            else if(radioButton4.Checked)
            {
                si.vehicle = "Motor";
                insertStoreInfo();
            }
            else if (radioButton5.Checked)
            {
                si.vehicle = "Truck";
                insertStoreInfo();
            }
            else if (radioButton6.Checked)
            {
                si.vehicle = "Van";
                insertStoreInfo();
            }

            else { MessageBox.Show("Invalid"); }
           
           
            
            

        }

        private void buttonPassengerBack_Click(object sender, EventArgs e)
        {
            passenger1 psngr1 = new passenger1();
            this.Close();
            psngr1.Show();
        }

        private void passenger2_Load(object sender, EventArgs e)
        {
            label1.Text = si.name;
            label2.Text = si.location;
            label3.Text = si.destination;
            label4.Text = si.phone;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 Form1 = new Form1();
            Form1.Show();
        }
    }
}
