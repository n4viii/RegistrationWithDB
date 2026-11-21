using System;
using System.Windows.Forms;

namespace RegistrationWithDB
{
    public partial class FrmUpdateMember : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;

        public FrmUpdateMember()
        {
            InitializeComponent();
        }

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            clubRegistrationQuery = new ClubRegistrationQuery();
            clubRegistrationQuery.PopulateStudentIDs(cbStudentId);
        }

        private void cbStudentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            long selectedId = Convert.ToInt64(cbStudentId.Text);
            clubRegistrationQuery.SearchStudent(selectedId);

            txtFirstName.Text = clubRegistrationQuery._FirstName;
            txtMiddleName.Text = clubRegistrationQuery._MiddleName;
            txtLastName.Text = clubRegistrationQuery._LastName;
            txtAge.Text = clubRegistrationQuery._Age.ToString();
            cbGender.Text = clubRegistrationQuery._Gender;
            cbProgram.Text = clubRegistrationQuery._Program;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            long studentId = Convert.ToInt64(cbStudentId.Text);
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;
            string lastName = txtLastName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            string gender = cbGender.Text;
            string program = cbProgram.Text;

            clubRegistrationQuery.UpdateStudent(studentId, firstName, middleName, lastName, age, gender, program);
            MessageBox.Show("Member record updated successfully!");
            this.Close();
        }
    }
}