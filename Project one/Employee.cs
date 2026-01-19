using System;
using System.Data;
using System.Data.SqlClient;

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
                           Initial Catalog=Project-One-DB;
                           Integrated Security=True;
                           TrustServerCertificate=True";
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

    }
}