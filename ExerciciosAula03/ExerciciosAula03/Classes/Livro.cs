using System;

namespace ExerciciosAula03.Classes
{
    public class Livro
    {
        public Livro(int codigo, string titulo, string autor, int iSBN, decimal preco, int codFornecedor)
        {
            Codigo = codigo;
            Titulo = titulo;
            Autor = autor;
            ISBN = iSBN;
            Preco = preco;
            CodFornecedor = codFornecedor;
        }

        public int Codigo { get; private set; }
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public int ISBN { get; private set; }
        public decimal Preco { get; private set; }
        public int CodFornecedor { get; private set; }

        public void Inserir()
        {
            throw new NotImplementedException();
        }

        public void Excluir()
        {
            throw new NotImplementedException();
        }

        public void Alterar()
        {
            throw new NotImplementedException();
        }

        public void Consultar()
        {
            throw new NotImplementedException();
        }
    }
}
