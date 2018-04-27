using Empresa.Tarefas.Persistencia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Tarefas.Persistencia.Mapas
{
    public class UsuarioMapa : MapaBase<Usuario, int>
    {
        public UsuarioMapa()
        {
            ToTable("usuario");
            HasKey(x => x.Id).Property(x => x.Id).HasColumnName("id");
            Property(x => x.Nome).HasColumnName("nome");

            HasMany(u => u.ListaTarefas).WithRequired().HasForeignKey(t => t.UsuarioId);
        }
    }
}
