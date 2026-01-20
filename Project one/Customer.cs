using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_one
{
    internal class Customer
    {
        string connection = @"Data Source=(localdb)\MSSQLLocalDB;
      AttachDbFilename=C:\Users\fahim\source\repos\Project-one\Project Database.mdf;
      Integrated Security=True;
      Connect Timeout=30;
      TrustServerCertificate=True;
      Pooling=False";
        public int C_Id { get; set; }
        public string C_Name { get; set; }
        public long C_PhoneNumber { get; set; }
        public DateTime? C_DOB { get; set; }
        public string C_Address { get; set; }
        public string C_Email { get; set; }
        public long C_NID { get; set; }
        public string C_Gender { get; set; }
        public string C_Company { get; set; }
        public string C_Position { get; set; }
        public string C_Password { get; set; }
        public string C_Status { get; set; }
        public void InsertCustomer()
        {
            string query = @"INSERT INTO Customer 
                        (C_Id, C_Name, C_PhoneNumber, C_DOB, C_Address, C_Email, C_NID, C_Gender, C_Company, C_Position, C_Password, C_Status)
                        VALUES 
                        (@C_Id, @C_Name, @C_PhoneNumber, @C_DOB, @C_Address, @C_Email, @C_NID, @C_Gender, @C_Company, @C_Position, @C_Password, @C_Status)";

            using (SqlConnection conn = new SqlConnection(connection))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@C_Id", C_Id);
                cmd.Parameters.AddWithValue("@C_Name", C_Name);
                cmd.Parameters.AddWithValue("@C_PhoneNumber", C_PhoneNumber);
                cmd.Parameters.AddWithValue("@C_DOB", (object)C_DOB ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@C_Address", (object)C_Address ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@C_Email", C_Email);
                cmd.Parameters.AddWithValue("@C_NID", C_NID);
                cmd.Parameters.AddWithValue("@C_Gender", C_Gender);
                cmd.Parameters.AddWithValue("@C_Company", (object)C_Company ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@C_Position", (object)C_Position ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@C_Password", C_Password);
                cmd.Parameters.AddWithValue("@C_Status", C_Status);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable SearchRules(string searchText)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM Rules 
                                                 WHERE CAST([No] AS NVARCHAR) LIKE @search 
                                                 OR Rules LIKE @search ORDER BY [No]", con))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching rules:\n" + ex.Message);
            }

            return dt;
        }
        public DataTable ShowRules()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Rules ORDER BY [No]", con))
                {
                    da.Fill(dt);
                }
            }
            catch (Exception)
            {
            }

            return dt;
        }

        public bool UpdatePass(int customerId, string currentPassword, string newPassword)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();

                    string query = @"UPDATE Customer
                             SET C_Password = @NewPass
                             WHERE C_Id = @CustomerId
                               AND C_Password = @CurrentPass";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NewPass", newPassword);
                        cmd.Parameters.AddWithValue("@CustomerId", customerId);
                        cmd.Parameters.AddWithValue("@CurrentPass", currentPassword);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
        public bool CheckValidation()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string query = @"SELECT COUNT(*) FROM Customer WHERE C_Id = @Id AND C_Password = @Password and C_Status='Active'";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", C_Id);
                        cmd.Parameters.AddWithValue("@Password", C_Password);

                        con.Open();
                        int count = (int)cmd.ExecuteScalar();
                        return count == 1;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public  Customer showCustomerDetails(int id)
        {
            string query = "SELECT * FROM Customer WHERE C_Id = @Id";

            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    da.SelectCommand.Parameters.AddWithValue("@Id", id);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                        return null;

                    DataRow row = dt.Rows[0];

                    return new Customer
                    {
                        C_Id = Convert.ToInt32(row["C_Id"]),
                        C_Name = row["C_Name"].ToString(),
                        C_NID = Convert.ToInt64(row["C_NID"]),
                        C_Company = row["C_Company"] == DBNull.Value ? null : row["C_Company"].ToString(),
                        C_Position = row["C_Position"] == DBNull.Value ? null : row["C_Position"].ToString(),
                        C_PhoneNumber = Convert.ToInt64(row["C_PhoneNumber"]),
                        C_Email = row["C_Email"].ToString(),
                        C_Address = row["C_Address"] == DBNull.Value ? null : row["C_Address"].ToString(),
                        C_Gender = row["C_Gender"].ToString(),
                        C_DOB = row["C_DOB"] == DBNull.Value
                                    ? (DateTime?)null
                                    : Convert.ToDateTime(row["C_DOB"])
                    };
                }
            }
            catch
            {
                return null;
            }
        }

    }
}

