using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Project_one
{
    internal class Admin
    {
        string connection = @"Data Source=(localdb)\MSSQLLocalDB;
                           Initial Catalog=Project-One-DB;
                           Integrated Security=True;
                           TrustServerCertificate=True";
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
        public string Dob { get; set; }
        public Admin() { }
        public Admin(int id, string name, long nId, string fatherName, string motherName, long phoneNumber, string gmail, string address, string religion, string maritalStatus, string gender, string bloodGroup)
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
            string query = "SELECT * FROM Admin WHERE Admin_Id = @ID";
            string connectionn = @"Data Source=(localdb)\MSSQLLocalDB;
                           Initial Catalog=Project-One-DB;
                           Integrated Security=True;
                           TrustServerCertificate=True";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionn))
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
                        Dob = row["Admin_Dob"] == DBNull.Value ? null : row["Admin_Dob"].ToString(),
                        BloodGroup = row["Admin_BloodGroup"].ToString()
                    };
                }
            }
            catch (Exception)
            {
                return null;
            }

        }

        public int UpdateAdmin(Admin ad)
        {
            string query = @"UPDATE Admin SET Admin_Name = @Name, Admin_NID = @NID, Admin_FatherName = @FatherName, Admin_MotherName = @MotherName, Admin_PhoneNumber = @PhoneNumber, Admin_Gmail = @Gmail,Admin_Address = @Address, Admin_Religion = @Religion, Admin_MaritalStatus = @MaritalStatus, Admin_Gender = @Gender, Admin_BloodGroup = @BloodGroup, Admin_Dob = @Dob WHERE Admin_Id = 1";
            try
            {
                using (SqlConnection sqc = new SqlConnection(connection))
                using (SqlCommand cmd = new SqlCommand(query, sqc))
                {
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 40).Value = ad.Name;
                    cmd.Parameters.Add("@NID", SqlDbType.BigInt).Value = ad.NID;
                    cmd.Parameters.Add("@FatherName", SqlDbType.NVarChar, 40).Value = (object)ad.FatherName ?? DBNull.Value;
                    cmd.Parameters.Add("@MotherName", SqlDbType.NVarChar, 40).Value = (object)ad.MotherName ?? DBNull.Value;
                    cmd.Parameters.Add("@PhoneNumber", SqlDbType.BigInt).Value = ad.PhoneNumber;
                    cmd.Parameters.Add("@Gmail", SqlDbType.NVarChar, 60).Value = ad.Gmail;
                    cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 200).Value = (object)ad.Address ?? DBNull.Value;
                    cmd.Parameters.Add("@Religion", SqlDbType.NVarChar, 20).Value = ad.Religion;
                    cmd.Parameters.Add("@MaritalStatus", SqlDbType.NVarChar, 20).Value = (object)ad.MaritalStatus ?? DBNull.Value;
                    cmd.Parameters.Add("@Gender", SqlDbType.NVarChar, 20).Value = ad.Gender;
                    cmd.Parameters.Add("@BloodGroup", SqlDbType.NVarChar, 2).Value = ad.BloodGroup;
                    cmd.Parameters.Add("@Dob", SqlDbType.Date).Value = string.IsNullOrWhiteSpace(ad.Dob) ? (object)DBNull.Value : DateTime.Parse(ad.Dob);
                    sqc.Open();
                    return cmd.ExecuteNonQuery();
                    sqc.Close();
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public DataTable ShowAllEmployees(Employee ee)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection sqc = new SqlConnection(connection))
                using (SqlDataAdapter sqd = new SqlDataAdapter("SELECT * FROM Employee", sqc))
                {
                    sqd.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees:\n" + ex.Message);
            }

            return dt;
        }

        public int UpdateEmployee(Employee ee)
        {
            string query = @"UPDATE Employee SET 
                        E_Name=@Name,
                        E_NickName=@NickName,
                        E_Designation=@Designation,
                        E_NID=@NID,
                        E_FatherName=@FatherName,
                        E_MotherName=@MotherName,
                        E_Number=@PhoneNumber,
                        E_Emergency_Number=@EmergencyNumber,
                        E_Gmail=@Gmail,
                        E_Address=@Address,
                        E_Parmanent_Address=@ParmanentAddress,
                        E_Religion=@Religion,
                        E_MaritalStatus=@MaritalStatus,
                        E_Gender=@Gender,
                        E_BloodGroup=@BloodGroup,
                        E_DOB=@Dob
                     WHERE E_Id=@Id";

            try
            {
                using (SqlConnection sqc = new SqlConnection(connection))
                using (SqlCommand cmd = new SqlCommand(query, sqc))
                {
                    cmd.Parameters.AddWithValue("@Id", ee.Id);
                    cmd.Parameters.AddWithValue("@Name", ee.Name);
                    cmd.Parameters.AddWithValue("@NickName", ee.NickName);
                    cmd.Parameters.AddWithValue("@Designation", ee.Designation);
                    cmd.Parameters.AddWithValue("@NID", ee.NID);
                    cmd.Parameters.AddWithValue("@FatherName", ee.FatherName);
                    cmd.Parameters.AddWithValue("@MotherName", ee.MotherName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", ee.PhoneNumber);
                    cmd.Parameters.AddWithValue("@EmergencyNumber", ee.EmergencyNumber);
                    cmd.Parameters.AddWithValue("@Gmail", ee.Gmail);
                    cmd.Parameters.AddWithValue("@Address", ee.Address);
                    cmd.Parameters.AddWithValue("@ParmanentAddress", ee.ParmanentAddress);
                    cmd.Parameters.AddWithValue("@Religion", ee.Religion);
                    cmd.Parameters.AddWithValue("@MaritalStatus", (object)ee.MaritalStatus ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Gender", ee.Gender);
                    cmd.Parameters.AddWithValue("@BloodGroup", ee.BloodGroup);
                    cmd.Parameters.AddWithValue("@Dob", ee.Dob);

                    sqc.Open();
                    return cmd.ExecuteNonQuery();
                    sqc.Close();
                }
            }
            catch
            {
                return 0;
            }
        }

        public int DeleteEmployee(Employee ee)
        {
            string query = "DELETE FROM Employee WHERE E_Id = @Id";
            try
            {
                using (SqlConnection sqc = new SqlConnection(connection))
                using (SqlCommand cmd = new SqlCommand(query, sqc))
                {
                    cmd.Parameters.AddWithValue("@Id", ee.Id);
                    sqc.Open();
                    return cmd.ExecuteNonQuery();
                    sqc.Close();
                }
            }
            catch
            {
                return 0;
            }
        }

        public DataTable SearchEmployees(string search)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();
                    string query = @"SELECT * FROM Employee  WHERE CAST(E_Id AS NVARCHAR) LIKE @search OR E_Name LIKE @search OR
                    CAST(E_Number AS NVARCHAR) LIKE @search OR
                    E_Gmail LIKE @search OR
                    E_Designation LIKE @search";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return dt;
        }

    }
}
