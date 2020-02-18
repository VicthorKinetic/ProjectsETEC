using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Avaliação
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            int nr, n, min, max;
            nr = 0; n = 0; min = 1; max = 100;
            Random rdn = new Random();
            nr = rdn.Next(1, 100);
            do
            {

            do
            {
                Console.Write("Digite um número de " + min.ToString() + " até " + max.ToString() + ": ");
                n=int.Parse(Console.ReadLine());
            }
            while (n < min || n > max);
            
            if ( n < nr )
            {
                min = n;
            }
            else
            {
                if (n > nr )
                {
                    max = n;
                }
                else
                {
                }
            }
            }
            while ( n != nr);
            Console.Write("Você perdeu o jogo");
            Console.ReadKey();

        }
    }
}
