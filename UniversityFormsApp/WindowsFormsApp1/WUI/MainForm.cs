using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {

    public partial class MainForm : Form {

        List<Student> Students = new List<Student>();
        List<Professor> Professors = new List<Professor>();
        List<Course> Courses = new List<Course>();

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

        }

        // add student button
        private void button4_Click(object sender, EventArgs e) {

            Student student = new Student();

            //OPEN FORM ...
            StudentForm form = new StudentForm();
            form.NewStudent = student;


            form.ShowDialog();

            //WHEN FORM CLOSES ADD THE STUDENT TO A STUDENT LIST
            Students.Add(student);

            listBoxControl1.DataSource = Students.Select(x => x.Name);
        }

        private void button2_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        // add professor button
        private void button5_Click(object sender, EventArgs e) {
            Professor professor = new Professor();
            
            ProfessorForm form = new ProfessorForm();
            form.NewProfessor = professor;

            form.ShowDialog();

            Professors.Add(professor);

            listBoxControl3.DataSource = Professors.Select(x => x.Name);
        }

        // add course button
        private void button3_Click(object sender, EventArgs e) {
            Course course = new Course();

            CourseForm form = new CourseForm();
            form.NewCourse = course;

            form.ShowDialog();

            Courses.Add(course);

            listBoxControl2.DataSource = Courses.Select(x => x.Subject);
        }
    }
}
