using System;
using System.Globalization;

/*Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo que o lado A representa o maior dos 3 lados.
 *A seguir, determine o tipo de triângulo que estes três lados formam, com base nos seguintes casos, sempre escrevendo uma mensagem adequada:
se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
se A2 < B2 + C2, apresente a mensagem: TRIANGULO ACUTANGULO
se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES*/

namespace Beecrowd_1045
{
    class Program
    {
        static void Main(string[] args)
        {
            string dados = Console.ReadLine();
            string[] vect = dados.Split(' ');
            double a = double.Parse(vect[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vect[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vect[2], CultureInfo.InvariantCulture);

            double temp;

            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            if (a < c)
            {
                temp = a;
                a = c;
                c = temp;
            }
            if (b < c)
            {
                temp = b;
                b = c;
                c = temp;
            }

            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (a * a == b * b + c * c)
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                if (a * a > b * b + c * c)
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                if (a * a < b * b + c * c)
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                if (a == b && a == c && b == c)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else
                {
                    if (a == b || a == c || b == c)
                    {
                        Console.WriteLine("TRIANGULO ISOSCELES");
                    }
                }

            }

        }
    }
}
