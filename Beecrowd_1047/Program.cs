using System;

/*Leia a hora inicial, minuto inicial, hora final e minuto final de um jogo. A seguir calcule a duração do jogo.
Obs: O jogo tem duração mínima de um (1) minuto e duração máxima de 24 horas.*/

namespace Beecrowd_1047
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = Console.ReadLine();
            string[] data = entrada.Split(' ');
            int horaInicial = int.Parse(data[0]);
            int minutoInicial = int.Parse(data[1]);
            int horaFinal = int.Parse(data[2]);
            int minutoFinal = int.Parse(data[3]);

            minutoInicial += horaInicial * 60;
            minutoFinal += horaFinal * 60;
            int tempo = minutoFinal - minutoInicial;

            if (tempo <= 0)
            {
                tempo += 24 * 60;
            }

            int h = tempo / 60;
            int m = tempo % 60;

            Console.WriteLine($"O JOGO DUROU {h} HORA(S) E {m} MINUTO(S)");
            
        }
    }
}

