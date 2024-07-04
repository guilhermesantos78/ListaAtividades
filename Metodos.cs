using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividades
{
    public class Metodos
    {
        public double Media{ get; set; }
        public void CalcularEstoqueMedio(double QuantidadeMax, double QuantidadeMin)
        {
            Media = (QuantidadeMax + QuantidadeMin)   / 2;

            Console.WriteLine($"A media do seu estoque é {Media}" );
        }

        public void DolarReal()
        {
            Console.WriteLine("Digite a cotação do dolar ");
            double Dolar = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor em dolar ");
            double Valor = double.Parse(Console.ReadLine());

            double resultado = Valor * Dolar;

            Console.WriteLine($"seu dinheiro convertendo Dolar :{Valor}$ em Real ficará em {resultado}$");
        }

        }
    }

