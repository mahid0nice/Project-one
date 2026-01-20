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
    public partial class Employee_Dashboard : Form
    {
        internal int duplicateId;
        public Employee_Dashboard()
        {
            InitializeComponent();
            Employee_profile.Visible = false;

        }
        public Employee_Dashboard(int duplicateId)
        {
            this.duplicateId = duplicateId;
            InitializeComponent();
            Employee_profile.Visible = false;
        }


        void showProfileLabel(bool value)
        {
            eName_label.Visible = value;
            eID_label.Visible = value;
            ePhone_label.Visible = value;
            eDob_label.Visible = value;
            eNID_label.Visible = value;
            eAddress_label.Visible = value;
            eGender_label.Visible = value;
            eFather_label.Visible = value;
            eMother_label.Visible = value;
            eMerital_label.Visible = value;
            eBlood_label.Visible = value;
            eMail_label.Visible = value;
        }

        void showProfileTextBox(bool value)
        {
            eName_text.Visible = value;
            eID_text.Visible = value;
            ePhone_text.Visible = value;
            eDOB_text.Visible = value;
            eNID_text.Visible = value;
            eAddress_text.Visible = value;
            eGender_text.Visible = value;
            eFather_text.Visible = value;
            eMother_text.Visible = value;
            eMerital_text.Visible = value;
            eBlood_text.Visible = value;
            gMail_text.Visible = value;
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {

        }


        private void btn_profile_Click_1(object sender, EventArgs e)
        {
            int result = showEmployeeProfile();
            if (result == 0)
               MessageBox.Show("No Employee Found");

        }

        int showEmployeeProfile()
        {
            try
            {
                Employee emp = new Employee().GetEmployeeById(duplicateId);

                if (emp == null)
                { return 0; }
                else
                eName_label.Text = emp.Name;
                eID_label.Text = emp.Id.ToString();
                ePhone_label.Text = emp.PhoneNumber.ToString();
                eDob_label.Text = emp.Dob?.ToString("yyyy-MM-dd");
                eNID_label.Text = emp.NID.ToString();
                eAddress_label.Text = emp.Address;
                eGender_label.Text = emp.Gender;
                eFather_label.Text = emp.FatherName;
                eMother_label.Text = emp.MotherName;
                eMerital_label.Text = emp.MaritalStatus;
                eBlood_label.Text = emp.BloodGroup; ;
                eMail_label.Text = emp.Gmail;

                showProfileTextBox(false);
                showProfileLabel(true);
                Employee_profile.Visible = true;
                UpdateButton.Visible = true;
                SaveButton.Visible = false;
                CancelButton.Visible = false;
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateButton.Visible = false;
            SaveButton.Visible = true;
            CancelButton.Visible = true;
            eName_text.Text = eName_label.Text;
            eID_text.Text = eID_label.Text;
            ePhone_text.Text = ePhone_label.Text;
            gMail_text.Text = eMail_label.Text;
            eAddress_text.Text = eAddress_label.Text;
            eGender_text.Text = eGender_label.Text;
            eFather_text.Text = eFather_label.Text;
            eMother_text.Text = eMother_label.Text;
            eMerital_text.Text = eMerital_label.Text;
            eBlood_text.Text = eBlood_label.Text;
            eDOB_text.Text = eDob_label.Text;
            eNID_text.Text = eNID_label.Text;
            showProfileLabel(false);
            showProfileTextBox(true);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee
                {
                    Id = int.Parse(eID_text.Text),
                    Name = eName_text.Text,
                    NID = long.Parse(eNID_text.Text),
                    FatherName = eFather_text.Text,
                    MotherName = eMother_text.Text,
                    PhoneNumber = long.Parse(ePhone_text.Text),
                    Gmail = gMail_text.Text,
                    Address = eAddress_text.Text,
                    MaritalStatus = eMerital_text.Text,
                    Gender = eGender_text.Text,
                    BloodGroup = eBlood_text.Text,
                    Dob = string.IsNullOrWhiteSpace(eDOB_text.Text) ? (DateTime?)null : DateTime.Parse(eDOB_text.Text)
                };


                int result = emp.UpdateEmployee(emp);

                if (result == 1)
                {
                    MessageBox.Show("Updated successfully.");
                    showProfileLabel(true);  
                    showProfileTextBox(false);
                    showEmployeeProfile();           
                }
                else
                {
                    MessageBox.Show("Cannot be updated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            showProfileLabel(true);
            showProfileTextBox(false);
            showEmployeeProfile();
        }
    }
}
