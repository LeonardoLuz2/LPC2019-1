using AtividadeAvaliativa01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeAvaliativa01.Repository
{
    public class TarefaRepository
    {
        private List<Tarefa> tarefas;

        public TarefaRepository()
        {
            tarefas = new List<Tarefa>();
        }

        public List<Tarefa> GetAll()
        {
            return tarefas;
        }

        public Tarefa GetById(Guid id)
        {
            return tarefas.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Tarefa tarefa)
        {
            tarefas.Add(tarefa);
        }

        public void Remove(Guid id)
        {
            tarefas.Remove(GetById(id));
        }

        public void Update(Tarefa tarefa)
        {
            int index = tarefas.FindIndex(x => x.Id == tarefa.Id);
            tarefas[index] = tarefa;
        }
    }
}
