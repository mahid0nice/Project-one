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
    public partial class Employee_Dashboard : Form
    {
        int duplicateId;
        public Employee_Dashboard()
        {
            InitializeComponent();
           
        }
        public Employee_Dashboard(int duplicateId)
        {
            this.duplicateId = duplicateId;
            InitializeComponent();
            MessageBox.Show($"Employee ID: {duplicateId}");
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {

        }
    }
}
