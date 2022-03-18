﻿using System;
using System.Globalization;
/*Leia quatro números (N1, N2, N3, N4), cada um deles com uma casa decimal, correspondente às quatro notas de um aluno.
 *Calcule a média com pesos 2, 3, 4 e 1, respectivamente, para cada uma destas notas e mostre esta média acompanhada pela
 *mensagem "Media: ".
 *Se esta média for maior ou igual a 7.0, imprima a mensagem "Aluno aprovado."
 *. Se a média calculada for inferior a 5.0, imprima a mensagem "Aluno reprovado."
 *. Se a média calculada for um valor entre 5.0 e 6.9, inclusive estas, 
 *o programa deve imprimir a mensagem "Aluno em exame.".

No caso do aluno estar em exame, leia um valor correspondente à nota do exame obtida pelo aluno.
Imprima então a mensagem "Nota do exame: " acompanhada pela nota digitada. 
Recalcule a média (some a pontuação do exame com a média anteriormente calculada e divida por 2).
e imprima a mensagem "Aluno aprovado." (caso a média final seja 5.0 ou mais ) ou "Aluno reprovado."
(caso a média tenha ficado 4.9 ou menos). Para estes dois casos (aprovado ou reprovado após ter pego exame)
apresente na última linha uma mensagem "Media final: " seguido da média final para esse aluno.*/

namespace Beecrowd_1040
{
    class Program
    {
        static void Main(string[] args)
        {
            string notas = Console.ReadLine();
            string[] vect = notas.Split(' ');
            double n1 = double.Parse(vect[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(vect[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(vect[2], CultureInfo.InvariantCulture);
            double n4 = double.Parse(vect[3], CultureInfo.InvariantCulture);

            double media = ((n1 * 2.0) + (n2 * 3.0) + (n3 * 4.0) + (n4 * 1.0)) / (10);

            if (media >= 7.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1",CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1",CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                double exame = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.WriteLine("Media: " + media,CultureInfo.InvariantCulture);
                Console.WriteLine("Aluno em exame.");
                Console.WriteLine("Nota do exame: " + exame.ToString("F1",CultureInfo.InvariantCulture));
                double mFinal = (media + exame) / 2;

                if (mFinal<= 4.9 )
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " +mFinal.ToString("F1",CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + mFinal.ToString("F1", CultureInfo.InvariantCulture));
                }

            }

        }
    }
}

/* Este algoritmo tem dado algum erro de arredondamento nos testes que ainda não consegui resolver.*/
