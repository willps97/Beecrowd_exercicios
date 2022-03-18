using System;
using System.Globalization;

/*Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item.
 *A seguir, calcule e mostre o valor da conta a pagar.*/

namespace Beecrowd_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            string[] vect = data.Split(' ');

            int codigo = int.Parse(vect[0]);
            int quantidade = int.Parse(vect[1]);

            if(codigo == 1)
            {
                 double total =(quantidade * 4.00);
                Console.WriteLine("Total: R$ " + total.ToString("F2",CultureInfo.InvariantCulture));
            }
            else if (codigo == 2)
            {
                double total = (quantidade * 4.50);
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 3)
            {
                double total = (quantidade * 5.00);
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 4)
            {
                double total = (quantidade * 2.00);
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 5)
            {
                double total = (quantidade * 1.50);
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
