using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace EnrolStudent
{
    public partial class MainForm : Form
    {
        private OleDbConnection connRoss;
        
        private OleDbDataAdapter daStudent;
        private OleDbDataAdapter daCourse;
        private OleDbDataAdapter daEnrolment;

        private DataSet dsRoss;
        private DataTable dtStudent;
        private DataTable dtCourse;
        private DataTable dtEnrolment;

        private CurrencyManager cmStudent;
        private CurrencyManager cmCourse;
        private CurrencyManager cmEnrolment;

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetRossData();
            BindControls();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void GetRossData()
        {
            string myConnectionString;
            myConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" +
                @"Data Source=c:\temp\RossCollege.mdb";

            connRoss = new OleDbConnection(myConnectionString);
            dsRoss = new DataSet();

            daStudent = new OleDbDataAdapter("SELECT * FROM Student", connRoss);
            daCourse = new OleDbDataAdapter("SELECT * FROM Course", connRoss);
            daEnrolment = new OleDbDataAdapter("SELECT * FROM Enrolment", connRoss);

            OleDbCommandBuilder cmdBldrStudent = new OleDbCommandBuilder(daStudent);
            OleDbCommandBuilder cmdBldrCourse = new OleDbCommandBuilder(daCourse);
            OleDbCommandBuilder cmdBldrEnrolment = new OleDbCommandBuilder(daEnrolment);

            daStudent.Fill(dsRoss, "Student");
            daCourse.Fill(dsRoss, "Course");
            daEnrolment.Fill(dsRoss, "Enrolment");

            dtStudent = dsRoss.Tables["Student"];
            dtCourse = dsRoss.Tables["Course"];
            dtEnrolment = dsRoss.Tables["Enrolment"];

            cmCourse = (CurrencyManager)this.BindingContext[dsRoss, "Course"];
            cmStudent = (CurrencyManager)this.BindingContext[dsRoss, "Student"];
            cmEnrolment = (CurrencyManager)this.BindingContext[dsRoss, "Enrolment"];

        }

        public void BindControls()
        {
            dgvStudents.DataSource = dsRoss;
            dgvStudents.DataMember = "Student";

            dgvCourses.DataSource = dsRoss;
            dgvCourses.DataMember = "Course";

            dgvEnrolments.DataSource = dsRoss;
            dgvEnrolments.DataMember = "Enrolment";
        }

        private void btnEnrolStudent_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newEnrolment = dtEnrolment.NewRow();

                newEnrolment["CourseID"] = dgvCourses["CourseID", cmCourse.Position].Value;
                newEnrolment["StudentID"] = dgvStudents["StudentID", cmStudent.Position].Value;
                newEnrolment["Status"] = cboStatus.Text;
                newEnrolment["FinalGrade"] = cboFinalGrade.Text;
                dsRoss.Tables["Enrolment"].Rows.Add(newEnrolment);
                daEnrolment.Update(dsRoss, "Enrolment");

                MessageBox.Show("Student assigned successfully", "Acknowledgement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Data.OleDb.OleDbException)
            {
                MessageBox.Show("The Student is already enrolled on the course.", "Error");
            }
            
        }
    }
}
