using Empresa.Tarefas.Persistencia.Entidades;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Tarefas.Persistencia.Repositorio
{
    public class UsuarioRepositorio : Repositorio<Usuario, int>, IRepositorio<Usuario, int>
    {
        public UsuarioRepositorio(DbContext context) : base(context)
        {

        }
    }
}
