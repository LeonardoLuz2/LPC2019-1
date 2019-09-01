using System;

namespace ExerciciosAula05.Models
{
    public class Carro
    {
        public Carro() { }

        public Carro(Guid id, string modelo, int ano)
        {
            Id = id;
            Modelo = modelo;
            Ano = ano;
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Modelo { get; set; }
        public int Ano { get; set; }

    }
}
