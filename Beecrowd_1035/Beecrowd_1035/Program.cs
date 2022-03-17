using System;

/*Leia 4 valores inteiros A, B, C e D. A seguir, se B for maior do que C e se D for maior do que A,
 *e a soma de C com D for maior que a soma de A e B e se C e D, ambos, forem positivos e 
 *se a variável A for par escrever a mensagem "Valores aceitos", senão escrever "Valores nao aceitos".*/

namespace Beecrowd_1035
{
    class Program
    {
        static void Main(string[] args)
        {
            string dados = Console.ReadLine();
            string[] data = dados.Split(' ');

            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            int c = int.Parse(data[2]);
            int d = int.Parse(data[3]);

            if (b > c && d > a && c + d > a + b && c > 0 && d > 0 && a % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }

        }
    }
}
