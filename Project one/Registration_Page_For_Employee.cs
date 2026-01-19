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
    public partial class Registration_Page_For_Employee : Form
    {
        public Registration_Page_For_Employee()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void First_name_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void phone_number_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void registration_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Nick_name_label_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Gender_groupbox_Enter(object sender, EventArgs e)
        {

        }

        private void Registration_lebel_Click(object sender, EventArgs e)
        {

        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            Employee ee = new Employee();
            int insertDB = -1;

            try
            {
                if (string.IsNullOrWhiteSpace(first_name_textbox.Text) ||string.IsNullOrWhiteSpace(last_name_textbox.Text) ||string.IsNullOrWhiteSpace(nickname_textbox.Text) ||string.IsNullOrWhiteSpace(gmail_textbox.Text) ||
                    string.IsNullOrWhiteSpace(Address_textbox.Text) ||string.IsNullOrWhiteSpace(parAddress_textbox.Text) ||string.IsNullOrWhiteSpace(relegion_textbox.Text) ||string.IsNullOrWhiteSpace(comboBox1.Text) ||
                    string.IsNullOrWhiteSpace(marital_status_textbox.Text) || string.IsNullOrWhiteSpace(fathers_textbox.Text) ||string.IsNullOrWhiteSpace(mothers_textbox.Text) ||
                    string.IsNullOrWhiteSpace(employee_id_textbox.Text) || string.IsNullOrWhiteSpace(DesignationText.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }


                if (!int.TryParse(employee_id_textbox.Text, out int empId))
                {
                    MessageBox.Show("Employee ID must be a number.");
                    return;
                }

                if (!long.TryParse(phone_number_textbox.Text, out long phoneNumber))
                {
                    MessageBox.Show("Phone number must be numeric.");
                    return;
                }

                if (!long.TryParse(emergency_number_textbox.Text, out long emergencyNumber))
                {
                    MessageBox.Show("Emergency number must be numeric.");
                    return;
                }

                if (!long.TryParse(nid_textbox.Text, out long nid))
                {
                    MessageBox.Show("NID must be numeric.");
                    return;
                }

                if ((DateTime.Now - DobPicker.Value).TotalDays / 365 < 20)
                {
                    MessageBox.Show("Employee must be at least 20 years old.");
                    return;
                }

                if (!male_radioButton.Checked && !Female_radioButton.Checked && !others_gender_radiobutton.Checked)
                {
                    MessageBox.Show("Please select a gender.");
                    return;
                }

                ee.Id = empId;
                ee.Name = first_name_textbox.Text + " " + last_name_textbox.Text;
                ee.NickName = nickname_textbox.Text;
                ee.Designation = DesignationText.Text;
                ee.NID = nid;
                ee.FatherName = fathers_textbox.Text;
                ee.MotherName = mothers_textbox.Text;
                ee.PhoneNumber = phoneNumber;
                ee.EmergencyNumber = emergencyNumber;
                ee.Gmail = gmail_textbox.Text;
                ee.Address = Address_textbox.Text;
                ee.ParmanentAddress = parAddress_textbox.Text;
                ee.Religion = relegion_textbox.Text;
                ee.MaritalStatus = marital_status_textbox.Text;
                ee.BloodGroup = comboBox1.Text;
                ee.Dob = DobPicker.Value;

                if (male_radioButton.Checked)
                    ee.Gender = "Male";
                else if (Female_radioButton.Checked)
                    ee.Gender = "Female";
                else
                    ee.Gender = maskedTextBox1.Text.Trim();


                insertDB = ee.insert(ee);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }

            if (insertDB == 1)
            {
                new Admin_Dashboard().Show();
                this.Hide();
                MessageBox.Show("Registration Successfully");
                first_name_textbox.Clear();
                last_name_textbox.Clear();
                nickname_textbox.Clear();
                phone_number_textbox.Clear();
                emergency_number_textbox.Clear();
                nid_textbox.Clear();
                gmail_textbox.Clear();
                Address_textbox.Clear();
                parAddress_textbox.Clear();
                relegion_textbox.Clear();
                comboBox1.SelectedIndex = -1;
                marital_status_textbox.Clear();
                fathers_textbox.Clear();
                mothers_textbox.Clear();
                employee_id_textbox.Clear();
                DesignationText.Clear();
                DobPicker.Value = DateTime.Now;

                male_radioButton.Checked = false;
                Female_radioButton.Checked = false;
                others_gender_radiobutton.Checked = false;
                maskedTextBox1.Clear();

            }
            else if (insertDB == 2)
            {
                MessageBox.Show("Database error occurred.");
            }
            else if (insertDB == 3)
            {
                MessageBox.Show("Data type mismatch while reading admin data.");
            }
            else if (insertDB == 4)
            {
                MessageBox.Show("Required admin data is missing.\n");
            }
            else if (insertDB == 5)
            {
                MessageBox.Show("Unexpected error occurred.\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Admin_Dashboard().Show();
            this.Hide();
        }
    }
}
