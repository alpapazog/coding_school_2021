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

            if (ctrlTextSubject.Text.Length == 0) {
                MessageBox.Show(SubjectErrorMessage);
                return;
            }
            else {
                NewCourse.Subject = ctrlTextSubject.EditValue.ToString();
            }

            if (ctrlCalcHours.Value == 0) {
                MessageBox.Show(HoursErrorMessage);
                return;
            }
            else {
                NewCourse.Hours = Convert.ToInt32(ctrlCalcHours.EditValue);
            }

            if (ctrlTextCode.Text.Length == 0) {
                MessageBox.Show(CodeErrorMessage);
                return;
            }
            else {
                NewCourse.Code = ctrlTextCode.EditValue.ToString();
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
