using System;
using System.Globalization;

/*Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário.
 *A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto.
 *As notas consideradas são de 100, 50, 20, 10, 5, 2. As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01.
 *A seguir mostre a relação de notas necessárias.*/

namespace Beecrowd_1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

            double nota_100 = (double)(decimal) n / 100;
            n %= 100;
            double nota_50 = (double)(decimal) n / 50;
            n %= 50;
            double nota_20 = (double)(decimal) n / 20;
            n %= 20;
            double nota_10 = (double)(decimal) n / 10;
            n %= 10;
            double nota_05 = (double)(decimal) n / 5;
            n %= 5;
            double nota_2 = (double)(decimal) n / 2;
            n %= 2;
            double moeda_01 = (double)(decimal) n / 1;
            n %= 1;
            double moeda_050 = (double)(decimal) n / 0.50;
            n %= 0.50;
            double moeda_025 = (double)(decimal) n / 0.25;
            n %= 0.25;
            double moeda_010 = (double)(decimal) n / 0.10;
            n %= 0.10;
            double moeda_005 = (double)(decimal) n / 0.05;
            n %= 0.05;
            double moeda_001 = (double)(decimal) n / 0.01;

            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{(int)nota_100} nota(s) de R$ 100.00");
            Console.WriteLine($"{(int)nota_50} nota(s) de R$ 50.00");
            Console.WriteLine($"{(int)nota_20} nota(s) de R$ 20.00");
            Console.WriteLine($"{(int)nota_10} nota(s) de R$ 10.00");
            Console.WriteLine($"{(int)nota_05} nota(s) de R$ 5.00");
            Console.WriteLine($"{(int)nota_2} nota(s) de R$ 2.00");

            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{(int)moeda_01} nota(s) de R$ 1.00");
            Console.WriteLine($"{(int)moeda_050} nota(s) de R$ 0.50");
            Console.WriteLine($"{(int)moeda_025} nota(s) de R$ 0.25");
            Console.WriteLine($"{(int)moeda_010} nota(s) de R$ 0.10");
            Console.WriteLine($"{(int)moeda_005} nota(s) de R$ 0.05");
            Console.WriteLine($"{(int)moeda_001} nota(s) de R$ 0.01");
        }
    }
}