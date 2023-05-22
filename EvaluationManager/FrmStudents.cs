using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationManager {

    public partial class FrmStudents : Form {
        public FrmStudents() {
            InitializeComponent();
        }

        private void ShowStudents() {
            List<Student> students = StudentRepository.GetStudents();
            dgvStudents.DataSource = students;
        }

        private void FrmStudents_Load(object sender, EventArgs e) {
            ShowStudents();
        }

        private void btnEvaluateStudent_Click(object sender, EventArgs e) {
            if (dgvStudents.SelectedRows.Count > 0) {
                Student selectedStudent = dgvStudents.CurrentRow.DataBoundItem as Student;
                if (selectedStudent != null) {
                    FrmEvaluation frmEvaluation = new FrmEvaluation(selectedStudent);
                    frmEvaluation.ShowDialog();
                }
            }
        }
        private void btnGenerateReport_Click(object sender, EventArgs e) {
            var form = new FrmFinalReport();
            form.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e) {
            var form = new FrmFinalReport();
            form.ShowDialog();
        }
        
    }
}
