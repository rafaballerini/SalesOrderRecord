using System;
using System.Collections.Generic;
using System.Text;

namespace OrdemDeVenda.Models
{
    public class Material
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public double Peso { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public Material(string codigo, string descricao, double peso, decimal preco, int quantidade)
        {
            Codigo = codigo;
            Descricao = descricao;
            Peso = peso;
            Preco = preco;
            Quantidade = quantidade;
        }
        public void Cadastrar(ref List<Material> material)
        {
            material.Add(this);
        }

        public static Material SolicitaInfoMaterial()
        {
            string codigo = "", descricao = "";
            double peso = 0;
            decimal preco = 0.00m;
            int quantidade = 0;

            var codigoCorreto = false;
            var descricaoCorreto = false;
            var pesoCorreto = false;
            var precoCorreto = false;
            var quantidadeCorreta = false;

            while (!codigoCorreto)
            {
                Console.WriteLine("\nInforme o código do material: ");
                codigo = Console.ReadLine();
                if (string.IsNullOrEmpty(codigo?.Trim()))
                {
                    Console.WriteLine("Código não pode ser vazio ou nulo!");
                    codigoCorreto = false;
                }
                else
                    codigoCorreto = true;
            }

            while (!descricaoCorreto)
            {
                Console.WriteLine("Informe a descrição do material: ");
                descricao = Console.ReadLine();
                if (string.IsNullOrEmpty(descricao?.Trim()))
                {
                    Console.WriteLine("Descrição não pode ser vazia ou nula!");
                    descricaoCorreto = false;
                }
                else
                    descricaoCorreto = true;
            }

            while (!pesoCorreto)
            {
                bool aux = true;
                Console.WriteLine("Informe o peso do material: ");
                var peso2 = Console.ReadLine();
                try
                {
                    peso = double.Parse(peso2);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Peso deve ser um número válido!");
                    pesoCorreto = false;
                    aux = false;
                }
                if (aux)
                {
                    pesoCorreto = true;
                }
            }

            while (!precoCorreto)
            {
                bool aux = true;
                Console.WriteLine("Informe o preço do material: ");
                var preco1 = Console.ReadLine();
                preco1 = preco1.Replace(".", ",");
                try
                {
                    preco = Math.Round(Convert.ToDecimal(preco1), 2);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Preço deve ser um número válido!");
                    precoCorreto = false;
                    aux = false;
                }
                if (aux)
                {
                    precoCorreto = true;
                }
            }

            while (!quantidadeCorreta)
            {
                bool aux = true;
                Console.WriteLine("Informe a quantidade do material: ");
                var quantidade2 = Console.ReadLine();
                try
                {
                    quantidade = int.Parse(quantidade2);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Quantidade deve ser um número válido!");
                    quantidadeCorreta = false;
                    aux = false;
                }
                if (aux)
                {
                    quantidadeCorreta = true;
                }
            }
            return new Material(codigo, descricao, peso, preco, quantidade);
        }

    }
}
