using System;
using System.Collections.Generic;

namespace AtividadeAvaliativaEF.Interfaces
{
    public interface IRepositorio<T> where T: class
    {
        IEnumerable<T> BuscarTodos();
        T BuscarPorId(Guid id);
        void Adicionar(T model);
        void Atualizar(T model);
        void Remover(Guid id);
    }
}
