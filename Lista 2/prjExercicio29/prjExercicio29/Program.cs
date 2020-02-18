using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio29
{
    class Program
    {
        static void Main(string[] args)
        {

            //declarar variaveis(SEXO)
            //repetir
              //zerar variaveis
              //solicitar SEXO
              //receber SEXO
            //enquanto(Sexo diferente F ou Sexo diferente M)
            //exibir FOI

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            string s = "";
            do
            {
                Console.Clear();
                s = "";
                Console.Write("Digite seu sexo (M ou F): ");
                s = Console.ReadLine();

            }
            while(s != "M" && s != "F");

            Console.Write("FOI");
            Console.ReadKey();


              

        }
    }
}
