using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Empresa.Tarefas.Persistencia.Mapas;
using Empresa.Tarefas.Persistencia.Entidades;

namespace Empresa.Tarefas.Persistencia.Contexto
{
    public class TarefasDBContexto : DbContext
    {
        public TarefasDBContexto() : base ("TarefasDBContext")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (modelBuilder != null)
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.HasDefaultSchema("dbo");
                modelBuilder.Conventions.Remove<StoreGeneratedIdentityKeyConvention>();

                /** */
                modelBuilder.Configurations.Add(new UsuarioMapa());
                modelBuilder.Configurations.Add(new TarefaMapa());
            }
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }

    }
}
