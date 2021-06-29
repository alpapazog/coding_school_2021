using OnlineTrainingCourses.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineTrainingCoursesApp {
    public partial class Form2 : Form {
        public object EditObject { get; set; }
        public Form2() {
            InitializeComponent();
        }
        private void Form2_Load_1(object sender, EventArgs e) {
            switch (EditObject) {
                case Student student:
                    StudentLayout(student);
                    break;
                case Course course:
                    CourseLayout(course);
                    break;
                default:
                    break;
            }
        }


        private void StudentLayout(Student editStudent) {
            label5.Text = "Student Details";
            textBox3.Visible = true;
            numericUpDown1.Visible = false;
            label1.Text = "Name:";
            label2.Text = "Surname";
            label3.Text = "Birthdate:";
            label4.Text = "Address:";


            if (editStudent.Name != null) {
                textBox1.Text = editStudent.Name;
                textBox2.Text = editStudent.Surname;
                dateTimePicker1.Value = editStudent.Birthdate;
                textBox3.Text = editStudent.Address;
            }
        }
        private void CourseLayout(Course editCourse) {
            label5.Text = "Course Details";
            numericUpDown1.Visible = true;
            textBox3.Visible = false;
            label1.Text = "Title:";
            label2.Text = "Category:";
            label3.Text = "Date:";
            label4.Text = "Duration:";
            numericUpDown1.Controls[0].Visible = false;
            numericUpDown1.Visible = true;
            numericUpDown1.Location = textBox3.Location;
            numericUpDown1.Minimum = 1;

            if (editCourse.Title != null) {
                textBox1.Text = editCourse.Title;
                textBox2.Text = editCourse.Category;
                dateTimePicker1.Value = editCourse.Date;
                numericUpDown1.Value = editCourse.Duration;
            }
        }
        private void StudentEdit(Student editStudent) {
            editStudent.Name = textBox1.Text;
            editStudent.Surname = textBox2.Text;
            editStudent.Birthdate = dateTimePicker1.Value.Date;
            editStudent.Address = textBox3.Text;
        }
        private void CourseEdit(Course editCourse) {
            editCourse.Title = textBox1.Text;
            editCourse.Category = textBox2.Text;
            editCourse.Date = dateTimePicker1.Value.Date;
            editCourse.Duration = Convert.ToInt32(numericUpDown1.Value);
        }

        private void btnOk_Click(object sender, EventArgs e) {
            switch (EditObject) {
                case Student student:
                    StudentEdit(student);
                    break;
                case Course course:
                    CourseEdit(course);
                    break;
                default:
                    break;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

    }
}
