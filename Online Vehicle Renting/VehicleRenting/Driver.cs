using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace VehicleRenting
{
    class Driver
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Birthdate { get; set; }
        public string LicenseNo { get; set; }
        public string Phone { get; set; }

        public DataTable Select()
        {
            //Step 1: Database Connection
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=VSYS;User ID=sa;Password=tiger");

            DataTable dt = new DataTable();

            //Step 2: Writing SQL query

            string query = "Select * from driver";

            //Creating cmd using sql and connection string            

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.Fill(dt);

            return dt;
        }

        //Inserting data into database table
        public bool Insert(Driver d)
        {

            //creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1: Database Connection

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=VSYS;User ID=sa;Password=tiger");
            try
            {

                //Step 2: Writing SQL query

                string query = "Insert into driver (d_id,d_name,d_birthdate,license_no,d_phone)values(@d_id,@d_name,@d_birthdate,@license_no,@d_phone)";
                //Creating cmd using sql and connection string
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@d_id", d.ID);
                cmd.Parameters.AddWithValue("@d_name", d.Name);
                cmd.Parameters.AddWithValue("@d_birthdate", d.Birthdate);
                cmd.Parameters.AddWithValue("@license_no", d.LicenseNo);
                cmd.Parameters.AddWithValue("@d_phone", d.Phone);


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
        public bool Update(Driver d)
        {
            //creating a default return type and setting its value to false

            bool isSuccess = false;

            //Step 1: Database Connection
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=VSYS;User ID=sa;Password=tiger");
            try
            {


                //Step 2: Writing SQL query

                string query = "Insert into driver (d_id,d_name,d_birthdate,license_no,d_phone)values(@d_id,@d_name,@d_birthdate,@license_no,@d_phone)";
                //Creating cmd using sql and connection string
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@d_id", d.ID);
                cmd.Parameters.AddWithValue("@d_name", d.Name);
                cmd.Parameters.AddWithValue("@d_birthdate", d.Birthdate);
                cmd.Parameters.AddWithValue("@license_no", d.LicenseNo);
                cmd.Parameters.AddWithValue("@d_phone", d.Phone);

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
        public bool Delete(Driver d)
        {
            //creating a default return type and setting its value to false

            bool isSuccess = false;

            //Step 1: Database Connection
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=VSYS;Integrated Security=True");
            try
            {


                //Step 2: Writing SQL query

                string query = "Delete from driver where d_id=@d_id";
                //Creating cmd using sql and connection string
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@d_id", d.ID);

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
