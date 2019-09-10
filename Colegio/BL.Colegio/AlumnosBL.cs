using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Colegio
{
   public class AlumnosBL
    {
        Contexto _contexto;
        public BindingList<Alumno> ListaAlumnos { get; set; }

        public AlumnosBL()
        {
            _contexto = new Contexto();
            ListaAlumnos = new BindingList<Alumno>();
        }
        public BindingList<Alumno> ObtenerAlumnos()
        {
            _contexto.Alumnos.Load();
            ListaAlumnos = _contexto.Alumnos.Local.ToBindingList();

            return ListaAlumnos;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarAlumno(Alumno alumno)
        {
            var resultado = Validar(alumno);

            if (resultado.Exitoso== false)
            {
                return resultado;
            }
            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;  
        }
        public void AgregarAlumno ()
        {
            var nuevoAlumno = new Alumno();
            ListaAlumnos.Add(nuevoAlumno);
        }

        public bool EliminarAlumno(int id)
        {
            foreach (var alumno in ListaAlumnos)
            {
                if (alumno.Id == id)
                {
                    ListaAlumnos.Remove(alumno);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        private Resultado Validar(Alumno alumno)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(alumno.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un Nombre";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(alumno.Telefono) == true)
            {
                resultado.Mensaje = "Ingrese un Numero de Telefono";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(alumno.Direccion) == true)
            {
                resultado.Mensaje = "Ingrese una Direccion";
                resultado.Exitoso = false;
            }
            if (alumno.GradoID == 0)
            {
                resultado.Mensaje = "Seleccione un grado";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public int GradoID { get; set; }
        public Grado Grado { get; set; }

        public byte[] foto { get; set; }
        public bool Activo { get; set; }
    }
    
}
