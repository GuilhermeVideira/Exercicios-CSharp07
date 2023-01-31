using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analise_e_projeto_de_sistemass
{
    internal class Banco
    {
        public String nome { get; set; }
        private List<Cliente> clientes = new List<Cliente>();
        private List<Funcionario> funcionarios = new List<Funcionario>();
        private List<Filial> filiais = new List<Filial>();

        public List<Cliente> getCliente()
        {
            return this.clientes;
        }

        public void addCliente(Cliente cliente)
        {
            this.clientes.Add(cliente);
        }

        public List<Funcionario> GetFuncionarios()
        {
            return this.funcionarios;
        }
        public void addFuncionario(Funcionario funcionario)
        {
            this.funcionarios.Add(funcionario);
        }

        public List<Filial> getFiliais()
        {
            return this.filiais;
        }
        public void addFilial(Filial filial)
        {
            this.filiais.Add(filial);
        }
    }
}
