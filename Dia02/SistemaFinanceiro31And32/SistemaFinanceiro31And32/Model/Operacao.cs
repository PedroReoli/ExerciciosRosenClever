using SistemaFinanceiro_Slide_31_32__.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    internal class Operacao
    {
        public Operacao()
        {
            // Construtor padrão sem ações específicas
        }
        //////////////////////////////
        // Slide 26 
        //////////////////////////////
        public long CompararMaiorSaldo(Conta conta1, Conta conta2)
        {
            // Obtém o saldo de ambas as contas
            decimal saldo1 = conta1.Saldo;
            decimal saldo2 = conta2.Saldo;

            // Calcula o maior saldo entre as duas contas
            decimal maiorSaldo = Math.Max(saldo1, saldo2);

            // Retorna o número da conta com o maior saldo
            return maiorSaldo == saldo1 ? conta1.Numero : conta2.Numero;
        }

        // Método para transferir valor entre duas contas
        public void Transferir(decimal valor, Conta contaPerde, Conta contaRecebe)
        {
            // Verifica se a conta de origem tem saldo suficiente para a transferência
            if (contaPerde.Saldo - valor >= 0)
            {
                // Realiza a transferência
                contaPerde.Saldo -= valor;
                contaRecebe.Saldo += valor;
            }
            else
            {
                // Lança uma exceção se o saldo for insuficiente
                throw new ArgumentException("Valor da transferência ultrapassa o saldo disponível");
            }

            // Exibe o saldo atualizado das contas envolvidas
            Console.WriteLine($"O valor atual da conta de {contaPerde.Cliente.Nome} é {contaPerde.Saldo}");
            Console.WriteLine($"O valor atual da conta de {contaRecebe.Cliente.Nome} é {contaRecebe.Saldo}");
        }

        // Método para criar um novo cliente
        public Cliente CriarCliente()
        {
            Console.WriteLine("Informe o nome do Cliente:");
            string nomeCliente = Console.ReadLine();

            Console.WriteLine("Informe a idade:");
            int idadeCliente = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o CPF:");
            string cpfCliente = Console.ReadLine();

            // Cria um novo cliente com as informações fornecidas
            var cliente = new Cliente(nomeCliente, idadeCliente, cpfCliente);

            return cliente;
        }

        // Método para criar um novo banco
        public Banco CriarBanco()
        {
            Console.WriteLine("Informe o número do Banco:");
            int numeroBanco = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome do Banco:");
            string nomeBanco = Console.ReadLine();

            // Cria um novo banco com as informações fornecidas
            Banco banco = new Banco(numeroBanco, nomeBanco);

            return banco;
        }

        // Método para criar uma nova agência
        public Agencia CriarAgencia(Banco banco)
        {
            Console.WriteLine("Informe o número da Agência:");
            int numeroAgencia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome da Agência:");
            string nomeAgencia = Console.ReadLine();

            Console.WriteLine("Informe o telefone da Agência:");
            string telefoneAgencia = Console.ReadLine();

            Console.WriteLine("Informe o CEP da Agência:");
            string cepAgencia = Console.ReadLine();

            // Cria uma nova agência com as informações fornecidas
            var agencia = new Agencia(numeroAgencia, nomeAgencia, telefoneAgencia, cepAgencia, banco);

            return agencia;
        }
    }
}
