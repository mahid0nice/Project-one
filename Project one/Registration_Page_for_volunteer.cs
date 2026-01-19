
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
    public partial class Registration_Page_for_volunteer : Form
    {
        public Registration_Page_for_volunteer()
        {
            InitializeComponent();
        }

        private void Female_radioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            Volunteer v = new Volunteer();
            int insertDB = -1;

            try
            {
                if (string.IsNullOrWhiteSpace(V_FirstNameText.Text) ||
                    string.IsNullOrWhiteSpace(V_LastNameText.Text) ||
                    string.IsNullOrWhiteSpace(V_PhoneText.Text) ||
                    string.IsNullOrWhiteSpace(V_AddressText.Text) ||
                    string.IsNullOrWhiteSpace(V_GmailText.Text) ||
                    string.IsNullOrWhiteSpace(V_NidText.Text) ||
                    string.IsNullOrWhiteSpace(V_RelegionText.Text) ||
                    string.IsNullOrWhiteSpace(V_FatherNameText.Text) ||
                    string.IsNullOrWhiteSpace(V_MotherNameText.Text) ||
                    string.IsNullOrWhiteSpace(V_IdText.Text) ||
                    string.IsNullOrWhiteSpace(V_PasswordText.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }
                if (!int.TryParse(V_IdText.Text, out int volId))
                {
                    MessageBox.Show("Volunteer ID must be numeric.");
                    return;
                }
                if (!long.TryParse(V_PhoneText.Text, out long phone))
                {
                    MessageBox.Show("Phone number must be numeric.");
                    return;
                }
                if (!long.TryParse(V_NidText.Text, out long nid))
                {
                    MessageBox.Show("NID must be numeric.");
                    return;
                }

                if ((DateTime.Now - V_Datetimer.Value).TotalDays / 365 < 18)
                {
                    MessageBox.Show("Volunteer must be at least 18 years old.");
                    return;
                }
                if (!male_radioButton.Checked &&
                    !Female_radioButton.Checked &&
                    !others_gender_radiobutton.Checked)
                {
                    MessageBox.Show("Please select a gender.");
                    return;
                }
                v.Id = volId;
                v.Name = V_FirstNameText.Text + " " + V_LastNameText.Text;
                v.PhoneNumber = phone;
                v.Dob = V_Datetimer.Value;
                v.Address = V_AddressText.Text;
                v.Gmail = V_GmailText.Text;
                v.NID = nid;
                v.Religion = V_RelegionText.Text;
                v.FatherName = V_FatherNameText.Text;
                v.MotherName = V_MotherNameText.Text;
                v.Skill1 = V_Skill1Text.Text;
                v.Skill2 = V_Skill2Text.Text;
                v.Password = V_PasswordText.Text;
                if (male_radioButton.Checked)
                    v.Gender = "Male";
                else if (Female_radioButton.Checked)
                    v.Gender = "Female";
                else
                    v.Gender = V_OtherText.Text.Trim();
                insertDB = v.insert(v);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
            if (insertDB == 1)
            {
                MessageBox.Show("Registration successful wait for validation.");
                new User_login_page().Show();
                this.Hide();

                V_FirstNameText.Clear();
                V_LastNameText.Clear();
                V_PhoneText.Clear();
                V_AddressText.Clear();
                V_GmailText.Clear();
                V_NidText.Clear();
                V_RelegionText.Clear();
                V_FatherNameText.Clear();
                V_MotherNameText.Clear();
                V_Skill1Text.Clear();
                V_Skill2Text.Clear();
                V_IdText.Clear();
                V_PasswordText.Clear();
                V_OtherText.Clear();
                V_Datetimer.Value = DateTime.Now;
                male_radioButton.Checked = false;
                Female_radioButton.Checked = false;
                others_gender_radiobutton.Checked = false;
            }
            else if (insertDB == 2)
            {
                MessageBox.Show("Database error occurred.");
            }
            else if (insertDB == 3)
            {
                MessageBox.Show("Data type mismatch while reading volunteer data.");
            }
            else if (insertDB == 4)
            {
                MessageBox.Show("Required volunteer data is missing.");
            }
            else if (insertDB == 5)
            {
                MessageBox.Show("Unexpected error occurred.");
            }

        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            
            new User_login_page().Show();
            this.Hide();
        }
    }
}
