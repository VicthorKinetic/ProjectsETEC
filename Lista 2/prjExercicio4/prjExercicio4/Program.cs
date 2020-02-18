using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarar variaveis (l,resu)
            // l = 0; resu = 0
            // solicitar litros
            // receber litros
            // resu = l * 3.05
            // exibir resu

            double l, resu;
            l = 0; resu = 0;

            Console.Write("Insire a quantidade de litros de gasolina: ");
            l = double.Parse(Console.ReadLine());

            resu = l * 3.05;

            Console.Write("O preço em reais é igual a: " + resu.ToString());
            Console.ReadKey();



        }
    }
}
