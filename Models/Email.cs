using System;
using System.Collections.Generic;
using System.Text;

namespace OrdemDeVenda.Models
{
    public class Email
    {
        public string Corpo { get; set; }
        public string Destinatario { get; set; }
        public string CodMaterial { get; set; }
        public string DescMaterial { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoTotal { get; set; }


        public Email(string destinatario, string codigomat, string descmat, int quantidade, decimal preco)
        {
            Destinatario = destinatario;
            CodMaterial = codigomat;
            DescMaterial = descmat;
            Quantidade = quantidade;
            PrecoTotal = preco * quantidade;

            Corpo = (@$"Bom dia {Destinatario}! 
A compra que solicitou do material {CodMaterial} - {DescMaterial} está sendo enviada.
A quantidade total da compra é de {Quantidade} unidades, com preço total de R${PrecoTotal}.
Qualquer dúvida pode entrar em contato comigo.
Att,
Rafaella");
        }

    }
}
