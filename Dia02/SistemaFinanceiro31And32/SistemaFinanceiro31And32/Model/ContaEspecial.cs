using SistemaFinanceiro.Model;
using System;

namespace SistemaFinanceiro_Slide_31_32__.Model
{
    internal class ContaEspecial : Conta
    {
        protected double _limite;

        // Construtor que inicializa a conta especial com os valores fornecidos
        public ContaEspecial(long numero, decimal saldo, Cliente cliente, Agencia agencia)
            : base(numero, saldo, cliente, agencia)
        {
            // Inicialização específica para a conta especial
        }

        // Propriedade para acessar e modificar o limite da conta especial
        public double Limite
        {
            get => _limite;
            set => _limite = value;
        }

        // Método para realizar saque da conta
        public override decimal Saque(decimal valor)
        {
            // Verifica se o valor do saque não ultrapassa o saldo disponível
            if (Saldo - valor >= 0)
            {
                // Realiza o saque e retorna o saldo atualizado
                Saldo -= valor;
                return Saldo;
            }
            else
            {
                // Lança exceção se o valor do saque for maior que o saldo disponível
                throw new ArgumentException("O valor solicitado para saque excede o saldo disponível.");
            }
        }

        // Método para transferir valor entre contas
        public override void Transferir(decimal valor, Conta contaPerde, Conta contaRecebe)
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
                // Lança exceção se o saldo for insuficiente
                throw new ArgumentException("O valor para transferência excede o saldo disponível na conta de origem.");
            }

            // Exibe o saldo atualizado das contas envolvidas na transferência
            Console.WriteLine($"Saldo atual da conta do cliente {contaPerde.Cliente.Nome} é R${contaPerde.Saldo}");
            Console.WriteLine($"Saldo atual da conta do cliente {contaRecebe.Cliente.Nome} é R${contaRecebe.Saldo}");
        }
    }
}
