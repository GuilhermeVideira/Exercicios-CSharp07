using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analise_e_projeto_de_sistemass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instancia do cliente
            Cliente c = new Cliente();
            c.nome = "João Silva";
            c.cpf = "222.222.222-22";
            c.codCliente = 123;
            c.saldo = 2000;
            c.credito = 3000;

            Cliente c2 = new Cliente();
            c2.nome = "Maria Ferreira";
            c2.cpf = "111.222.222-22";
            c2.codCliente = 823;
            c2.saldo = 4000;
            c2.credito = 6000;

            Cliente c3 = new Cliente();
            c3.nome = "Pedro Almeida";
            c3.cpf = "333.222.222-22";
            c3.codCliente = 823;
            c3.saldo = 6000;
            c3.credito = 6000;

            MostraInformacoes.mostrarDadosCliente(c);
            c.depositar(1000);
            Console.WriteLine("Saldo atual (depois do deposito): {0}", c.saldo);

            if (c.sacar(2900))
            {
                Console.WriteLine("Saque efetuado com sucesso!");
                Console.WriteLine("Saldo atual (depois do saque): {0}", c.saldo);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente - saldo atual: {0}", c.saldo);
            }

            Console.WriteLine("-----------------------------------------------------");

            //instancia do funcionario
            Funcionario f = new Funcionario();
            f.nome = "Ana Souza";
            f.cpf = "111.111.111-11";
            f.codFuncionario = 234;
            f.funcao = "Gerente";
            f.salario = 6000;

            Console.WriteLine("#### Funcionario ####");
            Console.WriteLine("Funcionario: {0} - Cod.: {1} ", f.nome, f.codFuncionario);
            f.mostrarFuncao();

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("#### Banco ####");
            Banco b = new Banco();
            b.nome = "Banco de Teste";
            b.addCliente(c);
            b.addCliente(c2);
            b.addCliente(c3);

            Console.WriteLine("------ Clientes ------ ");
            foreach (Cliente cliente in b.getCliente())
            {
                Console.WriteLine("Cliente: {0} - Saldo RS {1} - Cód: {2} ", cliente.nome, cliente.saldo, cliente.codCliente);
            }

            b.addFuncionario(f);
            Console.WriteLine("------ Funcionário ------ ");
            foreach (Funcionario func in b.GetFuncionarios())
            {
                Console.WriteLine("Funcionarios: {0}", func.nome);
            }

            //instanciar uma filial
            Filial fi = new Filial(b);
            fi.cidade = "Peruibe";
            fi.codFilial = 256;
            fi.endereco = "Av. Padre anchieta 222";

            //Exibindo dados da filial
            Console.WriteLine("------ Dados da filial ------ ");
            Console.WriteLine("Filial do banco: {0} Cod: {1}", fi.banco.nome, fi.codFilial);
            Console.WriteLine("Endereço: {0} Cidade {1}", fi.endereco, fi.cidade);
            Console.WriteLine("Lista de clientes: ");
            foreach (Cliente cli in fi.banco.getCliente())
            {
                Console.WriteLine(cli.nome);
            }

            //Prestador avulso
            Console.WriteLine("------ Avulso ------ ");
            PrestadorAvulso p = new PrestadorAvulso();
            p.nome = "Marcio";
            p.cpf = "555.555.555-55";
            p.funcao = "Auditória";
            Console.WriteLine("Nome: {0} ", p.nome);
            p.mostrarFuncao();


            Console.ReadKey();
        }
    }
}
