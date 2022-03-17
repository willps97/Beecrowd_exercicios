using System;
using System.Globalization;

/*Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. 
 *Se não for possível calcular as raízes, mostre a mensagem correspondente “Impossivel calcular”, 
 *caso haja uma divisão por 0 ou raiz de numero negativo.*/

namespace Beecrowd_1036
{
    class Program
    {
        static void Main(string[] args)
        {
            string dados = Console.ReadLine();
            string[] data = dados.Split(' ');
            double a = double.Parse(data[0], CultureInfo.InvariantCulture);
            double b = double.Parse(data[1], CultureInfo.InvariantCulture);
            double c = double.Parse(data[2], CultureInfo.InvariantCulture);

            double delta = Math.Pow(b, 2) - 4 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            if (delta < 0 || a ==0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                Console.WriteLine("R1 = " + x1.ToString("F5"),CultureInfo.InvariantCulture);
                Console.WriteLine("R2 = " + x2.ToString("F5"), CultureInfo.InvariantCulture);
            }
            
        }
    }
}
