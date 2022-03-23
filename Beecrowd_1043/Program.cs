using System;
using System.Globalization;

/*Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo. 
Em caso positivo, calcule o perímetro do triângulo e apresente a mensagem:
Perimetro = XX.X
Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem
Area = XX.X*/


namespace Beecrowd_1043
{
    class Program
    {
        static void Main(string[] args)
        {
            string dados = Console.ReadLine();
            string[] vect = dados.Split(' ');
            double a = double.Parse(vect[0],CultureInfo.InvariantCulture);
            double b = double.Parse(vect[1],CultureInfo.InvariantCulture);
            double c = double.Parse(vect[2],CultureInfo.InvariantCulture);

            if(a < b +c && b < a + c && c < a + b)
            {
                double perimetro = a + b + c;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1",CultureInfo.InvariantCulture));
            }
            else
            {
                double area = (c * (a + b) / 2);
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
