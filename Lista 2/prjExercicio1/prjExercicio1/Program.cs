using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarar variaveis (n1 , n2, resu)
            // n1 <- 0 n2 <- 0 resu <- 0
            // solicitar numero 1
            // receber numero 1
            // solicitar numero 2
            // receber numero 2
            // resu = n1 + n2
            // exibir resu

            int n1, n2, resu;

            n1 = 0; n2 = 0; resu = 0;

            Console.Write("Insira o primeiro número: ");
                n1 = int.Parse (Console.ReadLine());
            Console.Write("Insira o segundo número: ");
                n2 = int.Parse (Console.ReadLine());
            resu = n1 + n2;
            Console.Write("O resultado da soma sera igual a : " + resu.ToString());
            Console.ReadKey();


        }
    }
}
