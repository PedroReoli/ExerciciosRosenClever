using SistemaFinanceiro.Model;
using System;

namespace SistemaFinanceiro_Slide_31_32__.Model
{
    internal class ContaCaixinha : Conta
    {
        // Construtor da conta especial que chama o construtor da classe base
        public ContaCaixinha(long numero, decimal saldo, Cliente cliente, Agencia agencia) : base(numero, saldo, cliente, agencia)
        {
        }

        // Sobrescreve o método de depósito para incluir uma taxa de R$1,00
        public override void Deposito(decimal valor)
        {
            // Verifica se o valor do depósito é pelo menos R$1,00
            if (valor >= 1)
            {
                Saldo += valor + 1; // Adiciona o valor do depósito mais uma taxa de R$1,00
            }
            else
            {
                throw new ArgumentException("Depósitos inferiores a R$1,00 não são permitidos.");
            }
        }

        // Sobrescreve o método de saque para incluir uma taxa de R$5,00
        public override decimal Saque(decimal valor)
        {
            // Verifica se o saldo menos o valor do saque mais a taxa de R$5,00 é suficiente
            if (Saldo - (valor + 5) >= 0)
            {
                Saldo -= (valor + 5); // Deduz o valor do saque mais a taxa de R$5,00
                return Saldo;
            }
            else
            {
                throw new ArgumentException("O valor solicitado para saque excede o saldo disponível.");
            }
        }
    }
}
