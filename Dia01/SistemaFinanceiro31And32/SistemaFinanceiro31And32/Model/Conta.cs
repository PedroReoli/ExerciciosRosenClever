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
        ////////////////////////////////
        //Slide 31
        ////////////////////////////////
        public Conta(long numero, decimal saldo, Cliente cliente, Agencia agencia) 
        {
            _numero = numero;
            if (saldo >= 11)
            {
                _saldo = saldo;
            }
            else
            {
                Console.WriteLine("Erro: Saldo Inferior R$10.");
                
                throw new ArgumentException("Erro: Saldo Inferior R$10.");
            }
            _cliente = cliente; 

            _agencia = agencia;
        }

        public long Numero { get => _numero; private set => _numero = value; }
        public decimal Saldo { get => _saldo; set => _saldo = value; }
        public Cliente Cliente { get => _cliente; set => _cliente = value; }
        public Agencia Agencia { get => _agencia; set => _agencia = value; }
        public void Deposito(decimal valor) => _saldo += valor;

        public decimal Saque(decimal valor)
        {
            if(_saldo - valor >= 0)
            {
                // Taxa 
                _saldo -= (valor + 0.10m); 
                return _saldo;
            }
            else
            {
                throw new ArgumentException("Valor do saque ultrapassa o saldo");
            }
            
        }


    }
}
