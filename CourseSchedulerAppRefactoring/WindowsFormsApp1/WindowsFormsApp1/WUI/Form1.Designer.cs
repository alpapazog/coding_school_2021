
using System.Windows.Forms;

namespace UniversityApp.WUI {
    partial class DataForm1 {
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.dataGridStudents = new System.Windows.Forms.DataGridView();
            this.dataGridProfessors = new System.Windows.Forms.DataGridView();
            this.dataGridCourses = new System.Windows.Forms.DataGridView();
            this.dataGridSchedules = new System.Windows.Forms.DataGridView();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tabHome = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.bntExit = new MetroSet_UI.Controls.MetroSetButton();
            this.btnPreferences = new MetroSet_UI.Controls.MetroSetButton();
            this.btnSaveData = new MetroSet_UI.Controls.MetroSetButton();
            this.btnInitiateData = new MetroSet_UI.Controls.MetroSetButton();
            this.btnLoadData = new MetroSet_UI.Controls.MetroSetButton();
            this.tabSchedule = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.wizardPages1 = new UniversityApp.WUI.WizardPages();
            this.tabPageStart = new System.Windows.Forms.TabPage();
            this.metroSetButtonNewSchedule = new MetroSet_UI.Controls.MetroSetButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.metroSetButtonCourse = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButtonStudent = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButtonProfessor = new MetroSet_UI.Controls.MetroSetButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.metroBtnNext2Page2 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroBtnNext1Page2 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabelPage2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroBackPage2 = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.dataGridViewPage2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.metroBtnNextPage3 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetDefaultButton2 = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.metroSetLabelPage3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.dataGridViewPage3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.metroBtnSelectDate = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetDefaultButton4 = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.metroSetLabelPage4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.dataGridViewPage4 = new System.Windows.Forms.DataGridView();
            this.tabPageCalendar = new System.Windows.Forms.TabPage();
            this.metroBtnNextCalendar = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetDefaultButton1 = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroBtnAddSchedule = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetDefaultButton3 = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.tabProfessors = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.tabStudents = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.tabCourses = new MetroSet_UI.Child.MetroSetSetTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfessors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSchedules)).BeginInit();
            this.metroSetTabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.metroSetPanel1.SuspendLayout();
            this.tabSchedule.SuspendLayout();
            this.wizardPages1.SuspendLayout();
            this.tabPageStart.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPage2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPage3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPage4)).BeginInit();
            this.tabPageCalendar.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabProfessors.SuspendLayout();
            this.tabStudents.SuspendLayout();
            this.tabCourses.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(44, 450);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(143, 32);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove Schedule";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dataGridStudents
            // 
            this.dataGridStudents.AllowUserToOrderColumns = true;
            this.dataGridStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudents.Location = new System.Drawing.Point(0, 7);
            this.dataGridStudents.MultiSelect = false;
            this.dataGridStudents.Name = "dataGridStudents";
            this.dataGridStudents.RowHeadersVisible = false;
            this.dataGridStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridStudents.Size = new System.Drawing.Size(775, 245);
            this.dataGridStudents.TabIndex = 16;
            // 
            // dataGridProfessors
            // 
            this.dataGridProfessors.AllowUserToOrderColumns = true;
            this.dataGridProfessors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProfessors.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridProfessors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProfessors.Location = new System.Drawing.Point(0, 7);
            this.dataGridProfessors.MultiSelect = false;
            this.dataGridProfessors.Name = "dataGridProfessors";
            this.dataGridProfessors.RowHeadersVisible = false;
            this.dataGridProfessors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProfessors.Size = new System.Drawing.Size(775, 245);
            this.dataGridProfessors.TabIndex = 17;
            // 
            // dataGridCourses
            // 
            this.dataGridCourses.AllowUserToOrderColumns = true;
            this.dataGridCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCourses.Location = new System.Drawing.Point(0, 7);
            this.dataGridCourses.MultiSelect = false;
            this.dataGridCourses.Name = "dataGridCourses";
            this.dataGridCourses.RowHeadersVisible = false;
            this.dataGridCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCourses.Size = new System.Drawing.Size(775, 245);
            this.dataGridCourses.TabIndex = 18;
            // 
            // dataGridSchedules
            // 
            this.dataGridSchedules.AllowUserToAddRows = false;
            this.dataGridSchedules.AllowUserToDeleteRows = false;
            this.dataGridSchedules.AllowUserToOrderColumns = true;
            this.dataGridSchedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSchedules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSchedules.Location = new System.Drawing.Point(44, 294);
            this.dataGridSchedules.Name = "dataGridSchedules";
            this.dataGridSchedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSchedules.Size = new System.Drawing.Size(685, 150);
            this.dataGridSchedules.TabIndex = 19;
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(713, 0);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 21;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // metroSetTabControl1
            // 
            this.metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl1.AnimateTime = 200;
            this.metroSetTabControl1.BackgroundColor = System.Drawing.Color.White;
            this.metroSetTabControl1.Controls.Add(this.tabHome);
            this.metroSetTabControl1.Controls.Add(this.tabSchedule);
            this.metroSetTabControl1.Controls.Add(this.tabProfessors);
            this.metroSetTabControl1.Controls.Add(this.tabStudents);
            this.metroSetTabControl1.Controls.Add(this.tabCourses);
            this.metroSetTabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetTabControl1.IsDerivedStyle = true;
            this.metroSetTabControl1.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl1.Location = new System.Drawing.Point(15, 84);
            this.metroSetTabControl1.Name = "metroSetTabControl1";
            this.metroSetTabControl1.SelectedIndex = 1;
            this.metroSetTabControl1.SelectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl1.Size = new System.Drawing.Size(783, 541);
            this.metroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl1.Speed = 100;
            this.metroSetTabControl1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTabControl1.StyleManager = null;
            this.metroSetTabControl1.TabIndex = 22;
            this.metroSetTabControl1.ThemeAuthor = "Narwin";
            this.metroSetTabControl1.ThemeName = "MetroLite";
            this.metroSetTabControl1.UnselectedTextColor = System.Drawing.Color.Gray;
            this.metroSetTabControl1.UseAnimation = false;
            // 
            // tabHome
            // 
            this.tabHome.BaseColor = System.Drawing.Color.White;
            this.tabHome.Controls.Add(this.metroSetPanel1);
            this.tabHome.Font = null;
            this.tabHome.ImageIndex = 0;
            this.tabHome.ImageKey = null;
            this.tabHome.IsDerivedStyle = true;
            this.tabHome.Location = new System.Drawing.Point(4, 42);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(775, 495);
            this.tabHome.Style = MetroSet_UI.Enums.Style.Light;
            this.tabHome.StyleManager = null;
            this.tabHome.TabIndex = 4;
            this.tabHome.Text = "Home";
            this.tabHome.ThemeAuthor = "Narwin";
            this.tabHome.ThemeName = "MetroLite";
            this.tabHome.ToolTipText = null;
            // 
            // metroSetPanel1
            // 
            this.metroSetPanel1.BackgroundColor = System.Drawing.Color.White;
            this.metroSetPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel1.BorderThickness = 1;
            this.metroSetPanel1.Controls.Add(this.bntExit);
            this.metroSetPanel1.Controls.Add(this.btnPreferences);
            this.metroSetPanel1.Controls.Add(this.btnSaveData);
            this.metroSetPanel1.Controls.Add(this.btnInitiateData);
            this.metroSetPanel1.Controls.Add(this.btnLoadData);
            this.metroSetPanel1.IsDerivedStyle = true;
            this.metroSetPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(221, 492);
            this.metroSetPanel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetPanel1.StyleManager = null;
            this.metroSetPanel1.TabIndex = 0;
            this.metroSetPanel1.ThemeAuthor = "Narwin";
            this.metroSetPanel1.ThemeName = "MetroLite";
            // 
            // bntExit
            // 
            this.bntExit.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.bntExit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.bntExit.DisabledForeColor = System.Drawing.Color.Gray;
            this.bntExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bntExit.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.bntExit.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.bntExit.HoverTextColor = System.Drawing.Color.White;
            this.bntExit.IsDerivedStyle = true;
            this.bntExit.Location = new System.Drawing.Point(3, 169);
            this.bntExit.Name = "bntExit";
            this.bntExit.NormalBorderColor = System.Drawing.Color.White;
            this.bntExit.NormalColor = System.Drawing.Color.White;
            this.bntExit.NormalTextColor = System.Drawing.Color.Gray;
            this.bntExit.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.bntExit.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.bntExit.PressTextColor = System.Drawing.Color.White;
            this.bntExit.Size = new System.Drawing.Size(214, 47);
            this.bntExit.Style = MetroSet_UI.Enums.Style.Custom;
            this.bntExit.StyleManager = null;
            this.bntExit.TabIndex = 5;
            this.bntExit.Text = "Exit";
            this.bntExit.ThemeAuthor = "Narwin";
            this.bntExit.ThemeName = "MetroLite";
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // btnPreferences
            // 
            this.btnPreferences.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnPreferences.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnPreferences.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnPreferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPreferences.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnPreferences.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnPreferences.HoverTextColor = System.Drawing.Color.White;
            this.btnPreferences.IsDerivedStyle = true;
            this.btnPreferences.Location = new System.Drawing.Point(3, 126);
            this.btnPreferences.Name = "btnPreferences";
            this.btnPreferences.NormalBorderColor = System.Drawing.Color.White;
            this.btnPreferences.NormalColor = System.Drawing.Color.White;
            this.btnPreferences.NormalTextColor = System.Drawing.Color.Gray;
            this.btnPreferences.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnPreferences.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnPreferences.PressTextColor = System.Drawing.Color.White;
            this.btnPreferences.Size = new System.Drawing.Size(214, 47);
            this.btnPreferences.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnPreferences.StyleManager = null;
            this.btnPreferences.TabIndex = 4;
            this.btnPreferences.Text = "Preferences";
            this.btnPreferences.ThemeAuthor = "Narwin";
            this.btnPreferences.ThemeName = "MetroLite";
            // 
            // btnSaveData
            // 
            this.btnSaveData.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSaveData.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSaveData.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnSaveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSaveData.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSaveData.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSaveData.HoverTextColor = System.Drawing.Color.White;
            this.btnSaveData.IsDerivedStyle = true;
            this.btnSaveData.Location = new System.Drawing.Point(3, 84);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.NormalBorderColor = System.Drawing.Color.White;
            this.btnSaveData.NormalColor = System.Drawing.Color.White;
            this.btnSaveData.NormalTextColor = System.Drawing.Color.Gray;
            this.btnSaveData.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSaveData.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSaveData.PressTextColor = System.Drawing.Color.White;
            this.btnSaveData.Size = new System.Drawing.Size(214, 47);
            this.btnSaveData.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnSaveData.StyleManager = null;
            this.btnSaveData.TabIndex = 3;
            this.btnSaveData.Text = "Save Data";
            this.btnSaveData.ThemeAuthor = "Narwin";
            this.btnSaveData.ThemeName = "MetroLite";
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnInitiateData
            // 
            this.btnInitiateData.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnInitiateData.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnInitiateData.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnInitiateData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnInitiateData.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnInitiateData.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnInitiateData.HoverTextColor = System.Drawing.Color.White;
            this.btnInitiateData.IsDerivedStyle = true;
            this.btnInitiateData.Location = new System.Drawing.Point(4, 3);
            this.btnInitiateData.Name = "btnInitiateData";
            this.btnInitiateData.NormalBorderColor = System.Drawing.Color.White;
            this.btnInitiateData.NormalColor = System.Drawing.Color.White;
            this.btnInitiateData.NormalTextColor = System.Drawing.Color.Gray;
            this.btnInitiateData.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnInitiateData.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnInitiateData.PressTextColor = System.Drawing.Color.White;
            this.btnInitiateData.Size = new System.Drawing.Size(214, 47);
            this.btnInitiateData.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnInitiateData.StyleManager = null;
            this.btnInitiateData.TabIndex = 2;
            this.btnInitiateData.Text = "Initiate Data";
            this.btnInitiateData.ThemeAuthor = "Narwin";
            this.btnInitiateData.ThemeName = "MetroLite";
            this.btnInitiateData.Click += new System.EventHandler(this.btnInitiateData_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLoadData.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLoadData.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLoadData.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnLoadData.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnLoadData.HoverTextColor = System.Drawing.Color.White;
            this.btnLoadData.IsDerivedStyle = true;
            this.btnLoadData.Location = new System.Drawing.Point(3, 43);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.NormalBorderColor = System.Drawing.Color.White;
            this.btnLoadData.NormalColor = System.Drawing.Color.White;
            this.btnLoadData.NormalTextColor = System.Drawing.Color.Gray;
            this.btnLoadData.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnLoadData.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnLoadData.PressTextColor = System.Drawing.Color.White;
            this.btnLoadData.Size = new System.Drawing.Size(214, 47);
            this.btnLoadData.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnLoadData.StyleManager = null;
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.ThemeAuthor = "Narwin";
            this.btnLoadData.ThemeName = "MetroLite";
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // tabSchedule
            // 
            this.tabSchedule.BaseColor = System.Drawing.Color.White;
            this.tabSchedule.Controls.Add(this.wizardPages1);
            this.tabSchedule.Controls.Add(this.dataGridSchedules);
            this.tabSchedule.Controls.Add(this.btnRemove);
            this.tabSchedule.Font = null;
            this.tabSchedule.ImageIndex = 0;
            this.tabSchedule.ImageKey = null;
            this.tabSchedule.IsDerivedStyle = true;
            this.tabSchedule.Location = new System.Drawing.Point(4, 42);
            this.tabSchedule.Name = "tabSchedule";
            this.tabSchedule.Size = new System.Drawing.Size(775, 495);
            this.tabSchedule.Style = MetroSet_UI.Enums.Style.Light;
            this.tabSchedule.StyleManager = null;
            this.tabSchedule.TabIndex = 0;
            this.tabSchedule.Text = "Scheduler";
            this.tabSchedule.ThemeAuthor = "Narwin";
            this.tabSchedule.ThemeName = "MetroLite";
            this.tabSchedule.ToolTipText = null;
            // 
            // wizardPages1
            // 
            this.wizardPages1.Controls.Add(this.tabPageStart);
            this.wizardPages1.Controls.Add(this.tabPage1);
            this.wizardPages1.Controls.Add(this.tabPage2);
            this.wizardPages1.Controls.Add(this.tabPage3);
            this.wizardPages1.Controls.Add(this.tabPage4);
            this.wizardPages1.Controls.Add(this.tabPageCalendar);
            this.wizardPages1.Controls.Add(this.tabPage5);
            this.wizardPages1.Location = new System.Drawing.Point(42, 3);
            this.wizardPages1.Name = "wizardPages1";
            this.wizardPages1.NewSchedule = null;
            this.wizardPages1.ObjectOrder = null;
            this.wizardPages1.Order = null;
            this.wizardPages1.SelectedIndex = 0;
            this.wizardPages1.Size = new System.Drawing.Size(687, 241);
            this.wizardPages1.TabIndex = 21;
            // 
            // tabPageStart
            // 
            this.tabPageStart.Controls.Add(this.metroSetButtonNewSchedule);
            this.tabPageStart.Location = new System.Drawing.Point(4, 25);
            this.tabPageStart.Name = "tabPageStart";
            this.tabPageStart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStart.Size = new System.Drawing.Size(679, 212);
            this.tabPageStart.TabIndex = 0;
            this.tabPageStart.Text = "Start wizard";
            this.tabPageStart.UseVisualStyleBackColor = true;
            // 
            // metroSetButtonNewSchedule
            // 
            this.metroSetButtonNewSchedule.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButtonNewSchedule.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButtonNewSchedule.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButtonNewSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButtonNewSchedule.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButtonNewSchedule.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButtonNewSchedule.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButtonNewSchedule.IsDerivedStyle = true;
            this.metroSetButtonNewSchedule.Location = new System.Drawing.Point(249, 58);
            this.metroSetButtonNewSchedule.Name = "metroSetButtonNewSchedule";
            this.metroSetButtonNewSchedule.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButtonNewSchedule.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButtonNewSchedule.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButtonNewSchedule.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButtonNewSchedule.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButtonNewSchedule.PressTextColor = System.Drawing.Color.White;
            this.metroSetButtonNewSchedule.Size = new System.Drawing.Size(206, 58);
            this.metroSetButtonNewSchedule.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButtonNewSchedule.StyleManager = null;
            this.metroSetButtonNewSchedule.TabIndex = 0;
            this.metroSetButtonNewSchedule.Text = "Create New Schedule";
            this.metroSetButtonNewSchedule.ThemeAuthor = "Narwin";
            this.metroSetButtonNewSchedule.ThemeName = "MetroLite";
            this.metroSetButtonNewSchedule.Click += new System.EventHandler(this.metroSetButtonNewSchedule_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.metroSetButtonCourse);
            this.tabPage1.Controls.Add(this.metroSetButtonStudent);
            this.tabPage1.Controls.Add(this.metroSetButtonProfessor);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(679, 212);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // metroSetButtonCourse
            // 
            this.metroSetButtonCourse.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButtonCourse.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButtonCourse.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButtonCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButtonCourse.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButtonCourse.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButtonCourse.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButtonCourse.IsDerivedStyle = true;
            this.metroSetButtonCourse.Location = new System.Drawing.Point(426, 65);
            this.metroSetButtonCourse.Name = "metroSetButtonCourse";
            this.metroSetButtonCourse.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButtonCourse.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButtonCourse.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButtonCourse.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButtonCourse.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButtonCourse.PressTextColor = System.Drawing.Color.White;
            this.metroSetButtonCourse.Size = new System.Drawing.Size(156, 30);
            this.metroSetButtonCourse.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButtonCourse.StyleManager = null;
            this.metroSetButtonCourse.TabIndex = 24;
            this.metroSetButtonCourse.Text = "Select Course";
            this.metroSetButtonCourse.ThemeAuthor = "Narwin";
            this.metroSetButtonCourse.ThemeName = "MetroLite";
            this.metroSetButtonCourse.Click += new System.EventHandler(this.metroSetButtonCourse_Click);
            // 
            // metroSetButtonStudent
            // 
            this.metroSetButtonStudent.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButtonStudent.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButtonStudent.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButtonStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButtonStudent.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButtonStudent.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButtonStudent.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButtonStudent.IsDerivedStyle = true;
            this.metroSetButtonStudent.Location = new System.Drawing.Point(264, 65);
            this.metroSetButtonStudent.Name = "metroSetButtonStudent";
            this.metroSetButtonStudent.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButtonStudent.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButtonStudent.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButtonStudent.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButtonStudent.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButtonStudent.PressTextColor = System.Drawing.Color.White;
            this.metroSetButtonStudent.Size = new System.Drawing.Size(156, 30);
            this.metroSetButtonStudent.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButtonStudent.StyleManager = null;
            this.metroSetButtonStudent.TabIndex = 23;
            this.metroSetButtonStudent.Text = "Select Student";
            this.metroSetButtonStudent.ThemeAuthor = "Narwin";
            this.metroSetButtonStudent.ThemeName = "MetroLite";
            this.metroSetButtonStudent.Click += new System.EventHandler(this.metroSetButtonStudent_Click);
            // 
            // metroSetButtonProfessor
            // 
            this.metroSetButtonProfessor.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButtonProfessor.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButtonProfessor.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButtonProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButtonProfessor.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButtonProfessor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButtonProfessor.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButtonProfessor.IsDerivedStyle = true;
            this.metroSetButtonProfessor.Location = new System.Drawing.Point(102, 65);
            this.metroSetButtonProfessor.Name = "metroSetButtonProfessor";
            this.metroSetButtonProfessor.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButtonProfessor.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButtonProfessor.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButtonProfessor.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButtonProfessor.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButtonProfessor.PressTextColor = System.Drawing.Color.White;
            this.metroSetButtonProfessor.Size = new System.Drawing.Size(156, 30);
            this.metroSetButtonProfessor.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButtonProfessor.StyleManager = null;
            this.metroSetButtonProfessor.TabIndex = 22;
            this.metroSetButtonProfessor.Text = "Select Professor";
            this.metroSetButtonProfessor.ThemeAuthor = "Narwin";
            this.metroSetButtonProfessor.ThemeName = "MetroLite";
            this.metroSetButtonProfessor.Click += new System.EventHandler(this.metroSetButtonProfessor_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.metroBtnNext2Page2);
            this.tabPage2.Controls.Add(this.metroBtnNext1Page2);
            this.tabPage2.Controls.Add(this.metroSetLabelPage2);
            this.tabPage2.Controls.Add(this.metroBackPage2);
            this.tabPage2.Controls.Add(this.dataGridViewPage2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(679, 212);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // metroBtnNext2Page2
            // 
            this.metroBtnNext2Page2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnNext2Page2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnNext2Page2.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroBtnNext2Page2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroBtnNext2Page2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroBtnNext2Page2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroBtnNext2Page2.HoverTextColor = System.Drawing.Color.White;
            this.metroBtnNext2Page2.IsDerivedStyle = true;
            this.metroBtnNext2Page2.Location = new System.Drawing.Point(562, 183);
            this.metroBtnNext2Page2.Name = "metroBtnNext2Page2";
            this.metroBtnNext2Page2.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnNext2Page2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnNext2Page2.NormalTextColor = System.Drawing.Color.White;
            this.metroBtnNext2Page2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroBtnNext2Page2.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroBtnNext2Page2.PressTextColor = System.Drawing.Color.White;
            this.metroBtnNext2Page2.Size = new System.Drawing.Size(111, 23);
            this.metroBtnNext2Page2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroBtnNext2Page2.StyleManager = null;
            this.metroBtnNext2Page2.TabIndex = 5;
            this.metroBtnNext2Page2.Text = "metroSetButton2";
            this.metroBtnNext2Page2.ThemeAuthor = "Narwin";
            this.metroBtnNext2Page2.ThemeName = "MetroLite";
            this.metroBtnNext2Page2.Click += new System.EventHandler(this.metroBtnNext2Page2_Click);
            // 
            // metroBtnNext1Page2
            // 
            this.metroBtnNext1Page2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnNext1Page2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnNext1Page2.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroBtnNext1Page2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroBtnNext1Page2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroBtnNext1Page2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroBtnNext1Page2.HoverTextColor = System.Drawing.Color.White;
            this.metroBtnNext1Page2.IsDerivedStyle = true;
            this.metroBtnNext1Page2.Location = new System.Drawing.Point(445, 183);
            this.metroBtnNext1Page2.Name = "metroBtnNext1Page2";
            this.metroBtnNext1Page2.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnNext1Page2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnNext1Page2.NormalTextColor = System.Drawing.Color.White;
            this.metroBtnNext1Page2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroBtnNext1Page2.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroBtnNext1Page2.PressTextColor = System.Drawing.Color.White;
            this.metroBtnNext1Page2.Size = new System.Drawing.Size(111, 23);
            this.metroBtnNext1Page2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroBtnNext1Page2.StyleManager = null;
            this.metroBtnNext1Page2.TabIndex = 4;
            this.metroBtnNext1Page2.Text = "metroSetButton1";
            this.metroBtnNext1Page2.ThemeAuthor = "Narwin";
            this.metroBtnNext1Page2.ThemeName = "MetroLite";
            this.metroBtnNext1Page2.Click += new System.EventHandler(this.metroBtnNext1page2_Click);
            // 
            // metroSetLabelPage2
            // 
            this.metroSetLabelPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabelPage2.IsDerivedStyle = true;
            this.metroSetLabelPage2.Location = new System.Drawing.Point(6, 6);
            this.metroSetLabelPage2.Name = "metroSetLabelPage2";
            this.metroSetLabelPage2.Size = new System.Drawing.Size(223, 23);
            this.metroSetLabelPage2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabelPage2.StyleManager = null;
            this.metroSetLabelPage2.TabIndex = 3;
            this.metroSetLabelPage2.Text = "metroSetLabel1";
            this.metroSetLabelPage2.ThemeAuthor = "Narwin";
            this.metroSetLabelPage2.ThemeName = "MetroLite";
            // 
            // metroBackPage2
            // 
            this.metroBackPage2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroBackPage2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroBackPage2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroBackPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroBackPage2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroBackPage2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroBackPage2.HoverTextColor = System.Drawing.Color.White;
            this.metroBackPage2.IsDerivedStyle = true;
            this.metroBackPage2.Location = new System.Drawing.Point(353, 183);
            this.metroBackPage2.Name = "metroBackPage2";
            this.metroBackPage2.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroBackPage2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroBackPage2.NormalTextColor = System.Drawing.Color.Black;
            this.metroBackPage2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroBackPage2.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroBackPage2.PressTextColor = System.Drawing.Color.White;
            this.metroBackPage2.Size = new System.Drawing.Size(86, 23);
            this.metroBackPage2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroBackPage2.StyleManager = null;
            this.metroBackPage2.TabIndex = 1;
            this.metroBackPage2.Text = "Back";
            this.metroBackPage2.ThemeAuthor = "Narwin";
            this.metroBackPage2.ThemeName = "MetroLite";
            this.metroBackPage2.Click += new System.EventHandler(this.metroBackPage2_Click);
            // 
            // dataGridViewPage2
            // 
            this.dataGridViewPage2.AllowUserToOrderColumns = true;
            this.dataGridViewPage2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPage2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPage2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPage2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPage2.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewPage2.MultiSelect = false;
            this.dataGridViewPage2.Name = "dataGridViewPage2";
            this.dataGridViewPage2.ReadOnly = true;
            this.dataGridViewPage2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPage2.Size = new System.Drawing.Size(679, 142);
            this.dataGridViewPage2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.metroBtnNextPage3);
            this.tabPage3.Controls.Add(this.metroSetDefaultButton2);
            this.tabPage3.Controls.Add(this.metroSetLabelPage3);
            this.tabPage3.Controls.Add(this.dataGridViewPage3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(679, 212);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // metroBtnNextPage3
            // 
            this.metroBtnNextPage3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnNextPage3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnNextPage3.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroBtnNextPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroBtnNextPage3.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroBtnNextPage3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroBtnNextPage3.HoverTextColor = System.Drawing.Color.White;
            this.metroBtnNextPage3.IsDerivedStyle = true;
            this.metroBtnNextPage3.Location = new System.Drawing.Point(562, 183);
            this.metroBtnNextPage3.Name = "metroBtnNextPage3";
            this.metroBtnNextPage3.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnNextPage3.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnNextPage3.NormalTextColor = System.Drawing.Color.White;
            this.metroBtnNextPage3.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroBtnNextPage3.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroBtnNextPage3.PressTextColor = System.Drawing.Color.White;
            this.metroBtnNextPage3.Size = new System.Drawing.Size(111, 23);
            this.metroBtnNextPage3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroBtnNextPage3.StyleManager = null;
            this.metroBtnNextPage3.TabIndex = 23;
            this.metroBtnNextPage3.Text = "metroSetButton2";
            this.metroBtnNextPage3.ThemeAuthor = "Narwin";
            this.metroBtnNextPage3.ThemeName = "MetroLite";
            this.metroBtnNextPage3.Click += new System.EventHandler(this.metroBtnNextPage3_Click);
            // 
            // metroSetDefaultButton2
            // 
            this.metroSetDefaultButton2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetDefaultButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetDefaultButton2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetDefaultButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetDefaultButton2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetDefaultButton2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetDefaultButton2.HoverTextColor = System.Drawing.Color.White;
            this.metroSetDefaultButton2.IsDerivedStyle = true;
            this.metroSetDefaultButton2.Location = new System.Drawing.Point(470, 183);
            this.metroSetDefaultButton2.Name = "metroSetDefaultButton2";
            this.metroSetDefaultButton2.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetDefaultButton2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetDefaultButton2.NormalTextColor = System.Drawing.Color.Black;
            this.metroSetDefaultButton2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroSetDefaultButton2.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroSetDefaultButton2.PressTextColor = System.Drawing.Color.White;
            this.metroSetDefaultButton2.Size = new System.Drawing.Size(86, 23);
            this.metroSetDefaultButton2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetDefaultButton2.StyleManager = null;
            this.metroSetDefaultButton2.TabIndex = 22;
            this.metroSetDefaultButton2.Text = "Back";
            this.metroSetDefaultButton2.ThemeAuthor = "Narwin";
            this.metroSetDefaultButton2.ThemeName = "MetroLite";
            this.metroSetDefaultButton2.Click += new System.EventHandler(this.metroSetDefaultButton2_Click);
            // 
            // metroSetLabelPage3
            // 
            this.metroSetLabelPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabelPage3.IsDerivedStyle = true;
            this.metroSetLabelPage3.Location = new System.Drawing.Point(6, 6);
            this.metroSetLabelPage3.Name = "metroSetLabelPage3";
            this.metroSetLabelPage3.Size = new System.Drawing.Size(234, 23);
            this.metroSetLabelPage3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabelPage3.StyleManager = null;
            this.metroSetLabelPage3.TabIndex = 22;
            this.metroSetLabelPage3.Text = "metroSetLabel1";
            this.metroSetLabelPage3.ThemeAuthor = "Narwin";
            this.metroSetLabelPage3.ThemeName = "MetroLite";
            // 
            // dataGridViewPage3
            // 
            this.dataGridViewPage3.AllowUserToOrderColumns = true;
            this.dataGridViewPage3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPage3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPage3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPage3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPage3.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewPage3.MultiSelect = false;
            this.dataGridViewPage3.Name = "dataGridViewPage3";
            this.dataGridViewPage3.ReadOnly = true;
            this.dataGridViewPage3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPage3.Size = new System.Drawing.Size(679, 142);
            this.dataGridViewPage3.TabIndex = 22;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.metroBtnSelectDate);
            this.tabPage4.Controls.Add(this.metroSetDefaultButton4);
            this.tabPage4.Controls.Add(this.metroSetLabelPage4);
            this.tabPage4.Controls.Add(this.dataGridViewPage4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(679, 212);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // metroBtnSelectDate
            // 
            this.metroBtnSelectDate.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnSelectDate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnSelectDate.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroBtnSelectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroBtnSelectDate.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroBtnSelectDate.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroBtnSelectDate.HoverTextColor = System.Drawing.Color.White;
            this.metroBtnSelectDate.IsDerivedStyle = true;
            this.metroBtnSelectDate.Location = new System.Drawing.Point(562, 183);
            this.metroBtnSelectDate.Name = "metroBtnSelectDate";
            this.metroBtnSelectDate.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnSelectDate.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnSelectDate.NormalTextColor = System.Drawing.Color.White;
            this.metroBtnSelectDate.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroBtnSelectDate.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroBtnSelectDate.PressTextColor = System.Drawing.Color.White;
            this.metroBtnSelectDate.Size = new System.Drawing.Size(111, 23);
            this.metroBtnSelectDate.Style = MetroSet_UI.Enums.Style.Light;
            this.metroBtnSelectDate.StyleManager = null;
            this.metroBtnSelectDate.TabIndex = 24;
            this.metroBtnSelectDate.Text = "Next";
            this.metroBtnSelectDate.ThemeAuthor = "Narwin";
            this.metroBtnSelectDate.ThemeName = "MetroLite";
            this.metroBtnSelectDate.Click += new System.EventHandler(this.metroBtnSelectDate_Click);
            // 
            // metroSetDefaultButton4
            // 
            this.metroSetDefaultButton4.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetDefaultButton4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetDefaultButton4.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetDefaultButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetDefaultButton4.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetDefaultButton4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetDefaultButton4.HoverTextColor = System.Drawing.Color.White;
            this.metroSetDefaultButton4.IsDerivedStyle = true;
            this.metroSetDefaultButton4.Location = new System.Drawing.Point(470, 183);
            this.metroSetDefaultButton4.Name = "metroSetDefaultButton4";
            this.metroSetDefaultButton4.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetDefaultButton4.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetDefaultButton4.NormalTextColor = System.Drawing.Color.Black;
            this.metroSetDefaultButton4.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroSetDefaultButton4.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroSetDefaultButton4.PressTextColor = System.Drawing.Color.White;
            this.metroSetDefaultButton4.Size = new System.Drawing.Size(86, 23);
            this.metroSetDefaultButton4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetDefaultButton4.StyleManager = null;
            this.metroSetDefaultButton4.TabIndex = 22;
            this.metroSetDefaultButton4.Text = "Back";
            this.metroSetDefaultButton4.ThemeAuthor = "Narwin";
            this.metroSetDefaultButton4.ThemeName = "MetroLite";
            this.metroSetDefaultButton4.Click += new System.EventHandler(this.metroSetDefaultButton4_Click);
            // 
            // metroSetLabelPage4
            // 
            this.metroSetLabelPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabelPage4.IsDerivedStyle = true;
            this.metroSetLabelPage4.Location = new System.Drawing.Point(6, 6);
            this.metroSetLabelPage4.Name = "metroSetLabelPage4";
            this.metroSetLabelPage4.Size = new System.Drawing.Size(225, 23);
            this.metroSetLabelPage4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabelPage4.StyleManager = null;
            this.metroSetLabelPage4.TabIndex = 22;
            this.metroSetLabelPage4.Text = "metroSetLabel1";
            this.metroSetLabelPage4.ThemeAuthor = "Narwin";
            this.metroSetLabelPage4.ThemeName = "MetroLite";
            // 
            // dataGridViewPage4
            // 
            this.dataGridViewPage4.AllowUserToOrderColumns = true;
            this.dataGridViewPage4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPage4.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPage4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPage4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPage4.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewPage4.MultiSelect = false;
            this.dataGridViewPage4.Name = "dataGridViewPage4";
            this.dataGridViewPage4.ReadOnly = true;
            this.dataGridViewPage4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPage4.Size = new System.Drawing.Size(679, 142);
            this.dataGridViewPage4.TabIndex = 23;
            // 
            // tabPageCalendar
            // 
            this.tabPageCalendar.Controls.Add(this.metroBtnNextCalendar);
            this.tabPageCalendar.Controls.Add(this.metroSetDefaultButton1);
            this.tabPageCalendar.Controls.Add(this.metroSetLabel1);
            this.tabPageCalendar.Controls.Add(this.dateTimePickerTime);
            this.tabPageCalendar.Controls.Add(this.dateTimePickerDate);
            this.tabPageCalendar.Location = new System.Drawing.Point(4, 25);
            this.tabPageCalendar.Name = "tabPageCalendar";
            this.tabPageCalendar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCalendar.Size = new System.Drawing.Size(679, 212);
            this.tabPageCalendar.TabIndex = 5;
            this.tabPageCalendar.Text = "Calendar";
            this.tabPageCalendar.UseVisualStyleBackColor = true;
            // 
            // metroBtnNextCalendar
            // 
            this.metroBtnNextCalendar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnNextCalendar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnNextCalendar.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroBtnNextCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroBtnNextCalendar.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroBtnNextCalendar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroBtnNextCalendar.HoverTextColor = System.Drawing.Color.White;
            this.metroBtnNextCalendar.IsDerivedStyle = true;
            this.metroBtnNextCalendar.Location = new System.Drawing.Point(562, 183);
            this.metroBtnNextCalendar.Name = "metroBtnNextCalendar";
            this.metroBtnNextCalendar.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnNextCalendar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnNextCalendar.NormalTextColor = System.Drawing.Color.White;
            this.metroBtnNextCalendar.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroBtnNextCalendar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroBtnNextCalendar.PressTextColor = System.Drawing.Color.White;
            this.metroBtnNextCalendar.Size = new System.Drawing.Size(111, 23);
            this.metroBtnNextCalendar.Style = MetroSet_UI.Enums.Style.Light;
            this.metroBtnNextCalendar.StyleManager = null;
            this.metroBtnNextCalendar.TabIndex = 26;
            this.metroBtnNextCalendar.Text = "Next";
            this.metroBtnNextCalendar.ThemeAuthor = "Narwin";
            this.metroBtnNextCalendar.ThemeName = "MetroLite";
            this.metroBtnNextCalendar.Click += new System.EventHandler(this.metroBtnNextCalendar_Click);
            // 
            // metroSetDefaultButton1
            // 
            this.metroSetDefaultButton1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetDefaultButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetDefaultButton1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetDefaultButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetDefaultButton1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetDefaultButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetDefaultButton1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetDefaultButton1.IsDerivedStyle = true;
            this.metroSetDefaultButton1.Location = new System.Drawing.Point(470, 183);
            this.metroSetDefaultButton1.Name = "metroSetDefaultButton1";
            this.metroSetDefaultButton1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetDefaultButton1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetDefaultButton1.NormalTextColor = System.Drawing.Color.Black;
            this.metroSetDefaultButton1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroSetDefaultButton1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroSetDefaultButton1.PressTextColor = System.Drawing.Color.White;
            this.metroSetDefaultButton1.Size = new System.Drawing.Size(86, 23);
            this.metroSetDefaultButton1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetDefaultButton1.StyleManager = null;
            this.metroSetDefaultButton1.TabIndex = 25;
            this.metroSetDefaultButton1.Text = "Back";
            this.metroSetDefaultButton1.ThemeAuthor = "Narwin";
            this.metroSetDefaultButton1.ThemeName = "MetroLite";
            this.metroSetDefaultButton1.Click += new System.EventHandler(this.metroSetDefaultButton1_Click);
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(6, 6);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 24;
            this.metroSetLabel1.Text = "Select Date:";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.CustomFormat = "MM/dd/yyyy hh:mm";
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(72, 78);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.Size = new System.Drawing.Size(104, 23);
            this.dateTimePickerTime.TabIndex = 22;
            this.dateTimePickerTime.Value = new System.DateTime(2021, 7, 11, 9, 0, 0, 0);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CustomFormat = "MM/dd/yyyy hh:mm";
            this.dateTimePickerDate.Location = new System.Drawing.Point(72, 49);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(261, 23);
            this.dateTimePickerDate.TabIndex = 23;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.metroSetLabel3);
            this.tabPage5.Controls.Add(this.metroBtnAddSchedule);
            this.tabPage5.Controls.Add(this.metroSetDefaultButton3);
            this.tabPage5.Controls.Add(this.metroSetLabel2);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(679, 212);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(58, 67);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(498, 69);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 27;
            this.metroSetLabel3.Text = "metroSetLabel3";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroBtnAddSchedule
            // 
            this.metroBtnAddSchedule.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnAddSchedule.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnAddSchedule.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroBtnAddSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroBtnAddSchedule.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroBtnAddSchedule.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroBtnAddSchedule.HoverTextColor = System.Drawing.Color.White;
            this.metroBtnAddSchedule.IsDerivedStyle = true;
            this.metroBtnAddSchedule.Location = new System.Drawing.Point(562, 183);
            this.metroBtnAddSchedule.Name = "metroBtnAddSchedule";
            this.metroBtnAddSchedule.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnAddSchedule.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroBtnAddSchedule.NormalTextColor = System.Drawing.Color.White;
            this.metroBtnAddSchedule.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroBtnAddSchedule.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroBtnAddSchedule.PressTextColor = System.Drawing.Color.White;
            this.metroBtnAddSchedule.Size = new System.Drawing.Size(111, 23);
            this.metroBtnAddSchedule.Style = MetroSet_UI.Enums.Style.Light;
            this.metroBtnAddSchedule.StyleManager = null;
            this.metroBtnAddSchedule.TabIndex = 26;
            this.metroBtnAddSchedule.Text = "Add Schedule";
            this.metroBtnAddSchedule.ThemeAuthor = "Narwin";
            this.metroBtnAddSchedule.ThemeName = "MetroLite";
            this.metroBtnAddSchedule.Click += new System.EventHandler(this.metroBtnAddSchedule_Click);
            // 
            // metroSetDefaultButton3
            // 
            this.metroSetDefaultButton3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetDefaultButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetDefaultButton3.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetDefaultButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetDefaultButton3.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetDefaultButton3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetDefaultButton3.HoverTextColor = System.Drawing.Color.White;
            this.metroSetDefaultButton3.IsDerivedStyle = true;
            this.metroSetDefaultButton3.Location = new System.Drawing.Point(470, 183);
            this.metroSetDefaultButton3.Name = "metroSetDefaultButton3";
            this.metroSetDefaultButton3.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetDefaultButton3.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetDefaultButton3.NormalTextColor = System.Drawing.Color.Black;
            this.metroSetDefaultButton3.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroSetDefaultButton3.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroSetDefaultButton3.PressTextColor = System.Drawing.Color.White;
            this.metroSetDefaultButton3.Size = new System.Drawing.Size(86, 23);
            this.metroSetDefaultButton3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetDefaultButton3.StyleManager = null;
            this.metroSetDefaultButton3.TabIndex = 25;
            this.metroSetDefaultButton3.Text = "Back";
            this.metroSetDefaultButton3.ThemeAuthor = "Narwin";
            this.metroSetDefaultButton3.ThemeName = "MetroLite";
            this.metroSetDefaultButton3.Click += new System.EventHandler(this.metroSetDefaultButton3_Click);
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(58, 48);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(478, 19);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 0;
            this.metroSetLabel2.Text = "Would you like to add the following scedule?";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // tabProfessors
            // 
            this.tabProfessors.BaseColor = System.Drawing.Color.White;
            this.tabProfessors.Controls.Add(this.dataGridProfessors);
            this.tabProfessors.Font = null;
            this.tabProfessors.ImageIndex = 0;
            this.tabProfessors.ImageKey = null;
            this.tabProfessors.IsDerivedStyle = true;
            this.tabProfessors.Location = new System.Drawing.Point(4, 42);
            this.tabProfessors.Name = "tabProfessors";
            this.tabProfessors.Size = new System.Drawing.Size(775, 495);
            this.tabProfessors.Style = MetroSet_UI.Enums.Style.Light;
            this.tabProfessors.StyleManager = null;
            this.tabProfessors.TabIndex = 1;
            this.tabProfessors.Text = "Professors";
            this.tabProfessors.ThemeAuthor = "Narwin";
            this.tabProfessors.ThemeName = "MetroLite";
            this.tabProfessors.ToolTipText = null;
            // 
            // tabStudents
            // 
            this.tabStudents.BaseColor = System.Drawing.Color.White;
            this.tabStudents.Controls.Add(this.dataGridStudents);
            this.tabStudents.Font = null;
            this.tabStudents.ImageIndex = 0;
            this.tabStudents.ImageKey = null;
            this.tabStudents.IsDerivedStyle = true;
            this.tabStudents.Location = new System.Drawing.Point(4, 42);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Size = new System.Drawing.Size(775, 495);
            this.tabStudents.Style = MetroSet_UI.Enums.Style.Light;
            this.tabStudents.StyleManager = null;
            this.tabStudents.TabIndex = 2;
            this.tabStudents.Text = "Students";
            this.tabStudents.ThemeAuthor = "Narwin";
            this.tabStudents.ThemeName = "MetroLite";
            this.tabStudents.ToolTipText = null;
            // 
            // tabCourses
            // 
            this.tabCourses.BaseColor = System.Drawing.Color.White;
            this.tabCourses.Controls.Add(this.dataGridCourses);
            this.tabCourses.Font = null;
            this.tabCourses.ImageIndex = 0;
            this.tabCourses.ImageKey = null;
            this.tabCourses.IsDerivedStyle = true;
            this.tabCourses.Location = new System.Drawing.Point(4, 42);
            this.tabCourses.Name = "tabCourses";
            this.tabCourses.Size = new System.Drawing.Size(775, 495);
            this.tabCourses.Style = MetroSet_UI.Enums.Style.Light;
            this.tabCourses.StyleManager = null;
            this.tabCourses.TabIndex = 3;
            this.tabCourses.Text = "Courses";
            this.tabCourses.ThemeAuthor = "Narwin";
            this.tabCourses.ThemeName = "MetroLite";
            this.tabCourses.ToolTipText = null;
            // 
            // DataForm1
            // 
            this.ClientSize = new System.Drawing.Size(813, 650);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.metroSetTabControl1);
            this.Name = "DataForm1";
            this.Load += new System.EventHandler(this.DataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfessors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSchedules)).EndInit();
            this.metroSetTabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.metroSetPanel1.ResumeLayout(false);
            this.tabSchedule.ResumeLayout(false);
            this.wizardPages1.ResumeLayout(false);
            this.tabPageStart.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPage2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPage3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPage4)).EndInit();
            this.tabPageCalendar.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabProfessors.ResumeLayout(false);
            this.tabStudents.ResumeLayout(false);
            this.tabCourses.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        
        private System.Windows.Forms.Button button6;
 
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
  
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dataGridStudents;
        private System.Windows.Forms.DataGridView dataGridProfessors;
        private System.Windows.Forms.DataGridView dataGridCourses;
        private System.Windows.Forms.DataGridView dataGridSchedules;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private MetroSet_UI.Child.MetroSetSetTabPage tabSchedule;
        private MetroSet_UI.Child.MetroSetSetTabPage tabProfessors;
        private MetroSet_UI.Child.MetroSetSetTabPage tabStudents;
        private MetroSet_UI.Child.MetroSetSetTabPage tabCourses;
        private MetroSet_UI.Child.MetroSetSetTabPage tabHome;
        private WizardPages wizardPages1;
        private System.Windows.Forms.TabPage tabPageStart;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private MetroSet_UI.Controls.MetroSetButton metroSetButtonNewSchedule;
        private MetroSet_UI.Controls.MetroSetButton metroSetButtonCourse;
        private MetroSet_UI.Controls.MetroSetButton metroSetButtonStudent;
        private MetroSet_UI.Controls.MetroSetButton metroSetButtonProfessor;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabelPage2;
        private MetroSet_UI.Controls.MetroSetDefaultButton metroBackPage2;
        private System.Windows.Forms.DataGridView dataGridViewPage2;
        private System.Windows.Forms.DataGridView dataGridViewPage3;
        private System.Windows.Forms.TabPage tabPageCalendar;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private MetroSet_UI.Controls.MetroSetDefaultButton metroSetDefaultButton2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabelPage3;
        private MetroSet_UI.Controls.MetroSetDefaultButton metroSetDefaultButton4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabelPage4;
        private System.Windows.Forms.DataGridView dataGridViewPage4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetButton metroBtnNext2Page2;
        private MetroSet_UI.Controls.MetroSetButton metroBtnNext1Page2;
        private MetroSet_UI.Controls.MetroSetButton metroBtnNextPage3;
        private MetroSet_UI.Controls.MetroSetButton metroBtnSelectDate;
        private MetroSet_UI.Controls.MetroSetButton metroBtnNextCalendar;
        private MetroSet_UI.Controls.MetroSetDefaultButton metroSetDefaultButton1;
        private TabPage tabPage5;
        private MetroSet_UI.Controls.MetroSetButton metroBtnAddSchedule;
        private MetroSet_UI.Controls.MetroSetDefaultButton metroSetDefaultButton3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
        private MetroSet_UI.Controls.MetroSetButton btnLoadData;
        private MetroSet_UI.Controls.MetroSetButton btnSaveData;
        private MetroSet_UI.Controls.MetroSetButton btnInitiateData;
        private MetroSet_UI.Controls.MetroSetButton bntExit;
        private MetroSet_UI.Controls.MetroSetButton btnPreferences;
    }
}