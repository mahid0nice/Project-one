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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_profile = new System.Windows.Forms.Button();
            this.Registration_lebel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_vol_request = new System.Windows.Forms.Button();
            this.btn_vol_details = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.IdPassPanel = new System.Windows.Forms.Panel();
            this.oldPassWord = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.newpass = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.oldPass = new System.Windows.Forms.TextBox();
            this.Welcome_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.IdPassPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Welcome_panel
            // 
            this.Welcome_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Welcome_panel.Controls.Add(this.panel1);
            this.Welcome_panel.Controls.Add(this.IdPassPanel);
            this.Welcome_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Welcome_panel.Location = new System.Drawing.Point(0, 0);
            this.Welcome_panel.Name = "Welcome_panel";
            this.Welcome_panel.Size = new System.Drawing.Size(1022, 648);
            this.Welcome_panel.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.btn_profile);
            this.panel1.Controls.Add(this.Registration_lebel);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_vol_request);
            this.panel1.Controls.Add(this.btn_vol_details);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(8, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 609);
            this.panel1.TabIndex = 92;
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_profile.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profile.Location = new System.Drawing.Point(51, 178);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(179, 33);
            this.btn_profile.TabIndex = 83;
            this.btn_profile.Text = "Profile";
            this.btn_profile.UseVisualStyleBackColor = false;
            // 
            // Registration_lebel
            // 
            this.Registration_lebel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Registration_lebel.AutoSize = true;
            this.Registration_lebel.BackColor = System.Drawing.Color.Transparent;
            this.Registration_lebel.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration_lebel.Location = new System.Drawing.Point(28, 46);
            this.Registration_lebel.Name = "Registration_lebel";
            this.Registration_lebel.Size = new System.Drawing.Size(241, 24);
            this.Registration_lebel.TabIndex = 82;
            this.Registration_lebel.Text = "Customer Dashboard";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(51, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 33);
            this.button2.TabIndex = 87;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(51, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 33);
            this.button1.TabIndex = 86;
            this.button1.Text = "Update Password";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_vol_request
            // 
            this.btn_vol_request.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_vol_request.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vol_request.Location = new System.Drawing.Point(51, 229);
            this.btn_vol_request.Name = "btn_vol_request";
            this.btn_vol_request.Size = new System.Drawing.Size(179, 33);
            this.btn_vol_request.TabIndex = 84;
            this.btn_vol_request.Text = "Current Job";
            this.btn_vol_request.UseVisualStyleBackColor = false;
            // 
            // btn_vol_details
            // 
            this.btn_vol_details.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_vol_details.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vol_details.Location = new System.Drawing.Point(51, 282);
            this.btn_vol_details.Name = "btn_vol_details";
            this.btn_vol_details.Size = new System.Drawing.Size(179, 33);
            this.btn_vol_details.TabIndex = 85;
            this.btn_vol_details.Text = "Post Job";
            this.btn_vol_details.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(51, 338);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 33);
            this.button4.TabIndex = 88;
            this.button4.Text = "Rules";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // IdPassPanel
            // 
            this.IdPassPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.IdPassPanel.Controls.Add(this.oldPassWord);
            this.IdPassPanel.Controls.Add(this.button3);
            this.IdPassPanel.Controls.Add(this.newpass);
            this.IdPassPanel.Controls.Add(this.Password);
            this.IdPassPanel.Controls.Add(this.oldPass);
            this.IdPassPanel.Location = new System.Drawing.Point(306, 20);
            this.IdPassPanel.Name = "IdPassPanel";
            this.IdPassPanel.Size = new System.Drawing.Size(709, 609);
            this.IdPassPanel.TabIndex = 91;
            // 
            // oldPassWord
            // 
            this.oldPassWord.AutoSize = true;
            this.oldPassWord.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.oldPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPassWord.Location = new System.Drawing.Point(108, 272);
            this.oldPassWord.Name = "oldPassWord";
            this.oldPassWord.Size = new System.Drawing.Size(206, 25);
            this.oldPassWord.TabIndex = 8;
            this.oldPassWord.Text = "Current Password:";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.MediumPurple;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(269, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 38);
            this.button3.TabIndex = 7;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // newpass
            // 
            this.newpass.Location = new System.Drawing.Point(331, 319);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(219, 20);
            this.newpass.TabIndex = 6;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.SystemColors.GrayText;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(130, 314);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(173, 25);
            this.Password.TabIndex = 5;
            this.Password.Text = "New Password:";
            // 
            // oldPass
            // 
            this.oldPass.Location = new System.Drawing.Point(331, 272);
            this.oldPass.Name = "oldPass";
            this.oldPass.Size = new System.Drawing.Size(217, 20);
            this.oldPass.TabIndex = 9;
            // 
            // Volunteer_registration_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1022, 648);
            this.Controls.Add(this.Welcome_panel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Volunteer_registration_form";
            this.Text = "Volunteer_registration_form";
            this.Welcome_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.IdPassPanel.ResumeLayout(false);
            this.IdPassPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Welcome_panel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Label Registration_lebel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_vol_request;
        private System.Windows.Forms.Button btn_vol_details;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel IdPassPanel;
        private System.Windows.Forms.Label oldPassWord;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox oldPass;
    }
}