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
            // Construtor padrão
        }

        // Slide 26 - Compara o saldo de duas contas e retorna o número da conta com maior saldo
        public long ObterContaComMaiorSaldo(Conta conta1, Conta conta2)
        {
            decimal saldoConta1 = conta1.Saldo;
            decimal saldoConta2 = conta2.Saldo;

            decimal maiorSaldo = Math.Max(saldoConta1, saldoConta2);

            return maiorSaldo == saldoConta1 ? conta1.Numero : conta2.Numero;
        }

        public void TransferirValor(decimal valor, Conta contaDeOrigem, Conta contaDeDestino)
        {
            if (contaDeOrigem.Saldo >= valor)
            {
                contaDeOrigem.Saldo -= valor;
                contaDeDestino.Saldo += valor;
            }
            else
            {
                throw new ArgumentException("O valor da transferência excede o saldo disponível.");
            }

            Console.WriteLine($"Saldo atual da conta de {contaDeOrigem.Cliente.Nome}: {contaDeOrigem.Saldo}");
            Console.WriteLine($"Saldo atual da conta de {contaDeDestino.Cliente.Nome}: {contaDeDestino.Saldo}");
        }

        public Cliente CriarNovoCliente()
        {
            Console.WriteLine("Informe o nome do cliente:");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe a idade:");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o CPF:");
            string cpf = Console.ReadLine();

            return new Cliente(nome, idade, cpf);
        }

        public Banco CriarNovoBanco()
        {
            Console.WriteLine("Informe o número do banco:");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome do banco:");
            string nome = Console.ReadLine();

            return new Banco(numero, nome);
        }

        public Agencia CriarNovaAgencia(Banco banco)
        {
            Console.WriteLine("Informe o número da agência:");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome da agência:");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o telefone da agência:");
            string telefone = Console.ReadLine();

            Console.WriteLine("Informe o CEP da agência:");
            string cep = Console.ReadLine();

            return new Agencia(numero, nome, telefone, cep, banco);
        }
    }
}
