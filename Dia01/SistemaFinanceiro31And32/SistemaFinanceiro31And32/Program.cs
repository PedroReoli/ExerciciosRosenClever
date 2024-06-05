using SistemaFinanceiro.Model;
using System;

namespace SistemaFinanceiro31And32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var operacao = new Operacao();

            Console.WriteLine("Vamos começar criando um Banco:");
            Banco banco = operacao.CriarNovoBanco();

            Console.WriteLine("Agora, vamos criar uma Agência para este banco:");
            Agencia agencia = operacao.CriarNovaAgencia(banco);

            // Slide 31 - Criar Conta
            Console.WriteLine("Digite o número da conta:");
            long numeroConta = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Digite o saldo inicial da conta:");
            decimal saldoConta = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Agora, crie um Cliente para associar à conta:");
            Cliente cliente = operacao.CriarNovoCliente();

            var conta = new Conta(numeroConta, saldoConta, cliente, agencia);

            Console.WriteLine("Conta criada com sucesso!");
            Console.WriteLine($"Número da Conta: {conta.Numero}");
            Console.WriteLine($"Saldo Atual: {conta.Saldo}");
            Console.WriteLine($"Titular: {conta.Cliente.Nome}");

            Console.WriteLine("//////////////////////////////////////////////////////////////////");

            // Slide 31 - Criar Conta2
            Console.WriteLine("Vamos criar a segunda conta:");

            Console.WriteLine("Digite o número da conta:");
            long numeroConta2 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Digite o saldo inicial da conta:");
            decimal saldoConta2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Agora, crie um Cliente para associar à segunda conta:");
            Cliente cliente2 = operacao.CriarNovoCliente();

            var conta2 = new Conta(numeroConta2, saldoConta2, cliente2, agencia);

            Console.WriteLine("Segunda conta criada com sucesso!");
            Console.WriteLine($"Número da Conta: {conta2.Numero}");
            Console.WriteLine($"Saldo Atual: {conta2.Saldo}");
            Console.WriteLine($"Titular: {conta2.Cliente.Nome}");

            Console.WriteLine("//////////////////////////////////////////////////////////////////");

            Console.WriteLine("Vamos testar as transferências entre contas");

            Console.WriteLine($"Saldo atual da conta de {conta.Cliente.Nome}: {conta.Saldo}");
            Console.WriteLine($"Saldo atual da conta de {conta2.Cliente.Nome}: {conta2.Saldo}");

            Console.WriteLine("Digite o valor para transferir:");
            decimal valorTransferencia = Convert.ToDecimal(Console.ReadLine());

            operacao.TransferirValor(valorTransferencia, conta, conta2);

            Console.WriteLine($"Saldo atualizado da conta de {conta.Cliente.Nome}: {conta.Saldo}");
            Console.WriteLine($"Saldo atualizado da conta de {conta2.Cliente.Nome}: {conta2.Saldo}");
        }
    }
}
