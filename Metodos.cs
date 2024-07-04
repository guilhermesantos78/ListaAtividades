using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividades
{
    public class Metodos
    {
        public int EstoqueMedio { get; set; }
        public void CalcularEstoqueMedio(int QuantidadeMax, int QuantidadeMin)
        {
            EstoqueMedio = QuantidadeMin + QuantidadeMax / 2;

            Console.WriteLine($"A media do seu estoque é{ EstoqueMedio }" );
        }

        public void DolarReal()
        {
            Console.WriteLine("Digite a cotação do dolar ");
            double Dolar = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor em dolar ");
            double Valor = double.Parse(Console.ReadLine());

            double resultado = Valor * Dolar;

            Console.WriteLine($"seu dinheiro convertendo Dolar :{Dolar}$ em Real ficará em {resultado}$");
        }

        }
    }

