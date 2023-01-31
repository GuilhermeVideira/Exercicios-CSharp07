using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analise_e_projeto_de_sistemass
{
    internal class Filial
    {
        public int codFilial { get; set; }

        public Banco banco { get; private set; }

        public String endereco { get; set; }

        public String cidade { get; set; }

        public Filial(Banco banco)
        {
            this.banco = banco;
        }
    }
}
