using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio32
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis (N,e,megaman,i1,i2,bilada)
            //zerar variaveis
            //repitir
              //solicitar N
              //receber N
            //enquanto N < 0
            //e = N
            //solicitar i1
            //receber i1
            //repitir
              //solicitar i2
              //receber i2
            //enquanto i2 <= i1
            //i1 = i1 - 1
            //repitir
              //i1 = i1 + 1
              //megaman = N * i1
              //exibir e + "*" + i1 + "=" + megaman
            //enquanto i1 != i2

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();


            int N = 0; int e = 0; int megaman = 0; int i1 = 0; int i2 = 0;
            do
            {
                Console.Clear();
                Console.Write("Digite um número meu negão: ");
                N = int.Parse(Console.ReadLine());



            }
            while (N < 0);
            e = N;

            Console.Write("Digite o início do intervalo: ");
            i1 = int.Parse(Console.ReadLine());

            do
            {
                

                Console.Write("Digite o final do intervalo: ");
                i2 = int.Parse(Console.ReadLine());
            }
            while (i2 <= i1);      
           
            i2 = i2 + 1;

            do
            {
                i2 = i2 - 1;
                megaman = N * i2;
                Console.WriteLine("" + e.ToString() + " * " + i2.ToString() + " = " + megaman.ToString());

            }

            while (i1 != i2 );

            Console.ReadKey();
        }
    }
}
