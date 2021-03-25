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

namespace AddCourse
{
    public partial class MainForm : Form
    {
        private OleDbConnection connRoss;
        private OleDbDataAdapter daCourse;
        private OleDbDataAdapter daLecturer;

        private DataSet dsRoss;
        private DataTable dtCourse;
        private DataTable dtLecturer;
        private CurrencyManager cmCourse;
        private CurrencyManager cmLecturer;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetRossData();
            LoadLecturers();
            DisplayCourses();
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
            daCourse = new OleDbDataAdapter("SELECT * FROM Course", connRoss);
            daLecturer = new OleDbDataAdapter("SELECT * FROM Lecturer", connRoss);
            OleDbCommandBuilder cmdBldr = new OleDbCommandBuilder(daCourse);
            OleDbCommandBuilder cmdBldrLecturer = new OleDbCommandBuilder(daLecturer);
            daCourse.Fill(dsRoss, "Course");
            daLecturer.Fill(dsRoss, "Lecturer");
            dtCourse = dsRoss.Tables["Course"];
            dtLecturer = dsRoss.Tables["Lecturer"];
            cmLecturer = (CurrencyManager)this.BindingContext[dsRoss, "Lecturer"];
            cmCourse = (CurrencyManager)this.BindingContext[dsRoss, "Course"];
        }

        public void DisplayCourses()
        {
            string courseText = "";
            txtCourses.Text = "";

            foreach (DataRow drCourse in dtCourse.Rows)
            {
                courseText += drCourse["CourseName"] + ",Fee: NZ$";
                courseText += drCourse["CourseFee"].ToString() + ", Level: ";
                courseText += drCourse["CourseLevel"] + "\r\n";
                txtCourses.Text += courseText;
                courseText = "";
            }
        }

        private void LoadLecturers()
        {
            cboLastName.DataSource = dsRoss;
            cboLastName.DisplayMember = "Lecturer.LastName";
            cboLastName.ValueMember = "Lecturer.LastName";
            cboFirstName.DataSource = dsRoss;
            cboFirstName.DisplayMember = "Lecturer.FirstName";
            cboFirstName.ValueMember = "Lecturer.FirstName";
            cboLecturer.DataSource = dsRoss;
            cboLecturer.DisplayMember = "Lecturer.LecturerID";
            cboLecturer.ValueMember = "Lecturer.LecturerID";
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            DataRow newCourseRow = dtCourse.NewRow();
            if ((txtCourseName.Text == ""))
            {
                MessageBox.Show("You are missing the course name", "Error");
            }
            else
            {
                try
                {
                    newCourseRow["CourseName"] = txtCourseName.Text;
                    newCourseRow["CourseFee"] = nudCourseFee.Value;
                    newCourseRow["CourseLevel"] = nudCourseLevel.Value;
                    newCourseRow["LecturerID"] = cboLecturer.Text;
                    dtCourse.Rows.Add(newCourseRow);
                    MessageBox.Show("Course added successfully", "Success");
                    daCourse.Update(dsRoss, "Course");
                    DisplayCourses();
                    txtCourseName.Text = "";
                    nudCourseFee.Value = 400;
                    nudCourseLevel.Value = 5;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter a number for fee or level", "Error");
                }
            }

        }
    }
}
