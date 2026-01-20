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
    public partial class User_login_page : Form
    {
        public User_login_page()
        {
            InitializeComponent();
        }

        private void log_in_2_timer_Tick(object sender, EventArgs e)
        {
            Timer_3_label.Text = DateTime.Now.ToLongTimeString();
        }

        private void user_username_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void log_is_as_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Log_in_user_button_Click(object sender, EventArgs e)
        {
            if (log_is_as_combobox.SelectedItem == null)
            {
                MessageBox.Show("Please select user type.");
                return;
            }

            string password = password_textbox.Text.Trim();
            string idText = userId_textbox.Text.Trim();
            string userType = log_is_as_combobox.SelectedItem.ToString();

            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }

            if (userType == "Customer")
            {
                Customer cust = new Customer
                {
                    C_Id = id,
                    C_Password = password
                };

                if (cust.CheckValidation())
                {
                    new Customer_Dashboard(id).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Customer ID or Password.");
                }
            }
            else if (userType == "Volunteer")
            {
                Volunteer vol = new Volunteer
                {
                    Id = id,
                    Password = password
                };

                if (vol.CheckValidation())
                {
                    new Volunteer_Dashboard(id).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Volunteer ID or Password.");
                }
            }
            else
            {
                MessageBox.Show("Please select a valid user type.");
            }
        }

        private void volunteer_sign_up_button_Click(object sender, EventArgs e)
        {
            new Registration_Page_for_volunteer().Show();
            this.Hide();
        }

        private void customer_sign_up_button_Click(object sender, EventArgs e)
        {
            new Registration_form_customer().Show();
            this.Hide();
        }
    }
}
