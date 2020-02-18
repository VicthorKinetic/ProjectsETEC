using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercício2
{
    class Program
    {
        static void Main(string[] args)
        {int l;
         int resultado;

         l = 1; resultado = 1;

         Console.Write("Digite um número para a aresta: ");

         l = int.Parse(Console.ReadLine());

         resultado = l * l;
         Console.Write("A área do quadrado é igual a: " + resultado.ToString());
         Console.ReadKey();
        }
    }
}
