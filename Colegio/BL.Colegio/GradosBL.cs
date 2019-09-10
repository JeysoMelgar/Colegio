using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Colegio
{
    public class GradosBL
    {
        Contexto _contexto;

        public BindingList<Grado> ListaGrados { get; set; }

        public GradosBL()
        {
            _contexto = new Contexto();
            ListaGrados = new BindingList<Grado>();
        }

        public BindingList<Grado> ObtenerGrados()
        {
            _contexto.Grados.Load();
            ListaGrados = _contexto.Grados.Local.ToBindingList();

            return ListaGrados;
        }
    }

    public class Grado
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
    }
}
