using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_one
{
    public partial class Customer_Registration_latest : Form
    {
        public Customer_Registration_latest()
        {
            InitializeComponent();
        }

        private void C_bt_submit_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            int insertDB = -1;

            try
            {

                if (string.IsNullOrWhiteSpace(C_FirstNameText.Text) ||
                    string.IsNullOrWhiteSpace(C_LastNameText.Text) ||
                    string.IsNullOrWhiteSpace(C_PhoneText.Text) ||
                    string.IsNullOrWhiteSpace(C_AddressText.Text) ||
                    string.IsNullOrWhiteSpace(C_EmailText.Text) ||
                    string.IsNullOrWhiteSpace(C_NidText.Text) ||
                    string.IsNullOrWhiteSpace(V_UserIDText.Text) ||
                    string.IsNullOrWhiteSpace(C_PasswordText.Text) ||
                    string.IsNullOrWhiteSpace(C_CompanyText.Text) ||
                    string.IsNullOrWhiteSpace(C_PositionText.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                if (!int.TryParse(V_UserIDText.Text, out int custId))
                {
                    MessageBox.Show("Customer ID must be numeric.");
                    return;
                }
                if (!long.TryParse(C_PhoneText.Text, out long phone))
                {
                    MessageBox.Show("Phone number must be numeric.");
                    return;
                }
                if (!long.TryParse(C_NidText.Text, out long nid))
                {
                    MessageBox.Show("NID must be numeric.");
                    return;
                }

                if ((DateTime.Now - C_DobPicker.Value).TotalDays / 365 < 22)
                {
                    MessageBox.Show("Customer must be at least 22 years old.");
                    return;
                }

                if (!male_radioButton.Checked &&
                    !Female_radioButton.Checked &&
                    !others_gender_radiobutton.Checked)
                {
                    MessageBox.Show("Please select a gender.");
                    return;
                }

                c.Id = custId;
                c.Name = C_FirstNameText.Text + " " + C_LastNameText.Text;
                c.Phone = phone;
                c.Dob = C_DobPicker.Value;
                c.Address = C_AddressText.Text;
                c.Email = C_EmailText.Text;
                c.Nid = nid;
                c.Company = C_CompanyText.Text;
                c.Position = C_PositionText.Text;
                c.Password = C_PasswordText.Text;

                if (male_radioButton.Checked)
                    c.Gender = "Male";
                else if (Female_radioButton.Checked)
                    c.Gender = "Female";
                else
                    c.Gender = C_OtherText.Text.Trim();

                insertDB = c.InsertCustomer(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }


            if (insertDB == 1)
            {
                MessageBox.Show("Registration successful wait for verification.");
                new User_login_page().Show();
                this.Hide();
            }
            else if (insertDB == 2)
            {
                MessageBox.Show("Database error occurred.");
            }
            else if (insertDB == 3)
            {
                MessageBox.Show("Data type mismatch while reading customer data.");
            }
            else if (insertDB == 4)
            {
                MessageBox.Show("Required customer data is missing.");
            }
            else if (insertDB == 5)
            {
                MessageBox.Show("Unexpected error occurred.");
            }
        }

        private void C_bt_cancel_Click(object sender, EventArgs e)
        {
            new User_login_page().Show();
            this.Hide();
        }
    }
}


