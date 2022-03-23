using System;
/*Leia 3 valores inteiros e ordene-os em ordem crescente. 
 *No final, mostre os valores em ordem crescente, uma linha em branco e em seguida, os valores na sequência como foram lidos.*/
namespace BeeCrowd_1042
{
    class Program
    {
        static void Main(string[] args)
        {
            string dados = Console.ReadLine();
            string[] vect = dados.Split(' ');

            int a = int.Parse(vect[0]);
            int b = int.Parse(vect[1]);
            int c = int.Parse(vect[2]);

            int x = a;
            int y = b;
            int z = c;
            int temp = 0;

            if(x > y)
            {
                temp = x;
                x = y;
                y = temp;
            }
            if (x > z)
            {
                temp = x;
                x = z;
                z = temp;
            }
            if (y > z)
            {
                temp = y;
                y = z;
                z = temp;
            }
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(" ");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
