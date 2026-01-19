namespace Project_one
{
    partial class Registration_Page_For_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration_Page_For_Employee));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.photo_size_lebel = new System.Windows.Forms.Label();
            this.picture_label = new System.Windows.Forms.Label();
            this.Upload_photo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.registration_panel = new System.Windows.Forms.Panel();
            this.DobPicker = new System.Windows.Forms.DateTimePicker();
            this.submit_button = new System.Windows.Forms.Button();
            this.DesignationText = new System.Windows.Forms.TextBox();
            this.Designation_label = new System.Windows.Forms.Label();
            this.employee_id_textbox = new System.Windows.Forms.TextBox();
            this.employee_id = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.blood_group_label = new System.Windows.Forms.Label();
            this.emergency_number_textbox = new System.Windows.Forms.TextBox();
            this.emergency_number = new System.Windows.Forms.Label();
            this.marital_status_textbox = new System.Windows.Forms.TextBox();
            this.Marital_Status_lebel = new System.Windows.Forms.Label();
            this.relegion_textbox = new System.Windows.Forms.TextBox();
            this.relegion_label = new System.Windows.Forms.Label();
            this.Gender_groupbox = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.others_gender_radiobutton = new System.Windows.Forms.RadioButton();
            this.Female_radioButton = new System.Windows.Forms.RadioButton();
            this.male_radioButton = new System.Windows.Forms.RadioButton();
            this.gender_label = new System.Windows.Forms.Label();
            this.parAddress_textbox = new System.Windows.Forms.TextBox();
            this.permanent_address_label = new System.Windows.Forms.Label();
            this.Address_textbox = new System.Windows.Forms.TextBox();
            this.address_label = new System.Windows.Forms.Label();
            this.mothers_textbox = new System.Windows.Forms.TextBox();
            this.fathers_textbox = new System.Windows.Forms.TextBox();
            this.nid_textbox = new System.Windows.Forms.TextBox();
            this.nid_label = new System.Windows.Forms.Label();
            this.Gmail_label = new System.Windows.Forms.Label();
            this.birthdate_label = new System.Windows.Forms.Label();
            this.last_name_textbox = new System.Windows.Forms.TextBox();
            this.nickname_textbox = new System.Windows.Forms.TextBox();
            this.phone_number_textbox = new System.Windows.Forms.TextBox();
            this.gmail_textbox = new System.Windows.Forms.TextBox();
            this.first_name_textbox = new System.Windows.Forms.TextBox();
            this.number_label = new System.Windows.Forms.Label();
            this.Nick_name_label = new System.Windows.Forms.Label();
            this.mothers_name_label = new System.Windows.Forms.Label();
            this.fathers_name_label = new System.Windows.Forms.Label();
            this.Lastname_label = new System.Windows.Forms.Label();
            this.Registration_lebel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.registration_panel.SuspendLayout();
            this.Gender_groupbox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Project_one.Properties.Resources._new;
            this.pictureBox1.Location = new System.Drawing.Point(123, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // photo_size_lebel
            // 
            this.photo_size_lebel.AutoSize = true;
            this.photo_size_lebel.BackColor = System.Drawing.Color.Silver;
            this.photo_size_lebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photo_size_lebel.Location = new System.Drawing.Point(83, 218);
            this.photo_size_lebel.Name = "photo_size_lebel";
            this.photo_size_lebel.Size = new System.Drawing.Size(268, 16);
            this.photo_size_lebel.TabIndex = 1;
            this.photo_size_lebel.Text = "Upload a clear photo size (150 X 150) ";
            // 
            // picture_label
            // 
            this.picture_label.AutoSize = true;
            this.picture_label.Location = new System.Drawing.Point(833, 234);
            this.picture_label.Name = "picture_label";
            this.picture_label.Size = new System.Drawing.Size(0, 13);
            this.picture_label.TabIndex = 2;
            // 
            // Upload_photo
            // 
            this.Upload_photo.BackColor = System.Drawing.SystemColors.Info;
            this.Upload_photo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload_photo.Location = new System.Drawing.Point(143, 262);
            this.Upload_photo.Name = "Upload_photo";
            this.Upload_photo.Size = new System.Drawing.Size(111, 34);
            this.Upload_photo.TabIndex = 3;
            this.Upload_photo.Text = "Upload photo";
            this.Upload_photo.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // registration_panel
            // 
            this.registration_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registration_panel.BackgroundImage = global::Project_one.Properties.Resources.light;
            this.registration_panel.Controls.Add(this.DobPicker);
            this.registration_panel.Controls.Add(this.submit_button);
            this.registration_panel.Controls.Add(this.DesignationText);
            this.registration_panel.Controls.Add(this.Designation_label);
            this.registration_panel.Controls.Add(this.employee_id_textbox);
            this.registration_panel.Controls.Add(this.employee_id);
            this.registration_panel.Controls.Add(this.comboBox1);
            this.registration_panel.Controls.Add(this.blood_group_label);
            this.registration_panel.Controls.Add(this.emergency_number_textbox);
            this.registration_panel.Controls.Add(this.emergency_number);
            this.registration_panel.Controls.Add(this.marital_status_textbox);
            this.registration_panel.Controls.Add(this.Marital_Status_lebel);
            this.registration_panel.Controls.Add(this.relegion_textbox);
            this.registration_panel.Controls.Add(this.relegion_label);
            this.registration_panel.Controls.Add(this.Gender_groupbox);
            this.registration_panel.Controls.Add(this.gender_label);
            this.registration_panel.Controls.Add(this.parAddress_textbox);
            this.registration_panel.Controls.Add(this.permanent_address_label);
            this.registration_panel.Controls.Add(this.Address_textbox);
            this.registration_panel.Controls.Add(this.address_label);
            this.registration_panel.Controls.Add(this.mothers_textbox);
            this.registration_panel.Controls.Add(this.fathers_textbox);
            this.registration_panel.Controls.Add(this.nid_textbox);
            this.registration_panel.Controls.Add(this.nid_label);
            this.registration_panel.Controls.Add(this.Gmail_label);
            this.registration_panel.Controls.Add(this.birthdate_label);
            this.registration_panel.Controls.Add(this.last_name_textbox);
            this.registration_panel.Controls.Add(this.nickname_textbox);
            this.registration_panel.Controls.Add(this.phone_number_textbox);
            this.registration_panel.Controls.Add(this.gmail_textbox);
            this.registration_panel.Controls.Add(this.first_name_textbox);
            this.registration_panel.Controls.Add(this.number_label);
            this.registration_panel.Controls.Add(this.Nick_name_label);
            this.registration_panel.Controls.Add(this.mothers_name_label);
            this.registration_panel.Controls.Add(this.fathers_name_label);
            this.registration_panel.Controls.Add(this.Lastname_label);
            this.registration_panel.Controls.Add(this.Registration_lebel);
            this.registration_panel.Controls.Add(this.label1);
            this.registration_panel.Location = new System.Drawing.Point(0, 0);
            this.registration_panel.Name = "registration_panel";
            this.registration_panel.Size = new System.Drawing.Size(744, 839);
            this.registration_panel.TabIndex = 9;
            this.registration_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.registration_panel_Paint);
            // 
            // DobPicker
            // 
            this.DobPicker.Location = new System.Drawing.Point(528, 144);
            this.DobPicker.Name = "DobPicker";
            this.DobPicker.Size = new System.Drawing.Size(200, 20);
            this.DobPicker.TabIndex = 45;
            // 
            // submit_button
            // 
            this.submit_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.Location = new System.Drawing.Point(257, 691);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(157, 41);
            this.submit_button.TabIndex = 43;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = false;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // DesignationText
            // 
            this.DesignationText.Location = new System.Drawing.Point(184, 589);
            this.DesignationText.Name = "DesignationText";
            this.DesignationText.Size = new System.Drawing.Size(193, 20);
            this.DesignationText.TabIndex = 42;
            // 
            // Designation_label
            // 
            this.Designation_label.AutoSize = true;
            this.Designation_label.BackColor = System.Drawing.Color.Transparent;
            this.Designation_label.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Designation_label.ForeColor = System.Drawing.Color.Black;
            this.Designation_label.Location = new System.Drawing.Point(17, 588);
            this.Designation_label.Name = "Designation_label";
            this.Designation_label.Size = new System.Drawing.Size(107, 21);
            this.Designation_label.TabIndex = 41;
            this.Designation_label.Text = "Designation :";
            // 
            // employee_id_textbox
            // 
            this.employee_id_textbox.Location = new System.Drawing.Point(184, 552);
            this.employee_id_textbox.Name = "employee_id_textbox";
            this.employee_id_textbox.Size = new System.Drawing.Size(193, 20);
            this.employee_id_textbox.TabIndex = 40;
            // 
            // employee_id
            // 
            this.employee_id.AutoSize = true;
            this.employee_id.BackColor = System.Drawing.Color.Transparent;
            this.employee_id.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_id.ForeColor = System.Drawing.Color.Black;
            this.employee_id.Location = new System.Drawing.Point(17, 552);
            this.employee_id.Name = "employee_id";
            this.employee_id.Size = new System.Drawing.Size(114, 21);
            this.employee_id.TabIndex = 39;
            this.employee_id.Text = "Employee ID :";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.comboBox1.Location = new System.Drawing.Point(243, 408);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(74, 21);
            this.comboBox1.TabIndex = 38;
            // 
            // blood_group_label
            // 
            this.blood_group_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.blood_group_label.AutoSize = true;
            this.blood_group_label.BackColor = System.Drawing.Color.Transparent;
            this.blood_group_label.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blood_group_label.ForeColor = System.Drawing.Color.Black;
            this.blood_group_label.Location = new System.Drawing.Point(19, 408);
            this.blood_group_label.Name = "blood_group_label";
            this.blood_group_label.Size = new System.Drawing.Size(114, 21);
            this.blood_group_label.TabIndex = 37;
            this.blood_group_label.Text = "Blood Group :";
            // 
            // emergency_number_textbox
            // 
            this.emergency_number_textbox.Location = new System.Drawing.Point(184, 203);
            this.emergency_number_textbox.Name = "emergency_number_textbox";
            this.emergency_number_textbox.Size = new System.Drawing.Size(230, 20);
            this.emergency_number_textbox.TabIndex = 36;
            // 
            // emergency_number
            // 
            this.emergency_number.AutoSize = true;
            this.emergency_number.BackColor = System.Drawing.Color.Transparent;
            this.emergency_number.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emergency_number.ForeColor = System.Drawing.Color.Black;
            this.emergency_number.Location = new System.Drawing.Point(17, 203);
            this.emergency_number.Name = "emergency_number";
            this.emergency_number.Size = new System.Drawing.Size(164, 21);
            this.emergency_number.TabIndex = 35;
            this.emergency_number.Text = "Emergency Number :";
            // 
            // marital_status_textbox
            // 
            this.marital_status_textbox.Location = new System.Drawing.Point(184, 441);
            this.marital_status_textbox.Name = "marital_status_textbox";
            this.marital_status_textbox.Size = new System.Drawing.Size(230, 20);
            this.marital_status_textbox.TabIndex = 34;
            // 
            // Marital_Status_lebel
            // 
            this.Marital_Status_lebel.AutoSize = true;
            this.Marital_Status_lebel.BackColor = System.Drawing.Color.Transparent;
            this.Marital_Status_lebel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marital_Status_lebel.ForeColor = System.Drawing.Color.Black;
            this.Marital_Status_lebel.Location = new System.Drawing.Point(19, 440);
            this.Marital_Status_lebel.Name = "Marital_Status_lebel";
            this.Marital_Status_lebel.Size = new System.Drawing.Size(120, 21);
            this.Marital_Status_lebel.TabIndex = 33;
            this.Marital_Status_lebel.Text = "Marital Status :";
            // 
            // relegion_textbox
            // 
            this.relegion_textbox.Location = new System.Drawing.Point(184, 340);
            this.relegion_textbox.Name = "relegion_textbox";
            this.relegion_textbox.Size = new System.Drawing.Size(230, 20);
            this.relegion_textbox.TabIndex = 32;
            // 
            // relegion_label
            // 
            this.relegion_label.AutoSize = true;
            this.relegion_label.BackColor = System.Drawing.Color.Transparent;
            this.relegion_label.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relegion_label.ForeColor = System.Drawing.Color.Black;
            this.relegion_label.Location = new System.Drawing.Point(17, 340);
            this.relegion_label.Name = "relegion_label";
            this.relegion_label.Size = new System.Drawing.Size(84, 21);
            this.relegion_label.TabIndex = 31;
            this.relegion_label.Text = "Relegion :";
            // 
            // Gender_groupbox
            // 
            this.Gender_groupbox.BackColor = System.Drawing.Color.Transparent;
            this.Gender_groupbox.Controls.Add(this.maskedTextBox1);
            this.Gender_groupbox.Controls.Add(this.others_gender_radiobutton);
            this.Gender_groupbox.Controls.Add(this.Female_radioButton);
            this.Gender_groupbox.Controls.Add(this.male_radioButton);
            this.Gender_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender_groupbox.Location = new System.Drawing.Point(184, 371);
            this.Gender_groupbox.Name = "Gender_groupbox";
            this.Gender_groupbox.Size = new System.Drawing.Size(404, 36);
            this.Gender_groupbox.TabIndex = 30;
            this.Gender_groupbox.TabStop = false;
            this.Gender_groupbox.Enter += new System.EventHandler(this.Gender_groupbox_Enter);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(279, 8);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(105, 20);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // others_gender_radiobutton
            // 
            this.others_gender_radiobutton.AutoSize = true;
            this.others_gender_radiobutton.Location = new System.Drawing.Point(209, 7);
            this.others_gender_radiobutton.Name = "others_gender_radiobutton";
            this.others_gender_radiobutton.Size = new System.Drawing.Size(64, 17);
            this.others_gender_radiobutton.TabIndex = 2;
            this.others_gender_radiobutton.TabStop = true;
            this.others_gender_radiobutton.Text = "Other :";
            this.others_gender_radiobutton.UseVisualStyleBackColor = true;
            // 
            // Female_radioButton
            // 
            this.Female_radioButton.AutoSize = true;
            this.Female_radioButton.Location = new System.Drawing.Point(110, 8);
            this.Female_radioButton.Name = "Female_radioButton";
            this.Female_radioButton.Size = new System.Drawing.Size(65, 17);
            this.Female_radioButton.TabIndex = 1;
            this.Female_radioButton.TabStop = true;
            this.Female_radioButton.Text = "Female";
            this.Female_radioButton.UseVisualStyleBackColor = true;
            // 
            // male_radioButton
            // 
            this.male_radioButton.AutoSize = true;
            this.male_radioButton.Location = new System.Drawing.Point(22, 8);
            this.male_radioButton.Name = "male_radioButton";
            this.male_radioButton.Size = new System.Drawing.Size(52, 17);
            this.male_radioButton.TabIndex = 0;
            this.male_radioButton.TabStop = true;
            this.male_radioButton.Text = "Male";
            this.male_radioButton.UseVisualStyleBackColor = true;
            // 
            // gender_label
            // 
            this.gender_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gender_label.AutoSize = true;
            this.gender_label.BackColor = System.Drawing.Color.Transparent;
            this.gender_label.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_label.ForeColor = System.Drawing.Color.Black;
            this.gender_label.Location = new System.Drawing.Point(17, 376);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(73, 21);
            this.gender_label.TabIndex = 29;
            this.gender_label.Text = "Gender :";
            // 
            // parAddress_textbox
            // 
            this.parAddress_textbox.Location = new System.Drawing.Point(184, 314);
            this.parAddress_textbox.Name = "parAddress_textbox";
            this.parAddress_textbox.Size = new System.Drawing.Size(230, 20);
            this.parAddress_textbox.TabIndex = 28;
            // 
            // permanent_address_label
            // 
            this.permanent_address_label.AutoSize = true;
            this.permanent_address_label.BackColor = System.Drawing.Color.Transparent;
            this.permanent_address_label.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permanent_address_label.ForeColor = System.Drawing.Color.Black;
            this.permanent_address_label.Location = new System.Drawing.Point(17, 314);
            this.permanent_address_label.Name = "permanent_address_label";
            this.permanent_address_label.Size = new System.Drawing.Size(161, 21);
            this.permanent_address_label.TabIndex = 27;
            this.permanent_address_label.Text = "Permanent Address :";
            // 
            // Address_textbox
            // 
            this.Address_textbox.Location = new System.Drawing.Point(184, 288);
            this.Address_textbox.Name = "Address_textbox";
            this.Address_textbox.Size = new System.Drawing.Size(230, 20);
            this.Address_textbox.TabIndex = 26;
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.BackColor = System.Drawing.Color.Transparent;
            this.address_label.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_label.ForeColor = System.Drawing.Color.Black;
            this.address_label.Location = new System.Drawing.Point(19, 287);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(78, 21);
            this.address_label.TabIndex = 25;
            this.address_label.Text = "Address :";
            // 
            // mothers_textbox
            // 
            this.mothers_textbox.Location = new System.Drawing.Point(466, 487);
            this.mothers_textbox.Name = "mothers_textbox";
            this.mothers_textbox.Size = new System.Drawing.Size(203, 20);
            this.mothers_textbox.TabIndex = 24;
            // 
            // fathers_textbox
            // 
            this.fathers_textbox.Location = new System.Drawing.Point(145, 489);
            this.fathers_textbox.Name = "fathers_textbox";
            this.fathers_textbox.Size = new System.Drawing.Size(193, 20);
            this.fathers_textbox.TabIndex = 23;
            this.fathers_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nid_textbox
            // 
            this.nid_textbox.Location = new System.Drawing.Point(184, 262);
            this.nid_textbox.Name = "nid_textbox";
            this.nid_textbox.Size = new System.Drawing.Size(230, 20);
            this.nid_textbox.TabIndex = 22;
            // 
            // nid_label
            // 
            this.nid_label.AutoSize = true;
            this.nid_label.BackColor = System.Drawing.Color.Transparent;
            this.nid_label.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nid_label.ForeColor = System.Drawing.Color.Black;
            this.nid_label.Location = new System.Drawing.Point(17, 260);
            this.nid_label.Name = "nid_label";
            this.nid_label.Size = new System.Drawing.Size(80, 21);
            this.nid_label.TabIndex = 21;
            this.nid_label.Text = "NID NO :";
            // 
            // Gmail_label
            // 
            this.Gmail_label.AutoSize = true;
            this.Gmail_label.BackColor = System.Drawing.Color.Transparent;
            this.Gmail_label.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gmail_label.ForeColor = System.Drawing.Color.Black;
            this.Gmail_label.Location = new System.Drawing.Point(19, 235);
            this.Gmail_label.Name = "Gmail_label";
            this.Gmail_label.Size = new System.Drawing.Size(63, 21);
            this.Gmail_label.TabIndex = 20;
            this.Gmail_label.Text = "Gmail :";
            // 
            // birthdate_label
            // 
            this.birthdate_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.birthdate_label.AutoSize = true;
            this.birthdate_label.BackColor = System.Drawing.Color.Transparent;
            this.birthdate_label.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdate_label.ForeColor = System.Drawing.Color.Black;
            this.birthdate_label.Location = new System.Drawing.Point(421, 143);
            this.birthdate_label.Name = "birthdate_label";
            this.birthdate_label.Size = new System.Drawing.Size(89, 21);
            this.birthdate_label.TabIndex = 16;
            this.birthdate_label.Text = "Birth Date:";
            // 
            // last_name_textbox
            // 
            this.last_name_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.last_name_textbox.Location = new System.Drawing.Point(533, 115);
            this.last_name_textbox.Name = "last_name_textbox";
            this.last_name_textbox.Size = new System.Drawing.Size(195, 20);
            this.last_name_textbox.TabIndex = 15;
            // 
            // nickname_textbox
            // 
            this.nickname_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nickname_textbox.Location = new System.Drawing.Point(183, 142);
            this.nickname_textbox.Name = "nickname_textbox";
            this.nickname_textbox.Size = new System.Drawing.Size(189, 20);
            this.nickname_textbox.TabIndex = 14;
            // 
            // phone_number_textbox
            // 
            this.phone_number_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.phone_number_textbox.Location = new System.Drawing.Point(183, 168);
            this.phone_number_textbox.Name = "phone_number_textbox";
            this.phone_number_textbox.Size = new System.Drawing.Size(189, 20);
            this.phone_number_textbox.TabIndex = 13;
            this.phone_number_textbox.TextChanged += new System.EventHandler(this.phone_number_textbox_TextChanged);
            // 
            // gmail_textbox
            // 
            this.gmail_textbox.Location = new System.Drawing.Point(184, 236);
            this.gmail_textbox.Name = "gmail_textbox";
            this.gmail_textbox.Size = new System.Drawing.Size(230, 20);
            this.gmail_textbox.TabIndex = 12;
            // 
            // first_name_textbox
            // 
            this.first_name_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.first_name_textbox.Location = new System.Drawing.Point(183, 116);
            this.first_name_textbox.Name = "first_name_textbox";
            this.first_name_textbox.Size = new System.Drawing.Size(189, 20);
            this.first_name_textbox.TabIndex = 11;
            // 
            // number_label
            // 
            this.number_label.AutoSize = true;
            this.number_label.BackColor = System.Drawing.Color.Transparent;
            this.number_label.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_label.ForeColor = System.Drawing.Color.Black;
            this.number_label.Location = new System.Drawing.Point(17, 168);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(130, 21);
            this.number_label.TabIndex = 10;
            this.number_label.Text = "Phone Number :";
            this.number_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // Nick_name_label
            // 
            this.Nick_name_label.AutoSize = true;
            this.Nick_name_label.BackColor = System.Drawing.Color.Transparent;
            this.Nick_name_label.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nick_name_label.ForeColor = System.Drawing.Color.Black;
            this.Nick_name_label.Location = new System.Drawing.Point(19, 140);
            this.Nick_name_label.Name = "Nick_name_label";
            this.Nick_name_label.Size = new System.Drawing.Size(93, 21);
            this.Nick_name_label.TabIndex = 9;
            this.Nick_name_label.Text = "Nickname :";
            this.Nick_name_label.Click += new System.EventHandler(this.Nick_name_label_Click);
            // 
            // mothers_name_label
            // 
            this.mothers_name_label.AutoSize = true;
            this.mothers_name_label.BackColor = System.Drawing.Color.Transparent;
            this.mothers_name_label.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mothers_name_label.ForeColor = System.Drawing.Color.Black;
            this.mothers_name_label.Location = new System.Drawing.Point(344, 487);
            this.mothers_name_label.Name = "mothers_name_label";
            this.mothers_name_label.Size = new System.Drawing.Size(126, 21);
            this.mothers_name_label.TabIndex = 8;
            this.mothers_name_label.Text = "Mothers Name :";
            // 
            // fathers_name_label
            // 
            this.fathers_name_label.AutoSize = true;
            this.fathers_name_label.BackColor = System.Drawing.Color.Transparent;
            this.fathers_name_label.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fathers_name_label.ForeColor = System.Drawing.Color.Black;
            this.fathers_name_label.Location = new System.Drawing.Point(17, 488);
            this.fathers_name_label.Name = "fathers_name_label";
            this.fathers_name_label.Size = new System.Drawing.Size(118, 21);
            this.fathers_name_label.TabIndex = 7;
            this.fathers_name_label.Text = "Fathers Name :";
            // 
            // Lastname_label
            // 
            this.Lastname_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lastname_label.AutoSize = true;
            this.Lastname_label.BackColor = System.Drawing.Color.Transparent;
            this.Lastname_label.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lastname_label.ForeColor = System.Drawing.Color.Black;
            this.Lastname_label.Location = new System.Drawing.Point(421, 114);
            this.Lastname_label.Name = "Lastname_label";
            this.Lastname_label.Size = new System.Drawing.Size(95, 21);
            this.Lastname_label.TabIndex = 6;
            this.Lastname_label.Text = "Last Name :";
            // 
            // Registration_lebel
            // 
            this.Registration_lebel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Registration_lebel.AutoSize = true;
            this.Registration_lebel.BackColor = System.Drawing.Color.Transparent;
            this.Registration_lebel.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration_lebel.Location = new System.Drawing.Point(228, 20);
            this.Registration_lebel.Name = "Registration_lebel";
            this.Registration_lebel.Size = new System.Drawing.Size(207, 24);
            this.Registration_lebel.TabIndex = 0;
            this.Registration_lebel.Text = "Registration Form";
            this.Registration_lebel.Click += new System.EventHandler(this.Registration_lebel_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Upload_photo);
            this.panel1.Controls.Add(this.photo_size_lebel);
            this.panel1.Location = new System.Drawing.Point(740, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 839);
            this.panel1.TabIndex = 10;
            // 
            // Registration_Page_For_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_one.Properties.Resources.REGISTRATION_FORM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1104, 839);
            this.Controls.Add(this.registration_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picture_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registration_Page_For_Employee";
            this.Text = "Registration_Page_For_Employee";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.registration_panel.ResumeLayout(false);
            this.registration_panel.PerformLayout();
            this.Gender_groupbox.ResumeLayout(false);
            this.Gender_groupbox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label photo_size_lebel;
        private System.Windows.Forms.Label picture_label;
        private System.Windows.Forms.Button Upload_photo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel registration_panel;
        private System.Windows.Forms.Label mothers_name_label;
        private System.Windows.Forms.Label fathers_name_label;
        private System.Windows.Forms.Label Lastname_label;
        private System.Windows.Forms.Label Registration_lebel;
        private System.Windows.Forms.Label number_label;
        private System.Windows.Forms.Label Nick_name_label;
        private System.Windows.Forms.TextBox last_name_textbox;
        private System.Windows.Forms.TextBox nickname_textbox;
        private System.Windows.Forms.TextBox phone_number_textbox;
        private System.Windows.Forms.TextBox gmail_textbox;
        private System.Windows.Forms.TextBox first_name_textbox;
        private System.Windows.Forms.Label birthdate_label;
        private System.Windows.Forms.Label Gmail_label;
        private System.Windows.Forms.TextBox nid_textbox;
        private System.Windows.Forms.Label nid_label;
        private System.Windows.Forms.TextBox mothers_textbox;
        private System.Windows.Forms.TextBox fathers_textbox;
        private System.Windows.Forms.Label permanent_address_label;
        private System.Windows.Forms.TextBox Address_textbox;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.TextBox parAddress_textbox;
        private System.Windows.Forms.Label gender_label;
        private System.Windows.Forms.GroupBox Gender_groupbox;
        private System.Windows.Forms.RadioButton others_gender_radiobutton;
        private System.Windows.Forms.RadioButton Female_radioButton;
        private System.Windows.Forms.RadioButton male_radioButton;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox relegion_textbox;
        private System.Windows.Forms.Label relegion_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox marital_status_textbox;
        private System.Windows.Forms.Label Marital_Status_lebel;
        private System.Windows.Forms.TextBox emergency_number_textbox;
        private System.Windows.Forms.Label emergency_number;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label blood_group_label;
        private System.Windows.Forms.TextBox DesignationText;
        private System.Windows.Forms.Label Designation_label;
        private System.Windows.Forms.TextBox employee_id_textbox;
        private System.Windows.Forms.Label employee_id;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.DateTimePicker DobPicker;
    }
}