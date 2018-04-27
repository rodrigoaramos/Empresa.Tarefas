using Empresa.Tarefas.Persistencia.Entidades;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Http;
using System.Net.Http;

namespace Empresa.Tarefas.Persistencia.Repositorio
{
    public class TarefaRepositorio : Repositorio<Tarefa, int>, IRepositorio<Tarefa, int>
    {
        public TarefaRepositorio(DbContext context) : base(context)
        {
        }
    }
}
