using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Project_one
{
    public partial class Employee_Dashboard : Form
    {
        internal int duplicateId;
        public Employee_Dashboard()
        {
            InitializeComponent();
            ShowPanel(0);

        }
        public Employee_Dashboard(int duplicateId)
        {
            this.duplicateId = duplicateId;
            InitializeComponent();
            ShowPanel(0);
        }

        void ShowPanel(int panel)
        {
            
            Employee_profile.Visible = panel >= 1;
            Volunteer_panel.Visible = panel >= 2;
            inactiveVolunteer.Visible = panel >= 3;
            IdPassPanel.Visible = panel >= 4;
            rulesPanel.Visible = panel >= 5;
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
                ShowPanel(1);
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
        //volunteer
        private void vSave_Click(object sender, EventArgs e)
        {
            //volunteer save
            if (v_dataGridView1.SelectedRows.Count != 1)
                return;

            DataGridViewRow row = v_dataGridView1.SelectedRows[0];

            Volunteer v = new Volunteer
            {
                Id = Convert.ToInt32(row.Cells["V_Id"].Value),
                Name = row.Cells["V_Name"].Value.ToString(),
                PhoneNumber = Convert.ToInt64(row.Cells["V_PhoneNumber"].Value),
                Dob = Convert.ToDateTime(row.Cells["V_DOB"].Value),
                Address = row.Cells["V_Address"].Value.ToString(),
                Gmail = row.Cells["V_Gmail"].Value.ToString(),
                NID = Convert.ToInt64(row.Cells["V_NID"].Value),
                Religion = row.Cells["V_Religion"].Value.ToString(),
                FatherName = row.Cells["V_FatherName"].Value.ToString(),
                MotherName = row.Cells["V_MotherName"].Value.ToString(),
                Skill1 = row.Cells["V_Skill1"].Value.ToString(),
                Skill2 = row.Cells["V_Skill2"].Value?.ToString(),
                Gender = row.Cells["V_Gender"].Value.ToString()
            };

            Employee ee = new Employee();
            int result = ee.UpdateVolunteer(v);

            if (result == 1)
            {
                MessageBox.Show("Volunteer updated successfully.");
                LoadVolunteers();
                vCancel.Visible = false;
                vSave.Visible = false;
                vUpdate.Visible = true;
                vDelete.Visible = true;
            }
            else
            {
                MessageBox.Show("Volunteer update failed.");
            }
        }

        private void vSearch_Click(object sender, EventArgs e)
        {
            //volunteer search
            vRefresh.Visible = true;
            string search = v_searchText.Text.Trim();
            Employee ee = new Employee();

            DataTable dt = ee.SearchVolunteers(search);

            if (dt.Rows.Count > 0)
                v_dataGridView1.DataSource = dt;
            else
            {
                MessageBox.Show("No volunteers found.");
                LoadVolunteers();
            }

            foreach (DataGridViewRow row in v_dataGridView1.Rows)
                row.ReadOnly = true;

            v_dataGridView1.ClearSelection();
        }
        private void vUpdate_Click(object sender, EventArgs e)
        {
            //volunteer update
            if (v_dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select one volunteer to update.");
                return;
            }
            vCancel.Visible = true;
            vSave.Visible = true;
            vUpdate.Visible = false;
            vDelete.Visible = false;
            foreach (DataGridViewRow row in v_dataGridView1.Rows)
                row.ReadOnly = true;

            int index = v_dataGridView1.SelectedRows[0].Index;
            v_dataGridView1.Rows[index].ReadOnly = false;
            v_dataGridView1.Rows[index].Cells["V_Id"].ReadOnly = true;

            MessageBox.Show("You can now edit the selected volunteer.");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            vCancel.Visible = false;
            vSave.Visible = false;
            vUpdate.Visible = true;
            vDelete.Visible = true;
            foreach (DataGridViewRow row in v_dataGridView1.Rows)
                row.ReadOnly = true;

            v_dataGridView1.ClearSelection();
            LoadVolunteers();
        }
        private void LoadVolunteers()
        {
            //volunteer load
            Employee ee = new Employee();
            v_dataGridView1.DataSource = ee.ShowAllVolunteers();

            foreach (DataGridViewRow row in v_dataGridView1.Rows)
            { row.ReadOnly = true; }

            v_dataGridView1.ClearSelection();
        }
        private void vCancel_Click(object sender, EventArgs e)
        {
            //volunteer cancel
            vCancel.Visible = false;
            vSave.Visible = false;
            vUpdate.Visible = true;
            vDelete.Visible = true;
            foreach (DataGridViewRow row in v_dataGridView1.Rows)
                row.ReadOnly = true;

            v_dataGridView1.ClearSelection();
            LoadVolunteers();
        }

        private void vDelete_Click(object sender, EventArgs e)
        {
            //volunteer delete
            if (v_dataGridView1.SelectedRows.Count != 1)
                return;

            int id = Convert.ToInt32(
                v_dataGridView1.SelectedRows[0].Cells["V_Id"].Value);

            DialogResult dr = MessageBox.Show(
                "Are you sure you want to delete this volunteer?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                Employee ee = new Employee();
                int result = ee.DeleteVolunteer(id);

                if (result == 1)
                {
                    MessageBox.Show("Volunteer deleted successfully.");
                    LoadVolunteers();
                }
                else
                {
                    MessageBox.Show("Delete failed.");
                }
            }
        }

        private void vRefresh_Click(object sender, EventArgs e)
        {
            //volunteer refresh
            vCancel.Visible = false;
            vSave.Visible = false;
            vRefresh.Visible = false;
            vUpdate.Visible = true;
            vDelete.Visible = true;
            v_searchText.Clear();
            LoadVolunteers();
        }

        private void btn_vol_details_Click(object sender, EventArgs e)
        {
            //vol baton
            vCancel.Visible = false;
            vSave.Visible = false;
            vRefresh.Visible = false;
            vUpdate.Visible = true;
            vDelete.Visible = true;
            Employee ee = new Employee();
            v_dataGridView1.DataSource = ee.ShowAllVolunteers();
            LoadVolunteers();
            v_dataGridView1.ClearSelection();
            v_NameText.Visible = false;
            V_IdText.Visible = false;
            V_PhoneText.Visible = false;
            V_DobText.Visible = false;
            V_Address.Visible = false;
            V_GmailText.Visible = false;
            V_NIDTEXT.Visible = false;
            V_ReligionText.Visible = false;
            V_FatherName.Visible = false;
            V_MotherName.Visible = false;
            V_Skill1.Visible = false;
            V_Skill2.Visible = false;
            V_Gender.Visible = false;
            ShowPanel(2);
        }

        private void btn_vol_request_Click(object sender, EventArgs e)
        {

            v_dataGridView2.DataSource =  new Employee().ShowAllInactiveVolunteers();
            LoadInActiveVolunteers();
            ShowPanel(3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VIRefresh.Visible = true;
            string search = v_searchText2.Text.Trim();
            Employee ee = new Employee();

            DataTable dt = ee.SearchInactiveVolunteers(search);

            if (dt.Rows.Count > 0)
                v_dataGridView2.DataSource = dt;
            else
            {
                MessageBox.Show("No volunteers found.");
                LoadInActiveVolunteers();
            }

            foreach (DataGridViewRow row in v_dataGridView2.Rows)
                row.ReadOnly = true;

            v_dataGridView2.ClearSelection();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (v_dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select one volunteer to update.");
                return;
            }
            vCancel.Visible = true;
            vSave.Visible = true;
            vUpdate.Visible = false;
            vDelete.Visible = false;
            foreach (DataGridViewRow row in v_dataGridView1.Rows)
                row.ReadOnly = true;

            int index = v_dataGridView1.SelectedRows[0].Index;
            v_dataGridView1.Rows[index].ReadOnly = false;
            v_dataGridView1.Rows[index].Cells["V_Id"].ReadOnly = true;

            MessageBox.Show("You can now edit the selected volunteer.");
        }

  
        //inactive volunter
        private void IVActive_Click(object sender, EventArgs e)
        {
            if (v_dataGridView2.SelectedRows.Count != 1)
                return;

            int id = Convert.ToInt32(
                v_dataGridView2.SelectedRows[0].Cells["V_Id"].Value);

            DialogResult dr = MessageBox.Show(
                "Are you sure you want to delete this volunteer?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                Employee ee = new Employee();
                int result = ee.AcceptVolunteer(id);

                if (result == 1)
                {
                    MessageBox.Show("Accept successfully.");
                    LoadInActiveVolunteers();
                }
                else
                {
                    MessageBox.Show("Failed.");
                }
            }
        }

        private void IVDelete_Click(object sender, EventArgs e)
        {
            if (v_dataGridView2.SelectedRows.Count != 1)
                return;

            int id = Convert.ToInt32(
                v_dataGridView2.SelectedRows[0].Cells["V_Id"].Value);

            DialogResult dr = MessageBox.Show(
                "Are you sure you want to delete this volunteer?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                Employee ee = new Employee();
                int result = ee.DeleteVolunteer(id);

                if (result == 1)
                {
                    MessageBox.Show("Volunteer deleted successfully.");
                    LoadInActiveVolunteers();
                }
                else
                {
                    MessageBox.Show("Delete failed.");
                }
            }
        }

        private void LoadInActiveVolunteers()
        {
            //inactive volunteer load
            Employee ee = new Employee();
            v_dataGridView2.DataSource = ee.ShowAllInactiveVolunteers();

            foreach (DataGridViewRow row in v_dataGridView2.Rows)
            { row.ReadOnly = true; }

            v_dataGridView2.ClearSelection();
            VIRefresh.Visible = false;
        }

        private void IVSearch_Click(object sender, EventArgs e)
        {
            v_searchText.Clear();
            LoadInActiveVolunteers();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_Login().Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowPanel(4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string currPassWord = oldPass.Text.Trim();
            string newPassWord = newpass.Text.Trim();

            if (string.IsNullOrEmpty(currPassWord) || string.IsNullOrEmpty(newPassWord))
            {
                MessageBox.Show("Please enter both current and new passwords.");
                return;
            }

            try
            {
                Employee ee = new Employee();

                bool updated = ee.UpdatePass(duplicateId, currPassWord, newPassWord);

                if (updated)
                {
                    MessageBox.Show("Password updated successfully.");
                    oldPass.Clear();
                    newpass.Clear();
                }
                else
                {
                    MessageBox.Show("Invalid current password. Try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowPanel(5);
            ShowRulesGrid();
        }

        private void ShowRulesGrid()
        {
            try
            {
                Admin ad = new Admin();
                DataTable dt = ad.ShowRules();
                RulesGrid.DataSource = dt;
                RRefresh_button.Visible = false;

                foreach (DataGridViewRow row in RulesGrid.Rows)
                {
                    row.ReadOnly = true;
                }
                RulesGrid.ClearSelection();
                RulesGrid.Columns["No"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                RulesGrid.Columns["Rules"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                RulesGrid.Columns["Rules"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                RulesGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rules: " + ex.Message);
            }
        }

        private void RRefresh_button_Click(object sender, EventArgs e)
        {
            rulesSearch_text.Clear();
            ShowRulesGrid();
        }

        private void RSearch_button_Click(object sender, EventArgs e)
        {
            RRefresh_button.Visible = true;
            string search = rulesSearch_text.Text.Trim();
            Admin ad = new Admin();
            DataTable dt = ad.SearchRules(search);

            if (dt.Rows.Count > 0)
            {
                RulesGrid.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No matching rules found. Showing previous data.");
                ShowRulesGrid();
            }

            foreach (DataGridViewRow row in RulesGrid.Rows)
            {
                row.ReadOnly = true;
            }
            RulesGrid.ClearSelection();
        }
    }
}
