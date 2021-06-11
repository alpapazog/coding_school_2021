
namespace WindowsFormsApp1 {
    partial class ProfessorForm {
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
            this.ctrlLabelCourse = new DevExpress.XtraEditors.LabelControl();
            this.ctrlTextCourse = new DevExpress.XtraEditors.TextEdit();
            this.ctrlLabelAge = new DevExpress.XtraEditors.LabelControl();
            this.ctrlCalcAge = new DevExpress.XtraEditors.CalcEdit();
            this.ctrlLabelLastName = new DevExpress.XtraEditors.LabelControl();
            this.ctrlLabelFirstName = new DevExpress.XtraEditors.LabelControl();
            this.ctrlTextLastName = new DevExpress.XtraEditors.TextEdit();
            this.ctrlTextFirstName = new DevExpress.XtraEditors.TextEdit();
            this.ctrlLabelTitle = new DevExpress.XtraEditors.LabelControl();
            this.ctrlLabelRank = new DevExpress.XtraEditors.LabelControl();
            this.ctrlTextRank = new DevExpress.XtraEditors.TextEdit();
            this.ctrlCancel = new System.Windows.Forms.Button();
            this.ctrlOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTextCourse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCalcAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTextLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTextFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTextRank.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlLabelCourse
            // 
            this.ctrlLabelCourse.Location = new System.Drawing.Point(81, 224);
            this.ctrlLabelCourse.Name = "ctrlLabelCourse";
            this.ctrlLabelCourse.Size = new System.Drawing.Size(67, 13);
            this.ctrlLabelCourse.TabIndex = 23;
            this.ctrlLabelCourse.Text = "Add a course:";
            // 
            // ctrlTextCourse
            // 
            this.ctrlTextCourse.EditValue = "(optional)";
            this.ctrlTextCourse.Location = new System.Drawing.Point(163, 221);
            this.ctrlTextCourse.Name = "ctrlTextCourse";
            this.ctrlTextCourse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ctrlTextCourse.Size = new System.Drawing.Size(153, 20);
            this.ctrlTextCourse.TabIndex = 27;
            // 
            // ctrlLabelAge
            // 
            this.ctrlLabelAge.Location = new System.Drawing.Point(125, 169);
            this.ctrlLabelAge.Name = "ctrlLabelAge";
            this.ctrlLabelAge.Size = new System.Drawing.Size(23, 13);
            this.ctrlLabelAge.TabIndex = 21;
            this.ctrlLabelAge.Text = "Age:";
            // 
            // ctrlCalcAge
            // 
            this.ctrlCalcAge.Location = new System.Drawing.Point(163, 166);
            this.ctrlCalcAge.Name = "ctrlCalcAge";
            this.ctrlCalcAge.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlCalcAge.Size = new System.Drawing.Size(100, 20);
            this.ctrlCalcAge.TabIndex = 20;
            // 
            // ctrlLabelLastName
            // 
            this.ctrlLabelLastName.Location = new System.Drawing.Point(94, 143);
            this.ctrlLabelLastName.Name = "ctrlLabelLastName";
            this.ctrlLabelLastName.Size = new System.Drawing.Size(54, 13);
            this.ctrlLabelLastName.TabIndex = 19;
            this.ctrlLabelLastName.Text = "Last Name:";
            // 
            // ctrlLabelFirstName
            // 
            this.ctrlLabelFirstName.Location = new System.Drawing.Point(94, 117);
            this.ctrlLabelFirstName.Name = "ctrlLabelFirstName";
            this.ctrlLabelFirstName.Size = new System.Drawing.Size(55, 13);
            this.ctrlLabelFirstName.TabIndex = 18;
            this.ctrlLabelFirstName.Text = "First Name:";
            // 
            // ctrlTextLastName
            // 
            this.ctrlTextLastName.Location = new System.Drawing.Point(163, 140);
            this.ctrlTextLastName.Name = "ctrlTextLastName";
            this.ctrlTextLastName.Size = new System.Drawing.Size(153, 20);
            this.ctrlTextLastName.TabIndex = 17;
            // 
            // ctrlTextFirstName
            // 
            this.ctrlTextFirstName.Location = new System.Drawing.Point(163, 114);
            this.ctrlTextFirstName.Name = "ctrlTextFirstName";
            this.ctrlTextFirstName.Size = new System.Drawing.Size(153, 20);
            this.ctrlTextFirstName.TabIndex = 16;
            // 
            // ctrlLabelTitle
            // 
            this.ctrlLabelTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlLabelTitle.Appearance.Options.UseFont = true;
            this.ctrlLabelTitle.Location = new System.Drawing.Point(234, 41);
            this.ctrlLabelTitle.Name = "ctrlLabelTitle";
            this.ctrlLabelTitle.Size = new System.Drawing.Size(327, 39);
            this.ctrlLabelTitle.TabIndex = 24;
            this.ctrlLabelTitle.Text = "ADD NEW PROFESSOR";
            // 
            // ctrlLabelRank
            // 
            this.ctrlLabelRank.Location = new System.Drawing.Point(120, 198);
            this.ctrlLabelRank.Name = "ctrlLabelRank";
            this.ctrlLabelRank.Size = new System.Drawing.Size(28, 13);
            this.ctrlLabelRank.TabIndex = 26;
            this.ctrlLabelRank.Text = "Rank:";
            // 
            // ctrlTextRank
            // 
            this.ctrlTextRank.EditValue = "";
            this.ctrlTextRank.Location = new System.Drawing.Point(163, 195);
            this.ctrlTextRank.Name = "ctrlTextRank";
            this.ctrlTextRank.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ctrlTextRank.Size = new System.Drawing.Size(153, 20);
            this.ctrlTextRank.TabIndex = 25;
            // 
            // ctrlCancel
            // 
            this.ctrlCancel.Location = new System.Drawing.Point(679, 406);
            this.ctrlCancel.Name = "ctrlCancel";
            this.ctrlCancel.Size = new System.Drawing.Size(109, 32);
            this.ctrlCancel.TabIndex = 29;
            this.ctrlCancel.Text = "Cancel";
            this.ctrlCancel.UseVisualStyleBackColor = true;
            this.ctrlCancel.Click += new System.EventHandler(this.ctrlCancel_Click);
            // 
            // ctrlOK
            // 
            this.ctrlOK.Location = new System.Drawing.Point(564, 406);
            this.ctrlOK.Name = "ctrlOK";
            this.ctrlOK.Size = new System.Drawing.Size(109, 32);
            this.ctrlOK.TabIndex = 28;
            this.ctrlOK.Text = "OK";
            this.ctrlOK.UseVisualStyleBackColor = true;
            this.ctrlOK.Click += new System.EventHandler(this.ctrlOK_Click);
            // 
            // ProfessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlCancel);
            this.Controls.Add(this.ctrlOK);
            this.Controls.Add(this.ctrlLabelRank);
            this.Controls.Add(this.ctrlTextRank);
            this.Controls.Add(this.ctrlLabelTitle);
            this.Controls.Add(this.ctrlLabelCourse);
            this.Controls.Add(this.ctrlTextCourse);
            this.Controls.Add(this.ctrlLabelAge);
            this.Controls.Add(this.ctrlCalcAge);
            this.Controls.Add(this.ctrlLabelLastName);
            this.Controls.Add(this.ctrlLabelFirstName);
            this.Controls.Add(this.ctrlTextLastName);
            this.Controls.Add(this.ctrlTextFirstName);
            this.Name = "ProfessorForm";
            this.Text = "ProfessorForm";
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTextCourse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCalcAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTextLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTextFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTextRank.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl ctrlLabelCourse;
        private DevExpress.XtraEditors.TextEdit ctrlTextCourse;
        private DevExpress.XtraEditors.LabelControl ctrlLabelAge;
        private DevExpress.XtraEditors.CalcEdit ctrlCalcAge;
        private DevExpress.XtraEditors.LabelControl ctrlLabelLastName;
        private DevExpress.XtraEditors.LabelControl ctrlLabelFirstName;
        private DevExpress.XtraEditors.TextEdit ctrlTextLastName;
        private DevExpress.XtraEditors.TextEdit ctrlTextFirstName;
        private DevExpress.XtraEditors.LabelControl ctrlLabelTitle;
        private DevExpress.XtraEditors.LabelControl ctrlLabelRank;
        private DevExpress.XtraEditors.TextEdit ctrlTextRank;
        private System.Windows.Forms.Button ctrlCancel;
        private System.Windows.Forms.Button ctrlOK;
    }
}