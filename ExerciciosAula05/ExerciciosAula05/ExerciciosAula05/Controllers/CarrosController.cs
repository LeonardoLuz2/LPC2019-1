using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExerciciosAula05.Models;
using ExerciciosAula05.Repository;

namespace ExerciciosAula05.Controllers
{
    public class CarrosController : Controller
    {
        private readonly CarroRepository _repository;

        public CarrosController(CarroRepository repository)
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

            var carro = _repository.GetById(id.Value);
            if (carro == null)
            {
                return NotFound();
            }

            return View(carro);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Modelo,Ano")] Carro carro)
        {
            _repository.Add(carro);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carro = _repository.GetById(id.Value);
            if (carro == null)
            {
                return NotFound();
            }
            return View(carro);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("Id,Modelo,Ano")] Carro carro)
        {
            _repository.Update(carro);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carro = _repository.GetById(id.Value);
            if (carro == null)
            {
                return NotFound();
            }

            return View(carro);
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
