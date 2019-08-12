using System;

namespace ExerciciosAula02.Classes
{
    public class CartaoCredito
    {
        public CartaoCredito(int numero, DateTime dataValidade, Cliente cliente)
        {
            Numero = numero;
            DataValidade = dataValidade;
            Cliente = cliente;
        }

        public int Numero { get; private set; }
        public DateTime DataValidade { get; private set; }
        public Cliente Cliente { get; private set; }
    }
}
