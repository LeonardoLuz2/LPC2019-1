using System;

namespace ExerciciosAula03.Classes.Pedido
{
    public class PedidoFornecedor : Pedido
    {
        public PedidoFornecedor(int codigo, DateTime dataPedido, int quantidade, decimal valor, int codFornecedor, DateTime dataRecebimento)
            : base(codigo, dataPedido, quantidade, valor)
        {
            CodFornecedor = codFornecedor;
            DataRecebimento = dataRecebimento;
        }

        public int CodFornecedor { get; private set; }
        public DateTime DataRecebimento { get; private set; }
        public Fornecedor Fornecedor { get; private set; }

        public override void Pagamento()
        {
            throw new NotImplementedException();
        }

        public override void RecuperarPed()
        {
            throw new NotImplementedException();
        }
    }
}
