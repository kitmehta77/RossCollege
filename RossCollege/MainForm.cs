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


namespace RossCollege
{
    public partial class MainForm : Form
    {
        private OleDbConnection connRoss;
        private OleDbDataAdapter daLecturer;
        private DataSet dsRoss;
        private DataTable dtLecturer;
        private CurrencyManager cmLecturer;
        private int maxId;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetRossData();
            DisplayLecturers();

        }
        public void GetRossData()
        {
            string myConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" +
                @"Data Source=c:\temp\RossCollege.mdb";                               // 1. Set up connection string
            connRoss = new OleDbConnection(myConnectionString);                        // 2. Instantiate the connection
            dsRoss = new DataSet();                                                    // 3. Instantiate a new DataSet
            daLecturer = new OleDbDataAdapter("SELECT * FROM Lecturer", connRoss);      // 4. Instantiate DataAdapter with
                                                                                         //    select command and connection
            OleDbCommandBuilder cmdBldr = new OleDbCommandBuilder(daLecturer);         // 5. Fill in insert, update, and
                                                                                         //    delete commands
            daLecturer.Fill(dsRoss, "Lecturer");                                   // 6. Fill the dataset
            dtLecturer = dsRoss.Tables["Lecturer"];                                // 7. Create data table
            cmLecturer = (CurrencyManager)this.BindingContext[dsRoss, "Lecturer"]; // 8. Create the currency manager
            getMaxId();                                                                  // 9. Find the highest department id
        }

        private void getMaxId()
        {
            maxId = 0;
            foreach (DataRow dr in dtLecturer.Rows)
            {
                int keyValue = Convert.ToInt32(dr["LecturerID"].ToString());
                if (keyValue > maxId)
                {
                    maxId = keyValue + 1;
                }
            }
        }

        public void DisplayLecturers()
        {
            string lecturerText = "";
            txtLecturers.Text = "";
            
            foreach (DataRow drLecturer in dtLecturer.Rows)
            {
                lecturerText += drLecturer["LastName"] + ",";
                lecturerText += drLecturer["FirstName"] + ",";
                lecturerText += drLecturer["Status"] + "\r\n";
                txtLecturers.Text += lecturerText;
                lecturerText = "";
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text == "" || txtFirstName.Text == "" || txtPhoneNumber.Text == "" ||
                cboStatus.Text == "")
            {
                MessageBox.Show("One or more fields is blank", "Error", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            else
            {
                DataRow newLecturerRow = dtLecturer.NewRow();
                newLecturerRow["LecturerID"] = maxId.ToString();
                newLecturerRow["LastName"] = txtLastName.Text;
                newLecturerRow["FirstName"] = txtFirstName.Text;
                newLecturerRow["PhoneNumber"] = txtPhoneNumber.Text;
                newLecturerRow["Status"] = cboStatus.Text;
                dsRoss.Tables["Lecturer"].Rows.Add(newLecturerRow);
                daLecturer.Update(dsRoss, "Lecturer");
                DisplayLecturers();
                MessageBox.Show("Lecturer created successfully", "Acknowledgment", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                txtLastName.Text = "";
                txtFirstName.Text = "";
                txtPhoneNumber.Text = "";
                cboStatus.Text = "";
                maxId++;
            }

        }
    }
}
