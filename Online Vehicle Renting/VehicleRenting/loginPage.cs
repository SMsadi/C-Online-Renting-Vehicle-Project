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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxUsername.Focus();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You really want to close the application", "Close window", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                Application.Exit();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    //MessageBox.Show(textBox1.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OHUHK3O\SQLEXPRESS;Initial Catalog=VSYS;Persist Security Info=True;User ID=sa;Password=tiger");
                    con.Open();
                    string id = textBoxUsername.Text;
                    string Password = textBoxPassword.Text;
                    SqlCommand cmd = new SqlCommand("select title from login where id=\'" + id + "\' and Password= \'" + Password + "\'", con);
                    string title = (string)cmd.ExecuteScalar();

                    cmd.CommandText = "select status from login where id=\'" + id + "\' and Password= \'" + Password + "\'";
                    string status = (string)cmd.ExecuteScalar();
                    con.Close();
                    if (title == "admin")
                    {
                        //MessageBox.Show("Login Successfully as admin");
                        this.Hide();
                        admin admin = new admin(textBoxUsername.Text, title);
                        admin.Show();
                    }
                    else if (title == "staff")
                    {
                        if (status == "inactive")
                        {
                            MessageBox.Show("Your account is inactive!\n" +
                                "Contact to Admin");
                            return;
                        }
                        //MessageBox.Show("Login Successfully as staff");
                        this.Hide();
                        staff form = new staff();//textBoxUsername.Text, "staff"
                        form.ShowDialog();
                    }
                    else if (title == "passenger")
                    {
                        if (status == "inactive")
                        {
                            MessageBox.Show("Your account is inactive!\n" +
                                "Contact to Employee");
                            return;
                        }
                        //MessageBox.Show("Login Successfully as passenger");
                         this.Hide();
                         passenger1 form = new passenger1();//textBoxUsername.Text, "passenger"
                        form.ShowDialog();
                    }
                    else if (title == "driver")
                    {
                        if (status == "inactive")
                        {
                            MessageBox.Show("Your account is inactive!\n" +
                                "Contact to Employee");
                            return;
                        }
                        this.Hide();
                        driver1 driver1 = new driver1(textBoxUsername.Text, "driver");//textBoxUsername.Text, "driver"
                        driver1.Show();
                    }
                    else if (title == null)
                    {
                        MessageBox.Show("Invalid ID or Password");
                        textBoxUsername.Focus();
                    }
                }
            }
            
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
