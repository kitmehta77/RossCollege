
namespace MainMenu
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnExitMain = new System.Windows.Forms.Button();
            this.btnEnrolStudentMain = new System.Windows.Forms.Button();
            this.btnDeleteStudentsMain = new System.Windows.Forms.Button();
            this.btnAddStudentsMain = new System.Windows.Forms.Button();
            this.btnAddLecturerMain = new System.Windows.Forms.Button();
            this.btnAddCourseMain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitMain
            // 
            this.btnExitMain.Location = new System.Drawing.Point(543, 331);
            this.btnExitMain.Name = "btnExitMain";
            this.btnExitMain.Size = new System.Drawing.Size(200, 40);
            this.btnExitMain.TabIndex = 11;
            this.btnExitMain.Text = "Exit";
            this.btnExitMain.UseVisualStyleBackColor = true;
            this.btnExitMain.Click += new System.EventHandler(this.btnExitMain_Click);
            // 
            // btnEnrolStudentMain
            // 
            this.btnEnrolStudentMain.Location = new System.Drawing.Point(543, 268);
            this.btnEnrolStudentMain.Name = "btnEnrolStudentMain";
            this.btnEnrolStudentMain.Size = new System.Drawing.Size(200, 40);
            this.btnEnrolStudentMain.TabIndex = 10;
            this.btnEnrolStudentMain.Text = "Enrol Student";
            this.btnEnrolStudentMain.UseVisualStyleBackColor = true;
            this.btnEnrolStudentMain.Click += new System.EventHandler(this.btnEnrolStudentMain_Click);
            // 
            // btnDeleteStudentsMain
            // 
            this.btnDeleteStudentsMain.Location = new System.Drawing.Point(543, 210);
            this.btnDeleteStudentsMain.Name = "btnDeleteStudentsMain";
            this.btnDeleteStudentsMain.Size = new System.Drawing.Size(200, 40);
            this.btnDeleteStudentsMain.TabIndex = 9;
            this.btnDeleteStudentsMain.Text = "Delete Students";
            this.btnDeleteStudentsMain.UseVisualStyleBackColor = true;
            this.btnDeleteStudentsMain.Click += new System.EventHandler(this.btnDeleteStudentsMain_Click);
            // 
            // btnAddStudentsMain
            // 
            this.btnAddStudentsMain.Location = new System.Drawing.Point(543, 148);
            this.btnAddStudentsMain.Name = "btnAddStudentsMain";
            this.btnAddStudentsMain.Size = new System.Drawing.Size(200, 40);
            this.btnAddStudentsMain.TabIndex = 8;
            this.btnAddStudentsMain.Text = "Add Students";
            this.btnAddStudentsMain.UseVisualStyleBackColor = true;
            this.btnAddStudentsMain.Click += new System.EventHandler(this.btnAddStudentsMain_Click);
            // 
            // btnAddLecturerMain
            // 
            this.btnAddLecturerMain.Location = new System.Drawing.Point(543, 90);
            this.btnAddLecturerMain.Name = "btnAddLecturerMain";
            this.btnAddLecturerMain.Size = new System.Drawing.Size(200, 40);
            this.btnAddLecturerMain.TabIndex = 7;
            this.btnAddLecturerMain.Text = "Add Lecturer";
            this.btnAddLecturerMain.UseVisualStyleBackColor = true;
            this.btnAddLecturerMain.Click += new System.EventHandler(this.btnAddLecturerMain_Click);
            // 
            // btnAddCourseMain
            // 
            this.btnAddCourseMain.Location = new System.Drawing.Point(543, 33);
            this.btnAddCourseMain.Name = "btnAddCourseMain";
            this.btnAddCourseMain.Size = new System.Drawing.Size(200, 40);
            this.btnAddCourseMain.TabIndex = 6;
            this.btnAddCourseMain.Text = "Add Course";
            this.btnAddCourseMain.UseVisualStyleBackColor = true;
            this.btnAddCourseMain.Click += new System.EventHandler(this.btnAddCourseMain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 338);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 393);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExitMain);
            this.Controls.Add(this.btnEnrolStudentMain);
            this.Controls.Add(this.btnDeleteStudentsMain);
            this.Controls.Add(this.btnAddStudentsMain);
            this.Controls.Add(this.btnAddLecturerMain);
            this.Controls.Add(this.btnAddCourseMain);
            this.Name = "MainMenu";
            this.Text = "Ross College Management";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExitMain;
        private System.Windows.Forms.Button btnEnrolStudentMain;
        private System.Windows.Forms.Button btnDeleteStudentsMain;
        private System.Windows.Forms.Button btnAddStudentsMain;
        private System.Windows.Forms.Button btnAddLecturerMain;
        private System.Windows.Forms.Button btnAddCourseMain;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

