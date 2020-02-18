using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio33
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis (batata,resu,g)
            //zerar variaveis
            //repitir
              //repitir
                //batata = batata + 1
                //resu = batata * g
                //exibir g + " * " + batata + " = " + resu
              //enquanto batata != 10
              //pedir tecla para continuar
              //g = g + 1
              //batata = 0
            //enquanto g <= 20

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Clear();

            int batata = 0;
            int resu = 0;
            int g = 1;

            do
            {
                do
                {
                    batata = batata + 1;
                    resu = batata * g;


                    Console.WriteLine(g.ToString() + " * " + batata.ToString() + " = " + resu.ToString());

                }

                while (batata != 10);

                Console.ReadKey();
                g = g + 1;
                batata = 0 ;
                Console.WriteLine("");
            }
            while (g <= 20);
            Console.ReadKey();



          

        }
    }
}
