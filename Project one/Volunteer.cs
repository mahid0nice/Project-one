using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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

    }
}
