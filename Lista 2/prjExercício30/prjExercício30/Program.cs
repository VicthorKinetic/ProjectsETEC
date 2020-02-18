using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercício30
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar varialveis(e,batata)
            //zerar variaveis
            //repitir
             //batata = batata + 1
             //e = e + 5
             //exibir "5 * " + batata
             //exibir " = " + e
            //enquanto (e != 50)

           Console.BackgroundColor = ConsoleColor.DarkRed;
           Console.ForegroundColor = ConsoleColor.DarkYellow;
           Console.Clear();

             int e = 0;
             int batata = 0;
             do
             {
                
                 batata = batata + 1;
                 e = e + 5;
                 Console.WriteLine("5 * "+ batata.ToString() + " = " + e );
                 
             }

             while (e != 50);

             Console.ReadKey();
        }
    }
}
