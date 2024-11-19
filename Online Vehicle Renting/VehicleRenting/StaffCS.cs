using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace VehicleRenting
{
    class StaffCS
    {
        public string message;
        public string ID { get; set; }
        public string Name { get; set; }
        public string Birthdate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Salary { get; set; }
        public string Bonus { get; set; }
        public string Email { get; set; }


        public DataTable Select()
        {
            //Step 1: Database Connection
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=VSYS;User ID=sa;Password=tiger");

            DataTable dt = new DataTable();

            //Step 2: Writing SQL query

            string query = "Select * from staff";

            //Creating cmd using sql and connection string            

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.Fill(dt);

            return dt;
        }

        //Inserting data into database table
        public bool Insert(StaffCS s)
        {

            //creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1: Database Connection

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=VSYS;User ID=sa;Password=tiger");
            try
            {

                //Step 2: Writing SQL query

                string query = "Insert into staff (s_id,s_name,s_birthdate,s_address,s_phone,s_salary,s_bonus,s_email)values(@s_id,@s_name,@s_birthdate,@s_address,@s_phone,@s_salary,@s_bonus,@s_email)";
                //Creating cmd using sql and connection string
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@s_id", s.ID);
                cmd.Parameters.AddWithValue("@s_name", s.Name);
                cmd.Parameters.AddWithValue("@s_birthdate", s.Birthdate);
                cmd.Parameters.AddWithValue("@s_address", s.Address);
                cmd.Parameters.AddWithValue("@s_phone", s.Phone);
                cmd.Parameters.AddWithValue("@s_salary", s.Salary);
                cmd.Parameters.AddWithValue("@s_bonus", s.Bonus);
                cmd.Parameters.AddWithValue("@s_email", s.Email);
                Console.WriteLine(cmd.CommandText);
                message = cmd.CommandText;
                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                    }
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }

        //Updating data into database table
        public bool Update(StaffCS s)
        {
            //creating a default return type and setting its value to false

            bool isSuccess = false;

            //Step 1: Database Connection
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=VSYS;User ID=sa;Password=tiger");
            try
            {


                //Step 2: Writing SQL query

                string query = "Insert into staff (s_id,s_name,s_birthdate,s_address,s_phone,s_salary,s_bonus,s_email)values(@s_id,@s_name,@s_birthdate,@s_address,@s_phone,@s_salary,@s_bonus,@s_email)";
                //Creating cmd using sql and connection string
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@s_id", s.ID);
                cmd.Parameters.AddWithValue("@s_name", s.Name);
                cmd.Parameters.AddWithValue("@s_birthdate", s.Birthdate);
                cmd.Parameters.AddWithValue("@s_address", s.Address);
                cmd.Parameters.AddWithValue("@s_phone", s.Phone);
                cmd.Parameters.AddWithValue("@s_salary", s.Salary);
                cmd.Parameters.AddWithValue("@s_bonus", s.Bonus);
                cmd.Parameters.AddWithValue("@s_email", s.Email);

                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                    }
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }

        //Deleting data into database table
        public bool Delete(StaffCS s)
        {
            //creating a default return type and setting its value to false

            bool isSuccess = false;

            //Step 1: Database Connection
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=VSYS;User ID=sa;Password=tiger");
            try
            {


                //Step 2: Writing SQL query

                string query = "Delete from staff where s_id=@s_id";
                //Creating cmd using sql and connection string
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@s_id", s.ID);

                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                    }
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }
    }
}
