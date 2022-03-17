using System;
using System.Globalization;

/*Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. 
 *A seguir, mostre o número e o salário do funcionário, com duas casas decimais.*/

namespace Beecrowd_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int chapa = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double salHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salTotal = salHora * horas;

            Console.WriteLine("NUMBER = " + chapa);
            Console.WriteLine("SALARY = U$ " + salTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
