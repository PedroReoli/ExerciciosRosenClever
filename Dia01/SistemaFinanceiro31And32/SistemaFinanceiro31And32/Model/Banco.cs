using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    public class Banco
    {
        private int numero;
        private string nome;

        public Banco(int numero, string nome)
        {
            //Esse This.Numero referencia o Numero do private int
            //Esse segundo numero é o do Banco(int Numero)
            this.numero = numero;
            this.nome = nome;
        }
    }
}
