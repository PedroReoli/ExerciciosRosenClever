using System;
using SistemaFinanceiro.Model;
using SistemaFinanceiro26To30.Model;

namespace SistemaFinanceiro26To30
{
    class Program
    {
        static void Main(string[] args)
        {
            var comparaSaldo = new ComparaSaldo();

            var conta1 = new Conta(123, 1000m);
            var conta2 = new Conta(654321, 2341.42m);
            var cliente1 = new Cliente("Pedro Lucas Reis de Oliveira Sousa", 21, "12345678901", conta1);

            Console.WriteLine($"O saldo da conta {conta1.Numero} é {conta1.Saldo}");
            Console.WriteLine($"O saldo da conta {conta2.Numero} é {conta2.Saldo}");

            //Slide 26 - Numero da Conta com Maior Saldo
            var maiorSaldo = comparaSaldo.Comparador(conta1, conta2);

            Console.WriteLine($"O conta com maior saldo é {maiorSaldo}");

            //Slide 26 - Saldo Total Geral 
            var SaldoTotal = (conta1.Saldo + conta2.Saldo);

            Console.WriteLine($"Saldo Total Geral : {SaldoTotal}");

            //Slide 26 - Vinculando Conta ao Cliente
            Console.WriteLine($"A conta do {cliente1.Nome} é {cliente1.Conta.Numero}");

            //Slide 30 - Criar uma Conta com mais de R$10
            Console.WriteLine("Digite o numero da conta:");
            long numeroConta = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Digite o saldo da conta:");
            decimal numeroSaldo = Convert.ToDecimal(Console.ReadLine());

            var conta3 = new Conta(numeroConta, numeroSaldo);

            Console.WriteLine($"Conta nova Criada, Numero: {conta3.Numero} Saldo: {conta3.Saldo}");
        }
    }
}
