using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Colegio
{
    public class DocentesBL
    {
        Contexto _contexto;
        public BindingList<Docente> ListaDocentes { get; set; }

        public DocentesBL()
        {
            _contexto = new Contexto();
            ListaDocentes = new BindingList<Docente>();
        }
        
        public BindingList<Docente> ObtenerDocentes()
        {
            _contexto.Docentes.Load();
            ListaDocentes = _contexto.Docentes.Local.ToBindingList();

            return ListaDocentes;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarDocente(Docente docente)
        {
            var resultado = Validar(docente);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }
        public void AgregarDocente()
        {
            var nuevoDocente = new Docente();
            ListaDocentes.Add(nuevoDocente);
        }

        public bool EliminarDocente(int id)
        {
            foreach (var docente in ListaDocentes)
            {
                if (docente.ID == id)
                {
                    ListaDocentes.Remove(docente);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        private Resultado Validar(Docente docente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(docente.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un Nombre";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(docente.telefono) == true)
            {
                resultado.Mensaje = "Ingrese un Numero de Telefono";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(docente.Direccion) == true)
            {
                resultado.Mensaje = "Ingrese una Direccion";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }

    public class Docente
        {
            public int ID { get; set; }
            public string Nombre { get; set; }
            public string Direccion { get; set; }
            public string telefono { get; set; }

       }
}
