using Empresa.Tarefas.Persistencia.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Tarefas.Persistencia.Mapas
{
    public class MapaBase<TEntidade, TChave> : EntityTypeConfiguration<TEntidade>
        where TEntidade : EntidadeBase<TChave>
        where TChave : struct
    {
        protected void ConfigurePrimaryKey(string columnName)
        {
            this.HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName(columnName);
        }
    }
}
