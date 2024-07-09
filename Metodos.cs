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

        public void Valores()
        {
            Console.WriteLine("Digite um valor");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um segundo valor");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Antes da troca: a = {a}, b = {b}");

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"Depois da troca: a = {a}, b = {b}");
        }

        public void Modulo()
        {
            Console.WriteLine("Digite um numero");
            double Modulo1 = double.Parse(Console.ReadLine());

            if(Modulo1 == 0)
            {
                Console.WriteLine($"O numero {Modulo1} é igual 0 ");
            }
            else if (Modulo1 > 0)
            {
                Console.WriteLine($"O numero {Modulo1} é maior que 0 ");
            }
            else if (Modulo1 < 0)
            {
                Console.WriteLine($"O numero {Modulo1} é menor que 0 ");

            }


        }



        }
    }

