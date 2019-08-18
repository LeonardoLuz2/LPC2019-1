using System;
using System.Collections.Generic;

namespace ExerciciosAula03.Classes.Pedido
{
    public abstract class Pedido
    {
        protected Pedido(int codigo, DateTime dataPedido, int quantidade, decimal valor)
        {
            Codigo = codigo;
            DataPedido = dataPedido;
            Quantidade = quantidade;
            Valor = valor;
            Livros = new List<Livro>();
        }

        public int Codigo { get; private set; }
        public DateTime DataPedido { get; private set; }
        public List<Livro> Livros { get; private set; }
        public int Quantidade { get; private set; }
        public decimal Valor { get; private set; }

        protected void AdicionarLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        protected decimal CalcValor()
        {
            return Quantidade * Valor;
        }

        public abstract void Pagamento();
        public abstract void RecuperarPed();
    }
}
