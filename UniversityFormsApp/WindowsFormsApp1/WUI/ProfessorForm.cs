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
            if (ctrlTextFirstName.Text.Length == 0 || ctrlTextLastName.Text.Length == 0) {
                MessageBox.Show(NameErrorMessage);
                return;
            }
            string firstName = ctrlTextFirstName.EditValue.ToString();
            string lastName = ctrlTextLastName.EditValue.ToString();

            NewProfessor.Name = string.Format("{0} {1}", firstName, lastName);


            if (ctrlCalcAge.Value > 0) {
                NewProfessor.Age = Convert.ToInt32(ctrlCalcAge.EditValue);
            }
            else {
                MessageBox.Show(AgeErrorMessage);
                return;
            }


            if (ctrlTextCourse.Text.Length != 0) {
                Course course = new Course();
                course.Subject = ctrlTextCourse.EditValue.ToString();
                NewProfessor.Courses = new Course[] { course };
            }

            if (ctrlTextRank.Text.Length > 0) {
                NewProfessor.Rank = ctrlTextRank.EditValue.ToString();
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
