using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using UniversityApp.Impl;

namespace UniversityApp.WUI {

    public partial class DataForm1 : Form {

        private University NewUniversity { get; set; }

        private BindingSource BindingSourceStudents;
        private BindingSource BindingSourceProfessors;
        private BindingSource BindingSourceCourses;
        private BindingSource BindingSourceSchedules;

        private string _jsonFile = "Data.json";
        private string _logFile = "Log.txt";

        public DataForm1() {
            InitializeComponent();
        }

        #region Events
        private void DataForm_Load(object sender, EventArgs e) {
            dateTimePickerTime.ShowUpDown = true;
            // todo : load data on enter!
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
            AddSchedule();
        }
        private void btnRemove_Click(object sender, EventArgs e) {
            RemoveSchedules();
        }

        #endregion

        #region Methods
        private void AddToScheduleGrid(Schedule schedule) {
            Professor professor = NewUniversity.Professors.Find(x => x.Id == schedule.ProfessorId);
            string professorName = string.Format("{0} {1}", professor.Name, professor.Surname);

            Student student = NewUniversity.Students.Find(x => x.Id == schedule.StudentId);
            string studentName = string.Format("{0} {1}", student.Name, student.Surname);

            Course course = NewUniversity.Courses.Find(x => x.Id == schedule.CourseId);

            dataGridSchedules.Rows.Add(professorName, studentName, course.Subject, schedule.Calendar.ToString()) ;
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

            dataGridSchedules.ColumnCount = 4;
            dataGridSchedules.Columns[0].Name = "Professor";
            dataGridSchedules.Columns[1].Name = "Student";
            dataGridSchedules.Columns[2].Name = "Course";
            dataGridSchedules.Columns[3].Name = "Calendar";
            foreach (var s in NewUniversity.ScheduleList) {
                AddToScheduleGrid(s);
            }
        }
        private void AddSchedule() {
            DataGridViewRow courseRow = dataGridCourses.SelectedRows[0];
            DataGridViewRow professorRow = dataGridProfessors.SelectedRows[0];
            DataGridViewRow studentRow = dataGridStudents.SelectedRows[0];
            Schedule newSchedule = new Schedule() {
                CourseId = (Guid)courseRow.Cells["Id"].Value,
                ProfessorId = (Guid)professorRow.Cells["Id"].Value,
                StudentId = (Guid)studentRow.Cells["Id"].Value,
            };
            newSchedule.Calendar = dateTimePickerDate.Value.Date + dateTimePickerTime.Value.TimeOfDay;

            ScheduleValidate scheduleValidate = new ScheduleValidate(NewUniversity, _logFile);
            if (scheduleValidate.ValidateNewSchedule(newSchedule)) {
                NewUniversity.ScheduleList.Add(newSchedule);
                AddToScheduleGrid(newSchedule);
            }
            else {
                MessageBox.Show(scheduleValidate.ErrorMessage);
            }


            // TODO: 1. CANNOT ADD SAME STUDENT + PROFESSOR IN SAME DATE & HOUR

            // TODO: 2. EACH STUDENT CANNOT HAVE MORE THAN 3 COURSES PER DAY!

            // TODO: 3. A PROFESSOR CANNOT TEACH MORE THAN 4 COURSES PER DAY AND 40 COURSES PER WEEK


            // todo: add exception handling?
        }
        private void RemoveSchedules() {
            foreach (DataGridViewRow row in dataGridSchedules.SelectedRows) {
                dataGridSchedules.Rows.Remove(row);
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

        #endregion

    }


}