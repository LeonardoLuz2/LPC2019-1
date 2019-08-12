namespace ExerciciosAula02.Classes
{
    public class ContaBanco
    {
        public ContaBanco(int numero, decimal saldo)
        {
            Numero = numero;
            Saldo = saldo;
            Limite = 100;
        }
        public int Numero { get; private set; }
        public decimal Saldo { get; private set; }
        public decimal Limite { get; private set; }

        public void Deposito(int valor)
        {
            Saldo += valor;
        }

        public void Saque(int valor)
        {
            if (Saldo >= valor)
                Saldo -= valor;
        }

        public decimal ConsultaSaldo()
        {
            return Saldo;
        }
    }
}
