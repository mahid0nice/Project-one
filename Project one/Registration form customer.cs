using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_one
{
    public partial class Registration_form_customer : Form
    {
        public Registration_form_customer()
        {
            InitializeComponent();
        }

        private void C_bt_submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(V_UserIDText.Text.Trim(), out int customerId))
                {
                    MessageBox.Show("Please enter a valid Customer ID.");
                    return;
                }

                string name = C_NameText.Text.Trim();
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Customer name cannot be empty.");
                    return;
                }

                if (!long.TryParse(C_PhoneText.Text.Trim(), out long phone))
                {
                    MessageBox.Show("Please enter a valid phone number.");
                    return;
                }

                DateTime? dob = C_Datetimer.Checked ? C_Datetimer.Value : (DateTime?)null;

                if (dob == null)
                {
                    MessageBox.Show("Please select Date of Birth.");
                    return;
                }

                int age = DateTime.Now.Year - dob.Value.Year;
                if (dob.Value.Date > DateTime.Now.AddYears(-age)) age--;

                if (age < 20)
                {
                    MessageBox.Show("Customer must be at least 20 years old.");
                    return;
                }

                string address = string.IsNullOrWhiteSpace(C_AddressText.Text) ? null : C_AddressText.Text.Trim();

                string email = C_EmailText.Text.Trim();
                if (string.IsNullOrEmpty(email) || !email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Please enter a valid Gmail address.");
                    return;
                }

                if (!long.TryParse(C_NidText.Text.Trim(), out long nid))
                {
                    MessageBox.Show("Please enter a valid NID number.");
                    return;
                }

                string gender = "";
                if (male_radioButton.Checked)
                    gender = "Male";
                else if (Female_radioButton.Checked)
                    gender = "Female";
                else if (others_gender_radiobutton.Checked)
                {
                    if (string.IsNullOrWhiteSpace(C_OtherText.Text))
                    {
                        MessageBox.Show("Please specify your gender.");
                        return;
                    }
                    gender = C_OtherText.Text.Trim();
                }
                else
                {
                    MessageBox.Show("Please select a gender.");
                    return;
                }

                string company = string.IsNullOrWhiteSpace(C_CompanyText.Text) ? null : C_CompanyText.Text.Trim();
                string position = string.IsNullOrWhiteSpace(C_PositionText.Text) ? null : C_PositionText.Text.Trim();
                string password = C_PasswordText.Text.Trim();
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Password cannot be empty.");
                    return;
                }

                Customer newCustomer = new Customer
                {
                    C_Id = customerId,
                    C_Name = name,
                    C_PhoneNumber = phone,
                    C_DOB = dob,
                    C_Address = address,
                    C_Email = email,
                    C_NID = nid,
                    C_Gender = gender,
                    C_Company = company,
                    C_Position = position,
                    C_Password = password,
                    C_Status = "Inactive"
                };

                try
                {
                    newCustomer.InsertCustomer();
                    MessageBox.Show("Added successfully wait for the verification!");
                    new User_login_page().Show();
                    this.Hide();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void C_bt_cancel_Click(object sender, EventArgs e)
        {
            new User_login_page().Show();
            this.Hide();
        }
    }
}
