using ExerciciosAula03.Classes.Pedido;
using System;
using System.Collections.Generic;

namespace ExerciciosAula03.Classes
{
    public class Fornecedor
    {
        public Fornecedor(int codigo, string nome, string endereco, string cidade, string estado, string cEP, string telefone, string cNPJ)
        {
            Codigo = codigo;
            Nome = nome;
            Endereco = endereco;
            Cidade = cidade;
            Estado = estado;
            CEP = cEP;
            Telefone = telefone;
            CNPJ = cNPJ;
        }

        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string CEP { get; private set; }
        public string Telefone { get; private set; }
        public string CNPJ { get; private set; }

        public List<PedidoFornecedor> Pedidos { get; private set; }

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
