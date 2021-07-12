using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using UniversityApp.Impl;

namespace UniversityApp.WUI {

    public partial class DataForm1 : MetroSetForm {

        private University NewUniversity { get; set; }

        private BindingSource BindingSourceStudents;
        private BindingSource BindingSourceProfessors;
        private BindingSource BindingSourceCourses;

        private readonly string _jsonFile = "Data.json";
        private readonly string _logFile = "Log.txt";

        public DataForm1() {
            InitializeComponent();
        }

        #region Events
        private void DataForm_Load(object sender, EventArgs e) {
            dateTimePickerTime.ShowUpDown = true;
            dataGridStudents.BackgroundColor = System.Drawing.Color.White;
            dataGridProfessors.BackgroundColor = System.Drawing.Color.White;
            dataGridCourses.BackgroundColor = System.Drawing.Color.White;
            dataGridSchedules.BackgroundColor = System.Drawing.Color.White;
        }
        private void initializeDataToolStripMenuItem_Click(object sender, EventArgs e) {
            InitializeUniversityData();
        }
        private void btnLoad_Click(object sender, EventArgs e) {
            if (NewUniversity == null) {
                LoadUniversityData();
            }
            else {
                string message = "Loading data from json will erase all current data. Are you sure you  want to continue?";
                string caption = "Loading University Data";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    LoadUniversityData();
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e) {
            SaveUniversityData();
        }
        private void btnAdd_Click(object sender, EventArgs e) {
            //AddSchedule();
        }
        private void btnRemove_Click(object sender, EventArgs e) {
            RemoveSchedules();
        }

        #endregion

        #region Methods
        private void AddToScheduleGrid(Schedule schedule) {
            string professorName, studentName;
            Course course;
            ScheduleToReadableFormat(schedule, out professorName, out studentName, out course);

            dataGridSchedules.Rows.Add(professorName, studentName, course.Subject, schedule.Calendar.ToString(), schedule.Id);
        }

        private void ScheduleToReadableFormat(Schedule schedule, out string professorName, out string studentName, out Course course) {
            Professor professor = NewUniversity.Professors.Find(x => x.Id == schedule.ProfessorId);
            professorName = string.Format("{0} {1}", professor.Name, professor.Surname);
            Student student = NewUniversity.Students.Find(x => x.Id == schedule.StudentId);
            studentName = string.Format("{0} {1}", student.Name, student.Surname);
            course = NewUniversity.Courses.Find(x => x.Id == schedule.CourseId);
        }

        private void InitDataGrids() {
            BindingSourceStudents = new BindingSource();
            BindingSourceProfessors = new BindingSource();
            BindingSourceCourses = new BindingSource();

            BindingSourceStudents.DataSource = NewUniversity.Students;
            BindingSourceProfessors.DataSource = NewUniversity.Professors;
            BindingSourceCourses.DataSource = NewUniversity.Courses;

            dataGridCourses.DataSource = BindingSourceCourses;
            dataGridProfessors.DataSource = BindingSourceProfessors;
            dataGridStudents.DataSource = BindingSourceStudents;

            dataGridCourses.Columns["Id"].Visible = false;
            dataGridProfessors.Columns["Id"].Visible = false;
            dataGridStudents.Columns["Id"].Visible = false; ;
            RefreshSceduleGrid();

        }

        private bool AddSchedule(Schedule newSchedule) {

            ScheduleValidate scheduleValidate = new ScheduleValidate(NewUniversity, _logFile);
            if (scheduleValidate.ValidateNewSchedule(newSchedule)) {
                NewUniversity.ScheduleList.Add(newSchedule);
                AddToScheduleGrid(newSchedule);
                return true;
            }
            else {
                MessageBox.Show(scheduleValidate.ErrorMessage);
                return false;
            }


            // TODO: 1. CANNOT ADD SAME STUDENT + PROFESSOR IN SAME DATE & HOUR

            // TODO: 2. EACH STUDENT CANNOT HAVE MORE THAN 3 COURSES PER DAY!

            // TODO: 3. A PROFESSOR CANNOT TEACH MORE THAN 4 COURSES PER DAY AND 40 COURSES PER WEEK


            // todo: add exception handling?
        }
        private void RemoveSchedules() {
            foreach (DataGridViewRow row in dataGridSchedules.SelectedRows) {
                dataGridSchedules.Rows.Remove(row);
                NewUniversity.ScheduleList.RemoveAll(x => x.Id == (Guid)row.Cells[4].Value);
            }
        }
        private void InitializeUniversityData() {
            NewUniversity = new University();
            NewUniversity.InitUniversity();
            InitDataGrids();
        }
        private void SaveUniversityData() {
            (new JsonHandler(_jsonFile)).SerializeToJson(NewUniversity);
        }
        private void LoadUniversityData() {
            NewUniversity = (new JsonHandler(_jsonFile)).DeserializeFromJson();
            InitDataGrids();
        }
        private void RefreshSceduleGrid() {
            dataGridSchedules.Rows.Clear();
            dataGridSchedules.ColumnCount = 5;
            dataGridSchedules.Columns[0].Name = "Professor";
            dataGridSchedules.Columns[1].Name = "Student";
            dataGridSchedules.Columns[2].Name = "Course";
            dataGridSchedules.Columns[3].Name = "Calendar";
            dataGridSchedules.Columns[4].Name = "Id";
            dataGridSchedules.Columns[4].Visible = false;
            foreach (var s in NewUniversity.ScheduleList) {
                AddToScheduleGrid(s);
            }
        }

        #endregion

        #region Wizard Events
        private void metroSetButtonNewSchedule_Click(object sender, EventArgs e) {
            wizardPages1.SelectedTab = tabPage1;
        }
        private void metroSetButtonProfessor_Click(object sender, EventArgs e) {
            LoadFirstWizardGrid("Professor");
        }
        private void metroSetButtonStudent_Click(object sender, EventArgs e) {
            LoadFirstWizardGrid("Student");
        }
        private void metroSetButtonCourse_Click(object sender, EventArgs e) {
            LoadFirstWizardGrid("Course");
        }
        private void metroBackPage2_Click(object sender, EventArgs e) {
            wizardPages1.SelectedTab = tabPage1;
            wizardPages1.Order.RemoveAt(0);
        }
        private void metroBtnNext1page2_Click(object sender, EventArgs e) {
            LoadSecondWizardGrid(metroBtnNext1Page2.Text.Split(' ')[1]);
        }
        private void metroBtnNext2Page2_Click(object sender, EventArgs e) {
            LoadSecondWizardGrid(metroBtnNext2Page2.Text.Split(' ')[1]);
        }
        private void metroSetDefaultButton2_Click(object sender, EventArgs e) {
            wizardPages1.SelectedTab = tabPage2;
            wizardPages1.Order.RemoveAt(1);
            wizardPages1.ObjectOrder.RemoveAt(0);
        }
        private void metroBtnNextPage3_Click(object sender, EventArgs e) {
            LoadThirdWizardGrid(metroBtnNextPage3.Text.Split(' ')[1]);
        }
        private void metroSetDefaultButton4_Click(object sender, EventArgs e) {
            wizardPages1.SelectedTab = tabPage3;
            wizardPages1.Order.RemoveAt(2);
            wizardPages1.ObjectOrder.RemoveAt(1);
        }
        private void metroBtnSelectDate_Click(object sender, EventArgs e) {
            wizardPages1.SelectedTab = tabPageCalendar;
            wizardPages1.ObjectOrder.Add(dataGridViewPage4.SelectedRows[0]);
        }
        private void metroSetDefaultButton1_Click(object sender, EventArgs e) {
            wizardPages1.SelectedTab = tabPage4;
            wizardPages1.ObjectOrder.RemoveAt(2);
        }
        private void metroBtnNextCalendar_Click(object sender, EventArgs e) {
            LoadEndWizardTab();
        }
        private void metroBtnAddSchedule_Click(object sender, EventArgs e) {
            if (AddSchedule(wizardPages1.NewSchedule)) {
                wizardPages1.SelectedTab = tabPageStart;
                MessageBox.Show("Schedule successfully added.");
            }

        }
        private void metroSetDefaultButton3_Click(object sender, EventArgs e) {
            wizardPages1.SelectedTab = tabPageCalendar;
        }
        #endregion
        #region Wizard methods
        private void LoadFirstWizardGrid(string obj) {
            wizardPages1.SelectedTab = tabPage2;
            metroSetLabelPage2.Text = string.Format("Select {0}:", obj);
            wizardPages1.Order = new List<string>();
            wizardPages1.ObjectOrder = new List<DataGridViewRow>();
            wizardPages1.Order.Add(obj);
            try {
                switch (obj) {
                    case "Student":
                        dataGridViewPage2.DataSource = NewUniversity.Students;
                        metroBtnNext1Page2.Text = "Select Professor";
                        metroBtnNext2Page2.Text = "Select Course";
                        dataGridViewPage2.Columns["Registration_Number"].HeaderText = "Registration Number";
                        break;
                    case "Professor":
                        dataGridViewPage2.DataSource = NewUniversity.Professors;
                        metroBtnNext1Page2.Text = "Select Student";
                        metroBtnNext2Page2.Text = "Select Course";
                        break;
                    case "Course":
                        dataGridViewPage2.DataSource = NewUniversity.Courses;
                        metroBtnNext1Page2.Text = "Select Professor";
                        metroBtnNext2Page2.Text = "Select Student";
                        break;
                    default:
                        break;
                }
                this.dataGridViewPage2.Columns["Id"].Visible = false;
            }
            catch (Exception e) {
                File.WriteAllText(_logFile, e.ToString());
                MessageBox.Show("Exception thrown. Check Log.txt for details.");
            }
        }
        private void LoadSecondWizardGrid(string obj) {
            wizardPages1.SelectedTab = tabPage3;
            metroSetLabelPage3.Text = string.Format("Select {0}:", obj);
            wizardPages1.Order.Add(obj);
            wizardPages1.ObjectOrder.Add(dataGridViewPage2.SelectedRows[0]);
            try {
                switch (obj) {
                    case "Student":
                        dataGridViewPage3.DataSource = NewUniversity.Students;
                        dataGridViewPage3.Columns["Registration_Number"].HeaderText = "Registration Number";
                        break;
                    case "Professor":
                        dataGridViewPage3.DataSource = NewUniversity.Professors;
                        break;
                    case "Course":
                        dataGridViewPage3.DataSource = NewUniversity.Courses;
                        break;
                    default:
                        break;
                }
                this.dataGridViewPage3.Columns["Id"].Visible = false;
                if (wizardPages1.Order.Exists(x=>x=="Student") && wizardPages1.Order.Exists(x => x == "Professor")) {
                    metroBtnNextPage3.Text = "Select Course";
                }
                else if (wizardPages1.Order.Exists(x => x == "Student") && wizardPages1.Order.Exists(x => x == "Course")) {
                    metroBtnNextPage3.Text = "Select Professor";
                }
                else if (wizardPages1.Order.Exists(x => x == "Course") && wizardPages1.Order.Exists(x => x == "Professor")) {
                    metroBtnNextPage3.Text = "Select Student";
                }
            }
            catch (Exception e) {
                File.WriteAllText(_logFile, e.ToString());
                MessageBox.Show("Exception thrown. Check Log.txt for details.");
            }
        }
        private void LoadThirdWizardGrid(string obj) {
            wizardPages1.SelectedTab = tabPage4;
            metroSetLabelPage4.Text = string.Format("Select {0}:", obj);
            wizardPages1.Order.Add(obj);
            wizardPages1.ObjectOrder.Add(dataGridViewPage3.SelectedRows[0]);
            try {
                switch (obj) {
                    case "Student":
                        dataGridViewPage4.DataSource = NewUniversity.Students;
                        dataGridViewPage4.Columns["Registration_Number"].HeaderText = "Registration Number";
                        break;
                    case "Professor":
                        dataGridViewPage4.DataSource = NewUniversity.Professors;
                        break;
                    case "Course":
                        dataGridViewPage4.DataSource = NewUniversity.Courses;
                        break;
                    default:
                        break;
                }
                this.dataGridViewPage4.Columns["Id"].Visible = false;
            }
            catch (Exception e) {
                File.WriteAllText(_logFile, e.ToString());
                MessageBox.Show("Exception thrown. Check Log.txt for details.");
            }
        }
        private void LoadEndWizardTab() {
            wizardPages1.SelectedTab = tabPage5;
            int studentIndex = wizardPages1.Order.FindIndex(x => x == "Student");
            int professorIndex = wizardPages1.Order.FindIndex(x => x == "Professor");
            int courseIndex = wizardPages1.Order.FindIndex(x => x == "Course");

            DataGridViewRow studentRow = wizardPages1.ObjectOrder[studentIndex];
            DataGridViewRow professorRow = wizardPages1.ObjectOrder[professorIndex];
            DataGridViewRow courseRow = wizardPages1.ObjectOrder[courseIndex];


            Schedule newSchedule = new Schedule() {
                CourseId = (Guid)courseRow.Cells["Id"].Value,
                ProfessorId = (Guid)professorRow.Cells["Id"].Value,
                StudentId = (Guid)studentRow.Cells["Id"].Value,
            };
            newSchedule.Calendar = dateTimePickerDate.Value.Date + dateTimePickerTime.Value.TimeOfDay;

            wizardPages1.NewSchedule = newSchedule;

            string professorName, studentName;
            Course course;
            ScheduleToReadableFormat(newSchedule, out professorName, out studentName, out course);
            metroSetLabel3.Text = string.Format("Professor: {0}\nStudent: {1}\nSubject: {2}\nDate and Time: {3}", professorName, studentName, course.Subject, newSchedule.Calendar.ToString());
        }

        #endregion

    }

    class WizardPages : TabControl {
        public List<string> Order {get; set;}
        public List<DataGridViewRow> ObjectOrder { get; set; }

        public Schedule NewSchedule { get; set; }
        protected override void WndProc(ref Message m) {
            // Hide tabs by trapping the TCM_ADJUSTRECT message
            if (m.Msg == 0x1328 && !DesignMode) m.Result = (IntPtr)1;
            else base.WndProc(ref m);
        }
    }

}