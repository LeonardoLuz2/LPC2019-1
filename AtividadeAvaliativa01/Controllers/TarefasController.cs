using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AtividadeAvaliativa01.Models;
using AtividadeAvaliativa01.Repository;

namespace AtividadeAvaliativa01.Controllers
{
    public class TarefasController : Controller
    {
        private readonly TarefaRepository _repository;

        public TarefasController(TarefaRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View(_repository.GetAll());
        }

        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarefa = _repository.GetById(id.Value);
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
            _repository.Add(tarefa);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarefa = _repository.GetById(id.Value);
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
            _repository.Update(tarefa);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarefa = _repository.GetById(id.Value);
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
            _repository.Remove(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
