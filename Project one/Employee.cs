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
                string q2 = @"INSERT INTO Employee_Log_in (E_Id, E_Password) VALUES (@Id, '@@@@')";

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
                    SqlCommand cmd2 = new SqlCommand(q2, sqc);
                    cmd2.ExecuteNonQuery();

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

        public int UpdateVolunteer(Volunteer v)
        {
            string query = @"UPDATE Volunteer SET V_Name=@Name, V_PhoneNumber=@Phone, V_DOB=@Dob,
                        V_Address=@Address, V_Gmail=@Gmail, V_NID=@NID, V_Religion=@Religion, V_FatherName=@Father,
                        V_MotherName=@Mother, V_Skill1=@Skill1, V_Skill2=@Skill2,
                        V_Gender=@Gender WHERE V_Id=@Id";

            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", v.Id);
                    cmd.Parameters.AddWithValue("@Name", v.Name);
                    cmd.Parameters.AddWithValue("@Phone", v.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Dob", v.Dob);
                    cmd.Parameters.AddWithValue("@Address", v.Address);
                    cmd.Parameters.AddWithValue("@Gmail", v.Gmail);
                    cmd.Parameters.AddWithValue("@NID", v.NID);
                    cmd.Parameters.AddWithValue("@Religion", v.Religion);
                    cmd.Parameters.AddWithValue("@Father", v.FatherName);
                    cmd.Parameters.AddWithValue("@Mother", v.MotherName);
                    cmd.Parameters.AddWithValue("@Skill1", v.Skill1);
                    cmd.Parameters.AddWithValue("@Skill2", (object)v.Skill2 ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Gender", v.Gender);

                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                return 0;
            }
        }
        public int DeleteVolunteer(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                using (SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Volunteer WHERE V_Id=@Id", con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                return 0;
            }
        }
        public DataTable SearchVolunteers(string search)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string query = @"SELECT V_Id, V_Name, V_PhoneNumber, V_DOB, V_Address, V_Gmail, V_NID, V_Religion, V_FatherName, V_MotherName, V_Skill1, V_Skill2, V_Gender
                                         FROM Volunteer WHERE V_Status = 'Active' AND (
                                         CAST(V_Id AS NVARCHAR) LIKE @search
                                         OR V_Name LIKE @search
                                         OR CAST(V_PhoneNumber AS NVARCHAR) LIKE @search
                                         OR V_Gmail LIKE @search)";

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
                MessageBox.Show("Error searching volunteers:\n" + ex.Message);
            }
            return dt;
        }

        public DataTable ShowAllVolunteers()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                using (SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT V_Id, V_Name, V_PhoneNumber, V_DOB, V_Address, V_Gmail, V_NID, V_Religion, V_FatherName, V_MotherName,
                V_Skill1, V_Skill2, V_Gender FROM Volunteer where V_Status = 'Active'", con))
                {
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading volunteers:\n" + ex.Message);
            }
            return dt;
        }

        public DataTable ShowAllInactiveVolunteers()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                using (SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT 
                V_Id, V_Name, V_PhoneNumber, V_DOB, V_Address, V_Gmail,
                V_NID, V_Religion, V_FatherName, V_MotherName,
                V_Skill1, V_Skill2, V_Gender
              FROM Volunteer
              WHERE V_Status = 'Inactive'", con))
                {
                    da.Fill(dt);
                }
            }
            catch (Exception)
            {
            }

            return dt;
        }

        public DataTable SearchInactiveVolunteers(string search)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string query = @"SELECT V_Id, V_Name, V_PhoneNumber, V_DOB, V_Address, V_Gmail, V_NID, V_Religion, V_FatherName, V_MotherName, V_Skill1, V_Skill2, V_Gender
                                         FROM Volunteer WHERE V_Status = 'Inactive' AND (
                                         CAST(V_Id AS NVARCHAR) LIKE @search
                                         OR V_Name LIKE @search
                                         OR CAST(V_PhoneNumber AS NVARCHAR) LIKE @search
                                         OR V_Gmail LIKE @search)";

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
                MessageBox.Show("Error searching volunteers:\n" + ex.Message);
            }
            return dt;
        }

        public int AcceptVolunteer(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                using (SqlCommand cmd = new SqlCommand(
                    "UPDATE Volunteer SET V_Status = 'Active' WHERE V_Id = @Id;", con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                return 0;
            }
        }

        public bool UpdatePass(int empId, string currentPassword, string newPassword)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                string query = @"UPDATE Employee_Log_in
                         SET E_Password = @NewPass
                         WHERE E_Id = @EmpId
                           AND E_Password = @CurrentPass";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NewPass", newPassword);
                    cmd.Parameters.AddWithValue("@EmpId", empId);
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

        public DataTable ShowAllCustomers()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                using (SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT C_Id, C_Name, C_PhoneNumber, C_DOB, C_Address, C_Email, C_NID, C_Gender, 
                     C_Company, C_Position 
              FROM Customer 
              WHERE C_Status = 'Active'", con))
                {
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers:\n" + ex.Message);
            }
            return dt;
        }

        public DataTable SearchCustomers(string search)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string query = @"SELECT C_Id, C_Name, C_PhoneNumber, C_DOB, C_Address, C_Email, C_NID, C_Gender, C_Company, C_Position
                FROM Customer WHERE C_Status = 'Active' AND (
                    CAST(C_Id AS NVARCHAR) LIKE @search
                    OR C_Name LIKE @search
                    OR CAST(C_PhoneNumber AS NVARCHAR) LIKE @search
                    OR C_Email LIKE @search
                )";

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
                MessageBox.Show("Error searching customers:\n" + ex.Message);
            }
            return dt;

        }

        public int UpdateCustomer(Customer c)
        {
            string query = @"UPDATE Customer SET 
                        C_Name = @Name,
                        C_PhoneNumber = @Phone,
                        C_DOB = @Dob,
                        C_Address = @Address,
                        C_Email = @Email,
                        C_NID = @NID,
                        C_Gender = @Gender,
                        C_Company = @Company,
                        C_Position = @Position
                     WHERE C_Id = @Id";

            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", c.C_Id);
                    cmd.Parameters.AddWithValue("@Name", c.C_Name);
                    cmd.Parameters.AddWithValue("@Phone", c.C_PhoneNumber);
                    cmd.Parameters.AddWithValue("@Dob", (object)c.C_DOB ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Address", (object)c.C_Address ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", c.C_Email);
                    cmd.Parameters.AddWithValue("@NID", c.C_NID);
                    cmd.Parameters.AddWithValue("@Gender", c.C_Gender);
                    cmd.Parameters.AddWithValue("@Company", (object)c.C_Company ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Position", (object)c.C_Position ?? DBNull.Value);

                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                return 0;
            }
        }

        public int DeleteCustomer(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Customer WHERE C_Id=@Id", con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                return 0;
            }
        }

        public DataTable ShowInactiveCustomers()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                using (SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT C_Id, C_Name, C_PhoneNumber, C_DOB, C_Address, C_Email, C_NID, C_Gender, 
                     C_Company, C_Position 
              FROM Customer 
              WHERE C_Status = 'Inactive'", con))
                {
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers:\n" + ex.Message);
            }
            return dt;
        }

        public DataTable InactiveSearchCustomers(string search)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string query = @"SELECT C_Id, C_Name, C_PhoneNumber, C_DOB, C_Address, C_Email, C_NID, C_Gender, C_Company, C_Position
                FROM Customer WHERE C_Status = 'Inactive' AND (
                    CAST(C_Id AS NVARCHAR) LIKE @search
                    OR C_Name LIKE @search
                    OR CAST(C_PhoneNumber AS NVARCHAR) LIKE @search
                    OR C_Email LIKE @search
                )";

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
                MessageBox.Show("Error searching customers:\n" + ex.Message);
            }
            return dt;

        }

        public int DeleteInactiveCustomer(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Customer WHERE C_Id=@Id", con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                return 0;
            }
        }

        public int AcceptInactiveCustomer(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                using (SqlCommand cmd = new SqlCommand(
                    "UPDATE Customer SET C_Status='Active' WHERE C_Id=@Id", con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                return 0;
            }
        }


    }
}
