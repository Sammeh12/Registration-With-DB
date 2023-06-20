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

namespace RegistrationWithDB
{
    public partial class FrmUpdateMember : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery; 
        private int Age;
        private string Program; 
        private long StudentId;

        public FrmUpdateMember()
        {
            InitializeComponent();
        }

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            clubRegistrationQuery = new ClubRegistrationQuery(); 
            clubRegistrationQuery.DisplayID(cbStudentID);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            StudentId = Convert.ToInt64(cbStudentID.Text); 
            Age = Convert.ToInt32(txtAge1.Text);
            Program = cbProgram.Text; 
            clubRegistrationQuery.UpdateStudent(StudentId, Age, Program);

        }

        public void fill()
        {
            string ClubDBConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GAMAY\source\repos\RegistrationWithDB\RegistrationWithDB\ClubDB.mdf;Integrated Security=True";
            SqlConnection sqlConnect = new SqlConnection(ClubDBConnectionString); string getId = "SELECT * FROM ClubMembers";
            SqlCommand sqlCommand = new SqlCommand(getId, sqlConnect); sqlConnect.Open();
            SqlDataReader sqlReader = sqlCommand.ExecuteReader();

            while (sqlReader.Read())
            {
                cbStudentID.Items.Add(sqlReader["StudentId"]);

            }
            sqlConnect.Close();
        }

        public void cbFill()
        {
            clubRegistrationQuery.DisplayID(cbStudentID);
        }
        public void textFill()
        {
            txtLastName1.Text = clubRegistrationQuery._LastName; 
            txtFirstName1.Text = clubRegistrationQuery._FirstName; 
            txtMiddleName1.Text = clubRegistrationQuery._MiddleName; 
            txtAge1.Text = clubRegistrationQuery._Age.ToString(); 
            cbGender.Text = clubRegistrationQuery._Gender; 
            cbProgram.Text = clubRegistrationQuery._Program;
        }

        private void cbID_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            clubRegistrationQuery.DisplayText(cbStudentID.Text); 
            textFill();
        }

        private void cbStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            clubRegistrationQuery.DisplayText(cbStudentID.Text); 
            textFill();
        }
    }
}
