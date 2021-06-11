using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace WindowsFormsApp1 {

    public partial class MainForm : Form {

        University university = new University();

        private const string _JsonFile = "UniversityData.json";

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
            if (form.DialogResult == DialogResult.OK) {
                university.Students.Add(student);
            }

            RefreshLists();
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

            if (form.DialogResult == DialogResult.OK) { 
                university.Professors.Add(professor);
            }

            RefreshLists();
        }

        // add course button
        private void button3_Click(object sender, EventArgs e) {
            Course course = new Course();

            CourseForm form = new CourseForm();
            form.NewCourse = course;

            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK) {
                university.Courses.Add(course);
            }

            RefreshLists();
        }

        private void ctrlImport_Click(object sender, EventArgs e) {
            ImportFromJson();
        }

        private void ImportFromJson() {
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            string data = File.ReadAllText(path);

            university = serializer.Deserialize<University>(data);
            
            RefreshLists();
        }

        private void ctrlExtract_Click(object sender, EventArgs e) {
            ExtractToJson();
        }

        private void ExtractToJson() {
            
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string data = serializer.Serialize(university);
            
            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            
            File.WriteAllText(path, data);
        }

        private void RefreshLists() {
            listBoxControl2.DataSource = university.Courses.Select(x => x.Subject);
            listBoxControl1.DataSource = university.Students.Select(x => x.Name);
            listBoxControl3.DataSource = university.Professors.Select(x => x.Name);

        }
    }
}
