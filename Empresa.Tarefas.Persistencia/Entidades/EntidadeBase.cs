using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Tarefas.Persistencia.Entidades
{
    public class EntidadeBase<TChave> where TChave : struct
    {
        public EntidadeBase() { }

        private TChave id;

        public TChave Id { get => id; protected set => id = value; }

        public void SetId(TChave value)
        {
            Id = value;
        }
    }
}
