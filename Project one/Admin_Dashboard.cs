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

        private void admin_Profile_button_Click(object sender, EventArgs e)
        {
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
    }
}
