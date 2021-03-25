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

namespace DeleteStudents
{
    public partial class MainForm : Form
    {
        private OleDbConnection connRoss;
        private OleDbDataAdapter daStudent;
        private DataSet dsRoss;
        private DataTable dtStudent;
        private CurrencyManager cmStudent;


        public MainForm()
        {
            InitializeComponent();
            GetRossData();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

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
            OleDbCommandBuilder cmdBldr = new OleDbCommandBuilder(daStudent);
            daStudent.Fill(dsRoss, "Student");
            dtStudent = dsRoss.Tables["Student"];
            cmStudent = (CurrencyManager)this.BindingContext[dsRoss, "Student"];
            dgvStudents.DataSource = dsRoss;
            dgvStudents.DataMember = "Student";
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow deleteStudentRow = dtStudent.Rows[cmStudent.Position];
                if (MessageBox.Show("Are you sure you want to delete this student?", "Warning", MessageBoxButtons.OKCancel)== DialogResult.OK)
                {
                    deleteStudentRow.Delete();
                    daStudent.Update(dsRoss, "Student");
                    MessageBox.Show("Student Deleted Successfully", "Acknowledgment", MessageBoxButtons.OK);

                }
            }
            catch (System.Data.OleDb.OleDbException ex)
            {
                MessageBox.Show("This Student has enrolments and cannot be deleted.", "Error");
                dgvStudents.DataSource = dsRoss;
            }
        }
    }
}
