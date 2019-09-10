using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumno.BL
{
    public class AlumnosBL
    {
        public BindingList<Alumno> ListadeAlumnos { get; set; }

        public AlumnosBL()
        {
            ListadeAlumnos = new BindingList<Alumno>();

            var alumno1 = new Alumno();
            alumno1.Id = 1;
            alumno1.Nombre = "Jose Perez";
            alumno1.Telefono = "99239382";
            alumno1.Direccion = "Col.Florencia";
            alumno1.Grado = "noveno";
            alumno1.Activo = true;

            ListadeAlumnos.Add(alumno1);

            var alumno2 = new Alumno();
            alumno2.Id = 2;
            alumno2.Nombre = "Maria Juarez";
            alumno2.Telefono = "99394930";
            alumno2.Direccion = "Bo Barandillas";
            alumno2.Grado = "Octavo";
            alumno2.Activo = true;
            ListadeAlumnos.Add(alumno2);

            var alumno3 = new Alumno();
            alumno3.Id = 3;
            alumno3.Nombre = "Lucas Leiva";
            alumno3.Telefono = "93249403";
            alumno3.Direccion = "Bo Guadalup";
            alumno3.Grado = "noveno";
            alumno3.Activo = true;
            ListadeAlumnos.Add(alumno3);
        }
        public BindingList<Alumno> ObtenerAlumnos()
        {
            return ListadeAlumnos;
        }

        public class Alumno
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Telefono { get; set; }
            public string Direccion { get; set; }
            public string Grado { get; set; }
            public bool Activo { get; set; }

        }

    }
}
