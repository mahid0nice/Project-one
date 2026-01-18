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
    internal class Admin
    {
        string connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project-One-DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
        public int Id { get; set; }
        public string Name { get; set; }
        public long NID { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public long PhoneNumber { get; set; }
        public string Gmail { get; set; }
        public string Address { get; set; }
        public string Religion { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public Admin() { }
        public Admin(int id,string name, long nId,string fatherName,string motherName, long phoneNumber,string gmail,string address,string religion,string maritalStatus,string gender,string bloodGroup)
        {
            Id = id;
            Name = name;
            NID = nId;
            FatherName = fatherName;
            MotherName = motherName;
            PhoneNumber = phoneNumber;
            Gmail = gmail;
            Address = address;
            Religion = religion;
            MaritalStatus = maritalStatus;
            Gender = gender;
            BloodGroup = bloodGroup;
        }

        public static Admin showAdminDetails(int ID)
        {
            string connection = @"Data Source=(localdb)\MSSQLLocalDB;
                           Initial Catalog=Project-One-DB;
                           Integrated Security=True;
                           TrustServerCertificate=True";

            string query = "SELECT * FROM Admin WHERE Admin_Id = @ID";

            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    da.SelectCommand.Parameters.AddWithValue("@ID", ID);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                        return null;

                    DataRow row = dt.Rows[0];

                    return new Admin
                    {
                        Id = Convert.ToInt32(row["Admin_Id"]),
                        Name = row["Admin_Name"].ToString(),
                        NID = Convert.ToInt64(row["Admin_NID"]),
                        FatherName = row["Admin_FatherName"] == DBNull.Value ? null : row["Admin_FatherName"].ToString(),
                        MotherName = row["Admin_MotherName"] == DBNull.Value ? null : row["Admin_MotherName"].ToString(),
                        PhoneNumber = Convert.ToInt64(row["Admin_PhoneNumber"]),
                        Gmail = row["Admin_Gmail"].ToString(),
                        Address = row["Admin_Address"] == DBNull.Value ? null : row["Admin_Address"].ToString(),
                        Religion = row["Admin_Religion"].ToString(),
                        MaritalStatus = row["Admin_MaritalStatus"] == DBNull.Value ? null : row["Admin_MaritalStatus"].ToString(),
                        Gender = row["Admin_Gender"].ToString(),
                        BloodGroup = row["Admin_BloodGroup"].ToString()
                    };
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error occurred.\n" + ex.Message);
                return null;
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Data type mismatch while reading admin data.\n" + ex.Message);
                return null;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Required admin data is missing.\n" + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error occurred.\n" + ex.Message);
                return null;
            }
        }

    }
}
