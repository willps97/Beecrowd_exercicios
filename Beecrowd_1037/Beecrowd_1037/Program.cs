﻿using System;
using System.Globalization;

/*Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes intervalos
 *([0,25], (25,50], (50,75], (75,100]) este valor se encontra. 
 *Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
O símbolo ( representa "maior que". Por exemplo:
[0,25]  indica valores entre 0 e 25.0000, inclusive eles.
(25,50] indica valores maiores que 25 Ex: 25.00001 até o valor 50.0000000*/

namespace Beecrowd_1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (n >= 0.0 && n <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (n > 25.0 && n <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (n > 50.0 && n <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (n > 75.0 && n <= 100.0)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
