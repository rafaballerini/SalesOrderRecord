using System;
using System.Collections.Generic;
using System.Text;

namespace OrdemDeVenda.Models
{
    public class ClienteFisico : Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public ClienteFisico(string nome, string cpf, string telefone, string endereco, string email)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Endereco = endereco;
            Email = email;
        }

        public void Cadastrar(ref List<ClienteFisico> clientesf)
        {
            clientesf.Add(this);
        }

        public static ClienteFisico SolicitaInfoCliente()
        {
            string nome = "", cpfcnpj = "", telefone = "", endereco = "", email = "";

            var nomeCorreto = false;
            var cpfCorreto = false;
            var telefoneCorreto = false;
            var enderecoCorreto = false;
            var emailCorreto = false;

            while (!nomeCorreto)
            {
                Console.WriteLine("Informe o nome do cliente: ");
                nome = Console.ReadLine();
                if (string.IsNullOrEmpty(nome?.Trim()) || (nome.Length > 100))
                {
                    Console.WriteLine("Nome não pode ser vazio, nulo ou maior que 100 caracteres!");
                    nomeCorreto = false;
                }
                else
                    nomeCorreto = true;
            }

            while (!cpfCorreto)
            {
                Console.WriteLine("Informe o cpf do cliente: ");
                cpfcnpj = Console.ReadLine();
                if (string.IsNullOrEmpty(cpfcnpj?.Trim()))
                {
                    Console.WriteLine("Cpf não pode ser vazio ou nulo!");
                    cpfCorreto = false;
                }
                else
                    cpfCorreto = true;
            }

            while (!telefoneCorreto)
            {
                Console.WriteLine("Informe o telefone do cliente: ");
                telefone = Console.ReadLine();
                if (string.IsNullOrEmpty(telefone?.Trim()))
                {
                    Console.WriteLine("Telefone não pode ser vazio ou nulo!");
                    telefoneCorreto = false;
                }
                else
                    telefoneCorreto = true;
            }

            while (!enderecoCorreto)
            {
                Console.WriteLine("Informe o endereço do cliente: ");
                endereco = Console.ReadLine();
                if (string.IsNullOrEmpty(endereco?.Trim()))
                {
                    Console.WriteLine("Endereço não pode ser vazio ou nulo!");
                    enderecoCorreto = false;
                }
                else
                    enderecoCorreto = true;
            }

            while (!emailCorreto)
            {
                Console.WriteLine("Informe o email do cliente: ");
                email = Console.ReadLine();
                if (string.IsNullOrEmpty(email?.Trim()))
                {
                    Console.WriteLine("Email não pode ser vazio ou nulo!");
                    emailCorreto = false;
                }
                else
                    emailCorreto = true;
            }

            return new ClienteFisico(nome, cpfcnpj, telefone, endereco, email);
        }

    }
}