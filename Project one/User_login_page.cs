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

        }

        private void volunteer_sign_up_button_Click(object sender, EventArgs e)
        {
            new Registration_Page_for_volunteer().Show();
            this.Hide();
        }

        private void customer_sign_up_button_Click(object sender, EventArgs e)
        {
            //last
        }
    }
}
