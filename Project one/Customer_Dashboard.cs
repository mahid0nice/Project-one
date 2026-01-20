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
            RRefresh_button.Visible = true;
            string search = rulesSearch_text.Text.Trim();
            Volunteer vv = new Volunteer();
            DataTable dt = vv.SearchRules(search);

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
