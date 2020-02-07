using OrdemDeVenda.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

//Alteração Zé
namespace OrdemDeVenda
{
    class Program
    {
        static void Main()
        {
            bool a = true;
            Console.WriteLine("Cadastro de Ordens de Venda!");
            var Materiais = new List<Material>();
            var listaClientes = new List<ClienteFisico>();
            var ListaClientesJuridicos = new List<ClienteJuridico>();
            while (a)
            {
                Console.WriteLine("Você deseja cadastrar como pessoa física [A] ou jurídica [B]?  ");
                var pessoafj = Console.ReadLine();
                if (pessoafj == "A" || pessoafj == "a")
                {
                    // Cadastro de pessoa física
                    var cliente = ClienteFisico.SolicitaInfoCliente();
                    cliente.Cadastrar(ref listaClientes);
                    listaClientes.Add(cliente);
                    // Cadastro de material
                    var material = Material.SolicitaInfoMaterial();
                    material.Cadastrar(ref Materiais);
                    Materiais.Add(material);
                    //Email
                    Email novoEmail = new Email(cliente.Nome, material.Codigo, material.Descricao, material.Quantidade, material.Preco);
                    Console.WriteLine("\nEmail a ser enviado: ");
                    Console.Write(novoEmail.Corpo);
                }
                else if (pessoafj == "B" || pessoafj == "b")
                {
                    // Cadastro de pessoa jurídica
                    var clientef = ClienteJuridico.SolicitaInfoCliente();
                    clientef.Cadastrar(ref ListaClientesJuridicos);
                    ListaClientesJuridicos.Add(clientef);
                    // Cadastro de material
                    var material = Material.SolicitaInfoMaterial();
                    material.Cadastrar(ref Materiais);
                    Materiais.Add(material);
                    //Email
                    Email novoEmail = new Email(clientef.RazaoSocial, material.Codigo, material.Descricao, material.Quantidade, material.Preco);
                    Console.WriteLine("\nEmail a ser enviado: ");
                    Console.Write(novoEmail.Corpo);
                }
                else
                {
                    Console.WriteLine("Letra inválida");
                    continue;
                }

                // Imprime ordem de venda
                Thread.Sleep(5000);
                Console.WriteLine("\n\n");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("---------------------------------------------------------------------Ordem de Venda-------------------------------------------------------------------");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------\n\n");
                if (pessoafj == "A" || pessoafj == "a")
                {
                    Console.WriteLine("------------------------------------------------------------------------Cliente-----------------------------------------------------------------------\n");
                    listaClientes.ForEach(lv1 => Console.WriteLine("Nome: " + lv1.Nome + " || Cpf: " + lv1.Cpf + " || Telefone: " + lv1.Telefone + " || Endereço: " + lv1.Endereco + " || Email: " + lv1.Email + "\n"));
                }
                else if (pessoafj == "B" || pessoafj == "b")
                {
                    Console.WriteLine("------------------------------------------------------------------------Cliente-----------------------------------------------------------------------\n");
                    ListaClientesJuridicos.ForEach(lv3 => Console.WriteLine("Razão Social: " + lv3.RazaoSocial + " || Cnpj: " + lv3.Cnpj + " || Telefone: " + lv3.Telefone + " || Endereço: " + lv3.Endereco + " || Email: " + lv3.Email + "\n"));
                }
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------\n\n");
                Console.WriteLine("------------------------------------------------------------------------Material----------------------------------------------------------------------\n");
                Materiais.ForEach(lv2 => Console.WriteLine("Código: " + lv2.Codigo + " || Descrição: " + lv2.Descricao + " || Peso: " + lv2.Peso + " || Preço: " + lv2.Preco + " || Quantidade: " + lv2.Quantidade + "\n"));
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
                Thread.Sleep(5000);
                Console.WriteLine("\n\n");

                //Volta para início
                Console.Write(@"Para cadastrar outra Ordem de Venda aperte [1] " +
                    "Para sair perte [0]: \n");
                var decisao2 = Console.ReadLine();
                if (decisao2 == "0")
                {
                    a = false;
                }
            }
            //Alteração Miguel
        }
    }
}