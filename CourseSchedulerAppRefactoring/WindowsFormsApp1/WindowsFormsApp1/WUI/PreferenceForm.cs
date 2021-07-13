using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using UniversityApp.Impl;

namespace UniversityApp.WUI {

    public partial class PreferenceForm : MetroSetForm {
        public University _university;
        public PreferenceForm() {
            InitializeComponent();
        }

        private void PreferenceForm_Load(object sender, EventArgs e) {
            LoadPreferences();
        }


        private void btnOk_Click(object sender, EventArgs e) {
            SavePreferences();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void LoadPreferences() {
            if (_university != null) {
                ctrlMaxProfessorCoursesPerDay.Value = _university.Preferences.MaxProfessorCoursesPerDay;
                ctrlMaxProfessorCoursesPerWeek.Value = _university.Preferences.MaxProfessorCoursesPerWeek;
                ctrlMaxStudentCoursesPerDay.Value = _university.Preferences.MaxStudentCoursesPerDay;
                ctrlMaxStudentCoursesPerWeek.Value = _university.Preferences.MaxStudentCoursesPerWeek;
                return;
            }
        }
        private void SavePreferences() {
            if (_university != null) {
                 _university.Preferences.MaxProfessorCoursesPerDay = (short)ctrlMaxProfessorCoursesPerDay.Value;
                _university.Preferences.MaxProfessorCoursesPerWeek = (short)ctrlMaxProfessorCoursesPerWeek.Value;
                _university.Preferences.MaxStudentCoursesPerDay = (short)ctrlMaxStudentCoursesPerDay.Value;
                _university.Preferences.MaxStudentCoursesPerWeek = (short)ctrlMaxStudentCoursesPerWeek.Value;
                Close();
                return;
            }
        }
    }
}
