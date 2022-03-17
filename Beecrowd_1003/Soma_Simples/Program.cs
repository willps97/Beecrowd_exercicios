using System;

/*Leia dois valores inteiros, no caso para variáveis A e B. A seguir, calcule a soma entre elas e atribua á variável Soma.
 A seguir escrever o valor desta variável.*/

namespace Soma_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int soma = a + b;

            Console.WriteLine("SOMA = " + soma);
        }
    }
}
