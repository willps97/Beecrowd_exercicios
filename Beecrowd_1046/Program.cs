using System;

/*Leia a hora inicial e a hora final de um jogo. 
 *A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, 
 *tendo uma duração mínima de 1 hora e máxima de 24 horas.*/

namespace Beecrowd_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string dados = Console.ReadLine();
            string[] data = dados.Split(' ');
            int inicio = int.Parse(data[0]);
            int final = int.Parse(data[1]);
            int t=0;

            if (inicio < final)
            {
                t = final - inicio;
            }
            if (inicio > final)
            {
                t = (final - inicio) + 24;
            }
            if (inicio == final)
            {
                t = 24;
            }

            Console.WriteLine($"O JOGO DUROU {t} HORA(S)");
        }
    }
}
