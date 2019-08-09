using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Colegio
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("HOLA"); 
        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAlumnos = new FormAlumnos();
            formAlumnos.MdiParent = this;
            formAlumnos.Show();
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formDocentes = new FormDocentes();
            formDocentes.MdiParent = this;
            formDocentes.Show();
        }
    }
}
