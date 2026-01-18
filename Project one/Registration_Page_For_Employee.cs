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
                ee.Name = first_name_textbox.Text + " " + last_name_textbox.Text;
                ee.NickName = nickname_textbox.Text;
                ee.PhoneNumber = long.Parse(phone_number_textbox.Text);
                ee.EmergencyNumber = long.Parse(emergency_number_textbox.Text);
                ee.NID = long.Parse(nid_textbox.Text);
                ee.Gmail = gmail_textbox.Text;
                ee.Address = Address_textbox.Text;
                ee.ParmanentAddress = parAddress_textbox.Text;
                ee.Religion = relegion_textbox.Text;
                ee.BloodGroup = comboBox1.Text;
                ee.MaritalStatus = marital_status_textbox.Text;
                ee.FatherName = fathers_textbox.Text;
                ee.MotherName = mothers_textbox.Text;
                ee.Id = int.Parse(employee_id_textbox.Text);
                ee.Designation = DesignationText.Text;
                ee.Dob = dateTimePicker2.Value.ToString("dd-MM-yyyy");
                if (male_radioButton.Checked)
                {
                    ee.Gender = "Male";
                }
                else if (Female_radioButton.Checked)
                {
                    ee.Gender = "Female";
                }
                else if (others_gender_radiobutton.Checked)
                {
                    ee.Gender = maskedTextBox1.Text.Trim();
                }

                insertDB = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


            insertDB = ee.insert(ee);
            if (insertDB == 0)
            {
                insertDB = ee.insert(ee);
                if(insertDB==1)
                {
                    MessageBox.Show("Registration Successfully");
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

           
        }

    }
}
