using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Tarefas.Persistencia.Entidades
{
    public class Tarefa : EntidadeBase<int>
    {
        public new int Id { get => base.Id; set => base.Id = value; }
        public int UsuarioId { get; set; }
        public DateTime Registro { get; set; }
        public string Descricao { get; set; }
        public string EhImportante { get; set; }
        public int Prioridade { get; set; }
        public string EhConcluida { get; set; }
        public DateTime Conclusao { get; set; }
        
        public virtual Usuario Usuario { get; protected set; }
    }
}