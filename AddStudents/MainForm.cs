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

namespace AddStudents
{
    public partial class MainForm : Form
    {
        private OleDbConnection connRoss;
        private OleDbDataAdapter daStudent;
        private DataSet dsRoss;
        private DataTable dtStudent;
        private CurrencyManager cmStudent;
        private int maxId;

        public MainForm()
        {
            InitializeComponent();
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
            getMaxId();
        }
        public void DisplayStudents()
        {
            string studentText = "";
            txtStudents.Text = "";

            foreach (DataRow drStudent in dtStudent.Rows)
            {
                studentText += drStudent["LastName"] + ", ";
                studentText += drStudent["FirstName"] + "  -  Address: ";
                studentText += drStudent["StreetAddress"] + ", ";
                studentText += drStudent["Suburb"] + "\r\n";
                txtStudents.Text += studentText;
                studentText = "";
            }
        }
        private void getMaxId()
        //maxId should end up with a value greater than any existing key
        {
            maxId = 0;
            foreach (DataRow dr in dtStudent.Rows)
            {
                int keyValue = Convert.ToInt32(dr["StudentID"].ToString());
                if (keyValue > maxId)
                {
                    maxId = keyValue + 1;
                }
            }
        }

        private void clearfields()
        {
            txtLastName.Text = "";
            txtFirstName.Text = "";
            dtpDateOfBirth.Value = DateTime.Today;
            txtSuburb.Text = "";
            txtStreetAddress.Text = "";
            txtPhoneNumber.Text = "";
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            GetRossData();
            DisplayStudents();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text == "" || txtFirstName.Text == "" || txtStreetAddress.Text == "" ||
                 txtSuburb.Text == "" || txtPhoneNumber.Text == "")
            {
                MessageBox.Show("One or more fields is blank", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                DataRow newStudentRow = dtStudent.NewRow();
                newStudentRow["StudentID"] = maxId.ToString();
                newStudentRow["LastName"] = txtLastName.Text;
                newStudentRow["FirstName"] = txtFirstName.Text;
                newStudentRow["StreetAddress"] = txtStreetAddress.Text;
                newStudentRow["Suburb"] = txtSuburb.Text;
                newStudentRow["PhoneNumber"] = txtPhoneNumber.Text;
                newStudentRow["DateOfBirth"] = dtpDateOfBirth.Value;
                dsRoss.Tables["Student"].Rows.Add(newStudentRow);
                daStudent.Update(dsRoss, "Student");
                DisplayStudents();
                MessageBox.Show("Student created successfully", "Acknowledgment", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                clearfields();
                maxId++;
            }

        }
    }
}
