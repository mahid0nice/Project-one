using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_one
{
    internal class Customer
    {
       internal string connection = @"Data Source=(localdb)\MSSQLLocalDB;
      AttachDbFilename=C:\Users\fahim\source\repos\Project-one\Project Database.mdf;
      Integrated Security=True;
      Connect Timeout=30;
      TrustServerCertificate=True;
      Pooling=False";
        public int Id { get; set; }
        public string Name { get; set; }
        public long Phone { get; set; }
        public DateTime? Dob { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public long Nid { get; set; }
        public string Gender { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string Password { get; set; }

        public int InsertCustomer(Customer c)
        {
            int success = 0;
            SqlConnection sqc = new SqlConnection(connection);

            try
            {
                string query = @"INSERT INTO Customer 
                        (C_Id, C_Name, C_PhoneNumber, C_DOB, C_Address, C_Email, C_NID, C_Gender, C_Company, C_Position, C_Password) 
                        VALUES 
                        (@Id, @Name, @PhoneNumber, @DOB, @Address, @Email, @Nid, @Gender, @Company, @Position, @Password)";

                sqc.Open();
                SqlCommand cmd = new SqlCommand(query, sqc);

                cmd.Parameters.AddWithValue("@Id", c.Id);
                cmd.Parameters.AddWithValue("@Name", c.Name);
                cmd.Parameters.Add("@PhoneNumber", SqlDbType.BigInt).Value = c.Phone;
                cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = c.Dob ?? (object)DBNull.Value;
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Email", c.Email);
                cmd.Parameters.Add("@Nid", SqlDbType.BigInt).Value = c.Nid;
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@Company", c.Company ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Position", c.Position ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Password", c.Password);

                int row = cmd.ExecuteNonQuery();
                if (row > 0) success = 1;
            }
            catch (SqlException)
            {
                return 2;
            }
            catch (InvalidCastException)
            {
                return 3;
            }
            catch (NullReferenceException)
            {
                return 4;
            }
            catch (Exception)
            {
                return 5;
            }
            finally
            {
                sqc.Close();
            }
            return success;
        }
    }
}
