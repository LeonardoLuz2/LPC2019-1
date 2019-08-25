namespace ExerciciosAula03.Classes.Gerente
{
    public interface IGerenteFornecedor : IGerente
    {
        void EnviarPedFornecedor();
        void EfetuarPagFornecedor();
        void ImprimirRelFornecedores();
        void ImprimirRelPedFornecedores();
    }
}
