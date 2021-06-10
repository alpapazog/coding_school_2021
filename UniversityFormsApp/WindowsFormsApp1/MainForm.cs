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


        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {

            //MessageBox.Show("Hello World!");
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

        }

        private void button4_Click(object sender, EventArgs e) {



            Student student = new Student();
            // TODO: 1. ΝΑ ΠΕΡΑΣΩ ΤΟ STUDENT ΟΒJECT ΣΤΗΝ ΦΟΡΜΑ!

            // TODO: OPEN FORM ...
            StudentForm form = new StudentForm();
            form.Student = student;

            //this.Hide();
            form.ShowDialog();

            //TODO: WHEN FORM THE CLOSES ADD THE STUDENT TO A STUDENT LIST
            Students.Add(student);

            listBoxControl1.DataSource = Students.Select(x => x.Name);
        }

        private void button2_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
