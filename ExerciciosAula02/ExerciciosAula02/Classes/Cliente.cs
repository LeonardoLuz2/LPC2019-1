using System.Collections.Generic;

namespace ExerciciosAula02.Classes
{
    public class Cliente
    {
        public Cliente(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            Cartoes = new List<CartaoCredito>();
        }

        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public List<CartaoCredito> Cartoes { get; private set; }
    }
}
