using AtividadeAvaliativaEF.Context;
using AtividadeAvaliativaEF.Interfaces;

namespace AtividadeAvaliativaEF.Class
{
    public class UnidadeDeTrabalho : IUnidadeDeTrabalho
    {
        private readonly TarefaContext _context;

        public UnidadeDeTrabalho(TarefaContext context)
        {
            _context = context;
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
