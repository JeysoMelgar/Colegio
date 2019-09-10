using BL.Colegio;
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
    public partial class FormDocentes : Form
    {
        DocentesBL _docentes;

        public FormDocentes()
        {
            InitializeComponent();
            _docentes = new DocentesBL();

            listaDocentesBindingSource.DataSource = _docentes.ObtenerDocentes();
        }

        private void listaDocentesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaDocentesBindingSource.EndEdit();
            var docente = (Docente)listaDocentesBindingSource.Current;

            var resultado = _docentes.GuardarDocente(docente);

            if (resultado.Exitoso == true)
            {
                listaDocentesBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Docente guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _docentes.AgregarDocente();
            listaDocentesBindingSource.MoveLast();

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

            if (iDTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea Eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(iDTextBox.Text);
                    Eliminar(id);
                }
            }
        }

        private void Eliminar(int id)
        {

            var resultado = _docentes.EliminarDocente(id);
            if (resultado == true)
            {
                listaDocentesBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el Docente");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _docentes.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void FormDocentes_Load(object sender, EventArgs e)
        {

        }
    }
}