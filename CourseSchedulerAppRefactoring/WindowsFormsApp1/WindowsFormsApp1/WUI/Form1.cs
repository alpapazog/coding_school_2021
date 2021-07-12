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
        private void RefreshDataGrids() {
            dataGridCourses.Refresh();
            dataGridProfessors.Refresh();
            dataGridStudents.Refresh();
            dataGridSchedules.Refresh();
        }
        private void InitDataGrids() {
            BindingSourceStudents = new BindingSource();
            BindingSourceProfessors = new BindingSource();
            BindingSourceCourses = new BindingSource();
            BindingSourceSchedules = new BindingSource();

            BindingSourceStudents.DataSource = NewUniversity.Students;
            BindingSourceProfessors.DataSource = NewUniversity.Professors;
            BindingSourceCourses.DataSource = NewUniversity.Courses;
            BindingSourceSchedules.DataSource = NewUniversity.ScheduleList;

            dataGridCourses.DataSource = BindingSourceCourses;
            dataGridProfessors.DataSource = BindingSourceProfessors;
            dataGridStudents.DataSource = BindingSourceStudents;
            dataGridSchedules.DataSource = BindingSourceSchedules;

            dataGridCourses.Columns["Id"].Visible = false;
            dataGridProfessors.Columns["Id"].Visible = false;
            dataGridStudents.Columns["Id"].Visible = false; ;
            dataGridSchedules.Columns["Id"].Visible = true;
        }
        private void AddSchedule() {
            DataGridViewRow courseRow = dataGridCourses.SelectedRows[0];
            DataGridViewRow professorRow = dataGridCourses.SelectedRows[0];
            DataGridViewRow studentRow = dataGridStudents.SelectedRows[0];
            Schedule newSchedule = new Schedule() {
                CourseId = (Guid)courseRow.Cells["Id"].Value,
                ProfessorId = (Guid)professorRow.Cells["Id"].Value,
                StudentId = (Guid)studentRow.Cells["Id"].Value,
            };
            newSchedule.Calendar = dateTimePickerDate.Value.Date + dateTimePickerTime.Value.TimeOfDay;

            if (NewUniversity.ValidateNewSchedule(newSchedule)) {
                NewUniversity.ScheduleList.Add(newSchedule);
                BindingSourceSchedules.ResetBindings(true);
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
            RefreshDataGrids();
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