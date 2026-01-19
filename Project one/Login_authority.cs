using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_one
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Login_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            labeltime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void Log_button_Click(object sender, EventArgs e)
        {
            if (authorities_combobox.SelectedItem == null)
            {
                MessageBox.Show("Please select authority.");
                return;
            }

            string password = Password_textbox.Text;
            string idText = userId_textbox.Text;
            string authority = authorities_combobox.SelectedItem.ToString();

            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }

            if (authority == "Admin")
            {
                Admin ad = new Admin
                {
                    Id = id,
                    Password = password
                };

                if (ad.CheckValidation())
                {
                    new Admin_Dashboard().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Admin ID or Password.");
                }
            }
            else if (authority == "Employee")
            {
                Employee emp = new Employee
                {
                    Id = id,
                    Password = password
                };

                if (emp.CheckValidation())
                {
                    new Employee_Dashboard().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Employee ID or Password.");
                }
            }
            else
            {
                MessageBox.Show("Please select a valid info.");
            }
        }


    }
}
