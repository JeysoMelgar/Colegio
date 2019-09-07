using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Colegio
{
    public class DatosdeInicio:CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var usuarioAdmin = new Usuario();
            usuarioAdmin.Nombre = "admin";
            usuarioAdmin.Contrasena = "123";

            contexto.Usuarios.Add(usuarioAdmin);

            var usuario2 = new Usuario();
            usuario2.Nombre = "user";
            usuario2.Contrasena = "456";

            contexto.Usuarios.Add(usuario2);

            var grado1 = new Grado();
            grado1.Descripcion = "Primer grado";
            contexto.Grados.Add(grado1);

            var grado2 = new Grado();
            grado2.Descripcion = "Segundo grado";
            contexto.Grados.Add(grado2);

            var grado3 = new Grado();
            grado3.Descripcion = "Tercer grado";
            contexto.Grados.Add(grado3);

            var grado4 = new Grado();
            grado4.Descripcion = "Cuarto grado";
            contexto.Grados.Add(grado4);

            var grado5 = new Grado();
            grado5.Descripcion = "Quinto grado";
            contexto.Grados.Add(grado5);

            var grado6 = new Grado();
            grado6.Descripcion = "Sexto grado";
            contexto.Grados.Add(grado6);

            var grado7 = new Grado();
            grado7.Descripcion = "Septimo grado";
            contexto.Grados.Add(grado7);

            var grado8 = new Grado();
            grado8.Descripcion = "Octavo grado";
            contexto.Grados.Add(grado8);

            var grado9 = new Grado();
            grado9.Descripcion = "Noveno grado";
            contexto.Grados.Add(grado9);
        }

    }
}
