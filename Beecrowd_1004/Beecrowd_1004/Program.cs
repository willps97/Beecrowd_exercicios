using System;

/*Leia dois valores inteiros. A seguir, calcule o produto entre ester dois valores e atribua esta operação à variavel PROD.
 A seguir mostre a variável PROD com mensagem correspondente.*/

namespace Beecrowd_1004
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int prod = a * b;

            Console.WriteLine("PROD = " + prod);
        }
    }
}
