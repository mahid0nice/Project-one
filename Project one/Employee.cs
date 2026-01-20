using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_one
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string Designation { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public long NID { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public long PhoneNumber { get; set; }
        public long EmergencyNumber { get; set; }
        public string Gmail { get; set; }
        public string Address { get; set; }
        public string ParmanentAddress { get; set; }
        public string Religion { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public DateTime? Dob { get; set; }

        public Employee() { }
        string connection = @"Data Source=(localdb)\MSSQLLocalDB;
      AttachDbFilename=C:\Users\fahim\source\repos\Project-one\Project Database.mdf;
      Integrated Security=True;
      Connect Timeout=30;
      TrustServerCertificate=True;
      Pooling=False";
        public Employee(int id, string name, long nId, string fatherName, string motherName, long phoneNumber, string gmail, string address, string religion, string maritalStatus, string gender, string bloodGroup)
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

        public int insert(Employee ee)
        {
            int success = 0;
            SqlConnection sqc = new SqlConnection(connection);

            try
            {
                string q = @"INSERT INTO Employee (
                                E_Id, E_Name, E_NickName, E_Designation, E_NID, E_FatherName, E_MotherName,
                                E_Number, E_Emergency_Number, E_Gmail, E_Address, E_Parmanent_Address,
                                E_Religion, E_MaritalStatus, E_Gender, E_DOB, E_BloodGroup
                            ) VALUES (
                                @Id, @Name, @NickName, @Designation, @NID, @FatherName, @MotherName,
                                @Number, @EmergencyNumber, @Gmail, @Address, @ParmanentAddress,
                                @Religion, @MaritalStatus, @Gender, @DOB, @BloodGroup
                            )";

                sqc.Open();
                SqlCommand cmd = new SqlCommand(q, sqc);

                cmd.Parameters.AddWithValue("@Id", ee.Id);
                cmd.Parameters.AddWithValue("@Name", ee.Name);
                cmd.Parameters.AddWithValue("@NickName", ee.NickName);
                cmd.Parameters.AddWithValue("@Designation", ee.Designation);
                cmd.Parameters.Add("@NID", SqlDbType.BigInt).Value = ee.NID;
                cmd.Parameters.AddWithValue("@FatherName", ee.FatherName);
                cmd.Parameters.AddWithValue("@MotherName", ee.MotherName);
                cmd.Parameters.Add("@Number", SqlDbType.BigInt).Value = ee.PhoneNumber;
                cmd.Parameters.Add("@EmergencyNumber", SqlDbType.BigInt).Value = ee.EmergencyNumber;
                cmd.Parameters.AddWithValue("@Gmail", ee.Gmail);
                cmd.Parameters.AddWithValue("@Address", ee.Address);
                cmd.Parameters.AddWithValue("@ParmanentAddress", ee.ParmanentAddress);
                cmd.Parameters.AddWithValue("@Religion", ee.Religion);
                cmd.Parameters.AddWithValue("@MaritalStatus", ee.MaritalStatus);
                cmd.Parameters.AddWithValue("@Gender", ee.Gender);
                cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = ee.Dob;
                cmd.Parameters.AddWithValue("@BloodGroup", ee.BloodGroup);

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

        public bool CheckValidation()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string query = @"
                SELECT COUNT(*)
                FROM Employee_Log_in E1
                INNER JOIN Employee E2 ON E1.E_Id = E2.E_Id
                WHERE E1.E_Id = @EmpId
                  AND E1.E_Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@EmpId", Id);
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

        public Employee GetEmployeeById(int id)
        {
            string query = "SELECT * FROM Employee WHERE E_Id = @ID";

            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return null;

                        Employee emp = new Employee();

                        emp.Id = Convert.ToInt32(reader["E_Id"]);
                        emp.Name = reader["E_Name"].ToString();
                        emp.NickName = reader["E_NickName"] == DBNull.Value ? null : reader["E_NickName"].ToString();
                        emp.Designation = reader["E_Designation"].ToString();
                        emp.NID = Convert.ToInt64(reader["E_NID"]);
                        emp.FatherName = reader["E_FatherName"] == DBNull.Value ? null : reader["E_FatherName"].ToString();
                        emp.MotherName = reader["E_MotherName"] == DBNull.Value ? null : reader["E_MotherName"].ToString();
                        emp.PhoneNumber = Convert.ToInt64(reader["E_Number"]);
                        emp.EmergencyNumber = reader["E_Emergency_Number"] == DBNull.Value ? 0 : Convert.ToInt64(reader["E_Emergency_Number"]);
                        emp.Gmail = reader["E_Gmail"].ToString();
                        emp.Address = reader["E_Address"] == DBNull.Value ? null : reader["E_Address"].ToString();
                        emp.ParmanentAddress = reader["E_Parmanent_Address"] == DBNull.Value ? null : reader["E_Parmanent_Address"].ToString();
                        emp.Religion = reader["E_Religion"].ToString();
                        emp.MaritalStatus = reader["E_MaritalStatus"] == DBNull.Value ? null : reader["E_MaritalStatus"].ToString();
                        emp.Gender = reader["E_Gender"].ToString();
                        emp.BloodGroup = reader["E_BloodGroup"].ToString();
                        emp.Dob = reader["E_DOB"] == DBNull.Value ? null : (DateTime?)reader["E_DOB"];

                        return emp;
                    }
                }
            }
            catch
            {
                return null;
            }
        }

        public int UpdateEmployee(Employee emp)
        {
            string query = @"
        UPDATE Employee 
        SET 
            E_Name = @Name,
            E_NID = @NID,
            E_FatherName = @FatherName,
            E_MotherName = @MotherName,
            E_Number = @PhoneNumber,
            E_Gmail = @Gmail,
            E_Address = @Address,
            E_MaritalStatus = @MaritalStatus,
            E_Gender = @Gender,
            E_BloodGroup = @BloodGroup,
            E_DOB = @Dob
        WHERE E_Id = @Id";

            try
            {
                using (SqlConnection sqc = new SqlConnection(connection))
                using (SqlCommand cmd = new SqlCommand(query, sqc))
                {
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = emp.Id;
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 100).Value = emp.Name;
                    cmd.Parameters.Add("@NID", SqlDbType.BigInt).Value = emp.NID;
                    cmd.Parameters.Add("@FatherName", SqlDbType.NVarChar, 50).Value = (object)emp.FatherName ?? DBNull.Value;
                    cmd.Parameters.Add("@MotherName", SqlDbType.NVarChar, 50).Value = (object)emp.MotherName ?? DBNull.Value;
                    cmd.Parameters.Add("@PhoneNumber", SqlDbType.BigInt).Value = emp.PhoneNumber;
                    cmd.Parameters.Add("@Gmail", SqlDbType.NVarChar, 60).Value = emp.Gmail;
                    cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 200).Value = (object)emp.Address ?? DBNull.Value;
                    cmd.Parameters.Add("@MaritalStatus", SqlDbType.NVarChar, 20).Value = (object)emp.MaritalStatus ?? DBNull.Value;
                    cmd.Parameters.Add("@Gender", SqlDbType.NVarChar, 20).Value = emp.Gender;
                    cmd.Parameters.Add("@BloodGroup", SqlDbType.NVarChar, 3).Value = emp.BloodGroup;
                    cmd.Parameters.Add("@Dob", SqlDbType.Date).Value = emp.Dob.HasValue ? (object)emp.Dob.Value : DBNull.Value;

                    sqc.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating employee: " + ex.Message);
                return 0;
            }
        }

    }
}