using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project_one
{
    internal class Volunteer
    {
        string connection = @"Data Source=(localdb)\MSSQLLocalDB;
      AttachDbFilename=C:\Users\fahim\source\repos\Project-one\Project Database.mdf;
      Integrated Security=True;
      Connect Timeout=30;
      TrustServerCertificate=True;
      Pooling=False";
        public int Id { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public DateTime? Dob { get; set; }
        public string Address { get; set; }
        public string Gmail { get; set; }
        public long NID { get; set; }
        public string Religion { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Skill1 { get; set; }
        public string Skill2 { get; set; }
        public string Gender { get; set; }

        public Volunteer() { }

        public int insert(Volunteer v)
        {
            int success = 0;
            SqlConnection sqc = new SqlConnection(connection);

            try
            {
               string q = "INSERT INTO Volunteer (V_Id, V_Name, V_PhoneNumber, V_DOB, V_Address, V_Gmail, V_NID, V_Religion, V_FatherName, V_MotherName, V_Skill1, V_Skill2, V_Gender, V_Password) VALUES (@Id, @Name, @PhoneNumber, @DOB, @Address, @Gmail, @NID, @Religion, @FatherName, @MotherName, @Skill1, @Skill2, @Gender, @Password)";



                sqc.Open();
                SqlCommand cmd = new SqlCommand(q, sqc);

                cmd.Parameters.AddWithValue("@Id", v.Id);
                cmd.Parameters.AddWithValue("@Name", v.Name);
                cmd.Parameters.Add("@PhoneNumber", SqlDbType.BigInt).Value = v.PhoneNumber;
                cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = v.Dob ?? (object)DBNull.Value;
                cmd.Parameters.AddWithValue("@Address", v.Address);
                cmd.Parameters.AddWithValue("@Gmail", v.Gmail);
                cmd.Parameters.Add("@NID", SqlDbType.BigInt).Value = v.NID;
                cmd.Parameters.AddWithValue("@Religion", v.Religion);
                cmd.Parameters.AddWithValue("@FatherName", v.FatherName);
                cmd.Parameters.AddWithValue("@MotherName", v.MotherName);
                cmd.Parameters.AddWithValue("@Skill1", (object)v.Skill1 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Skill2", (object)v.Skill2 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Gender", v.Gender);
                cmd.Parameters.AddWithValue("@Password", v.Password);

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    success = 1;
                }
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

        public bool UpdatePass(int volunteerId, string currentPassword, string newPassword)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                string query = @"UPDATE Volunteer
                             SET V_Password = @NewPass
                             WHERE V_Id = @VolId
                               AND V_Password = @CurrentPass";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NewPass", newPassword);
                    cmd.Parameters.AddWithValue("@VolId", volunteerId);
                    cmd.Parameters.AddWithValue("@CurrentPass", currentPassword);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
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

        public bool CheckValidation()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string query = @"SELECT COUNT(*) FROM Volunteer WHERE V_Id = @Id AND V_Password = @Password and V_Status = 'Active'";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", Id);
                        cmd.Parameters.AddWithValue("@Password", Password);

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
        public Volunteer ShowVolunteerDetails(int id)
        {
            string query = "SELECT * FROM Volunteer WHERE V_Id = @Id";

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

                    return new Volunteer
                    {
                        Id = Convert.ToInt32(row["V_Id"]),
                        Name = row["V_Name"].ToString(),
                        PhoneNumber = Convert.ToInt64(row["V_PhoneNumber"]),
                        Dob = row["V_DOB"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["V_DOB"]),
                        Address = row["V_Address"] == DBNull.Value ? null : row["V_Address"].ToString(),
                        Gmail = row["V_Gmail"].ToString(),
                        NID = Convert.ToInt64(row["V_NID"]),
                        FatherName = row["V_FatherName"] == DBNull.Value ? null : row["V_FatherName"].ToString(),
                        MotherName = row["V_MotherName"] == DBNull.Value ? null : row["V_MotherName"].ToString(),
                        Skill1 = row["V_Skill1"] == DBNull.Value ? null : row["V_Skill1"].ToString()
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
