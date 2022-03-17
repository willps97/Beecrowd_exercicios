using System;
using System.Globalization;

/*Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) 
 *e p2(x2,y2) e calcule a distância entre eles, mostrando 4 casas decimais após a vírgula, segundo a fórmula:
 "sqrt (x2 - x1)^2 + (y2 - y1)^2"*/

namespace Beecrowd_1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string coordX = Console.ReadLine();
            string coordY = Console.ReadLine();

            string[] coordenadasX = coordX.Split(' ');
            double x1 = double.Parse(coordenadasX[0],CultureInfo.InvariantCulture);
            double x2 = double.Parse(coordenadasX[1],CultureInfo.InvariantCulture);

            string[] coordenadasY = coordY.Split(' ');
            double y1 = double.Parse(coordenadasY[0],CultureInfo.InvariantCulture);
            double y2 = double.Parse(coordenadasY[1],CultureInfo.InvariantCulture);

            double p1 = x2 - x1;
            double p2 = y2 - y1;

            double distancia = Math.Sqrt((p1 * p1) + (p2 * p2));

            Console.WriteLine(distancia.ToString("F2", CultureInfo.InvariantCulture));


          








          
        }
    }
}
