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

        private string _jsonFile = "Data.json";

        public DataForm1() {
            InitializeComponent();
        }

        #region Events
        private void DataForm_Load(object sender, EventArgs e) {
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

        }
        #endregion

        #region Methods
        private void RefreshViews() {
            foreach (Student student in NewUniversity.Students) {
                list1.Items.Add(student.Name + " " + student.Surname);
            }

            foreach (Course course in NewUniversity.Courses) {
                listBox1.Items.Add(course.Code + "--" + course.Subject);
            }


            foreach (Professor professor in NewUniversity.Professors) {

                list3.Items.Add(string.Format("{0}  {1}", professor.Name, professor.Surname));
            }
        }
        private void AddSchedule() {
            try {

                // TODO: 1. CANNOT ADD SAME STUDENT + PROFESSOR IN SAME DATE & HOUR

                // TODO: 2. EACH STUDENT CANNOT HAVE MORE THAN 3 COURSES PER DAY!

                // TODO: 3. A PROFESSOR CANNOT TEACH MORE THAN 4 COURSES PER DAY AND 40 COURSES PER WEEK


                // todo : display on a grid??

                // todo: add exception handling?

                NewUniversity.ScheduleList.Add(new Schedule() { Course = listBox1.SelectedItem.ToString(), Student = list1.SelectedItem.ToString(), Professor = list3.SelectedItem.ToString(), Calendar = dateTimePicker2.Value });

                ctrlSchedule.Items.Clear();
                foreach (var AA in NewUniversity.ScheduleList) {

                    ctrlSchedule.Items.Add(AA.Calendar + " | " + AA.Course + " | " + AA.Student + " | " + AA.Professor);

                }
            }
            catch {

            }
            finally {
                MessageBox.Show("all ok!");

            }
        }
        private void InitializeUniversityData() {
            NewUniversity = new University();
            NewUniversity.InitUniversity();
            RefreshViews();
        }
        private void SaveUniversityData() {
            (new JsonHandler(_jsonFile)).SerializeToJson(NewUniversity);
        }
        private void LoadUniversityData() {
            NewUniversity = (new JsonHandler(_jsonFile)).DeserializeFromJson();
            RefreshViews();
        }
        private void validate_professorCourse_with_studentCourse() {

            //TODO: ???

        }

        #endregion

    }
}

