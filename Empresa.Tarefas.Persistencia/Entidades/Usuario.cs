using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Tarefas.Persistencia.Entidades
{
    public class Usuario : EntidadeBase<int>
    {
        public Usuario ()
        {
            ListaTarefas = new HashSet<Tarefa>();
        }

        public new int Id { get => base.Id; set => base.Id = value; }
        public string Nome { get; set; }

        public virtual ICollection<Tarefa> ListaTarefas { get; private set; }
    }
}
