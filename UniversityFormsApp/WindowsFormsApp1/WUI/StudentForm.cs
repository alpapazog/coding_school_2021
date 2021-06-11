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
            if (ctrlTextFirstName.Text.Length == 0 || ctrlTextLastName.Text.Length == 0) {
                MessageBox.Show(NameErrorMessage);
                return;
            }
            string firstName = ctrlTextFirstName.EditValue.ToString();
            string lastName = ctrlTextLastName.EditValue.ToString();

            NewStudent.Name = string.Format("{0} {1}", firstName, lastName);


            if (ctrlCalcAge.Value > 0) {
                NewStudent.Age = Convert.ToInt32(ctrlCalcAge.EditValue);
            }
            else {
                MessageBox.Show(AgeErrorMessage);
                return;
            }


            if (ctrlTextCourse.Text.Length != 0) {
                Course course = new Course();
                course.Subject = ctrlTextCourse.EditValue.ToString();
                NewStudent.Courses = new Course[] { course };
            }



            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
