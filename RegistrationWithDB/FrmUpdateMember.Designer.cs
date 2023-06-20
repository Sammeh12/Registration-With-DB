namespace RegistrationWithDB
{
    partial class FrmUpdateMember
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
            this.lblStudentID = new System.Windows.Forms.Label();
            this.cbStudentID = new System.Windows.Forms.ComboBox();
            this.txtLastName1 = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName1 = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtMiddleName1 = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge1 = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblProgram = new System.Windows.Forms.Label();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(22, 19);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(61, 13);
            this.lblStudentID.TabIndex = 13;
            this.lblStudentID.Text = "Student ID:";
            // 
            // cbStudentID
            // 
            this.cbStudentID.FormattingEnabled = true;
            this.cbStudentID.Location = new System.Drawing.Point(25, 35);
            this.cbStudentID.Name = "cbStudentID";
            this.cbStudentID.Size = new System.Drawing.Size(180, 21);
            this.cbStudentID.TabIndex = 14;
            this.cbStudentID.SelectedIndexChanged += new System.EventHandler(this.cbStudentID_SelectedIndexChanged);
            // 
            // txtLastName1
            // 
            this.txtLastName1.Location = new System.Drawing.Point(25, 84);
            this.txtLastName1.Name = "txtLastName1";
            this.txtLastName1.Size = new System.Drawing.Size(160, 20);
            this.txtLastName1.TabIndex = 15;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(22, 68);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(59, 13);
            this.lblLastName.TabIndex = 16;
            this.lblLastName.Text = "Last name:";
            // 
            // txtFirstName1
            // 
            this.txtFirstName1.Location = new System.Drawing.Point(25, 133);
            this.txtFirstName1.Name = "txtFirstName1";
            this.txtFirstName1.Size = new System.Drawing.Size(160, 20);
            this.txtFirstName1.TabIndex = 17;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(22, 117);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(58, 13);
            this.lblFirstName.TabIndex = 18;
            this.lblFirstName.Text = "First name:";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(22, 166);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(70, 13);
            this.lblMiddleName.TabIndex = 19;
            this.lblMiddleName.Text = "Middle name:";
            // 
            // txtMiddleName1
            // 
            this.txtMiddleName1.Location = new System.Drawing.Point(25, 182);
            this.txtMiddleName1.Name = "txtMiddleName1";
            this.txtMiddleName1.Size = new System.Drawing.Size(160, 20);
            this.txtMiddleName1.TabIndex = 20;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(22, 214);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 21;
            this.lblAge.Text = "Age:";
            // 
            // txtAge1
            // 
            this.txtAge1.Location = new System.Drawing.Point(25, 230);
            this.txtAge1.Name = "txtAge1";
            this.txtAge1.Size = new System.Drawing.Size(100, 20);
            this.txtAge1.TabIndex = 22;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(22, 263);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 23;
            this.lblGender.Text = "Gender:";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer not to say"});
            this.cbGender.Location = new System.Drawing.Point(25, 279);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(130, 21);
            this.cbGender.TabIndex = 24;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(68, 364);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(90, 30);
            this.btnConfirm.TabIndex = 25;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Location = new System.Drawing.Point(22, 312);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(49, 13);
            this.lblProgram.TabIndex = 26;
            this.lblProgram.Text = "Program:";
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
            this.cbProgram.Location = new System.Drawing.Point(25, 328);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(180, 21);
            this.cbProgram.TabIndex = 27;
            // 
            // FrmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 410);
            this.Controls.Add(this.cbProgram);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtAge1);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtMiddleName1);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName1);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName1);
            this.Controls.Add(this.cbStudentID);
            this.Controls.Add(this.lblStudentID);
            this.Name = "FrmUpdateMember";
            this.Text = "FrmUpdateMember";
            this.Load += new System.EventHandler(this.FrmUpdateMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.ComboBox cbStudentID;
        private System.Windows.Forms.TextBox txtLastName1;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtMiddleName1;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge1;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.ComboBox cbProgram;
    }
}