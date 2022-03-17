using System;

/*Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula:
Maior AB = (a+b+abs(a-b))/2
Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.*/

namespace Beecrowd_1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha = Console.ReadLine();

            string[] dados = linha.Split(' ');
            int a = int.Parse(dados[0]);
            int b = int.Parse(dados[1]);
            int c = int.Parse(dados[2]);


            int maiorAB = ((a + b + Math.Abs(a - b)) / 2);
            int maiorABC = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

            if (maiorABC > maiorAB)
            {
                Console.WriteLine($"{maiorABC} eh o maior");
            }
            else
            {
                Console.WriteLine($"{maiorAB} eh o maior");
            }
        }
    }
}
