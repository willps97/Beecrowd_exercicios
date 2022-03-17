using System;

/*Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e 
 * informe-o expresso no formato horas:minutos:segundos.*/

namespace Beecrowd_1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int segundos = int.Parse(Console.ReadLine());
            int hor = segundos / 3600;
            int min = (segundos % 3600) / 60;
            int segs = (segundos % 3600) % 60;
       
            Console.WriteLine(hor + ":" + min + ":" + segs);
        }
    }
}
