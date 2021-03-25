
namespace EnrolStudent
{
    partial class MainForm
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblFinalGrade = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboFinalGrade = new System.Windows.Forms.ComboBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.dgvEnrolments = new System.Windows.Forms.DataGridView();
            this.btnEnrolStudent = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrolments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(911, 517);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 24);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status:";
            // 
            // lblFinalGrade
            // 
            this.lblFinalGrade.AutoSize = true;
            this.lblFinalGrade.Location = new System.Drawing.Point(867, 575);
            this.lblFinalGrade.Name = "lblFinalGrade";
            this.lblFinalGrade.Size = new System.Drawing.Size(111, 24);
            this.lblFinalGrade.TabIndex = 1;
            this.lblFinalGrade.Text = "Final Grade:";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Pending",
            "Paid"});
            this.cboStatus.Location = new System.Drawing.Point(993, 517);
            this.cboStatus.MaxLength = 7;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(105, 32);
            this.cboStatus.TabIndex = 2;
            this.cboStatus.Text = "Pending";
            // 
            // cboFinalGrade
            // 
            this.cboFinalGrade.AutoCompleteCustomSource.AddRange(new string[] {
            "Fail",
            "Pass",
            "Merit"});
            this.cboFinalGrade.FormattingEnabled = true;
            this.cboFinalGrade.Location = new System.Drawing.Point(993, 572);
            this.cboFinalGrade.MaxLength = 5;
            this.cboFinalGrade.Name = "cboFinalGrade";
            this.cboFinalGrade.Size = new System.Drawing.Size(105, 32);
            this.cboFinalGrade.TabIndex = 3;
            this.cboFinalGrade.Text = "Pass";
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(58, 32);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(1040, 201);
            this.dgvStudents.TabIndex = 4;
            // 
            // dgvCourses
            // 
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new System.Drawing.Point(58, 270);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowHeadersWidth = 51;
            this.dgvCourses.RowTemplate.Height = 24;
            this.dgvCourses.Size = new System.Drawing.Size(889, 202);
            this.dgvCourses.TabIndex = 5;
            // 
            // dgvEnrolments
            // 
            this.dgvEnrolments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnrolments.Location = new System.Drawing.Point(58, 517);
            this.dgvEnrolments.Name = "dgvEnrolments";
            this.dgvEnrolments.RowHeadersWidth = 51;
            this.dgvEnrolments.RowTemplate.Height = 24;
            this.dgvEnrolments.Size = new System.Drawing.Size(730, 215);
            this.dgvEnrolments.TabIndex = 6;
            // 
            // btnEnrolStudent
            // 
            this.btnEnrolStudent.Location = new System.Drawing.Point(822, 690);
            this.btnEnrolStudent.Name = "btnEnrolStudent";
            this.btnEnrolStudent.Size = new System.Drawing.Size(141, 42);
            this.btnEnrolStudent.TabIndex = 7;
            this.btnEnrolStudent.Text = "Enrol Student";
            this.btnEnrolStudent.UseVisualStyleBackColor = true;
            this.btnEnrolStudent.Click += new System.EventHandler(this.btnEnrolStudent_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1026, 690);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 42);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 784);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnrolStudent);
            this.Controls.Add(this.dgvEnrolments);
            this.Controls.Add(this.dgvCourses);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.cboFinalGrade);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblFinalGrade);
            this.Controls.Add(this.lblStatus);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Enrol Students";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrolments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblFinalGrade;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboFinalGrade;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.DataGridView dgvEnrolments;
        private System.Windows.Forms.Button btnEnrolStudent;
        private System.Windows.Forms.Button btnExit;
    }
}

