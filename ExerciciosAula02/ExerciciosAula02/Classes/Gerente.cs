namespace ExerciciosAula02.Classes
{
    class Gerente
    {
        public Gerente(int numero, string nome, decimal salario)
        {
            Numero = numero;
            Nome = nome;
            Salario = salario;
        }

        public int Numero { get; private set; }
        public string Nome { get; private set; }
        public decimal Salario { get; private set; }

        public void AumentoSalarial()
        {
            this.Salario *= 1.10m;
        }

        public void AumentoSalarial(decimal porcentagem)
        {
            this.Salario *= 1 + (porcentagem / 100);
        }
    }
}
