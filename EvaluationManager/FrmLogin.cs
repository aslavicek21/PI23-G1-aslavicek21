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
    public partial class FrmLogin : Form {
        string userName = "Nastavnik";
        string passWord = "Lozinka";
        public FrmLogin() {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e) {
            if (txtUserName.Text == "") {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "") {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                if (txtUserName.Text == userName && txtPassword.Text == passWord) {
                    FrmStudents students = new FrmStudents();
                    Hide();
                    students.ShowDialog();
                    Close();
                } else {
                    MessageBox.Show("Krivi podaci", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e) {

        }
    }
}
