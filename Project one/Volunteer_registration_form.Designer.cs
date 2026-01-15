namespace Project_one
{
    partial class Volunteer_registration_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Volunteer_registration_form));
            this.Welcome_panel = new System.Windows.Forms.Panel();
            this.volunteer_registration_form_panel = new System.Windows.Forms.Panel();
            this.Welcome_picturebox = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.registration_form_welcome_label = new System.Windows.Forms.Label();
            this.Welcome_panel.SuspendLayout();
            this.volunteer_registration_form_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Welcome_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcome_panel
            // 
            this.Welcome_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Welcome_panel.Controls.Add(this.volunteer_registration_form_panel);
            this.Welcome_panel.Controls.Add(this.Welcome_picturebox);
            this.Welcome_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Welcome_panel.Location = new System.Drawing.Point(0, 0);
            this.Welcome_panel.Name = "Welcome_panel";
            this.Welcome_panel.Size = new System.Drawing.Size(1104, 839);
            this.Welcome_panel.TabIndex = 0;
            // 
            // volunteer_registration_form_panel
            // 
            this.volunteer_registration_form_panel.BackgroundImage = global::Project_one.Properties.Resources._360_F_588241010_cdQJ2QTsyDtt36jZsAFR45aAXICnPAzR1;
            this.volunteer_registration_form_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.volunteer_registration_form_panel.Controls.Add(this.registration_form_welcome_label);
            this.volunteer_registration_form_panel.Location = new System.Drawing.Point(0, 0);
            this.volunteer_registration_form_panel.Name = "volunteer_registration_form_panel";
            this.volunteer_registration_form_panel.Size = new System.Drawing.Size(1104, 780);
            this.volunteer_registration_form_panel.TabIndex = 1;
            // 
            // Welcome_picturebox
            // 
            this.Welcome_picturebox.BackgroundImage = global::Project_one.Properties.Resources.welcome_image1;
            this.Welcome_picturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Welcome_picturebox.Location = new System.Drawing.Point(0, 0);
            this.Welcome_picturebox.Name = "Welcome_picturebox";
            this.Welcome_picturebox.Size = new System.Drawing.Size(1104, 780);
            this.Welcome_picturebox.TabIndex = 0;
            this.Welcome_picturebox.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // registration_form_welcome_label
            // 
            this.registration_form_welcome_label.AutoSize = true;
            this.registration_form_welcome_label.BackColor = System.Drawing.Color.Transparent;
            this.registration_form_welcome_label.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration_form_welcome_label.Location = new System.Drawing.Point(278, 44);
            this.registration_form_welcome_label.Name = "registration_form_welcome_label";
            this.registration_form_welcome_label.Size = new System.Drawing.Size(426, 29);
            this.registration_form_welcome_label.TabIndex = 0;
            this.registration_form_welcome_label.Text = "Enter all the information correctly";
            // 
            // Volunteer_registration_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1104, 839);
            this.Controls.Add(this.Welcome_panel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Volunteer_registration_form";
            this.Text = "Volunteer_registration_form";
            this.Welcome_panel.ResumeLayout(false);
            this.volunteer_registration_form_panel.ResumeLayout(false);
            this.volunteer_registration_form_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Welcome_picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Welcome_panel;
        private System.Windows.Forms.PictureBox Welcome_picturebox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel volunteer_registration_form_panel;
        private System.Windows.Forms.Label registration_form_welcome_label;
    }
}