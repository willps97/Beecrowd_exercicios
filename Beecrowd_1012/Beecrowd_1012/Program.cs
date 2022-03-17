using System;
using System.Globalization;

/*Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.*/

namespace Beecrowd_1012
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = Console.ReadLine();

            string[] valores = entrada.Split(' ');
            double a = double.Parse(valores[0],CultureInfo.InvariantCulture);
            double b = double.Parse(valores[1],CultureInfo.InvariantCulture);
            double c = double.Parse(valores[2],CultureInfo.InvariantCulture);

            double pi = 3.14159;
            double areaTriangulo = (a * c) / 2;
            double areaCirculo = pi * Math.Pow(c, 2);
            double areaTrapezio = ((a + b) / 2) * c;
            double areaQuadrado = Math.Pow(b, 2);
            double areaRetangulo = a * b;

            Console.WriteLine("TRIANGULO: "+ areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: "+ areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: "+ areaQuadrado.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: "+ areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
