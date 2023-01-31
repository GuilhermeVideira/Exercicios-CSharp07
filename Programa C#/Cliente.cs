using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analise_e_projeto_de_sistemass
{
    internal class Cliente:Pessoa
    {
        public int codCliente { get; set; }
        public double saldo { get; set; }
        public double credito { get; set; }

        public Boolean sacar(double valorSaque)
        {
            bool result;
            if (this.saldo >= valorSaque)
            {
                result = true;
                this.saldo -= valorSaque;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public void depositar(double valorDep)
        {
            this.saldo = valorDep;
        }
    }
}
