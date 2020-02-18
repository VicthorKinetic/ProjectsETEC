using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercício8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            double resultado;
            a = 1;
            resultado = 1;

            Console.Write("Digite a distância em milhas marítimas: ");
            a = int.Parse(Console.ReadLine());

            resultado = a * 1852;
            resultado = resultado / 1000;
            Console.Write("A distância em quilômetros é: " + resultado.ToString());
            Console.ReadKey();


        }
    }
}
