using Empresa.Tarefas.Persistencia.Contexto;
using Empresa.Tarefas.Persistencia.Entidades;
using Empresa.Tarefas.Persistencia.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Empresa.Tarefas.Web.Controllers.Servicos
{
    public class TarefaController : ApiController
    {
        private IRepositorio<Tarefa, int> repositorio = new TarefaRepositorio(new TarefasDBContexto());

        public IEnumerable<Tarefa> GetAllTarefas()
        {
            return repositorio.BuscaTodos();
        }

        public Tarefa GetTarefa(int id)
        {
            Tarefa Tarefa = repositorio.Busca(id);
            if (Tarefa == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return Tarefa;
        }

        public HttpResponseMessage PostTarefa(Tarefa Tarefa)
        {
            Tarefa = repositorio.Inclui(Tarefa);
            var response = Request.CreateResponse<Tarefa>(HttpStatusCode.Created, Tarefa);
            string uri = Url.Link("DefaultApi", new { id = Tarefa.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        public void PutTarefa(int id, Tarefa Tarefa)
        {
            Tarefa.Id = id;
            repositorio.Altera(Tarefa);
        }

        public void DeleteTarefa(int id)
        {
            Tarefa Tarefa = repositorio.Busca(id);
            if (Tarefa == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            repositorio.Apaga(Tarefa);
        }
    }
}