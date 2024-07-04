using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividades
{
    public class Vendedor
    {
        public string Identificacao { get; set; }
        public List<Peca> Vendas { get; set; }

        public Vendedor(string identificacao)
        {
            Identificacao = identificacao;
            Vendas = new List<Peca>();
        }

        public void RealizarVenda(Peca peca)
        {
            Vendas.Add(peca);
        }

        public double CalcularComissao()
        {
            double totalComissao = 0;
            foreach (var peca in Vendas)
            {
                double valorVenda = peca.PrecoUnitario * peca.Quantidade;
                double comissao = valorVenda * 0.05; // Comissão de 5%
                totalComissao += comissao;
            }
            return totalComissao;
        }
    }
}
