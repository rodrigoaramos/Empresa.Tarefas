using Empresa.Tarefas.Persistencia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Tarefas.Persistencia.Repositorio
{
    public interface IRepositorio<TEntidade, TChave>
        where TEntidade : EntidadeBase<TChave>
        where TChave : struct
    {
        TEntidade Inclui(TEntidade entity);
        
        TEntidade Altera(TEntidade entity);
        
        TEntidade SalvaEAltera(TEntidade entity);
        
        void Apaga(TEntidade entity);

        TEntidade Busca(TChave key);
        
        ICollection<TEntidade> BuscaTodos();
        
        ICollection<TEntidade> BuscaTodos(int skip, int take, out int total, Func<IQueryable<TEntidade>, IOrderedQueryable<TEntidade>> orderBy = null);

        //ICollection<TEntity> BuscarTodos(Expression<Func<TEntity, bool>> expression, int skip, int take, out int total);

        //ICollection<TEntity> BuscarTodos(Expression<Func<TEntity, bool>> expression, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params string[] includeProperties);

        //ICollection<TEntity> BuscarTodos(Expression<Func<TEntity, bool>> expression, int skip, int take, out int total, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params string[] includeProperties);

        //ICollection<TEntity> BuscarTodos(IEnumerable<Func<TEntity, bool>> expressions, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params string[] includeProperties);

        //ICollection<TEntity> BuscarTodos(IEnumerable<Func<TEntity, bool>> expressions, int skip, int take, out int total, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy, params string[] includeProperties);

        //ICollection<TEntity> BuscarTodos(IEnumerable<Func<TEntity, bool>> expressions, int skip, int take, out int total, params string[] includeProperties);
    }
}
