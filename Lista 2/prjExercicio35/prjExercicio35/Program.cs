using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio35
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variavies(n1,n2,resu,parar)
            //zerar variaveis
            //n2 = 1
            //parar = 1
            //repitir
              //resu = n1 + n2
              //exibir resu
              //n1 = n2
              //n2 = resu
              //parar = parar + 1
            //enquanto parar != 30


            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            int n1 = 0, n2 = 1, resu = 0, parar = 1;
            Console.Write(n2.ToString() + "  ");
            do
            {
                resu = n1 + n2;
                Console.Write(resu.ToString() + "  ");
                n1 = n2;
                n2 = resu;
                parar = parar + 1;
            }

            while(parar != 30);
            Console.ReadKey();



        }
    }
}
