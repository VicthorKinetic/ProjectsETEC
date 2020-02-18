using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercício4
{
    class Program
    {
        static void Main(string[] args)
        {int b;
         int h;
         int resultado;
         b = 1;
         h = 1;
         resultado = 1;

         Console.Write("Digite a base do triângulo: ");
         b = int.Parse(Console.ReadLine());
            
         Console.Write("Digite a altura do triângulo: ");
         h = int.Parse(Console.ReadLine());

         resultado = b * h / 2;
         Console.Write("A área do triângulo é igual a: " + resultado.ToString());
         Console.ReadKey();
        }
    }
}
