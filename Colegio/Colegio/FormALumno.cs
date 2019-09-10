using Alumno.BL;
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
    public partial class FormALumno : Form
    {
        AlumnosBL _alumnos;

        public FormALumno()
        {
            InitializeComponent();

            _alumnos = new AlumnosBL();
            listadeAlumnosBindingSource.DataSource = _alumnos.ObtenerAlumnos();
        }
    }
}
