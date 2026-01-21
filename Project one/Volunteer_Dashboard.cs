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
    public partial class Volunteer_Dashboard : Form
    {
        public Volunteer_Dashboard()
        {
            InitializeComponent();
            ShowPanel(0);
        }
        internal int duplicateId;
        public Volunteer_Dashboard(int duplicateId)
        {
            InitializeComponent();
            this.duplicateId = duplicateId;
             ShowPanel(0);
        }

        void ShowPanel(int panel)
        {

            IdPassPanel.Visible = panel >= 1;
            rulesPanel.Visible = panel >= 2;
            Profile_Panel.Visible = panel >=3;
            CurrentJob_panel.Visible = panel >= 4;
            Available_JobLabel.Visible = panel >= 5;
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
                Volunteer vol = new Volunteer();

                bool updated = vol.UpdatePass(duplicateId, currPassWord, newPassWord);

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

  
        private void ShowRulesGrid()
        {
            try
            {
                Volunteer vv = new Volunteer();
                DataTable dt = vv.ShowRules();
                RulesGrid.DataSource = dt;
                RRefresh_button.Visible = false;
                rulesSearch_text.Clear();
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
            string search = rulesSearch_text.Text.Trim();
            Volunteer vv = new Volunteer();
            DataTable dt = vv.SearchRules(search);

            if (dt.Rows.Count > 0)
            {
                RulesGrid.DataSource = dt;
                RRefresh_button.Visible = true;
            }
            else
            {
                MessageBox.Show("No matching rules found.");
            }

            foreach (DataGridViewRow row in RulesGrid.Rows)
            {
                row.ReadOnly = true;
            }
            RulesGrid.ClearSelection();
        }


        int showVolunteerProfile()
        {
            try
            {
                Volunteer vv = new Volunteer();
                vv = vv.ShowVolunteerDetails(duplicateId);
                if (vv != null)
                {
                    adminNameText.Text = vv.Name;
                    adminNidText.Text = vv.NID.ToString();
                    adminFatherText.Text = vv.FatherName;
                    adminMotherText.Text = vv.MotherName;
                    adminPhoneText.Text = vv.PhoneNumber.ToString();
                    adminGmailText.Text = vv.Gmail;
                    adminAddressText.Text = vv.Address;
                    adminGenderText.Text = vv.Skill1;
                    adminDobText.Text = vv.Dob?.ToString("dd-MM-yyyy") ?? "";

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

        private void btn_profile_Click_1(object sender, EventArgs e)
        {
            int result = showVolunteerProfile();
            if (result == 0)
            {
                MessageBox.Show("No Admin Found");
            }

            else
            {
                ShowPanel(3);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowRulesGrid();
            rulesSearch_text.Text = "";
            ShowPanel(2);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowPanel(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new User_login_page().Show();
            this.Hide();
        }

        private void ICActive_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count != 1)
                    return;

                int jobId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Job_Id"].Value);

                DialogResult dr = MessageBox.Show(
                    "Are you sure you want to accept this job?",
                    "Confirm Accept",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    Volunteer vol = new Volunteer();
                    int result = vol.AcceptJob(jobId, duplicateId); 

                    if (result == 1)
                    {
                        MessageBox.Show("Job accepted successfully.");
                        AvailableJob();
                    }
                    else
                    {
                        MessageBox.Show("Accept failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while accepting the job: " + ex.Message);
            }
        }

        private void btn_vol_details_Click(object sender, EventArgs e)
        {
            LoadCurrentJob();
            C_searchText2.Text = "";
            ShowPanel(4);
        }
        private void LoadCurrentJob()
        {
            Volunteer vol = new Volunteer();
            C_dataGridView2.DataSource = vol.ShowMyJob(duplicateId);

            foreach (DataGridViewRow row in C_dataGridView2.Rows)
            {
                row.ReadOnly = true;
            }

            C_dataGridView2.ClearSelection();
            CIRefresh.Visible = false;

            C_dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            C_dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            C_dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            foreach (DataGridViewColumn col in C_dataGridView2.Columns)
            {
                col.ReadOnly = true;
            }
        }
        private void CIRefresh_Click(object sender, EventArgs e)
        {
            LoadCurrentJob();
            C_searchText2.Text = "";
        }



        private void C1Search_Click(object sender, EventArgs e)
        {
            string search = C_searchText2.Text.Trim();

            Volunteer vol = new Volunteer();
            DataTable dt = vol.SearchMyJobs(search, duplicateId);

            if (dt.Rows.Count > 0)
            {
                C_dataGridView2.DataSource = dt;
                CIRefresh.Visible = true;
                C_searchText2.Text="";
            }
            else
            {
                MessageBox.Show("No jobs found.");
            }

            foreach (DataGridViewRow row in C_dataGridView2.Rows)
                row.ReadOnly = true;

            C_dataGridView2.ClearSelection();

            C_dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            C_dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            C_dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            foreach (DataGridViewColumn col in C_dataGridView2.Columns)
                col.ReadOnly = true;
        }

        private void btn_vol_request_Click(object sender, EventArgs e)
        {
            AvailableJob();
            C_searchText2.Text = "";
            ShowPanel(5);
        }

        private void AvailableJob()
        {
            Volunteer vol = new Volunteer();
            dataGridView1.DataSource = vol.GetAvailableJobs();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.ReadOnly = true;
            }
            search_text.Text= "";
            dataGridView1.ClearSelection();
            RRRefresh.Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.ReadOnly = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string search = search_text.Text.Trim();

            try
            {
                Volunteer vol = new Volunteer();
                DataTable dt = vol.SearchAvailableJobs(search);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                    RRRefresh.Visible = true;
                }
                else
                {
                    MessageBox.Show("No jobs found.");
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                    row.ReadOnly = true;
                dataGridView1.ClearSelection();

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                    col.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching jobs: " + ex.Message);
            }
        }

        private void RRRefresh_Click(object sender, EventArgs e)
        {
            AvailableJob();
        }
    }
}
