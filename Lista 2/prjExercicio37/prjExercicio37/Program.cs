using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio37
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variavies (S,N,K,P)
            //zerar variaveis (S = 2;K = 3;)
            //repitir
              //solicitar N
              //receber N
            //enquanto N < 0 || N > 100
            //se 
            //repitir
              //K = K + 2
              //S = S + K
              //P = P + 1
              //exibir S
            //enquanto P != N


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            int S = 2; int N = 0; int K = 1; int P = 1;

            Console.Write("Digite o número de somas da sequência que você necessita: ");
            N = int.Parse(Console.ReadLine());
            if (N > 0 & N < 100)
            {
                Console.Write(S.ToString() + " ");
                do
                {
                    K = K + 2;
                    S = S + K;
                    P = P + 1;
                    Console.Write(S.ToString() + " ");                    
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
                while (N < 0 || N > 100);
                Console.Write(S.ToString() + " ");    
                do
                {
         
                    K = K + 2;
                    S = S + K;
                    P = P + 1;
                    Console.Write(S.ToString() + " ");                    
                }
                while (P != N);
            }

            Console.ReadKey();



          
          
        
            

        }
    }
}
