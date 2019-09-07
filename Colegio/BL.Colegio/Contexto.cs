using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BL.Colegio
{
    public class Contexto : DbContext
    {
        public Contexto() : base("Estudiante")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio());
        }


        public DbSet<Alumno> Alumnos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Grado> Grados { get; set; }
        
    
       
    }
}
