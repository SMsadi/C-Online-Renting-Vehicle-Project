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
    public partial class manageStaff : Form
    {
        StaffCS s = new StaffCS();
        public manageStaff()
        {
            InitializeComponent();
        }

        private void manageEmployee_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=VSYS;User ID=sa;Password=tiger");
            conn.Open();
            SqlCommand cmd = new SqlCommand("", conn);
            cmd.CommandText = "select * from staff";
            SqlDataAdapter sqa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqa.Fill(dt);
            dataGridViewStaff.DataSource = dt;
            conn.Close();

        }

        private void buttonAddStaff_Click(object sender, EventArgs e)
        {

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
            this.Close();
            admin admin = new admin();
            admin.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=VSYS;User ID=sa;Password=tiger");



            //Step 2: Writing SQL query

            string query = "Select * from staff where s_name like '%" + textBox1.Text + "%' ";


            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewStaff.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s.ID = textBox2.Text;
            s.Name = textBox3.Text;
            s.Birthdate = textBox4.Text;
            s.Address = textBox5.Text;
            s.Phone = textBox6.Text;
            s.Salary = textBox7.Text;
            s.Bonus = textBox8.Text;
            s.Email = textBox9.Text;


            bool success = s.Insert(s);

            if (success == true)
            {
                MessageBox.Show("Successfully data Inserted!");
                //Clear();
            }
            else
            {
                MessageBox.Show("Data Insertion failed!");
                MessageBox.Show(s.message);
            }


            DataTable dt = s.Select();
            dataGridViewStaff.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            s.ID = textBox2.Text;

            bool success = s.Delete(s);

            if (success == true)
            {
                MessageBox.Show("Successfully data deleted!");
                //Clear();
            }
            else
            {
                MessageBox.Show("Data Deletion failed!");
            }


            DataTable dt = s.Select();
            dataGridViewStaff.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            s.ID = textBox2.Text;
            s.Name = textBox3.Text;
            s.Birthdate = textBox4.Text;
            s.Address = textBox5.Text;
            s.Phone = textBox6.Text;
            s.Salary = textBox7.Text;
            s.Bonus = textBox8.Text;
            s.Email = textBox9.Text;


            bool success = s.Update(s);

            if (success == true)
            {
                MessageBox.Show("Successfully data Updated!");
                //Clear();
            }
            else
            {
                MessageBox.Show("Data Update failed!");
            }


            DataTable dt = s.Select();
            dataGridViewStaff.DataSource = dt;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 Form1 = new Form1();
            Form1.Show();
        }
    }
}
