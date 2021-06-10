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
    public partial class ProfessorForm : Form {

        public Professor Professor { get; set; }

        public ProfessorForm() {
            InitializeComponent();
        }

        //ok button
        private void button1_Click_1(object sender, EventArgs e) {

            //MODIFY THE OBJECT STUDENT -- CLOSE THE FORM!

            string firstName = string.Empty;
            string lastName = string.Empty;

            if (textEdit1.Text.Length > 0) {
                firstName = textEdit1.Text;
            }

            if (textEdit2.Text.Length > 0) {
                lastName = textEdit2.Text;
            }
            Professor.Name = string.Format("{0} {1}", firstName, lastName);
            
            if (calcEdit1.Value > 0) {
                Professor.Age = (int)calcEdit1.Value;
            }

            if (textEdit4.Text.Length > 0) {
                Professor.Rank = textEdit4.Text;
            }

            Course course = new Course {
                Subject = textEdit3.Text
            };
            Professor.Courses = new Course[] { course };
            this.Close();
        }

        // cancel button
        private void button2_Click_1(object sender, EventArgs e) {
            this.Close();
        }

    }
}
