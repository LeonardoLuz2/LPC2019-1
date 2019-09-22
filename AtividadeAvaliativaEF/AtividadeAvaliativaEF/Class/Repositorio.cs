using AtividadeAvaliativaEF.Context;
using AtividadeAvaliativaEF.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace AtividadeAvaliativaEF.Class
{
    public abstract class Repositorio<T> : IRepositorio<T> where T : class
    {
        protected readonly TarefaContext _context;
        private readonly DbSet<T> _db;

        public Repositorio(TarefaContext context)
        {
            _context = context;
            _db = context.Set<T>();
        }

        public void Adicionar(T model)
        {
            _db.Add(model);
        }

        public void Atualizar(T model)
        {
            _db.Update(model);
        }

        public T BuscarPorId(Guid id)
        {
            return _db.Find(id);
        }

        public IEnumerable<T> BuscarTodos()
        {
            return _db;
        }

        public void Remover(Guid id)
        {
            _db.Remove(BuscarPorId(id));
        }
    }
}
