using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analise_e_projeto_de_sistemass
{
    static class MostraInformacoes
    {
        public static void mostrarDadosCliente(Cliente cliente)
        {
            Console.WriteLine("#### Cliente ####");
            Console.WriteLine("Cliente: {0} Cod.: {1}", cliente.nome, cliente.codCliente);

            Console.WriteLine("Saldo atual: {0}", cliente.saldo);
        }
    }
}
