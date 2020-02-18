using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio39
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variavies (S,N,K,P,A,resu,mult)
            //zerar variaveis (S = 2;K = 1;P = 1; A = 1; resu = 1;)
            //solicitar N
            //receber N
            //se (N > 0 & N < 50)
              //exibir S + "/" + resu + " "
                //repitir
                  //K = K + 2
                  //S = S + K
                  //A = A + 1
                  //mult = S * A
                  //resu = mult - A
                  //P = P + 1
                  //exibir S + "/" + resu + " "
                //enquanto P != N
             //se não
               //repitir
                 //N = 0
                 //solicitar N
                 //receber N
               //enquanto N < 0 || N > 50
             //exibir S + "/" + resu + " "
             //repitir
               //K = K + 2
               //S = S + K
               //A = A + 1
               //mult = S * A
               //resu = mult - A
               //P = P + 1
               //exibir S + "/" + resu + " "
               //enquanto P != N


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            int S = 2; int N = 0; int K = 1; int P = 1; int A = 1; int resu = 1; int mult = 0;

            Console.Write("Digite quantos números da sequência você necessita: ");
            N = int.Parse(Console.ReadLine());
            if (N > 0 & N < 50)
            {
                Console.Write(S.ToString() + "/" + resu.ToString() + " ");
                do
                {
                    K = K + 2;
                    S = S + K;
                    A = A + 1;
                    mult = S * A;
                    resu = mult - A;
                    P = P + 1;
                    Console.Write(S.ToString() + "/" + resu.ToString() + " ");
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
                Console.Write(S.ToString() + "/" + resu.ToString() +" ");
                do
                {

                    A = A + 1;
                    mult = S * A;
                    resu = mult - A;
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
