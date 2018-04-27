using Empresa.Tarefas.Persistencia.Entidades;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Tarefas.Persistencia.Repositorio
{
    public class Repositorio<TEntidade, TChave> : IRepositorio<TEntidade, TChave>, IDisposable
        where TEntidade : EntidadeBase<TChave>
        where TChave : struct
    {
        public Repositorio(DbContext context)
        {
            Contexto = context;
        }

        protected DbContext Contexto { get; set; }

        #region IDAOGenerico Interface Members

        public TEntidade Inclui(TEntidade entity)
        {
            return Contexto.Set<TEntidade>().Add(entity);
        }

        public TEntidade Altera(TEntidade entity)
        {
            var entry = Contexto.Entry<TEntidade>(entity);
            entry.State = EntityState.Modified;
            return entry.Entity;
        }

        public TEntidade SalvaEAltera(TEntidade entity)
        {
            if (entity.Id.Equals(default(TChave)))
            {
                return Inclui(entity);
            }
            return Altera(entity);
        }

        public void Apaga(TEntidade entity)
        {
            Contexto.Set<TEntidade>().Remove(entity);
        }

        public TEntidade Busca(TChave key)
        {
            return Contexto.Set<TEntidade>().Find(key);
        }

        public ICollection<TEntidade> BuscaTodos()
        {
            return Contexto.Set<TEntidade>().ToList();
        }

        public ICollection<TEntidade> BuscaTodos(int skip, int take, out int total, Func<IQueryable<TEntidade>, IOrderedQueryable<TEntidade>> orderBy)
        {
            IQueryable<TEntidade> entities = Contexto.Set<TEntidade>();
            total = entities.Count();
            entities = entities.Skip(skip).Take(take);
            if (orderBy != null)
            {
                return orderBy(entities).ToList();
            }
            return entities.ToList();
        }

        #endregion IDAOGenerico Interface Members

        public void Dispose()
        {
            this.Dispose(true);
        }

        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    Contexto.Dispose();
                }

                this.disposedValue = true;
            }
        }

    }
}
