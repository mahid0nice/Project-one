using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Project_one
{
    public partial class Customer_Dashboard : Form
    {
        public Customer_Dashboard()
        {
            InitializeComponent();
            ShowPanel(0);
        }
        internal int duplicateId;
        public Customer_Dashboard(int duplicateId)
        {
            InitializeComponent();
            ShowPanel(0);
            this.duplicateId = duplicateId;
        }

        void ShowPanel(int panel)
        {

            IdPassPanel.Visible = panel >= 1;
            rulesPanel.Visible = panel >= 2;
            Profile_Panel.Visible = panel >= 3;
            CurrentJob_panel.Visible = panel >= 4;
            JobPostPanel.Visible = panel >= 5;
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            int result = showCustomerProfile();
            if (result == 0)
            {
                MessageBox.Show("No Admin Found");
            }

            else
            {
                ShowPanel(3);
            }
        }

        int showCustomerProfile()
        {
            try
            {
                Customer cc = new Customer();
                cc = cc.showCustomerDetails(duplicateId);
                if (cc != null)
                {
                    adminNameText.Text = cc.C_Name;
                    adminNidText.Text = cc.C_NID.ToString();
                    adminFatherText.Text = cc.C_Company;
                    adminMotherText.Text = cc.C_Position;
                    adminPhoneText.Text = cc.C_PhoneNumber.ToString();
                    adminGmailText.Text = cc.C_Email;
                    adminAddressText.Text = cc.C_Address;
                    adminGenderText.Text = cc.C_Gender;
                    adminDobText.Text = cc.C_DOB?.ToString("dd-MM-yyyy") ?? "";

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




        private void button3_Click(object sender, EventArgs e)
        {
            string currPassWord = oldPass.Text;
            string newPassWord = newpass.Text;

            if (string.IsNullOrEmpty(currPassWord) || string.IsNullOrEmpty(newPassWord))
            {
                MessageBox.Show("Please enter both current and new passwords.");
                return;
            }

            try
            {
                Customer cus = new Customer();

                bool updated = cus.UpdatePass(duplicateId, currPassWord, newPassWord);

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

        private void button1_Click(object sender, EventArgs e)
        {
            ShowPanel(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new User_login_page().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowRulesGrid();
            rulesSearch_text.Text = "";
            ShowPanel(2);
        }
        private void ShowRulesGrid()
        {
            try
            {
                Volunteer vv = new Volunteer();
                DataTable dt = vv.ShowRules();
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

        private void btn_vol_request_Click(object sender, EventArgs e)
        {
            LoadCustomerJobs();
            ShowPanel(4);
        }

        private void LoadCustomerJobs()
        {
            Customer cus = new Customer();
            dataGridView1.DataSource = cus.ShowMyJobs(duplicateId);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.ReadOnly = true;
            }

            dataGridView1.ClearSelection();
            RRRefresh.Visible = false;
            search_text.Text = "";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.ReadOnly = true;
            }
        }

        private void ICActive_Click(object sender, EventArgs e)
        {

        }

        private void C1Search_Click(object sender, EventArgs e)
        {
            string search = search_text.Text.Trim();

            try
            {
                Customer cus = new Customer();
                DataTable dt = cus.SearchMyJobs(search, duplicateId);

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

        private void ICDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count != 1)
                    return;

                int jobId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Job_Id"].Value);

                DialogResult dr = MessageBox.Show(
                    "Are you sure you want to delete this job?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    Customer cc = new Customer();
                    int result = cc.DeleteJob(jobId);

                    if (result == 1)
                    {
                        MessageBox.Show("Job deleted successfully.");
                        LoadCustomerJobs();
                    }
                    else
                    {
                        MessageBox.Show("Delete failed. Job may not exist.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the job: " + ex.Message);
            }

        }

        private void RRRefresh_Click(object sender, EventArgs e)
        {

            LoadCustomerJobs();
        }

        private void btn_vol_details_Click(object sender, EventArgs e)
        {
            ShowPanel(5); 
        }



        private void SubmitJob_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(jobidText.Text.Trim(), out int jobId))
                {
                    MessageBox.Show("Invalid Job ID.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(jobText.Text))
                {
                    MessageBox.Show("Job name is required.");
                    return;
                }

                if (!decimal.TryParse(paymentTextBox.Text.Trim(), out decimal payment))
                {
                    MessageBox.Show("Invalid payment amount.");
                    return;
                }

                DialogResult dr = MessageBox.Show(
                    "Are you sure you want to submit this job?",
                    "Confirm Job Submission",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dr != DialogResult.Yes)
                    return;

                Customer cs = new Customer();
                int result = cs.PostJob(jobId, jobText.Text.Trim(), duplicateId, payment);

                if (result > 0)
                {
                    MessageBox.Show("Job posted successfully.");
                    jobidText.Clear();
                    jobText.Clear();
                    paymentTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Job post failed. Job ID may already exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }
        }
    }
}
