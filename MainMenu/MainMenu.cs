using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAddCourseMain_Click(object sender, EventArgs e)
        {
             AddCourse.MainForm a1 = new AddCourse.MainForm();
             a1.ShowDialog();
            
        }

        private void btnAddLecturerMain_Click(object sender, EventArgs e)
        {
            RossCollege.MainForm a2 = new RossCollege.MainForm();
            a2.ShowDialog();
        }

        private void btnAddStudentsMain_Click(object sender, EventArgs e)
        {
            AddStudents.MainForm s1 = new AddStudents.MainForm();
            s1.ShowDialog();
        }

        private void btnDeleteStudentsMain_Click(object sender, EventArgs e)
        {
            DeleteStudents.MainForm d1 = new DeleteStudents.MainForm();
            d1.ShowDialog();
        }

        private void btnEnrolStudentMain_Click(object sender, EventArgs e)
        {
            EnrolStudent.MainForm e1 = new EnrolStudent.MainForm();
            e1.ShowDialog();
        }

        private void btnExitMain_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
