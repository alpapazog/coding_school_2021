using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class MdiMainForm : DevExpress.XtraEditors.XtraForm {

        University NewUniversity;

        private const string _JsonFile = "UniversityData.json";

        public MdiMainForm() {
            InitializeComponent();
        }

        private void MdiMainForm_Load(object sender, EventArgs e) {
            this.IsMdiContainer = true;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            ImportFromJson();
        }

        private void ImportFromJson() {
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            string data = File.ReadAllText(path);

            NewUniversity = serializer.Deserialize<University>(data);
        }

        private void ExtractToJson() {

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string data = serializer.Serialize(NewUniversity);

            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);

            File.WriteAllText(path, data);
        }

        //Load student form
        private void studentToolStripMenuItem_Click(object sender, EventArgs e) {
            Student newStudent = new Student();
            StudentForm form = new StudentForm();
            ChooseForm<StudentForm>(form);
        }

        //Load professor form
        private void professorToolStripMenuItem_Click(object sender, EventArgs e) {
            Professor newProfessor = new Professor();
            ChooseForm<Professor>(newProfessor);
        }

        //Load course form
        private void courseToolStripMenuItem_Click(object sender, EventArgs e) {
            Course newCourse = new Course();
            ChooseForm<Course>(newCourse);
        }

        private void ChooseForm<T>(T t) {
            t.GetType().GetMethod("Show").Invoke(t, null);
            //OPEN FORM ...

            // tForm.NewStudent = student;

            ////WHEN FORM CLOSES ADD THE STUDENT TO A STUDENT LIST
            //if (form.DialogResult == DialogResult.OK) {
            //    university.Students.Add(student);
            //}

            //RefreshLists();


        }
    }
}
