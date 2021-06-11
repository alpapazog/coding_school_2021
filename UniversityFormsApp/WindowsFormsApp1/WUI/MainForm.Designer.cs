﻿
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.listBoxControl2 = new DevExpress.XtraEditors.ListBoxControl();
            this.listBoxControl3 = new DevExpress.XtraEditors.ListBoxControl();
            this.ctrlExtract = new System.Windows.Forms.Button();
            this.ctrlImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl3)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(645, 458);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "University Management Application";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(69, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 117);
            this.button3.TabIndex = 7;
            this.button3.Text = "Add Course...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(217, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 117);
            this.button4.TabIndex = 8;
            this.button4.Text = "Add Student...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(363, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 117);
            this.button5.TabIndex = 9;
            this.button5.Text = "Add Professor...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(217, 222);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(109, 114);
            this.listBoxControl1.TabIndex = 10;
            // 
            // listBoxControl2
            // 
            this.listBoxControl2.Location = new System.Drawing.Point(69, 222);
            this.listBoxControl2.Name = "listBoxControl2";
            this.listBoxControl2.Size = new System.Drawing.Size(109, 114);
            this.listBoxControl2.TabIndex = 11;
            // 
            // listBoxControl3
            // 
            this.listBoxControl3.Location = new System.Drawing.Point(363, 222);
            this.listBoxControl3.Name = "listBoxControl3";
            this.listBoxControl3.Size = new System.Drawing.Size(109, 114);
            this.listBoxControl3.TabIndex = 12;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.ctrlImport);
            this.Controls.Add(this.ctrlExtract);
            this.Controls.Add(this.listBoxControl3);
            this.Controls.Add(this.listBoxControl2);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl2;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl3;
        private System.Windows.Forms.Button ctrlExtract;
        private System.Windows.Forms.Button ctrlImport;
    }
}
