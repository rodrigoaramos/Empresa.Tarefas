using Empresa.Tarefas.Persistencia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Tarefas.Persistencia.Mapas
{
    public class TarefaMapa : MapaBase<Tarefa, int>
    {
        public TarefaMapa()
        {
            ToTable("tarefa");
            HasKey(x => x.Id).Property(x => x.Id).HasColumnName("id");
            Property(x => x.UsuarioId).HasColumnName("idusuario").IsRequired();
            Property(x => x.Registro).HasColumnName("registro");
            Property(x => x.Descricao).HasColumnName("descricao").HasMaxLength(250).IsRequired();
            Property(x => x.EhImportante).HasColumnName("ehimportante").HasMaxLength(1);
            Property(x => x.Prioridade).HasColumnName("prioridade");
            Property(x => x.EhConcluida).HasColumnName("ehconcluida").HasMaxLength(1);
            Property(X => X.Conclusao).HasColumnName("conclusao");

            HasRequired(a => a.Usuario).WithMany(a => a.ListaTarefas).HasForeignKey(a => a.UsuarioId);
        }
    }
}