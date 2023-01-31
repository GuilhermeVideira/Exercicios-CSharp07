using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analise_e_projeto_de_sistemass
{
    internal class Funcionario:Pessoa
    {
        public int codFuncionario { get; set; }
        public double salario { get; set; }
        public string funcao { get; set; }

        public void mostrarFuncao()
        {
            Console.WriteLine("Função: {0}", this.funcao);
        }
    }
}
