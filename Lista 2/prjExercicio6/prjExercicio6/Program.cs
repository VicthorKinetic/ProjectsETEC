using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis (C,F)
            // C = 1; F = 0;
            // solicitar C
            // receber C
            // F = 9 * C + 160)/ 5;
            // exibir F

            int C, F;
            C = 1; F = 0;

            Console.Write("Digite a temperatura em graus Celsius: ");
            C = int.Parse(Console.ReadLine());

            F = (9 * C + 160)/ 5;

            Console.Write("A temperatura em graus Fahrenheit é igual a: " + F.ToString());
            Console.ReadKey();




        }
    }
}
