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
    public partial class manageDriver : Form
    {
        Driver d = new Driver();
        string person;
        public manageDriver(string person="")
        {
            InitializeComponent();
            this.person = person;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You really want to close the application", "Close window", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(person=="admin")
            {
                this.Close();
                admin admin = new admin();
                admin.Show();
            }
            else if(person=="staff")
            {
                this.Close();
                staff staff = new staff();
                staff.Show();
            }
  

        }

        private void dataGridViewDriver_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void manageDriver_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=VSYS;User ID=sa;Password=tiger");
            conn.Open();
            SqlCommand cmd = new SqlCommand("", conn);
            cmd.CommandText = "select * from driver";
            SqlDataAdapter sqa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqa.Fill(dt);
            dataGridViewDriver.DataSource = dt;
            conn.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=VSYS;User ID=sa;Password=tiger");



            //Step 2: Writing SQL query

            string query = "Select * from driver where d_name like '%" + textBoxSearch.Text + "%' ";


            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewDriver.DataSource = dt;
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            //get the student ID from the input field

            d.ID = textBox1.Text;

            bool success = d.Delete(d);

            if (success == true)
            {
                MessageBox.Show("Successfully data deleted!");
                //Clear();
            }
            else
            {
                MessageBox.Show("Data Deletion failed!");
            }


            DataTable dt = d.Select();
            dataGridViewDriver.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=VSYS;User ID=sa;Password=tiger");
            d.ID = textBox1.Text;
            d.Name = textBox2.Text;
            d.Birthdate = textBox3.Text;
            d.LicenseNo = textBox4.Text;
            d.Phone = textBox5.Text;


            bool success = d.Insert(d);

            if (success == true)
            {
                MessageBox.Show("Successfully data Inserted!");
                //Clear();
            }
            else
            {
                MessageBox.Show("Data Insertion failed!");
            }


            DataTable dt = d.Select();
            dataGridViewDriver.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            d.ID = textBox1.Text;
            d.Name = textBox2.Text;
            d.Birthdate = textBox3.Text;
            d.LicenseNo = textBox4.Text;
            d.Phone = textBox5.Text;

            bool success = d.Update(d);

            if (success == true)
            {
                MessageBox.Show("Successfully data Updated!");
                //Clear();
            }
            else
            {
                MessageBox.Show("Data Update failed!");
            }


            DataTable dt = d.Select();
            dataGridViewDriver.DataSource = dt;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 Form1 = new Form1();
            Form1.Show();
        }
    }
}
