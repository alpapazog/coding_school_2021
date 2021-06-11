
namespace WindowsFormsApp1 {
    partial class StudentForm {
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
            this.ctrlLabelTitle = new DevExpress.XtraEditors.LabelControl();
            this.ctrlTextFirstName = new DevExpress.XtraEditors.TextEdit();
            this.ctrlTextLastName = new DevExpress.XtraEditors.TextEdit();
            this.ctrlLabelFirstName = new DevExpress.XtraEditors.LabelControl();
            this.ctrlLabelLastName = new DevExpress.XtraEditors.LabelControl();
            this.ctrlCalcAge = new DevExpress.XtraEditors.CalcEdit();
            this.ctrlLabelAge = new DevExpress.XtraEditors.LabelControl();
            this.ctrlLabelCourse = new DevExpress.XtraEditors.LabelControl();
            this.ctrlTextCourse = new DevExpress.XtraEditors.TextEdit();
            this.ctrlCancel = new System.Windows.Forms.Button();
            this.ctrlOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTextFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTextLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCalcAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTextCourse.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlLabelTitle
            // 
            this.ctrlLabelTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlLabelTitle.Appearance.Options.UseFont = true;
            this.ctrlLabelTitle.Location = new System.Drawing.Point(218, 31);
            this.ctrlLabelTitle.Name = "ctrlLabelTitle";
            this.ctrlLabelTitle.Size = new System.Drawing.Size(289, 39);
            this.ctrlLabelTitle.TabIndex = 6;
            this.ctrlLabelTitle.Text = "ADD NEW STUDENT";
            // 
            // ctrlTextFirstName
            // 
            this.ctrlTextFirstName.Location = new System.Drawing.Point(148, 103);
            this.ctrlTextFirstName.Name = "ctrlTextFirstName";
            this.ctrlTextFirstName.Size = new System.Drawing.Size(153, 20);
            this.ctrlTextFirstName.TabIndex = 7;
            // 
            // ctrlTextLastName
            // 
            this.ctrlTextLastName.Location = new System.Drawing.Point(148, 129);
            this.ctrlTextLastName.Name = "ctrlTextLastName";
            this.ctrlTextLastName.Size = new System.Drawing.Size(153, 20);
            this.ctrlTextLastName.TabIndex = 8;
            // 
            // ctrlLabelFirstName
            // 
            this.ctrlLabelFirstName.Location = new System.Drawing.Point(79, 106);
            this.ctrlLabelFirstName.Name = "ctrlLabelFirstName";
            this.ctrlLabelFirstName.Size = new System.Drawing.Size(55, 13);
            this.ctrlLabelFirstName.TabIndex = 10;
            this.ctrlLabelFirstName.Text = "First Name:";
            // 
            // ctrlLabelLastName
            // 
            this.ctrlLabelLastName.Location = new System.Drawing.Point(79, 132);
            this.ctrlLabelLastName.Name = "ctrlLabelLastName";
            this.ctrlLabelLastName.Size = new System.Drawing.Size(54, 13);
            this.ctrlLabelLastName.TabIndex = 11;
            this.ctrlLabelLastName.Text = "Last Name:";
            // 
            // ctrlCalcAge
            // 
            this.ctrlCalcAge.Location = new System.Drawing.Point(148, 155);
            this.ctrlCalcAge.Name = "ctrlCalcAge";
            this.ctrlCalcAge.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlCalcAge.Size = new System.Drawing.Size(100, 20);
            this.ctrlCalcAge.TabIndex = 12;
            // 
            // ctrlLabelAge
            // 
            this.ctrlLabelAge.Location = new System.Drawing.Point(110, 158);
            this.ctrlLabelAge.Name = "ctrlLabelAge";
            this.ctrlLabelAge.Size = new System.Drawing.Size(23, 13);
            this.ctrlLabelAge.TabIndex = 13;
            this.ctrlLabelAge.Text = "Age:";
            // 
            // ctrlLabelCourse
            // 
            this.ctrlLabelCourse.Location = new System.Drawing.Point(64, 184);
            this.ctrlLabelCourse.Name = "ctrlLabelCourse";
            this.ctrlLabelCourse.Size = new System.Drawing.Size(70, 13);
            this.ctrlLabelCourse.TabIndex = 15;
            this.ctrlLabelCourse.Text = "Add a course: ";
            // 
            // ctrlTextCourse
            // 
            this.ctrlTextCourse.EditValue = "(optional)";
            this.ctrlTextCourse.Location = new System.Drawing.Point(148, 181);
            this.ctrlTextCourse.Name = "ctrlTextCourse";
            this.ctrlTextCourse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ctrlTextCourse.Size = new System.Drawing.Size(153, 20);
            this.ctrlTextCourse.TabIndex = 14;
            // 
            // ctrlCancel
            // 
            this.ctrlCancel.Location = new System.Drawing.Point(597, 407);
            this.ctrlCancel.Name = "ctrlCancel";
            this.ctrlCancel.Size = new System.Drawing.Size(109, 32);
            this.ctrlCancel.TabIndex = 17;
            this.ctrlCancel.Text = "Cancel";
            this.ctrlCancel.UseVisualStyleBackColor = true;
            this.ctrlCancel.Click += new System.EventHandler(this.ctrlCancel_Click);
            // 
            // ctrlOK
            // 
            this.ctrlOK.Location = new System.Drawing.Point(482, 407);
            this.ctrlOK.Name = "ctrlOK";
            this.ctrlOK.Size = new System.Drawing.Size(109, 32);
            this.ctrlOK.TabIndex = 16;
            this.ctrlOK.Text = "OK";
            this.ctrlOK.UseVisualStyleBackColor = true;
            this.ctrlOK.Click += new System.EventHandler(this.ctrlOK_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 451);
            this.Controls.Add(this.ctrlCancel);
            this.Controls.Add(this.ctrlOK);
            this.Controls.Add(this.ctrlLabelCourse);
            this.Controls.Add(this.ctrlTextCourse);
            this.Controls.Add(this.ctrlLabelAge);
            this.Controls.Add(this.ctrlCalcAge);
            this.Controls.Add(this.ctrlLabelLastName);
            this.Controls.Add(this.ctrlLabelFirstName);
            this.Controls.Add(this.ctrlTextLastName);
            this.Controls.Add(this.ctrlTextFirstName);
            this.Controls.Add(this.ctrlLabelTitle);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTextFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTextLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCalcAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTextCourse.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl ctrlLabelTitle;
        private DevExpress.XtraEditors.TextEdit ctrlTextFirstName;
        private DevExpress.XtraEditors.TextEdit ctrlTextLastName;
        private DevExpress.XtraEditors.LabelControl ctrlLabelFirstName;
        private DevExpress.XtraEditors.LabelControl ctrlLabelLastName;
        private DevExpress.XtraEditors.CalcEdit ctrlCalcAge;
        private DevExpress.XtraEditors.LabelControl ctrlLabelAge;
        private DevExpress.XtraEditors.LabelControl ctrlLabelCourse;
        private DevExpress.XtraEditors.TextEdit ctrlTextCourse;
        private System.Windows.Forms.Button ctrlCancel;
        private System.Windows.Forms.Button ctrlOK;
    }
}