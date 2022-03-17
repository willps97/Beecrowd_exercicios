﻿using System;
using System.Globalization;

/*Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês 
 * (em dinheiro). Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas 
 * informar o total a receber no final do mês, com duas casas decimais.*/

namespace Beecrowd_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double sF = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double sV =  vendas * 0.15;
            double sT = sF + sV;

            Console.WriteLine("TOTAL = R$ " + sT.ToString("F2"),CultureInfo.InvariantCulture);
        }
    }
}