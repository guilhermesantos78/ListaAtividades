using ListaAtividades;
using System;

Metodos m = new();
//1
System.Console.WriteLine("Digite a quantidade Maxima do estoque");
int Max = int.Parse(Console.ReadLine());

System.Console.WriteLine("Digite a quantidade Maxima do estoque");
int Min = int.Parse(Console.ReadLine());

m.CalcularEstoqueMedio(Max, Min);