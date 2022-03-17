using System;
using System.Globalization;

namespace Beecrowd_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string val1 = Console.ReadLine();
            string val2 = Console.ReadLine();

            string[] linha1 = val1.Split(' ');
            int codPeca1 = int.Parse(linha1[0]);
            int qtdPeca1 = int.Parse(linha1[1]);
            double vPeca1 = Convert.ToDouble(linha1[2], CultureInfo.InvariantCulture);

            string[] linha2 = val2.Split(' ');
            int codpeca2 = int.Parse(linha2[0]);
            int qtdpeca2 = int.Parse(linha2[1]);
            double vPeca2 = Convert.ToDouble(linha2[2],CultureInfo.InvariantCulture);

            double vTotal = (qtdPeca1 * vPeca1) + (qtdpeca2 * vPeca2);
            Console.WriteLine("VALOR A PAGAR: R$ " + vTotal.ToString("F2"),CultureInfo.InvariantCulture);
        }
    }
}
