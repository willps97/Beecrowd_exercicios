using System;
using System.Globalization;

/*Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R). 
 * A fórmula para calcular o volume é: (4/3) * pi * R3. Considere (atribua) para pi o valor 3.14159.

Dica: Ao utilizar a fórmula, procure usar (4/3.0) ou (4.0/3)
, pois algumas linguagens (dentre elas o C++), assumem que o resultado da divisão entre dois inteiros é outro inteiro.*/

namespace Beecrowd_1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double raio = ((4.0 / 3.0) * pi * Math.Pow(r, 3));

            Console.WriteLine("VOLUME = " + raio.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
