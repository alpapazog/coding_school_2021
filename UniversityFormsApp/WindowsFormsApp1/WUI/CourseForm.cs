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
    public partial class CourseForm : Form {

        public Course NewCourse { get; set; }
        public const string SubjectErrorMessage = "Please insert subject...";
        public const string CodeErrorMessage = "Please insert code...";
        public const string HoursErrorMessage = "Please insert hours...";

        public CourseForm() {
            InitializeComponent();
        }


        private void ctrlCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ctrlOK_Click(object sender, EventArgs e) {

            if (textEdit1.Text.Length == 0) {
                MessageBox.Show(SubjectErrorMessage);
                return;
            }
            else {
                NewCourse.Subject = textEdit1.EditValue.ToString();
            }

            if (calcEdit1.Value == 0) {
                MessageBox.Show(HoursErrorMessage);
                return;
            }
            else {
                NewCourse.Hours = Convert.ToInt32(calcEdit1.EditValue);
            }

            if (textEdit2.Text.Length == 0) {
                MessageBox.Show(CodeErrorMessage);
                return;
            }
            else {
                NewCourse.Code = textEdit2.EditValue.ToString();
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
