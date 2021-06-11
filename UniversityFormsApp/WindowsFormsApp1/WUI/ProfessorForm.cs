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

        public Professor NewProfessor { get; set; }
        public const string NameErrorMessage = "Please insert name...";
        public const string AgeErrorMessage = "Please insert age...";
        public const string RankErrorMessage = "Please insert rank...";


        public ProfessorForm() {
            InitializeComponent();
        }
            

        private void ctrlOK_Click(object sender, EventArgs e) {
            if (textEdit1.Text.Length == 0 || textEdit2.Text.Length == 0) {
                MessageBox.Show(NameErrorMessage);
                return;
            }
            string firstName = textEdit1.EditValue.ToString();
            string lastName = textEdit2.EditValue.ToString();

            NewProfessor.Name = string.Format("{0} {1}", firstName, lastName);


            if (calcEdit1.Value > 0) {
                NewProfessor.Age = Convert.ToInt32(calcEdit1.EditValue);
            }
            else {
                MessageBox.Show(AgeErrorMessage);
                return;
            }


            if (textEdit3.Text.Length != 0) {
                Course course = new Course();
                course.Subject = textEdit3.EditValue.ToString();
                NewProfessor.Courses = new Course[] { course };
            }

            if (textEdit4.Text.Length > 0) {
                NewProfessor.Rank = textEdit4.EditValue.ToString();
            }
            else {
                MessageBox.Show(RankErrorMessage);
                return;
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ctrlCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
