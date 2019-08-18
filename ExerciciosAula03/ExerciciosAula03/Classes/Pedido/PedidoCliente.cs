using System;

namespace ExerciciosAula03.Classes.Pedido
{
    public class PedidoCliente : Pedido
    {
        public PedidoCliente(int codigo, DateTime dataPedido, int quantidade, decimal valor, int codCliente, DateTime dataRemessa)
            : base(codigo, dataPedido, quantidade, valor)
        {
            CodCliente = codCliente;
            DataRemessa = dataRemessa;
        }

        public int CodCliente { get; private set; }
        public DateTime DataRemessa { get; private set; }
        public Cliente Cliente { get; private set; }

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
