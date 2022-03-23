using System;

/*Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos"
 * indicando se os valores lidos são múltiplos entre si.*/

namespace Beecrowd_1044
{
    class Program
    {
        static void Main(string[] args)
        {
            string dados = Console.ReadLine();
            string[] vect = dados.Split(' ');

            int a = int.Parse(vect[0]);
            int b = int.Parse(vect[1]);

            if(a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
