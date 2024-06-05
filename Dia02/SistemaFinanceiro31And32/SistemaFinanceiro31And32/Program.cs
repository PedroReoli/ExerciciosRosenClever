using SistemaFinanceiro.Model;
using SistemaFinanceiro_Slide_31_32__.Model;
using System;

namespace SistemaFinanceiro31And32
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação do banco
            Banco banco = new Banco(1000, "Bancão");

            // Criação dos clientes
            Cliente cliente1 = new Cliente("Pedro Lucas", 21, "71921039000");
            Cliente cliente2 = new Cliente("Mylena", 25, "71921039000");

            // Criação da agência
            Agencia agencia = new Agencia(1000, "Agência Central", "123456780", "523727298-29", banco);

            // Criação das contas especiais e caixinhas
            ContaEspecial contaEspecial = new ContaEspecial(1003, 100m, cliente1, agencia);
            ContaCaixinha contaCaixinha = new ContaCaixinha(1002, 50m, cliente2, agencia);

            Console.WriteLine("\nTeste da conta especial (Pedro):");
            Console.WriteLine($"Saldo inicial de {contaEspecial.Cliente.Nome}: R${contaEspecial.Saldo}");
            contaEspecial.Deposito(20m);
            Console.WriteLine($"Saldo após adicionar R$20: R${contaEspecial.Saldo}");
            contaEspecial.Saque(10m);
            Console.WriteLine($"Saldo após retirar R$10: R${contaEspecial.Saldo}");

            Console.WriteLine("\nTeste da conta caixinha (Mylena):");
            Console.WriteLine($"Saldo inicial de {contaCaixinha.Cliente.Nome}: R${contaCaixinha.Saldo}");
            contaCaixinha.Deposito(5m);
            Console.WriteLine($"Saldo após adicionar R$5: R${contaCaixinha.Saldo}");
            contaCaixinha.Saque(10m);
            Console.WriteLine($"Saldo após retirar R$10: R${contaCaixinha.Saldo}");

            Console.WriteLine($"\nSaldo atual na conta especial de {contaEspecial.Cliente.Nome}: R${contaEspecial.Saldo}");
            contaEspecial.Deposito(50m);
            Console.WriteLine($"Saldo após adicionar R$50: R${contaEspecial.Saldo}");
            Console.WriteLine($"Tentativa de saque de R$200:");
            try
            {
                contaEspecial.Saque(200m);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Falha ao tentar sacar: {ex.Message}");
            }

            Console.WriteLine("\nTransferência de R$30 da conta de Pedro para a conta de Mylena");
            try
            {
                contaEspecial.Transferir(30m, contaEspecial, contaCaixinha);
                Console.WriteLine($"Saldo atual da conta de {contaEspecial.Cliente.Nome}: R${contaEspecial.Saldo}");
                Console.WriteLine($"Saldo atual da conta de {contaCaixinha.Cliente.Nome}: R${contaCaixinha.Saldo}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro durante a transferência: {ex.Message}");
            }
        }
    }
}
