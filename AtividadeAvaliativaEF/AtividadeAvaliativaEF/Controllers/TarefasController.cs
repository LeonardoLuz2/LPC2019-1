using System;
using AtividadeAvaliativaEF.Class;
using AtividadeAvaliativaEF.Interfaces;
using AtividadeAvaliativaEF.Models;
using Microsoft.AspNetCore.Mvc;

namespace AtividadeAvaliativaEF.Controllers
{
    public class TarefasController : Controller
    {
        private readonly ITarefaRepositorio _repositorio;
        private readonly IUnidadeDeTrabalho _unidadeDeTrabalho;

        public TarefasController(ITarefaRepositorio repositorio, IUnidadeDeTrabalho unidadeDeTrabalho)
        {
            _repositorio = repositorio;
            _unidadeDeTrabalho = unidadeDeTrabalho;
        }

        public IActionResult Index()
        {
            return View(_repositorio.BuscarTodos());
        }

        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarefa = _repositorio.BuscarPorId(id.Value);
            if (tarefa == null)
            {
                return NotFound();
            }

            return View(tarefa);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] Tarefa tarefa)
        {
            _repositorio.Adicionar(tarefa);
            _unidadeDeTrabalho.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarefa = _repositorio.BuscarPorId(id.Value);
            if (tarefa == null)
            {
                return NotFound();
            }
            return View(tarefa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([FromForm]Tarefa tarefa)
        {
            _repositorio.Atualizar(tarefa);
            _unidadeDeTrabalho.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarefa = _repositorio.BuscarPorId(id.Value);
            if (tarefa == null)
            {
                return NotFound();
            }

            return View(tarefa);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _repositorio.Remover(id);
            _unidadeDeTrabalho.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}