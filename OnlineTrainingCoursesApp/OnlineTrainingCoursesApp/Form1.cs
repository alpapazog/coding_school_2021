using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using OnlineTrainingCourses.EF.Context;
using OnlineTrainingCourses.Model;

namespace OnlineTrainingCoursesApp {
    public partial class Form1 : Form {
        private OnlineTrainingCoursesAppContext _DbContext;
        private bool SavedFlag { get; set; }
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            SavedFlag = true;

            var optionsBuilder = new DbContextOptionsBuilder<OnlineTrainingCoursesAppContext>();
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-9DVRBJG;Initial Catalog=OnlineTrainingCoursesApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            _DbContext = new OnlineTrainingCoursesAppContext(optionsBuilder.Options);
            //
            Student s = new Student();
            s.Name = "a";
            s.Surname = "b";
            s.Birthdate = DateTime.Now;
            s.Address = "kamp";
            s.Courses = _DbContext.Courses.ToList<Course>();
            _DbContext.Students.Add(s);
            _DbContext.SaveChanges();
            //
            bindingSource1.DataSource = _DbContext.Students.ToList<Student>();
            bindingSource2.DataSource = _DbContext.Courses.ToList<Course>();
            dataGridStudents.DataSource = bindingSource1;
            dataGridCourses.DataSource = bindingSource2;


            dataGridStudents.Columns["ID"].Visible = false;
            dataGridCourses.Columns["ID"].Visible = false;
            dataGridStudents.Refresh();
            dataGridCourses.Refresh();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            _DbContext.Dispose();
        }

        
        private void btnSaveChanges_Click(object sender, EventArgs e) {
            SaveToDatabase();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            if (CheckUserExitRequest()) {
                Application.Exit();
            }
        }

        private void btnNewStudent_Click(object sender, EventArgs e) {
            AddStudent();
        }

        private void btnEditStudent_Click(object sender, EventArgs e) {
            EditStudent();
        }

        private void btnNewCourse_Click(object sender, EventArgs e) {
            AddCourse();
        }

        private void btnEditCourse_Click(object sender, EventArgs e) {
            EditCourse();
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e) {
            DeleteCourse();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e) {
            DeleteStudent();
        }
        private void SaveToDatabase() {
            if (!SavedFlag) {
                try {
                    _DbContext.SaveChanges();
                    SavedFlag = true;
                    MessageBox.Show("Changes were saved successfully.");
                }
                catch (Exception e) {
                    MessageBox.Show(e.Message);
                }
            }
            else {
                MessageBox.Show("No changes were made.");
            }
        }

        private bool CheckUserExitRequest() {
            if (!SavedFlag) {
                string msg = "Any changes you made will be lost if you don't save. Are you sure you want to exit?";
                string title = "Exit";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(msg,title,buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes) {
                    return true;
                }
                else {
                    return false;
                }
            }
            return true;
        }


        private void AddStudent() {
            try {
                Student newStudent = new Student();
                Form2 form = new Form2();
                form.EditObject = newStudent;
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK) {
                    SavedFlag = false;
                    bindingSource1.Add(newStudent);
                    _DbContext.Students.Add(newStudent);
                    dataGridStudents.Refresh();
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }

        private void EditStudent() {
            try {
                Student editStudent = dataGridStudents.SelectedRows[0].DataBoundItem as Student;
                Form2 form = new Form2();
                form.EditObject = editStudent;
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK) {
                    SavedFlag = false;
                    dataGridStudents.Refresh();
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }
        private void AddCourse() {
            try {
                Course newCourse = new Course();
                Form2 form = new Form2();
                form.EditObject = newCourse;
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK) {
                    SavedFlag = false;
                    bindingSource2.Add(newCourse);
                    _DbContext.Courses.Add(newCourse);
                    dataGridCourses.Refresh();
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }

        private void EditCourse() {
            try {
                Course editCourse = dataGridCourses.SelectedRows[0].DataBoundItem as Course;
                Form2 form = new Form2();
                form.EditObject = editCourse;
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK) {
                    SavedFlag = false;
                    dataGridCourses.Refresh();
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }
        private void DeleteStudent() {
            try {
                Student deleteStudent = dataGridStudents.SelectedRows[0].DataBoundItem as Student;
                bindingSource1.Remove(deleteStudent);
                _DbContext.Students.Remove(deleteStudent);
                SavedFlag = false;
                dataGridStudents.Refresh();
                
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }
        private void DeleteCourse() {
            try {
                Course deleteCourse = dataGridCourses.SelectedRows[0].DataBoundItem as Course;
                bindingSource2.Remove(deleteCourse);
                _DbContext.Remove(deleteCourse);
                SavedFlag = false;
                dataGridStudents.Refresh();
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }


    }
}
