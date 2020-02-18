using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio27
{
    class Program
    {
        static void Main(string[] args)
        {

            //declarar variaveis(N)
            //zerar variaveis
            //repetir
              //solicitar um valor
              //N <-- receber um valor
            //enquanto (N > 0)


            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();


            int N = 0;
            do
            {
                Console.Clear();
                Console.Write("Digite um número meu negão: ");
                N = int.Parse(Console.ReadLine());



            }
            while (N < 0);
                

            Console.ReadKey();
            







        }
    }
}
