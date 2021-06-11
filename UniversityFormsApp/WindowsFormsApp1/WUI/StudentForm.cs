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
        public Student NewStudent { get; set; }
        public const string NameErrorMessage = "Please insert name...";
        public const string AgeErrorMessage = "Please insert age...";


        // CONSTRUCTOR
        public StudentForm() {
            InitializeComponent();
        }


        // METHODS
        private void StudentForm_Load(object sender, EventArgs e) {

        }
        

        private void ctrlCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ctrlOK_Click(object sender, EventArgs e) {
            if (textEdit1.Text.Length == 0 || textEdit2.Text.Length == 0) {
                MessageBox.Show(NameErrorMessage);
                return;
            }
            string firstName = textEdit1.EditValue.ToString();
            string lastName = textEdit2.EditValue.ToString();

            NewStudent.Name = string.Format("{0} {1}", firstName, lastName);


            if (calcEdit1.Value > 0) {
                NewStudent.Age = Convert.ToInt32(calcEdit1.EditValue);
            }
            else {
                MessageBox.Show(AgeErrorMessage);
                return;
            }


            if (textEdit3.Text.Length != 0) {
                Course course = new Course();
                course.Subject = textEdit3.EditValue.ToString();
                NewStudent.Courses = new Course[] { course };
            }



            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
