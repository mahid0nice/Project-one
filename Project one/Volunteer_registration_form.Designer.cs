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
            this.SuspendLayout();
            // 
            // Welcome_panel
            // 
            this.Welcome_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Welcome_panel;
        private System.Windows.Forms.ImageList imageList1;
    }
}