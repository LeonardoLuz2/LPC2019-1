using ExerciciosAula05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosAula05.Repository
{
    public class CarroRepository
    {
        private List<Carro> carros;

        public CarroRepository()
        {
            carros = new List<Carro>();
        }

        public List<Carro> GetAll()
        {
            return carros;
        }

        public Carro GetById(Guid id)
        {
            return carros.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Carro carro)
        {
            carros.Add(carro);
        }

        public void Remove(Guid id)
        {
            carros.Remove(GetById(id));
        }

        public void Update(Carro carro)
        {
            int index = carros.FindIndex(x => x.Id == carro.Id);
            carros[index] = carro;
        }
    }
}
