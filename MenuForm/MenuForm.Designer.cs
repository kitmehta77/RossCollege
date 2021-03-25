
namespace MenuForm
{
    partial class MenuForm
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
            this.btnAddCourseMain = new System.Windows.Forms.Button();
            this.btnAddLecturerMain = new System.Windows.Forms.Button();
            this.btnAddStudentsMain = new System.Windows.Forms.Button();
            this.btnDeleteStudentsMain = new System.Windows.Forms.Button();
            this.btnEnrolStudentMain = new System.Windows.Forms.Button();
            this.btnExitMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCourseMain
            // 
            this.btnAddCourseMain.Location = new System.Drawing.Point(266, 51);
            this.btnAddCourseMain.Name = "btnAddCourseMain";
            this.btnAddCourseMain.Size = new System.Drawing.Size(200, 40);
            this.btnAddCourseMain.TabIndex = 0;
            this.btnAddCourseMain.Text = "Add Course";
            this.btnAddCourseMain.UseVisualStyleBackColor = true;
            this.btnAddCourseMain.Click += new System.EventHandler(this.btnAddCourseMain_Click);
            // 
            // btnAddLecturerMain
            // 
            this.btnAddLecturerMain.Location = new System.Drawing.Point(266, 108);
            this.btnAddLecturerMain.Name = "btnAddLecturerMain";
            this.btnAddLecturerMain.Size = new System.Drawing.Size(200, 40);
            this.btnAddLecturerMain.TabIndex = 1;
            this.btnAddLecturerMain.Text = "Add Lecturer";
            this.btnAddLecturerMain.UseVisualStyleBackColor = true;
            // 
            // btnAddStudentsMain
            // 
            this.btnAddStudentsMain.Location = new System.Drawing.Point(266, 166);
            this.btnAddStudentsMain.Name = "btnAddStudentsMain";
            this.btnAddStudentsMain.Size = new System.Drawing.Size(200, 40);
            this.btnAddStudentsMain.TabIndex = 2;
            this.btnAddStudentsMain.Text = "Add Students";
            this.btnAddStudentsMain.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStudentsMain
            // 
            this.btnDeleteStudentsMain.Location = new System.Drawing.Point(266, 222);
            this.btnDeleteStudentsMain.Name = "btnDeleteStudentsMain";
            this.btnDeleteStudentsMain.Size = new System.Drawing.Size(200, 40);
            this.btnDeleteStudentsMain.TabIndex = 3;
            this.btnDeleteStudentsMain.Text = "Delete Students";
            this.btnDeleteStudentsMain.UseVisualStyleBackColor = true;
            // 
            // btnEnrolStudentMain
            // 
            this.btnEnrolStudentMain.Location = new System.Drawing.Point(266, 288);
            this.btnEnrolStudentMain.Name = "btnEnrolStudentMain";
            this.btnEnrolStudentMain.Size = new System.Drawing.Size(200, 40);
            this.btnEnrolStudentMain.TabIndex = 4;
            this.btnEnrolStudentMain.Text = "Enrol Student";
            this.btnEnrolStudentMain.UseVisualStyleBackColor = true;
            // 
            // btnExitMain
            // 
            this.btnExitMain.Location = new System.Drawing.Point(266, 357);
            this.btnExitMain.Name = "btnExitMain";
            this.btnExitMain.Size = new System.Drawing.Size(200, 40);
            this.btnExitMain.TabIndex = 5;
            this.btnExitMain.Text = "Exit";
            this.btnExitMain.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExitMain);
            this.Controls.Add(this.btnEnrolStudentMain);
            this.Controls.Add(this.btnDeleteStudentsMain);
            this.Controls.Add(this.btnAddStudentsMain);
            this.Controls.Add(this.btnAddLecturerMain);
            this.Controls.Add(this.btnAddCourseMain);
            this.Name = "MenuForm";
            this.Text = "Ross College Management";
//            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCourseMain;
        private System.Windows.Forms.Button btnAddLecturerMain;
        private System.Windows.Forms.Button btnAddStudentsMain;
        private System.Windows.Forms.Button btnDeleteStudentsMain;
        private System.Windows.Forms.Button btnEnrolStudentMain;
        private System.Windows.Forms.Button btnExitMain;
    }
}

