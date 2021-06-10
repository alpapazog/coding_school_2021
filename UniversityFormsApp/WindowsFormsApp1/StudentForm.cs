using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress;

namespace WindowsFormsApp1 {

    public partial class StudentForm : Form {

        // PROPERTIES
        public Student Student { get; set; }

        // CONSTRUCTOR
        public StudentForm() {
            InitializeComponent();
        }


        // METHODS
        private void StudentForm_Load(object sender, EventArgs e) {

        }

        //ok button
        private void button1_Click(object sender, EventArgs e) {

            //MODIFY THE OBJECT STUDENT -- CLOSE THE FORM!

            string firstName = string.Empty;
            string lastName = string.Empty;

            if (textEdit1.Text.Length > 0) {
                 firstName = textEdit1.Text;
            }

            if(textEdit2.Text.Length > 0) {
                 lastName = textEdit2.Text;
            }
            Student.Name = string.Format("{0} {1}", firstName, lastName);
            

            if (calcEdit1.Value > 0) {
                Student.Age = (int)calcEdit1.Value;
            }

            Course course = new Course();
            course.Subject = textEdit3.Text;
            Student.Courses = new Course[] { course };
            this.Close();
        }

        //cancel button
        private void button2_Click(object sender, EventArgs e) {
            //CANCEL EVERYTHING -- DO NOT MODIFY THE OBJECT!
            this.Close();
        }

    
    }
}
