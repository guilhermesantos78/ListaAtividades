using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividades
{
    
    public class Calculadora
    {
        public double resultado { get; set; }

        public void Sistem()
        {
            Console.WriteLine("Digite um numero");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite um segundo numero");
            double num2 = double.Parse(Console.ReadLine());
            Menu();
            int acao = int.Parse(Console.ReadLine());

            if(acao == 1 )
            {
                Adicao(num1, num2);
                Console.WriteLine($"O resultado da sua operação é {resultado}");
            }
            else if (acao == 2 )
            {
                Subtracao(num1, num2);
                Console.WriteLine($"O resultado da sua operação é {resultado}");
            }
            else if (acao == 3)
            {
                Multiplicacao(num1, num2);
                Console.WriteLine($"O resultado da sua operação é {resultado}");
            }
            else if (acao == 4)
            {
                Divisao(num1, num2);
                Console.WriteLine($"O resultado da sua operação é {resultado}");
            }
        }
        public void Menu()
        {
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão");

        }

        public void Adicao(double Num1, double Num2)
        {
            double result = Num1+ Num2;
            resultado = result;
        }
        public void Subtracao(double Num1, double Num2)
        {
            double result = Num1 - Num2;
            resultado = result;
        }
        public void Multiplicacao(double Num1, double Num2)
        {
            double result = Num1 * Num2;
            resultado = result;
        }
        public void Divisao(double Num1, double Num2)
        {
            double result = Num1 / Num2;
            resultado= result;
        }
    }
}
