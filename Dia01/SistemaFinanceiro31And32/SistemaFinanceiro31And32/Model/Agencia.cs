
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    public class Agencia
    {
        private int _numero;
        private string _nome, _telefone, _cep;
        //Declaração do campo do tipo da Classe "Banco"
        private Banco _banco;

        // Criou-se um construtor com valores ja passados como parametros pré-definidos
        public Agencia(int numero,string nome, string telefone, string cep, Banco banco)
        {
            _numero = numero;
            _nome = nome;
            _telefone = telefone;
            _cep = cep;
            _banco = banco;
        }
        public int Numero { get => _numero; }
        public string Nome{ get => _nome; set => _nome = value; }
        public string CEP { get => _cep; set => _cep = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public Banco Banco { get => _banco; set => _banco = value; }
    }
}
