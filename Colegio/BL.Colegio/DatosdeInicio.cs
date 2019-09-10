using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Colegio
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var usuario1 = new Usuario();
            usuario1.Nombre = "admin";
            usuario1.Contrasena = "123";

            contexto.Usuarios.Add(usuario1);

            var usuario2 = new Usuario();
            usuario2.Nombre = "user";
            usuario2.Contrasena = "456";

            contexto.Usuarios.Add(usuario2);

            var grado1 = new Grado();
            grado1.Descripcion = "Primer grado";
            grado1.Precio = 1000;
            contexto.Grados.Add(grado1);

            var grado2 = new Grado();
            grado2.Descripcion = "Segundo grado";
            grado2.Precio = 1050;
            contexto.Grados.Add(grado2);

            var grado3 = new Grado();
            grado3.Descripcion = "Tercer grado";
            grado3.Precio = 1100;
            contexto.Grados.Add(grado3);

            var grado4 = new Grado();
            grado4.Descripcion = "Cuarto grado";
            grado4.Precio = 1150;
            contexto.Grados.Add(grado4);

            var grado5 = new Grado();
            grado5.Descripcion = "Quinto grado";
            grado5.Precio = 1200;
            contexto.Grados.Add(grado5);

            var grado6 = new Grado();
            grado6.Descripcion = "Sexto grado";
            grado6.Precio = 1250;
            contexto.Grados.Add(grado6);

            var grado7 = new Grado();
            grado7.Descripcion = "Septimo grado";
            grado7.Precio = 1300;
            contexto.Grados.Add(grado7);

            var grado8 = new Grado();
            grado8.Descripcion = "Octavo grado";
            grado8.Precio = 1350;
            contexto.Grados.Add(grado8);

            var grado9 = new Grado();
            grado9.Descripcion = "Noveno grado";
            grado9.Precio = 1400;
            contexto.Grados.Add(grado9);

            base.Seed(contexto);
        }
    }
}
