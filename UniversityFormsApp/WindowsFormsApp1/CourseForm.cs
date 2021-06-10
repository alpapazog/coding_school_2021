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

        public Course Course { get; set; }

        public CourseForm() {
            InitializeComponent();
        }

        //ok button
        private void button1_Click(object sender, EventArgs e) {
            
            Course.Subject = textEdit1.Text;

            if (calcEdit1.Value > 0) {
                Course.Hours = (int)calcEdit1.Value;
            }

            Course.Code = textEdit2.Text;

            this.Close();
        }

        //cancel button
        private void button2_Click(object sender, EventArgs e) {

        }
    }
}
