using System;
using System.Globalization;

/* A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:
 0 - 400 = 15%
400.01 - 800.00 = 12%
800.01 - 1200.00 = 10%
1200.01 - 2000.00 = 7%
Acima de 2000.00 = 4%
*/

namespace Beecrowd_1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double ganho = 0;
            double percentual = 0;
            double salarioFinal = 0;
            
            if (salario >= 0.00 && salario <= 400.00)
            {
                percentual = 15.00;
                ganho = salario * (percentual / 100);
                salarioFinal = salario + ganho;
            }
            else if (salario >= 400.01 && salario <= 800.00)
            {
                percentual = 12.00;
                ganho = salario * (percentual / 100);
                salarioFinal = salario + ganho;
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                percentual = 10.00;
                ganho = salario * (percentual / 100);
                salarioFinal = salario + ganho;
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                percentual = 7.00;
                ganho = salario * (percentual / 100);
                salarioFinal = salario + ganho;
            }
            else if (salario > 2000.00)
            {
                percentual = 4.00;
                ganho = salario * (percentual / 100);
                salarioFinal = salario + ganho;
            }
            Console.WriteLine("Novo salario: " + salarioFinal.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + ganho.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual.ToString("F0",CultureInfo.InvariantCulture)+" %");
        }
    }
}
