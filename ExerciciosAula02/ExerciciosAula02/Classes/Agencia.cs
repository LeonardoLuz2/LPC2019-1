namespace ExerciciosAula02.Classes
{
    public class Agencia
    {
        public Agencia(int numero)
        {
            Numero = numero;
        }

        public int Numero { get; private set; }

        public void AlteraNumeroAgencia(int novoNumero)
        {
            Numero = novoNumero;
        }
    }
}
