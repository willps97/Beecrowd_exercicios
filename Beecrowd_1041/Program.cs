using System;

/*Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. 
 *A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0)*/

namespace Beecrowd_1041
{
    class Program
    {
        static void Main(string[] args)
        {
            string coordenadas = Console.ReadLine();
            string[] dados = coordenadas.Split(' ');
            double x = double.Parse(dados[0]);
            double y = double.Parse(dados[1]);

            if (x == 0 && y != 0)
            {
                Console.WriteLine("Eixo Y");
            } 
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if(x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if(x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if(x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }

        }
    }
}
