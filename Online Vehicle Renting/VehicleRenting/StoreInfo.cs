using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace VehicleRenting
{
   public class StoreInfo
    {
        public string name;
        public string location;
        public string destination;
        public string phone;
        public string vehicle;

        public bool insert()
        {
            //creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1: Database Connection

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OHUHK3O\\SQLEXPRESS;Initial Catalog=VSYS;User ID=sa;Password=tiger");
            try
            {

                //Step 2: Writing SQL query

                string query = "Insert into storeinfo (name,location,destination,phone,vehicle)values(@name,@location,@destination,@phone,@vehicle)";
                //Creating cmd using sql and connection string
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", this.name);
                cmd.Parameters.AddWithValue("@location", this.location);
                cmd.Parameters.AddWithValue("@destination", this.destination);
                cmd.Parameters.AddWithValue("@phone", this.phone);
                cmd.Parameters.AddWithValue("@vehicle", this.vehicle);
                
                
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
