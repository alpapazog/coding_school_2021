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

        public CourseForm() {
            InitializeComponent();
        }


        private void ctrlCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ctrlOK_Click(object sender, EventArgs e) {

            NewCourse.Subject = textEdit1.EditValue.ToString();

            NewCourse.Hours = Convert.ToInt32(calcEdit1.EditValue);
            

            NewCourse.Code = textEdit2.EditValue.ToString();

            DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
