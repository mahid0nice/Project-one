using System;
using System.Windows.Forms;

namespace Project_one
{
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
            AdminProfile_panel.Visible = false;
            adminHireEmployee_panel.Visible = false;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        // string c = Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project-one-db;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30,
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
        void showProfile()
        {
            try
            {
                Profile_Cancel.Visible = false;
                Profile_Save.Visible = false;
                showProfileTextBox(false);
                showProfileLabel(true);
                Admin ad = new Admin();
                ad = Admin.showAdminDetails(1);
                adminNameText.Text = ad.Name;
                adminNidText.Text = ad.NID.ToString();
                adminFatherText.Text = ad.FatherName;
                adminMotherText.Text = ad.MotherName;
                adminPhoneText.Text = ad.PhoneNumber.ToString();
                adminGmailText.Text = ad.Gmail;
                adminAddressText.Text = ad.Address;
                adminReligionText.Text = ad.Religion;
                adminMaritalText.Text = ad.MaritalStatus;
                adminBloodText.Text = ad.Gender;
                adminBloodText.Text = ad.BloodGroup;
                adminDobText.Text = ad.Dob;
                adminGenderText.Text = ad.Gender;
                Profile_Update.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void admin_Profile_button_Click(object sender, EventArgs e)
        {
            showProfile();
            adminHireEmployee_panel.Visible = false;
            AdminProfile_panel.Visible = true;
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
            AdminProfile_panel.Visible = true;
            adminHireEmployee_panel.Visible = true;

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
    }
}
