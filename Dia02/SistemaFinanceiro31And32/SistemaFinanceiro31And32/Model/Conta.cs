using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    public class Conta
    {
        private long _numero;
        private decimal _saldo;
        public Cliente _cliente;
        public Agencia _agencia;

        // Slide 31 - A conta só pode ser criada se houver um cliente titular
        public Conta(long numero, decimal saldo, Cliente cliente, Agencia agencia)
        {
            // Verifica se o número da conta é maior que 999
            if (numero > 999)
            {
                _numero = numero;
            }
            else
            {
                Console.WriteLine("O número da conta deve ser superior a 999.");

                throw new ArgumentException("O número da conta deve ser superior a 999.");
            }

            // Verifica se o saldo inicial é pelo menos R$ 11
            if (saldo >= 11)
            {
                _saldo = saldo;
            }
            else
            {
                Console.WriteLine("O saldo inicial deve ser superior a R$10 para criar uma conta.");

                throw new ArgumentException("O saldo inicial deve ser superior a R$10 para criar uma conta.");
            }
            _cliente = cliente; // O cliente é obrigatório para a conta

            _agencia = agencia;
        }

        public long Numero
        {
            get => _numero;
            private set
            {
                _numero = value;
            }
        }

        public decimal Saldo
        {
            get => _saldo;
            set
            {
                _saldo = value;
            }
        }

        public Cliente Cliente
        {
            get => _cliente;
            set => _cliente = value;
        }

        public Agencia Agencia
        {
            get => _agencia;
            set => _agencia = value;
        }

        // Método para depositar valor na conta
        public virtual void Deposito(decimal valor)
        {
            _saldo += valor;
        }

        // Método para sacar valor da conta
        public virtual decimal Saque(decimal valor)
        {
            if (Saldo - valor >= 0)
            {
                Saldo -= (valor + 0.10m); // Slide 31: Banco agora cobra R$0,10 pelo saque
                return Saldo;
            }
            else
            {
                throw new ArgumentException("O valor solicitado para saque excede o saldo disponível.");
            }
        }

        // Método para transferir valor entre contas
        public virtual void Transferir(decimal valor, Conta contaPerde, Conta contaRecebe)
        {
            if (contaPerde.Saldo - valor >= 0)
            {
                contaPerde.Saldo -= valor;
                contaRecebe.Saldo += valor;
            }
            else
            {
                throw new ArgumentException("O valor da transferência excede o saldo disponível na conta de origem.");
            }

            Console.WriteLine($"O saldo atual da conta de {contaPerde.Cliente.Nome} é {contaPerde.Saldo}");
            Console.WriteLine($"O saldo atual da conta de {contaRecebe.Cliente.Nome} é {contaRecebe.Saldo}");
        }
    }
}
