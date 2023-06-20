using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationWithDB
{
    public partial class FrmClubRegistration : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery; 
        private int ID, Age;
        private int count = 0;
        private string FirstName, MiddleName, LastName, Gender, Program; 
        private long StudentId;

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshListofClubMembers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateMember upd = new FrmUpdateMember(); upd.Show();
        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            clubRegistrationQuery = new ClubRegistrationQuery();
            RefreshListofClubMembers();
        }

        public FrmClubRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ID = RegistrationID();
            StudentId = Convert.ToInt64(txtStudentID.Text);
            FirstName = txtFirstName.Text;
            MiddleName = txtMiddleName.Text; 
            LastName = txtLastName.Text;
            Age = Convert.ToInt32(txtAge.Text); 
            Gender = cbGender.Text;
            Program = cbProgram.Text; 
            clubRegistrationQuery.RegisterStudent(ID, StudentId, FirstName, MiddleName, LastName, Age, Gender, Program);

        }

        public int RegistrationID()
        {
            return count++;
        }
        public void RefreshListofClubMembers()
        {
            clubRegistrationQuery.DisplayList();
            dataGridView.DataSource = clubRegistrationQuery.bindingSource;

        }

    }
}
