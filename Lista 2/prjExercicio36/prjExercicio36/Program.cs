using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio36
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

            int n1 = 1, n2 = 1, n3 = 1, resu = 0, parar = 3;
            Console.Write(n1.ToString() + " ");
            Console.Write(n2.ToString() + " ");
            Console.Write(n3.ToString() + " ");
            do
            {
                resu = n1 + n2 + n3;
                Console.Write(resu.ToString() + " ");
                n1 = n2;
                n2 = n3;
                n3 = resu;
                parar = parar + 1;
            }

            while (parar != 20);
            Console.ReadKey();
        }
    }
}
