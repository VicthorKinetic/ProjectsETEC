using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercício7
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis (F,C)
            //F = 1; C = 1;
            //solicitar F
            //receber F
            //C = (F-32)*(5/9);
            //exibir C

            double F, C;
            F = 1; C = 1;

            Console.Write("Insira a temperatura em graus Fahrenheit: ");
            F = double.Parse(Console.ReadLine());

            C = (F - 32) * 5 / 9;

            Console.Write("A temperatura em graus Celsius é igual a: " + C.ToString());
            Console.ReadKey();

        }
    }
}
