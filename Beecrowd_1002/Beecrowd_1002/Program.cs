using System;
using System.Globalization;

/*A fórmula para calcular a área de uma circunferência é: area = π * raio^2. 
 * Considerando para este problema que π = 3.14159:
- Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.*/


namespace Beecrowd_1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;

            double area = (pi * Math.Pow(raio, 2));

            Console.WriteLine("A=" + area.ToString("F4"),CultureInfo.InvariantCulture);
            
        }
    }
}
