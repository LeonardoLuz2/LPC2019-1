using System;

namespace ExerciciosAula05.Models
{
    public class Carro
    {
        public Carro() { }

        public Carro(Guid id, string modelo, string cor, int portas, int ano, string combustivel)
        {
            Id = id;
            Modelo = modelo;
            Cor = cor;
            Portas = portas;
            Ano = ano;
            Combustivel = combustivel;
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int Portas { get; set; }
        public int Ano { get; set; }
        public string Combustivel { get; set; }

    }
}
