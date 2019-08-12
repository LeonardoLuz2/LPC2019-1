using ExerciciosAula02.Classes;
using System;

namespace ExerciciosAula02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cliente
            var cliente = new Cliente(1, "Leonardo");

            // Cartão de Crédito
            var cartaoCredito = new CartaoCredito(123, DateTime.Now.AddYears(5), cliente);
            Console.WriteLine($"Número Cartão: {cartaoCredito.Numero} - Data de Validade: {cartaoCredito.DataValidade.ToString("MM/yy")}");

            // Agências
            var agencia = new Agencia(998);
            Console.WriteLine($"Número da Agência 1: {agencia.Numero}");

            var agencia2 = new Agencia(999);
            Console.WriteLine($"Número da Agência 2: {agencia2.Numero}");

            // Contas 
            var contaBanco = new ContaBanco(10, 150);
            Console.WriteLine($"Número Conta: {contaBanco.Numero} - Saldo: {contaBanco.Saldo} - Limite: {contaBanco.Limite}");

            var contaBanco2 = new ContaBanco(15, 3000);
            Console.WriteLine($"Número Conta: {contaBanco2.Numero} - Saldo: {contaBanco2.Saldo} - Limite: {contaBanco2.Limite}");

            // Gerentes
            var gerente = new Gerente(1, "Leonardo", 12000);
            gerente.AumentoSalarial();
            Console.WriteLine($"Número Gerente: {gerente.Numero} - Nome: {gerente.Nome} - Salário: {gerente.Salario}");

            var gerente2 = new Gerente(1, "Leo", 16000);
            gerente2.AumentoSalarial(20);
            Console.WriteLine($"Número Gerente: {gerente2.Numero} - Nome: {gerente2.Nome} - Salário: {gerente2.Salario}");
        }
    }
}
