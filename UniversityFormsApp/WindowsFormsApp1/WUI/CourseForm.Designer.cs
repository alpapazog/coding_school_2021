
namespace WindowsFormsApp1 {
    partial class CourseForm {
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
            this.ctrlLabelCode = new DevExpress.XtraEditors.LabelControl();
            this.ctrlLabelSubject = new DevExpress.XtraEditors.LabelControl();
            this.ctrlTextCode = new DevExpress.XtraEditors.TextEdit();
            this.ctrlTextSubject = new DevExpress.XtraEditors.TextEdit();
            this.ctrlLabelHours = new DevExpress.XtraEditors.LabelControl();
            this.ctrlCalcHours = new DevExpress.XtraEditors.CalcEdit();
            this.ctrlOK = new System.Windows.Forms.Button();
            this.ctrlCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTextCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTextSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCalcHours.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlLabelTitle
            // 
            this.ctrlLabelTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlLabelTitle.Appearance.Options.UseFont = true;
            this.ctrlLabelTitle.Location = new System.Drawing.Point(261, 41);
            this.ctrlLabelTitle.Name = "ctrlLabelTitle";
            this.ctrlLabelTitle.Size = new System.Drawing.Size(270, 39);
            this.ctrlLabelTitle.TabIndex = 31;
            this.ctrlLabelTitle.Text = "ADD NEW COURSE";
            // 
            // ctrlLabelCode
            // 
            this.ctrlLabelCode.Location = new System.Drawing.Point(125, 145);
            this.ctrlLabelCode.Name = "ctrlLabelCode";
            this.ctrlLabelCode.Size = new System.Drawing.Size(29, 13);
            this.ctrlLabelCode.TabIndex = 35;
            this.ctrlLabelCode.Text = "Code:";
            // 
            // ctrlLabelSubject
            // 
            this.ctrlLabelSubject.Location = new System.Drawing.Point(114, 119);
            this.ctrlLabelSubject.Name = "ctrlLabelSubject";
            this.ctrlLabelSubject.Size = new System.Drawing.Size(40, 13);
            this.ctrlLabelSubject.TabIndex = 34;
            this.ctrlLabelSubject.Text = "Subject:";
            // 
            // ctrlTextCode
            // 
            this.ctrlTextCode.Location = new System.Drawing.Point(160, 142);
            this.ctrlTextCode.Name = "ctrlTextCode";
            this.ctrlTextCode.Size = new System.Drawing.Size(153, 20);
            this.ctrlTextCode.TabIndex = 33;
            // 
            // ctrlTextSubject
            // 
            this.ctrlTextSubject.Location = new System.Drawing.Point(160, 116);
            this.ctrlTextSubject.Name = "ctrlTextSubject";
            this.ctrlTextSubject.Size = new System.Drawing.Size(153, 20);
            this.ctrlTextSubject.TabIndex = 32;
            // 
            // ctrlLabelHours
            // 
            this.ctrlLabelHours.Location = new System.Drawing.Point(122, 170);
            this.ctrlLabelHours.Name = "ctrlLabelHours";
            this.ctrlLabelHours.Size = new System.Drawing.Size(32, 13);
            this.ctrlLabelHours.TabIndex = 39;
            this.ctrlLabelHours.Text = "Hours:";
            // 
            // ctrlCalcHours
            // 
            this.ctrlCalcHours.Location = new System.Drawing.Point(160, 167);
            this.ctrlCalcHours.Name = "ctrlCalcHours";
            this.ctrlCalcHours.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlCalcHours.Size = new System.Drawing.Size(100, 20);
            this.ctrlCalcHours.TabIndex = 38;
            // 
            // ctrlOK
            // 
            this.ctrlOK.Location = new System.Drawing.Point(564, 406);
            this.ctrlOK.Name = "ctrlOK";
            this.ctrlOK.Size = new System.Drawing.Size(109, 32);
            this.ctrlOK.TabIndex = 41;
            this.ctrlOK.Text = "OK";
            this.ctrlOK.UseVisualStyleBackColor = true;
            this.ctrlOK.Click += new System.EventHandler(this.ctrlOK_Click);
            // 
            // ctrlCancel
            // 
            this.ctrlCancel.Location = new System.Drawing.Point(679, 406);
            this.ctrlCancel.Name = "ctrlCancel";
            this.ctrlCancel.Size = new System.Drawing.Size(109, 32);
            this.ctrlCancel.TabIndex = 42;
            this.ctrlCancel.Text = "Cancel";
            this.ctrlCancel.UseVisualStyleBackColor = true;
            this.ctrlCancel.Click += new System.EventHandler(this.ctrlCancel_Click);
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlCancel);
            this.Controls.Add(this.ctrlOK);
            this.Controls.Add(this.ctrlLabelHours);
            this.Controls.Add(this.ctrlCalcHours);
            this.Controls.Add(this.ctrlLabelCode);
            this.Controls.Add(this.ctrlLabelSubject);
            this.Controls.Add(this.ctrlTextCode);
            this.Controls.Add(this.ctrlTextSubject);
            this.Controls.Add(this.ctrlLabelTitle);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTextCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTextSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCalcHours.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl ctrlLabelTitle;
        private DevExpress.XtraEditors.LabelControl ctrlLabelCode;
        private DevExpress.XtraEditors.LabelControl ctrlLabelSubject;
        private DevExpress.XtraEditors.TextEdit ctrlTextCode;
        private DevExpress.XtraEditors.TextEdit ctrlTextSubject;
        private DevExpress.XtraEditors.LabelControl ctrlLabelHours;
        private DevExpress.XtraEditors.CalcEdit ctrlCalcHours;
        private System.Windows.Forms.Button ctrlOK;
        private System.Windows.Forms.Button ctrlCancel;
    }
}