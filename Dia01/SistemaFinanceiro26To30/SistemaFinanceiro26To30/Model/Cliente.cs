using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro26To30.Model
{
    ////////////////////////////////
    // Slide 26 
    ////////////////////////////////
    internal class Cliente
    {
        private string _nome;
        private int _idade;
        private string _cpf;
        private Conta _conta;

        // Construtor da classe 'Cliente' que inicializa os campos
        public Cliente(string nome, int idade, string cpf, Conta conta)
        {
            _nome = nome;
            _idade = idade;
            _cpf = cpf;
            _conta = conta;
        }

      
        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public int Idade
        {
            get => _idade;
            set
            {
                // Verifica se a idade é 18 ou mais antes de definir
                if (value >= 18)
                {
                    _idade = value;
                }
                else
                {
                    Console.WriteLine("Um cliente precisa ter 18 anos ou mais");
                }
            }
        }

        // Propriedade para obter e definir a conta do cliente
        // Vinculando a classe Conta à classe Cliente
        public Conta Conta
        {
            get => _conta;
            set => _conta = value;
        }

        // Propriedade para obter e definir o CPF do cliente
        public string Cpf
        {
            get => _cpf;
            set
            {
                // Verificador do CPF 
                if (value.Length == 11)
                {
                    _cpf = value;
                }
                else
                {
                    Console.WriteLine("Entre com um CPF válido ");
                }
            }
        }
    }
}

