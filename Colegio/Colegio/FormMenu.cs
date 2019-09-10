using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colegio
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
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
            var formAlumno = new FormALumno();
            formAlumno.MdiParent = this;
            formAlumno.Show();
        }

        private void encargadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formEncargado = new FormEncargado();
            formEncargado.MdiParent = this;
            formEncargado.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formNotas = new FormNotas();
            formNotas.MdiParent = this;
            formNotas.Show();
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formDocente = new FormDocente();
            formDocente.MdiParent = this;
            formDocente.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Login();
        }
    }
}
