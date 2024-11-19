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
    public partial class managePassenger : Form
    {
        public managePassenger()
        {
            InitializeComponent();
        }

        private void managePassenger_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=VSYS;User ID=sa;Password=tiger");
            conn.Open();
            SqlCommand cmd = new SqlCommand("", conn);
            cmd.CommandText = "select * from passenger";
            SqlDataAdapter sqa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqa.Fill(dt);
            dataGridViewDriver.DataSource = dt;
            conn.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            staff staff = new staff();
            staff.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=VSYS;User ID=sa;Password=tiger");



            //Step 2: Writing SQL query

            string query = "Select * from passenger where p_name like '%" + textBox1.Text + "%' ";


            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
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
