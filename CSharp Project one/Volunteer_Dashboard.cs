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
            // show default top-level panel
            ShowOnlyPanel(volunteer_profile_view_panel);
        }

        // Hide only panels that are direct children of the form.
        // This avoids hiding container panels that must be visible for nested panels to show.
        private void HideAllPanels()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                {
                    c.Visible = false;
                }
            }
        }

        // Show the requested panel and ensure its parent chain is visible.
        private void ShowOnlyPanel(Panel panelToShow)
        {
            if (panelToShow == null)
                return;

            // Hide top-level panels first
            HideAllPanels();

            // Ensure all parents of the panel are visible (so nested panels can be shown)
            Control current = panelToShow.Parent;
            while (current != null)
            {
                if (current is Panel)
                    current.Visible = true;
                current = current.Parent;
            }

            panelToShow.Visible = true;
            panelToShow.BringToFront();
        }

        private void volunteer_profile_view_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Phone_label_Click(object sender, EventArgs e)
        {

        }

        private void Volunteer_Name_Show_label_Click(object sender, EventArgs e)
        {

        }

        private void Gmail_label_Click(object sender, EventArgs e)
        {

        }

        private void num_label_Click(object sender, EventArgs e)
        {

        }

        private void Gender_label_Click(object sender, EventArgs e)
        {

        }

        private void Volunteer_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void Volunteer_Profile_Button_Click(object sender, EventArgs e)
        {
            ShowOnlyPanel(volunteer_profile_view_panel);
        }

        private void Job_list_button_Click(object sender, EventArgs e)
        {
            ShowOnlyPanel(Job_apply_Search_panel);
        }
    }
}