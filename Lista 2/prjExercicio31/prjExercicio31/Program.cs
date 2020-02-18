using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis (N,e,batata,bilada,megaman)
            //zerar variaveis
            //repitir
              //solicitar N
              //receber N
            //enquanto N < 0
            //e = N
            //bilada = N * 10
            //repitir
              //batata = batata + 1
              //megaman = N * batata
              //exibir e + "*" + batata + "=" + megaman
            //enquanto megaman != bilada


             
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();


            int N = 0; int batata = 0; int megaman = 0; 
            do
            {
                N = 0;
                Console.Clear();
                Console.Write("Digite um número meu negão: ");
                N = int.Parse(Console.ReadLine());



            }
            while (N <= 0);
            do
            {
                

                batata = batata + 1;
                megaman = N * batata ;
                Console.WriteLine("" + N.ToString() + " * " + batata.ToString() + " = " + megaman.ToString());

            }
            
            while (batata != 10);

            Console.ReadKey();


        }
    }
}
