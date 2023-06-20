namespace RegistrationWithDB
{
    partial class FrmClubRegistration
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblProgram = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblListofClubMembers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 225);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(549, 153);
            this.dataGridView.TabIndex = 0;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(12, 49);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(130, 20);
            this.txtStudentID.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(187, 97);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(160, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(363, 97);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(160, 20);
            this.txtMiddleName.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(12, 97);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(160, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(12, 150);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 5;
            // 
            // cbProgram
            // 
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Items.AddRange(new object[] {
            "Science, Technology, Engineering, and Mathematics",
            "Humanities and Social Sciences",
            "General Academic",
            "IT in Mobile App & Web Development",
            "Digital Arts",
            "Tourism Operations",
            "Restaurant and Café Operations",
            "Culinary Arts",
            "BS in Computer Science",
            "BS in Information Technology",
            "BS in Computer Engineering",
            "BS in Business Administration",
            "BS in Retail Technology and Consumer Science",
            "BS in Tourism Management"});
            this.cbProgram.Location = new System.Drawing.Point(363, 48);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(180, 21);
            this.cbProgram.TabIndex = 8;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(578, 27);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 30);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(578, 64);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(578, 225);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 30);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(9, 33);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(61, 13);
            this.lblStudentID.TabIndex = 12;
            this.lblStudentID.Text = "Student ID:";
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Location = new System.Drawing.Point(360, 32);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(49, 13);
            this.lblProgram.TabIndex = 13;
            this.lblProgram.Text = "Program:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(9, 81);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(59, 13);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(184, 81);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(58, 13);
            this.lblFirstName.TabIndex = 15;
            this.lblFirstName.Text = "First name:";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(360, 81);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(70, 13);
            this.lblMiddleName.TabIndex = 16;
            this.lblMiddleName.Text = "Middle name:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(9, 134);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 17;
            this.lblAge.Text = "Age:";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer not to say"});
            this.cbGender.Location = new System.Drawing.Point(187, 150);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(130, 21);
            this.cbGender.TabIndex = 18;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(184, 135);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 19;
            this.lblGender.Text = "Gender:";
            // 
            // lblListofClubMembers
            // 
            this.lblListofClubMembers.AutoSize = true;
            this.lblListofClubMembers.Location = new System.Drawing.Point(9, 199);
            this.lblListofClubMembers.Name = "lblListofClubMembers";
            this.lblListofClubMembers.Size = new System.Drawing.Size(108, 13);
            this.lblListofClubMembers.TabIndex = 20;
            this.lblListofClubMembers.Text = "List of Club Members:";
            // 
            // FrmClubRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 390);
            this.Controls.Add(this.lblListofClubMembers);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cbProgram);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.dataGridView);
            this.Name = "FrmClubRegistration";
            this.Text = "FrmClubRegistration";
            this.Load += new System.EventHandler(this.FrmClubRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox cbProgram;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblListofClubMembers;
    }
}

