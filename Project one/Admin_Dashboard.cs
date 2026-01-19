using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_one
{
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
            ShowPanels(0);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        // string c = Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project-one-db;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30,
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void ShowPanels(int panel)
        {
            AdminProfile_panel.Visible = panel > 0;
            adminHireEmployee_panel.Visible = panel > 1;
            adminEmployee_panel.Visible = panel > 2;
        }


        void showProfileLabel(bool value)
        {
            adminNameText.Visible = value;
            adminNidText.Visible = value;
            adminFatherText.Visible = value;
            adminMotherText.Visible = value;
            adminPhoneText.Visible = value;
            adminGmailText.Visible = value;
            adminAddressText.Visible = value;
            adminReligionText.Visible = value;
            adminMaritalText.Visible = value;
            adminBloodText.Visible = value;
            adminBloodText.Visible = value;
            adminDobText.Visible = value;
            adminGenderText.Visible = value;
        }

        void showProfileTextBox(bool value)
        {
            pName_text.Visible = value;
            pNid_text.Visible = value;
            pFather_text.Visible = value;
            pMother_text.Visible = value;
            pPhone_text.Visible = value;
            pGmail_text.Visible = value;
            pAddress_text.Visible = value;
            pReligion_text.Visible = value;
            pMaritStatus_text.Visible = value;
            pGender_text.Visible = value;
            pBlood_text.Visible = value;
            pDob_text.Visible = value;
        }
        int showProfile()
        {
            try
            {
                Profile_Cancel.Visible = false;
                Profile_Save.Visible = false;
                showProfileTextBox(false);
                showProfileLabel(true);
                Admin ad = new Admin();
                ad = Admin.showAdminDetails(1);
                if (ad != null)
                {
                    adminNameText.Text = ad.Name;
                    adminNidText.Text = ad.NID.ToString();
                    adminFatherText.Text = ad.FatherName;
                    adminMotherText.Text = ad.MotherName;
                    adminPhoneText.Text = ad.PhoneNumber.ToString();
                    adminGmailText.Text = ad.Gmail;
                    adminAddressText.Text = ad.Address;
                    adminReligionText.Text = ad.Religion;
                    adminMaritalText.Text = ad.MaritalStatus;
                    adminBloodText.Text = ad.BloodGroup;
                    adminDobText.Text = ad.Dob;
                    adminGenderText.Text = ad.Gender;
                    Profile_Update.Visible = true;
                    return 1;
                }

                else
                {
                    return 0;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return 0;
            }
        }

        private void admin_Profile_button_Click(object sender, EventArgs e)
        {
            int a = 0;
                a = showProfile();
            if (a == 0) 
            {
                MessageBox.Show("No Admin Found");
            }

            else
            {
                ShowPanels(1);
            }
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

 
        private void adminHireEmployeeStaff_button_Click(object sender, EventArgs e)
        {
            
        }

        private void HireEmployee_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminProfile_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HireEmployee_panel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void adminHireEmployeeManager_button_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmpRefresh_button.Visible = false;
            ShowPanels(3);
            EmployeeUpdate_button.Visible = true;
            employeeDelete_button.Visible = true;
            EmployeeCancel_button.Visible = false;
            EmployeeSave_button.Visible = false;
            Employee ee = new Employee();
            Admin ad = new Admin();
            DataTable dt = ad.ShowAllEmployees(ee);
            employe_gridView.ReadOnly = false;
            employe_gridView.DataSource = dt;
            foreach (DataGridViewRow row in employe_gridView.Rows)
            {
                row.ReadOnly = true;
            }
            EUId.Visible = false;
            EUName.Visible = false;
            EUNickName.Visible = false;
            EUDesignation.Visible = false;
            EUNid.Visible = false;
            EUFatherName.Visible = false;
            EUMotherName.Visible = false;
            EUNumber.Visible = false;
            EUEmergencyNumber.Visible = false;
            EUGmail.Visible = false;
            EUAddress.Visible = false;
            EUParmanentAddress.Visible = false;
            EUReligion.Visible = false;
            EUMaritalStatus.Visible = false;
            EUGender.Visible = false;
            EUBloodGroup.Visible = false;
            EUDob.Visible = false;

        }

        private void adminHireManager_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Registration_Page_For_Employee R = new Registration_Page_For_Employee();
            R.Visible = true;
        }

        private void adminHireSupervisor_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Registration_Page_For_Employee R = new Registration_Page_For_Employee();
            R.Visible = true;
        }

        private void adminHireTeamLeader_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Registration_Page_For_Employee R = new Registration_Page_For_Employee();
            R.Visible = true;
        }

        private void adminHireStaff_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Registration_Page_For_Employee R = new Registration_Page_For_Employee();
            R.Visible = true;
        }

        private void Hire_Employe_button_Click(object sender, EventArgs e)
        {
            ShowPanels(2);

        }

        private void Profile_Update_Click(object sender, EventArgs e)
        {
            Profile_Update.Visible = false;
            showProfileLabel(false);
            showProfileTextBox(true);
            Profile_Cancel.Visible = true;
            Profile_Save.Visible = true;
            pName_text.Text = adminNameText.Text;
            pNid_text.Text = adminNidText.Text;
            pFather_text.Text = adminFatherText.Text;
            pMother_text.Text = adminMotherText.Text;
            pPhone_text.Text = adminPhoneText.Text;
            pGmail_text.Text = adminGmailText.Text;
            pAddress_text.Text = adminAddressText.Text;
            pReligion_text.Text = adminReligionText.Text;
            pMaritStatus_text.Text = adminMaritalText.Text;
            pBlood_text.Text = adminBloodText.Text;
            pDob_text.Text = adminDobText.Text;
            pGender_text.Text = adminGenderText.Text;

        }

        private void Profile_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Admin ad = new Admin
                {
                    Name = pName_text.Text,
                    NID = long.Parse(pNid_text.Text),
                    FatherName = pFather_text.Text,
                    MotherName = pMother_text.Text,
                    PhoneNumber = long.Parse(pPhone_text.Text),
                    Gmail = pGmail_text.Text,
                    Address = pAddress_text.Text,
                    Religion = pReligion_text.Text,
                    MaritalStatus = pMaritStatus_text.Text,
                    Gender = pGender_text.Text,
                    BloodGroup = pBlood_text.Text,
                    Dob = pDob_text.Text
                };

                int result = ad.UpdateAdmin(ad);

                if (result == 1)
                {
                    MessageBox.Show("Admin updated successfully.");
                    showProfile();
                    showProfileTextBox(false);
                    showProfileLabel(true);
                    
                }    
                else
                    MessageBox.Show("Record cannot be updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Profile_Cancel_Click(object sender, EventArgs e)
        {
            showProfile();
        }

        private void employe_gridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            employe_gridView.ClearSelection();
            employe_gridView.Rows[e.RowIndex].Selected = true;

        }

        private void EmployeeUpdate_button_Click(object sender, EventArgs e)
        {
            if (employe_gridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select a single row for editing.");
                return;
            }
            employeeDelete_button.Visible = false;
            EmployeeUpdate_button.Visible = false;
            EmployeeSave_button.Visible = true;
            EmployeeCancel_button.Visible = true;
            foreach (DataGridViewRow row in employe_gridView.Rows)
            {
                row.ReadOnly = true;
            }
            int row_index = employe_gridView.SelectedRows[0].Index;
            employe_gridView.Rows[row_index].ReadOnly = false;
            employe_gridView.Rows[row_index].Cells["E_Id"].ReadOnly = true;
            MessageBox.Show("You can now edit the selected row.");
        }

        private void EmployeeSave_button_Click(object sender, EventArgs e)
        {
            if (employe_gridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select a single row to save.");
                return;
            }

            int row_index = employe_gridView.SelectedRows[0].Index;
            DataGridViewRow row = employe_gridView.Rows[row_index];

            try
            {
                if (row.Cells["E_Id"].Value == null || row.Cells["E_Id"].Value == DBNull.Value ||
                    row.Cells["E_Name"].Value == null || string.IsNullOrWhiteSpace(row.Cells["E_Name"].Value.ToString()) ||
                    row.Cells["E_DOB"].Value == null || row.Cells["E_DOB"].Value == DBNull.Value ||
                    !DateTime.TryParse(row.Cells["E_DOB"].Value.ToString(), out DateTime dob))
                {
                    MessageBox.Show("Required fields are empty or invalid. Employee not updated.");
                    return;
                }

                Employee ee = new Employee
                {
                    Id = Convert.ToInt32(row.Cells["E_Id"].Value),
                    Name = row.Cells["E_Name"].Value.ToString(),
                    NickName = row.Cells["E_NickName"].Value?.ToString() ?? "",
                    Designation = row.Cells["E_Designation"].Value?.ToString() ?? "",
                    NID = row.Cells["E_NID"].Value != DBNull.Value ? Convert.ToInt64(row.Cells["E_NID"].Value) : 0,
                    FatherName = row.Cells["E_FatherName"].Value?.ToString() ?? "",
                    MotherName = row.Cells["E_MotherName"].Value?.ToString() ?? "",
                    PhoneNumber = row.Cells["E_Number"].Value != DBNull.Value ? Convert.ToInt64(row.Cells["E_Number"].Value) : 0,
                    EmergencyNumber = row.Cells["E_Emergency_Number"].Value != DBNull.Value ? Convert.ToInt64(row.Cells["E_Emergency_Number"].Value) : 0,
                    Gmail = row.Cells["E_Gmail"].Value?.ToString() ?? "",
                    Address = row.Cells["E_Address"].Value?.ToString() ?? "",
                    ParmanentAddress = row.Cells["E_Parmanent_Address"].Value?.ToString() ?? "",
                    Religion = row.Cells["E_Religion"].Value?.ToString() ?? "",
                    MaritalStatus = row.Cells["E_MaritalStatus"].Value?.ToString() ?? "",
                    Gender = row.Cells["E_Gender"].Value?.ToString() ?? "",
                    BloodGroup = row.Cells["E_BloodGroup"].Value?.ToString() ?? "",
                    Dob = dob
                };

                Admin ad = new Admin();
                int result = ad.UpdateEmployee(ee);

                if (result == 1)
                {
                    MessageBox.Show("Employee updated successfully.");
                    row.ReadOnly = true;
                    EmployeeUpdate_button.Visible = true;
                    employeeDelete_button.Visible = true;
                    EmployeeSave_button.Visible = false;
                    EmployeeCancel_button.Visible = false;
                }
                else
                {
                    MessageBox.Show("Employee update failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void employeeDelete_button_Click(object sender, EventArgs e)
        {
            if (employe_gridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select a single row to delete.");
                return;
            }

            int row_index = employe_gridView.SelectedRows[0].Index;
            DataGridViewRow row = employe_gridView.Rows[row_index];
            DialogResult dr = MessageBox.Show(
                $"Are you sure you want to delete employee '{row.Cells["E_Name"].Value}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dr == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(row.Cells["E_Id"].Value);
                    Admin ad = new Admin();
                    Employee ee = new Employee() { Id = id };
                    int result = ad.DeleteEmployee(ee);

                    if (result == 1)
                    {
                        MessageBox.Show("Employee deleted successfully.");
                        employe_gridView.Rows.RemoveAt(row_index);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete employee.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void EmployeeCancel_button_Click(object sender, EventArgs e)
        {
            EmployeeUpdate_button.Visible = true;
            employeeDelete_button.Visible = true;
            EmployeeSave_button.Visible = false;
            EmployeeCancel_button.Visible = false;
        }

        private void EmpSearch_button_Click(object sender, EventArgs e)
        {
            string search = EmployeeSearch_Text.Text.Trim();
            Admin ad = new Admin();
            DataTable dt = ad.SearchEmployees(search);

            if (dt.Rows.Count > 0)
            {
                employe_gridView.DataSource = dt;
                EmpRefresh_button.Visible = true;
            }
            else
            {
                MessageBox.Show("No matching employees found. Showing previous data.");
                DataTable previousData = ad.ShowAllEmployees(new Employee());
                employe_gridView.DataSource = previousData;
            }
            foreach (DataGridViewRow row in employe_gridView.Rows)
            {
                row.ReadOnly = true;
            }
            employe_gridView.ClearSelection();
        }

        private void EmpRefresh_button_Click(object sender, EventArgs e)
        {
            EmployeeSearch_Text.Clear();
            EmpRefresh_button.Visible = false;
            ShowPanels(3);
            EmployeeUpdate_button.Visible = true;
            employeeDelete_button.Visible = true;
            EmployeeCancel_button.Visible = false;
            EmployeeSave_button.Visible = false;

            Employee ee = new Employee();
            Admin ad = new Admin();
            DataTable dt = ad.ShowAllEmployees(ee);

            employe_gridView.DataSource = dt;
            foreach (DataGridViewRow row in employe_gridView.Rows)
            {
                row.ReadOnly = true;
            }
            employe_gridView.ClearSelection();
        }
    }
}


