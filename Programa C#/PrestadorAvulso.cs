using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analise_e_projeto_de_sistemass
{
    class PrestadorAvulso : Pessoa, IFuncao
    {
        public string funcao { get; set; }

        public void mostrarFuncao()
        {
            Console.WriteLine("Função: {0}", this.funcao);
        }
    }
}
