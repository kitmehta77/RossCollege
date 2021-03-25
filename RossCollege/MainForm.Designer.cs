
namespace RossCollege
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
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnAddLecturer = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtLecturers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(507, 37);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(80, 17);
            this.lblLastname.TabIndex = 1;
            this.lblLastname.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(507, 96);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 17);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(480, 160);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(107, 17);
            this.lblPhoneNumber.TabIndex = 3;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(535, 224);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 17);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status:";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Full-time",
            "Part-time"});
            this.cboStatus.Location = new System.Drawing.Point(632, 224);
            this.cboStatus.MaxLength = 9;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(152, 24);
            this.cboStatus.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(632, 37);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(190, 22);
            this.txtLastName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(632, 96);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(190, 22);
            this.txtFirstName.TabIndex = 7;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(632, 160);
            this.txtPhoneNumber.MaxLength = 16;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(190, 22);
            this.txtPhoneNumber.TabIndex = 8;
            // 
            // btnAddLecturer
            // 
            this.btnAddLecturer.Location = new System.Drawing.Point(472, 333);
            this.btnAddLecturer.Name = "btnAddLecturer";
            this.btnAddLecturer.Size = new System.Drawing.Size(175, 31);
            this.btnAddLecturer.TabIndex = 9;
            this.btnAddLecturer.Text = "Add Lecturer";
            this.btnAddLecturer.UseVisualStyleBackColor = true;
            this.btnAddLecturer.Click += new System.EventHandler(this.btnAddLecturer_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(697, 333);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(175, 31);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtLecturers
            // 
            this.txtLecturers.Location = new System.Drawing.Point(35, 34);
            this.txtLecturers.Multiline = true;
            this.txtLecturers.Name = "txtLecturers";
            this.txtLecturers.Size = new System.Drawing.Size(395, 362);
            this.txtLecturers.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 445);
            this.Controls.Add(this.txtLecturers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddLecturer);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastname);
            this.Name = "MainForm";
            this.Text = "Add Lecturer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnAddLecturer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtLecturers;
    }
}

