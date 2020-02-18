using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercício5
{
    class Program
    {
        static void Main(string[] args)
        {double d;
         double resultado;

         d = 1;
         resultado = 1;

         Console.Write("Digite um diâmetro para a esfera: ");
         d = int.Parse(Console.ReadLine());
         d = d / 2;
         resultado = 4 * 3.14 * d * d * d / 3;
         Console.Write("O volume é: " + resultado.ToString());
         Console.ReadKey();
        }
    }
}
