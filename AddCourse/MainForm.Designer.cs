
namespace AddCourse
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
            this.txtCourses = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseFee = new System.Windows.Forms.Label();
            this.lblCourseLevel = new System.Windows.Forms.Label();
            this.lblLecturer = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.nudCourseFee = new System.Windows.Forms.NumericUpDown();
            this.nudCourseLevel = new System.Windows.Forms.NumericUpDown();
            this.cboLecturer = new System.Windows.Forms.ComboBox();
            this.cboFirstName = new System.Windows.Forms.ComboBox();
            this.cboLastName = new System.Windows.Forms.ComboBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCourses
            // 
            this.txtCourses.Location = new System.Drawing.Point(41, 57);
            this.txtCourses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCourses.Multiline = true;
            this.txtCourses.Name = "txtCourses";
            this.txtCourses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCourses.Size = new System.Drawing.Size(586, 365);
            this.txtCourses.TabIndex = 0;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(687, 57);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(127, 24);
            this.lblCourseName.TabIndex = 1;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lblCourseFee
            // 
            this.lblCourseFee.AutoSize = true;
            this.lblCourseFee.Location = new System.Drawing.Point(707, 116);
            this.lblCourseFee.Name = "lblCourseFee";
            this.lblCourseFee.Size = new System.Drawing.Size(107, 24);
            this.lblCourseFee.TabIndex = 2;
            this.lblCourseFee.Text = "Course Fee:";
            // 
            // lblCourseLevel
            // 
            this.lblCourseLevel.AutoSize = true;
            this.lblCourseLevel.Location = new System.Drawing.Point(694, 178);
            this.lblCourseLevel.Name = "lblCourseLevel";
            this.lblCourseLevel.Size = new System.Drawing.Size(120, 24);
            this.lblCourseLevel.TabIndex = 3;
            this.lblCourseLevel.Text = "Course Level:";
            // 
            // lblLecturer
            // 
            this.lblLecturer.AutoSize = true;
            this.lblLecturer.Location = new System.Drawing.Point(731, 240);
            this.lblLecturer.Name = "lblLecturer";
            this.lblLecturer.Size = new System.Drawing.Size(83, 24);
            this.lblLecturer.TabIndex = 4;
            this.lblLecturer.Text = "Lecturer:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(842, 57);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(366, 32);
            this.txtCourseName.TabIndex = 5;
            // 
            // nudCourseFee
            // 
            this.nudCourseFee.DecimalPlaces = 2;
            this.nudCourseFee.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudCourseFee.Location = new System.Drawing.Point(842, 114);
            this.nudCourseFee.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudCourseFee.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudCourseFee.Name = "nudCourseFee";
            this.nudCourseFee.Size = new System.Drawing.Size(137, 32);
            this.nudCourseFee.TabIndex = 6;
            this.nudCourseFee.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // nudCourseLevel
            // 
            this.nudCourseLevel.Location = new System.Drawing.Point(843, 176);
            this.nudCourseLevel.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudCourseLevel.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudCourseLevel.Name = "nudCourseLevel";
            this.nudCourseLevel.Size = new System.Drawing.Size(102, 32);
            this.nudCourseLevel.TabIndex = 7;
            this.nudCourseLevel.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cboLecturer
            // 
            this.cboLecturer.FormattingEnabled = true;
            this.cboLecturer.Location = new System.Drawing.Point(843, 237);
            this.cboLecturer.Name = "cboLecturer";
            this.cboLecturer.Size = new System.Drawing.Size(167, 32);
            this.cboLecturer.TabIndex = 8;
            // 
            // cboFirstName
            // 
            this.cboFirstName.FormattingEnabled = true;
            this.cboFirstName.Location = new System.Drawing.Point(1189, 237);
            this.cboFirstName.Name = "cboFirstName";
            this.cboFirstName.Size = new System.Drawing.Size(167, 32);
            this.cboFirstName.TabIndex = 9;
            // 
            // cboLastName
            // 
            this.cboLastName.FormattingEnabled = true;
            this.cboLastName.Location = new System.Drawing.Point(1016, 237);
            this.cboLastName.Name = "cboLastName";
            this.cboLastName.Size = new System.Drawing.Size(167, 32);
            this.cboLastName.TabIndex = 10;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(717, 364);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(227, 43);
            this.btnAddCourse.TabIndex = 11;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1091, 364);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(227, 43);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 483);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.cboLastName);
            this.Controls.Add(this.cboFirstName);
            this.Controls.Add(this.cboLecturer);
            this.Controls.Add(this.nudCourseLevel);
            this.Controls.Add(this.nudCourseFee);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.lblLecturer);
            this.Controls.Add(this.lblCourseLevel);
            this.Controls.Add(this.lblCourseFee);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.txtCourses);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Add Courses";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCourses;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseFee;
        private System.Windows.Forms.Label lblCourseLevel;
        private System.Windows.Forms.Label lblLecturer;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.NumericUpDown nudCourseFee;
        private System.Windows.Forms.NumericUpDown nudCourseLevel;
        private System.Windows.Forms.ComboBox cboLecturer;
        private System.Windows.Forms.ComboBox cboFirstName;
        private System.Windows.Forms.ComboBox cboLastName;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnExit;
    }
}

