using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio38
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variavies (S,N,K,P)
            //zerar variaveis (K = 1)
            //solicitar N
            //receber N
            //se N > 0 & N < 50
              //repitir
                //K = K + 1
                //S = S + 1
                //P = P + 1
                //exibir S + "/" + K + " "
              //enquanto (P != N)
            //se não
              //repitir
                //N = 0
                //solicitar N
                //receber N
              //enquanto N < 0 || N > 50
              //repitir
                //K = K + 1
                //S = S + 1
                //P = P + 1
                //exibir S + "/" + K + " "
              //enquanto P != N
            


            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            int S = 0; int N = 0; int K = 1; int P = 0;

            Console.Write("Digite o número de somas da sequência que você necessita: ");
            N = int.Parse(Console.ReadLine());
            if (N > 0 & N < 50)
            {
                do
                {
                    K = K + 1;
                    S = S + 1;
                    P = P + 1;
                    Console.Write(S.ToString() + "/" + K.ToString() + " ");
                }
                while (P != N);
            }
            else
            {
                do
                {
                    N = 0;
                    Console.Write("Erro, digite um número válido: ");
                    N = int.Parse(Console.ReadLine());
                }
                while (N < 0 || N > 50);
                    do
                    {
                        K = K + 1;
                        S = S + 1;
                        P = P + 1;
                        Console.Write(S.ToString() + "/" + K.ToString() + " ");
                    }
                    while (P != N);
                }

            Console.ReadKey();
        }
    }
}
