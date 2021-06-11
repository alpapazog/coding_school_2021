
namespace WindowsFormsApp1 {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ctrlLabelTitle = new System.Windows.Forms.Label();
            this.ctrlAddCourse = new System.Windows.Forms.Button();
            this.ctrlAddStudent = new System.Windows.Forms.Button();
            this.ctrlAddProfessor = new System.Windows.Forms.Button();
            this.ctrlListStudent = new DevExpress.XtraEditors.ListBoxControl();
            this.ctrlListCourse = new DevExpress.XtraEditors.ListBoxControl();
            this.ctrlListProfessor = new DevExpress.XtraEditors.ListBoxControl();
            this.ctrlExtract = new System.Windows.Forms.Button();
            this.ctrlImport = new System.Windows.Forms.Button();
            this.ctrlExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlListStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlListCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlListProfessor)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlLabelTitle
            // 
            this.ctrlLabelTitle.AutoSize = true;
            this.ctrlLabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlLabelTitle.ForeColor = System.Drawing.Color.Red;
            this.ctrlLabelTitle.Location = new System.Drawing.Point(62, 9);
            this.ctrlLabelTitle.Name = "ctrlLabelTitle";
            this.ctrlLabelTitle.Size = new System.Drawing.Size(595, 39);
            this.ctrlLabelTitle.TabIndex = 6;
            this.ctrlLabelTitle.Text = "University Management Application";
            // 
            // ctrlAddCourse
            // 
            this.ctrlAddCourse.Location = new System.Drawing.Point(69, 70);
            this.ctrlAddCourse.Name = "ctrlAddCourse";
            this.ctrlAddCourse.Size = new System.Drawing.Size(109, 117);
            this.ctrlAddCourse.TabIndex = 7;
            this.ctrlAddCourse.Text = "Add Course...";
            this.ctrlAddCourse.UseVisualStyleBackColor = true;
            this.ctrlAddCourse.Click += new System.EventHandler(this.ctrlAddCourse_Click);
            // 
            // ctrlAddStudent
            // 
            this.ctrlAddStudent.Location = new System.Drawing.Point(217, 70);
            this.ctrlAddStudent.Name = "ctrlAddStudent";
            this.ctrlAddStudent.Size = new System.Drawing.Size(109, 117);
            this.ctrlAddStudent.TabIndex = 8;
            this.ctrlAddStudent.Text = "Add Student...";
            this.ctrlAddStudent.UseVisualStyleBackColor = true;
            this.ctrlAddStudent.Click += new System.EventHandler(this.ctrlAddStudent_Click);
            // 
            // ctrlAddProfessor
            // 
            this.ctrlAddProfessor.Location = new System.Drawing.Point(363, 70);
            this.ctrlAddProfessor.Name = "ctrlAddProfessor";
            this.ctrlAddProfessor.Size = new System.Drawing.Size(109, 117);
            this.ctrlAddProfessor.TabIndex = 9;
            this.ctrlAddProfessor.Text = "Add Professor...";
            this.ctrlAddProfessor.UseVisualStyleBackColor = true;
            this.ctrlAddProfessor.Click += new System.EventHandler(this.ctrlAddProfessor_Click);
            // 
            // ctrlListStudent
            // 
            this.ctrlListStudent.Location = new System.Drawing.Point(217, 222);
            this.ctrlListStudent.Name = "ctrlListStudent";
            this.ctrlListStudent.Size = new System.Drawing.Size(109, 114);
            this.ctrlListStudent.TabIndex = 10;
            // 
            // ctrlListCourse
            // 
            this.ctrlListCourse.Location = new System.Drawing.Point(69, 222);
            this.ctrlListCourse.Name = "ctrlListCourse";
            this.ctrlListCourse.Size = new System.Drawing.Size(109, 114);
            this.ctrlListCourse.TabIndex = 11;
            // 
            // ctrlListProfessor
            // 
            this.ctrlListProfessor.Location = new System.Drawing.Point(363, 222);
            this.ctrlListProfessor.Name = "ctrlListProfessor";
            this.ctrlListProfessor.Size = new System.Drawing.Size(109, 114);
            this.ctrlListProfessor.TabIndex = 12;
            // 
            // ctrlExtract
            // 
            this.ctrlExtract.Location = new System.Drawing.Point(12, 458);
            this.ctrlExtract.Name = "ctrlExtract";
            this.ctrlExtract.Size = new System.Drawing.Size(143, 32);
            this.ctrlExtract.TabIndex = 13;
            this.ctrlExtract.Text = "Extract to JSON";
            this.ctrlExtract.UseVisualStyleBackColor = true;
            this.ctrlExtract.Click += new System.EventHandler(this.ctrlExtract_Click);
            // 
            // ctrlImport
            // 
            this.ctrlImport.Location = new System.Drawing.Point(161, 458);
            this.ctrlImport.Name = "ctrlImport";
            this.ctrlImport.Size = new System.Drawing.Size(143, 32);
            this.ctrlImport.TabIndex = 14;
            this.ctrlImport.Text = "Import from JSON";
            this.ctrlImport.UseVisualStyleBackColor = true;
            this.ctrlImport.Click += new System.EventHandler(this.ctrlImport_Click);
            // 
            // ctrlExit
            // 
            this.ctrlExit.Location = new System.Drawing.Point(645, 458);
            this.ctrlExit.Name = "ctrlExit";
            this.ctrlExit.Size = new System.Drawing.Size(143, 32);
            this.ctrlExit.TabIndex = 15;
            this.ctrlExit.Text = "Exit";
            this.ctrlExit.UseVisualStyleBackColor = true;
            this.ctrlExit.Click += new System.EventHandler(this.ctrlExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.ctrlExit);
            this.Controls.Add(this.ctrlImport);
            this.Controls.Add(this.ctrlExtract);
            this.Controls.Add(this.ctrlListProfessor);
            this.Controls.Add(this.ctrlListCourse);
            this.Controls.Add(this.ctrlListStudent);
            this.Controls.Add(this.ctrlAddProfessor);
            this.Controls.Add(this.ctrlAddStudent);
            this.Controls.Add(this.ctrlAddCourse);
            this.Controls.Add(this.ctrlLabelTitle);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlListStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlListCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlListProfessor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ctrlLabelTitle;
        private System.Windows.Forms.Button ctrlAddCourse;
        private System.Windows.Forms.Button ctrlAddStudent;
        private System.Windows.Forms.Button ctrlAddProfessor;
        private DevExpress.XtraEditors.ListBoxControl ctrlListStudent;
        private DevExpress.XtraEditors.ListBoxControl ctrlListCourse;
        private DevExpress.XtraEditors.ListBoxControl ctrlListProfessor;
        private System.Windows.Forms.Button ctrlExtract;
        private System.Windows.Forms.Button ctrlImport;
        private System.Windows.Forms.Button ctrlExit;
    }
}

