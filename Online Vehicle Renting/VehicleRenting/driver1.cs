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
    public partial class driver1 : Form
    {
        private string id;
        private string title;
        public driver1()
        {
            InitializeComponent();
        }

        public driver1(string id, string title)
        {
            InitializeComponent();
            this.id = id;
            this.title = title;
        }
        private void buttonMyAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            driverAccount driver_account = new driverAccount(id,title);
            driver_account.ShowDialog();
        }

        private void buttonDriverExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You really want to close the application", "Close window", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                Application.Exit();
            }
        }

        private void driver1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=VSYS;User ID=sa;Password=tiger");
            conn.Open();
            SqlCommand cmd = new SqlCommand("", conn);
            cmd.CommandText = "select * from storeInfo";
            SqlDataAdapter sqa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqa.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 Form1 = new Form1();
            Form1.Show();
        }
    }
}
