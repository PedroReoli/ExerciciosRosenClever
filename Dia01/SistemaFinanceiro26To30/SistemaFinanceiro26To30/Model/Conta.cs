using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro26To30.Model
{
    public class Conta
    {
       
        private long _numero;
        private decimal _saldo;

        // Declarei um campo do Tipo da classe "Agencia" 
        public Agencia agencia;

        // O saldo inicial deve ser maior que 10 para criar uma conta
        ////////////////////////////////
        //Slide 30 - Criar objetos apenas com saldo acima de 10
        ////////////////////////////////
        public Conta(long numero, decimal saldo)
        {
            _numero = numero;
            if (saldo > 10)
            {
                _saldo = saldo;
            }
            else
            {
         
                Console.WriteLine("O saldo deve ser superior a R$10 .");
                throw new ArgumentException("O saldo deve ser superior a R$10 ");
            }
        }

        // Propriedade somente leitura para obter o número da conta
        // A definição da propriedade é privada
        public long Numero
        {
            get => _numero;
            private set { _numero = value; }
        }

        // Propriedade somente leitura para obter o saldo da conta
        public decimal Saldo { get => _saldo; }
        
        // Método para realizar depósitos na conta
        // Aumenta o saldo pelo valor do depósito
        public void Deposito(decimal valor) { _saldo += valor; }
      
        // Método para realizar saques na conta
        // Reduz o saldo pelo valor do saque se houver saldo suficiente
        public decimal Saque(decimal valor)
        {
            if (_saldo - valor >= 0)
            {
                _saldo -= valor;
                return _saldo;
            }
            else
            {
                // Lança uma exceção se o valor do saque for maior que o saldo disponível
                throw new ArgumentException("Valor do saque é maior que o valor de saqueSaldo");
            }
        }
    }
}
