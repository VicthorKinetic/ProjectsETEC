using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio2
{
    class Program
    {
        static void Main(string[] args)
        { 
            // declarar variaveis (n1,n2,n3,resu)
            // n1 = 1; n2 = 1; n3 = 1; resu = 0;
            // solicitar numero 1
            // receber numero 1
            // solicitar numero 2
            // receber numero 2
            // solicitar numero 3
            // receber numero 3
            // resu = n1 * n2 * n3
            // exbir resu

            int n1, n2, n3, resu;
            n1 = 1; n2 = 1; n3 = 1; resu = 0;

            Console.Write("Insira um número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Insira outro número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Insira o último número: ");
            n3 = int.Parse(Console.ReadLine());

            resu = n1 * n2 * n3;

            Console.Write("O resultado da multiplicação sera : " + resu.ToString());
            Console.ReadKey();



        }
    }
}
