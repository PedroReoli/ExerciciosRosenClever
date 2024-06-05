using SistemaFinanceiro26To30.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    internal class ComparaSaldo
    {
        public ComparaSaldo()
        {
        }
        ////////////////////////////////
        //Slide 26 - Compara o saldo  de 2 contas e retorna a que tem o maior valor
        ////////////////////////////////
        public long Comparador(Conta conta1, Conta conta2)
        {
            decimal saldo1 = conta1.Saldo;
            decimal saldo2 = conta2.Saldo;

            decimal maiorsaldo = Math.Max(saldo1, saldo2);

            if (maiorsaldo == saldo1)
            {
                return conta1.Numero;
            }
            else
            {
                return conta2.Numero;
            }

        }
    }
}
