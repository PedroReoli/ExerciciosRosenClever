using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro26To30.Model
{
    public class Agencia
    {
        
        private int _numero;
        private string _nome, _telefone;

        // Construtor da classe 'Agencia' que inicializa o campo '_numero' para poder maniplar 
        public Agencia(int numero)
        {
            _numero = numero;
        }
        // Propriedade somente leitura para obter o número da agência
        public int Numero { get => _numero; }

        // Propriedade para obter e definir o nome da agência
        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }
        // Propriedade para obter e definir o telefone da agência
        public string Telefone
        {
            get => _telefone;
            set
            {
                _telefone = value;
            }
        }
    }
}
