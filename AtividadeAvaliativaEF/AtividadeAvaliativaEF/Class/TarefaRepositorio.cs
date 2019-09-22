using AtividadeAvaliativaEF.Context;
using AtividadeAvaliativaEF.Interfaces;
using AtividadeAvaliativaEF.Models;

namespace AtividadeAvaliativaEF.Class
{
    public class TarefaRepositorio : Repositorio<Tarefa>, ITarefaRepositorio
    {
        public TarefaRepositorio(TarefaContext context) : base(context)
        {

        }
    }
}
