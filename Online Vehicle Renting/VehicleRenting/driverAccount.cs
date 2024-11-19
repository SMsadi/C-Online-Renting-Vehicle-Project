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
    public partial class driverAccount : Form
    {
        string id;
        string title;


        public driverAccount()
        {
            InitializeComponent();
        }
        public driverAccount(string id, string title)
        {
            this.id = id;
            this.title = title;
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You really want to close the application", "Close window", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                Application.Exit();
            }
        }

        private void driverAccount_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=VSYS;User ID=sa;Password=tiger";
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select name from login where id=\'" + id + "\'";
            string data = (string)cmd.ExecuteScalar();
            textBox2.Text = data;// Name

            textBox1.Text = id;

            

            //cmd.CommandText = "select mobile from login where id=\'" + id + "\'";
            //int mobile = (int)cmd.ExecuteScalar();
            //textBox5.Text = mobile.ToString();// age


            cmd.CommandText = "select email from login where id=\'" + id + "\'";
            data = (string)cmd.ExecuteScalar();
            textBox3.Text = data;// email

            cmd.CommandText = "select title from login where id=\'" + id + "\'";
            data = (string)cmd.ExecuteScalar();
            textBox5.Text = data;// email
           

            cmd.CommandText = "select gender from login where id=\'" + id + "\'";
            data = (string)cmd.ExecuteScalar();
            textBox4.Text = data;


            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            driver1 driver1 = new driver1();
            driver1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 Form1 = new Form1();
            Form1.Show();
        }
    }
}
