using BL.Colegio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Colegio
{
    public partial class FormAlumnos : Form
    {
        AlumnosBL _alumnos;
        GradosBL _grados;

        public FormAlumnos()
        {
            InitializeComponent();

            _alumnos = new AlumnosBL();
            listaAlumnosBindingSource.DataSource = _alumnos.ObtenerAlumnos();

            _grados = new GradosBL();
            listaGradosBindingSource.DataSource = _grados.ObtenerGrados();
        }

        private void listaAlumnosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaAlumnosBindingSource.EndEdit();
            var alumno = (Alumno)listaAlumnosBindingSource.Current;

            if(fotoPictureBox.Image != null)
            {
                alumno.foto = Program.imageToByteArray(fotoPictureBox.Image);
            }
            else
            {
                alumno.foto = null;
            }

            var resultado = _alumnos.GuardarAlumno(alumno);

            if(resultado.Exitoso == true)
            {
                listaAlumnosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Alumno guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _alumnos.AgregarAlumno();
            listaAlumnosBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }


        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
           
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea Eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
                

           }
        }

        private void Eliminar(int id)
        {
            
            var resultado = _alumnos.EliminarAlumno(id);
            if (resultado == true)
            {
                listaAlumnosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el alumno");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _alumnos.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void FormAlumnos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var alumno = (Alumno)listaAlumnosBindingSource.Current;

            if (alumno != null)
            {
                openFileDialog1.ShowDialog();
                var archivo = openFileDialog1.FileName;

                if (archivo != "")
                {
                    var fileInfo = new FileInfo(archivo);
                    var fileStream = fileInfo.OpenRead();

                    fotoPictureBox.Image = Image.FromStream(fileStream);
                }
            }
            else
            {
                MessageBox.Show("Cree un alumno antes de asignarle una imagen");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
