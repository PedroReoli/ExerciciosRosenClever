using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    // Slide 26: Definição da Classe Cliente
    public class Cliente
    {
        private string _nome;
        private int _idade;
        private string _cpf;
        private string _email;
        private int _anoNascimento;

        // Construtor da classe Cliente que valida idade e CPF
        public Cliente(string nome, int idade, string cpf)
        {
            _nome = nome;

            // Valida se o cliente tem idade mínima de 18 anos
            if (idade >= 18)
            {
                _idade = idade;
            }
            else
            {
                Console.WriteLine("É necessário que o cliente tenha pelo menos 18 anos.");
                throw new ArgumentException("É necessário que o cliente tenha pelo menos 18 anos.");
            }

            // Valida se o CPF tem exatamente 11 dígitos
            if (cpf.Length == 11)
            {
                _cpf = cpf;
            }
            else
            {
                Console.WriteLine("Por favor, informe um CPF válido (11 dígitos, apenas números).");
                throw new ArgumentException("Por favor, informe um CPF válido (11 dígitos, apenas números).");
            }
        }

        public string Nome { get => _nome; set => _nome = value; }
        public int Idade { get => _idade; set => _idade = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Email { get => _email; set => _email = value; }
        public int AnoNascimento { get => _anoNascimento; set => _anoNascimento = value; }

    }
}
